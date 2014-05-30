﻿namespace SFA.Apprenticeships.Common.Messaging.IntegrationConsole
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using System.Threading;
    using System.Xml.Serialization;
    using Microsoft.WindowsAzure.Storage.Queue;
    using SFA.Apprenticeships.Application.VacancyEtl.Entities;
    using SFA.Apprenticeships.Infrastructure.Azure.Common;
    using SFA.Apprenticeships.Infrastructure.Azure.Common.IoC;
    using SFA.Apprenticeships.Infrastructure.Common.IoC;
    using SFA.Apprenticeships.Infrastructure.Elasticsearch.IoC;
    using SFA.Apprenticeships.Infrastructure.LegacyWebServices.IoC;
    using SFA.Apprenticeships.Infrastructure.RabbitMq.Interfaces;
    using SFA.Apprenticeships.Infrastructure.RabbitMq.IoC;
    using SFA.Apprenticeships.Infrastructure.VacancyEtl.Consumers;
    using SFA.Apprenticeships.Infrastructure.VacancyEtl.IoC;
    using StructureMap;

    class Program
    {
        static void Main(string[] args)
        {
            ObjectFactory.Initialize(x =>
            {
                x.AddRegistry<CommonRegistry>();
                x.AddRegistry<AzureCommonConsoleRegistry>();
                x.AddRegistry<ElasticsearchRegistry>();
                x.AddRegistry<RabbitMqRegistry>();
                x.AddRegistry<LegacyWebServicesRegistry>();
                x.AddRegistry<VacancyEtlRegistry>();
            });

            var subscriberBootstrapper = ObjectFactory.GetInstance<IBootstrapSubcribers>();
            subscriberBootstrapper.LoadSubscribers(Assembly.GetAssembly(typeof(VacancySummaryConsumerAsync)), "VacancyEtl");

            var vacancySchedulerConsumer = ObjectFactory.GetInstance<VacancySchedulerConsumer>();

            Console.WriteLine("Enter any key to quit");
            Console.WriteLine("---------------------------------------------------------------");

            var azureClient = ObjectFactory.GetInstance<IAzureCloudClient>();
            var queueItems = GetAzureScheduledMessagesQueue(1);
            azureClient.AddMessage("vacancysearchdatacontrol", queueItems.Dequeue());

            while (!Console.KeyAvailable)
            {
                var task = vacancySchedulerConsumer.CheckScheduleQueue();
                task.Wait();
                Thread.Sleep(5000);
            }
        }

        private static Queue<CloudQueueMessage> GetAzureScheduledMessagesQueue(int count)
        {
            var queue = new Queue<CloudQueueMessage>();
            var serializer = new XmlSerializer(typeof(StorageQueueMessage));

            for (int i = count; i > 0; i--)
            {
                var storageScheduleMessage = new StorageQueueMessage
                {
                    ClientRequestId = Guid.NewGuid().ToString(),
                    SchedulerJobId = i.ToString()
                };

                string message;
                using (var ms = new MemoryStream())
                {
                    serializer.Serialize(ms, storageScheduleMessage);
                    ms.Position = 0;
                    var sr = new StreamReader(ms);
                    message = sr.ReadToEnd();
                }

                var cloudMessage = new CloudQueueMessage(message);
                queue.Enqueue(cloudMessage);
            }

            queue.Enqueue(null);
            return queue;
        }
    }
}

﻿namespace SFA.Apprenticeships.Infrastructure.Azure.ServiceBus
{
    using System;
    using System.Collections.Generic;
    using Application.Interfaces.Logging;
    using Configuration;
    using Domain.Interfaces.Configuration;
    using Domain.Interfaces.Messaging;
    using Microsoft.ServiceBus.Messaging;
    using Newtonsoft.Json;

    public class AzureServiceBus : IServiceBus
    {
        private readonly ILogService _logService;
        private readonly IConfigurationService _configurationService;

        private IDictionary<string, TopicClient> _topicClients;
        private readonly object _locker = new object();

        public AzureServiceBus(
            ILogService logService,
            IConfigurationService configurationService)
        {
            _logService = logService;
            _configurationService = configurationService;
        }

        public void PublishMessage<T>(T message) where T : class
        {
            if (message == null)
            {
                throw new ArgumentNullException("message");
            }

            EnsureTopicClientsCreated();

            var messageTypeName = message.GetType().FullName;

            if (!_topicClients.ContainsKey(messageTypeName))
            {
                _logService.Error("Failed to get service bus topic client for message type \"{0}\".", messageTypeName);
                return;
            }

            var json = JsonConvert.SerializeObject(message);
            var brokeredMessage = new BrokeredMessage(json)
            {
                ContentType = "application/json"
            };

            _topicClients[messageTypeName].Send(brokeredMessage);
        }

        #region Helpers

        private void EnsureTopicClientsCreated()
        {
            if (_topicClients != null) return;

            lock (_locker)
            {
                if (_topicClients != null) return;

                var topicClients = new Dictionary<string, TopicClient>();
                var configuration = _configurationService.Get<AzureServiceBusConfiguration>();

                foreach (var topic in configuration.Topics)
                {
                    var topicClient = TopicClient.CreateFromConnectionString(configuration.ConnectionString, topic.TopicName);

                    topicClients.Add(topic.MessageType, topicClient);
                }

                _topicClients = topicClients;
            }
        }

        #endregion
    }
}
﻿namespace SFA.Apprenticeships.Infrastructure.Repositories.Vacancies.Sql.Tests
{
    using System;
    using System.Data.SqlClient;
    using System.IO;
    using Domain.Entities.Vacancies.ProviderVacancies;
    using Domain.Entities.Vacancies.ProviderVacancies.Apprenticeship;
    using Domain.Interfaces.Repositories;
    using FluentAssertions;
    using Mappers;
    using Moq;
    using NewDB.Domain.Entities;
    using NewDB.Domain.Entities.Vacancy;
    using NUnit.Framework;
    using SFA.Infrastructure.Interfaces;
    using SFA.Infrastructure.Sql;
    using TrainingType = Domain.Entities.Vacancies.ProviderVacancies.TrainingType;
    using Vacancy = NewDB.Domain.Entities.Vacancy.Vacancy;
    using WageType = Domain.Entities.Vacancies.ProviderVacancies.WageType;
    //using StructureMap;
    using Web.Common.Configuration;

    [TestFixture]
    public class SqlApprenticeshipVacancyRepositoryTests
    {
        private static string _connectionString = string.Empty;
        readonly IMapper _mapper = new ApprenticeshipVacancyMappers();
        //private Container _container;

        static readonly Guid VacancyId_VacancyA = Guid.NewGuid();
        private const int VacancyReferenceNumber_VacancyA = 1;

        const int VacancyPartyId_EmployerA = 3;
        const int VacancyPartyId_ProviderA = 4;
        const int FrameworkId_Framework1 = 1;
        const string VacancyTypeCode_Apprenticeship = "A";
        const string VacancyStatusCode_Live = "LIV";
        const string VacancyLocationTypeCode_Specific = "S";
        const string TrainingTypeCode_Framework = "F";
        const string LevelCode_Intermediate = "2";
        const string WageTypeCode_Custom = "CUS";
        const string WageIntervalCode_Weekly = "W";


        [OneTimeSetUp]
        public void SetUpFixture()
        {
            /*
            _container = new Container(x =>
            {
                x.AddRegistry<CommonRegistry>();
                x.AddRegistry<LoggingRegistry>();
            });
            */

            //var configurationService = _container.GetInstance<IConfigurationService>();

            //var environment = configurationService.Get<CommonWebConfiguration>().Environment;

            var environment = "local";

            string databaseName = $"RaaTest-{environment}";
            _connectionString = $"Server=localhost\\SQLEXPRESS;Database={databaseName};Trusted_Connection=True;"; //TODO: get from settings

            var databaseProjectName = "SFA.Apprenticeships.Data";
            var databaseProjectPath = AppDomain.CurrentDomain.BaseDirectory + $"\\..\\..\\..\\{databaseProjectName}";
            var dacpacFilePath = Path.Combine(databaseProjectPath + $"\\bin\\{environment}\\{databaseProjectName}.dacpac");
                //TODO get configuration from settings
            var dbInitialiser = new DatabaseInitialiser(dacpacFilePath, _connectionString, databaseName);
            
            dbInitialiser.Publish(true);

            var seedScripts = new string[]
            {
            };
            var seedObjects = GetSeedObjects();

            dbInitialiser.Seed(seedScripts);
            dbInitialiser.Seed(seedObjects);
        }

        private static object[] GetSeedObjects()
        {
            var vacancy = new Vacancy
            {
                VacancyId = VacancyId_VacancyA,
                VacancyReferenceNumber = VacancyReferenceNumber_VacancyA,
                AV_ContactName = "av contact name",
                VacancyTypeCode = VacancyTypeCode_Apprenticeship,
                VacancyStatusCode = VacancyStatusCode_Live,
                VacancyLocationTypeCode = VacancyLocationTypeCode_Specific,
                Title = "Test vacancy",
                TrainingTypeCode = TrainingTypeCode_Framework,
                LevelCode = LevelCode_Intermediate,
                FrameworkId = FrameworkId_Framework1,
                WageValue = 100.0M,
                WageTypeCode = WageTypeCode_Custom,
                WageIntervalCode = WageIntervalCode_Weekly,
                ClosingDate = DateTime.Now,
                ContractOwnerVacancyPartyId = 1,
                DeliveryProviderVacancyPartyId = 1,
                EmployerVacancyPartyId = 1,
                ManagerVacancyPartyId = 1,
                OriginalContractOwnerVacancyPartyId = 1,
                ParentVacancyId = null,
                OwnerVacancyPartyId = 1,
                DurationValue = 3,
                DurationTypeCode = "Y",
                PublishedDateTime = DateTime.UtcNow.AddDays(-1)
            };

            var occupation = new Occupation
            {
                OccupationId = 1,
                OccupationStatusId = 1,
                CodeName = "O01",
                FullName = "Occupation 1",
                ShortName = "Occupation 1"
            };

            var framework = new Framework
            {
                FrameworkId = FrameworkId_Framework1,
                CodeName = "F01",
                FullName = "Framework 1",
                ShortName = "Framework 1",
                FrameworkStatusId = 1,
                OccupationId = 1
            };

            var vacancyParty1 = new VacancyParty
            {
                VacancyPartyTypeCode = "ES",
                FullName = "Employer A",
                Description = "A",
                WebsiteUrl = "URL",
                EDSURN = 1,
                UKPRN = null
            };

            var vacancyParty2 = new VacancyParty
            {
                VacancyPartyTypeCode = "PS",
                FullName = "Provider A",
                Description = "A",
                WebsiteUrl = "URL",
                EDSURN = null,
                UKPRN = 1
            };

            var seedObjects = new object[] {occupation, framework, vacancyParty1, vacancyParty2, vacancy};
            return seedObjects;
        }

        private static ApprenticeshipVacancy GetVacancy(long vacancyReferenceNumber)
        {
            ApprenticeshipVacancy vacancy;

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var commandText =
                    $"SELECT * FROM Vacancy.Vacancy WHERE VacancyReferenceNumber = {vacancyReferenceNumber}";

                using (var command = new SqlCommand(commandText, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        vacancy = new ApprenticeshipVacancy
                        {
                            Status =
                                (ProviderVacancyStatuses)
                                    Enum.Parse(typeof (ProviderVacancyStatuses), reader[3].ToString())
                        };
                    }
                }
                connection.Close();
            }

            return vacancy;
        }

        [Test]
        public void DoMappersMapEverything()
        {
            // Arrange
            var x = new ApprenticeshipVacancyMappers();

            // Act
            x.Initialise();

            // Assert
            x.Mapper.AssertConfigurationIsValid();
        }

        [Test]
        public void GetVacancyByVacancyReferenceNumberTest()
        {
            // configure _mapper
            IGetOpenConnection connection = new GetOpenConnectionFromConnectionString(_connectionString);
            var logger = new Mock<ILogService>();
            IApprenticeshipVacancyReadRepository repository = new ApprenticeshipVacancyRepository(connection, _mapper,
                logger.Object);

            var vacancy = repository.Get(VacancyReferenceNumber_VacancyA);

            vacancy.Status.Should().Be(ProviderVacancyStatuses.Live);
            vacancy.Title.Should().Be("Test vacancy");
            vacancy.WageType.Should().Be(WageType.Custom);
            vacancy.TrainingType = TrainingType.Frameworks;
        }

        [Test]
        public void GetVacancyByGuidTest()
        {
            // configure _mapper
            IGetOpenConnection connection = new GetOpenConnectionFromConnectionString(_connectionString);
            var logger = new Mock<ILogService>();
            IApprenticeshipVacancyReadRepository repository = new ApprenticeshipVacancyRepository(connection, _mapper,
                logger.Object);

            var vacancy = repository.Get(VacancyId_VacancyA);

            vacancy.Status.Should().Be(ProviderVacancyStatuses.Live);
            vacancy.Title.Should().Be("Test vacancy");
            vacancy.WageType.Should().Be(WageType.Custom);
            vacancy.TrainingType = TrainingType.Frameworks;
        }

        [Test]
        public void UpdateTest()
        {
            var newReferenceNumber = 3L;
            IGetOpenConnection connection = new GetOpenConnectionFromConnectionString(_connectionString);
            var logger = new Mock<ILogService>();

            IApprenticeshipVacancyReadRepository readRepository = new ApprenticeshipVacancyRepository(connection, _mapper,
                logger.Object);
            IApprenticeshipVacancyWriteRepository writeRepository = new ApprenticeshipVacancyRepository(connection, _mapper,
                logger.Object);

            var vacancy = readRepository.Get(VacancyReferenceNumber_VacancyA);

            vacancy.VacancyReferenceNumber = newReferenceNumber;

            writeRepository.Save(vacancy);

            vacancy = readRepository.Get(VacancyReferenceNumber_VacancyA);

            vacancy.Should().BeNull();

            vacancy = readRepository.Get(newReferenceNumber);

            vacancy.Status.Should().Be(ProviderVacancyStatuses.Live);
            vacancy.Title.Should().Be("Test vacancy");
            vacancy.WageType.Should().Be(WageType.Custom);
            vacancy.TrainingType = TrainingType.Frameworks;
        }

        /*
        [Test]
        public void ReserveVacancyForQaTest()
        {
            IGetOpenConnection connection = new GetOpenConnectionFromConnectionString(_connectionString);
            var logger = new Mock<ILogService>();
            IApprenticeshipVacancyWriteRepository repository = new ApprenticeshipVacancyRepository(connection, _mapper,
                logger.Object);

            repository.ReserveVacancyForQA(1);

            var vacancy = GetVacancy(1L);
        }*/
    }
}
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

    [TestFixture]
    public class SqlApprenticeshipVacancyRepositoryTests
    {
        private const string ConnectionString = "Server=VTUK027\\SQLEXPRESS;Database=Raa2;Trusted_Connection=True;";
            //TODO: get from settings

        private readonly IMapper _mapper = new ApprenticeshipVacancyMappers();
        private const int VacancyReferenceNumber = 1;

        [OneTimeSetUp]
        public void SetUpFixture()
        {
            var databaseProjectName = "SFA.Apprenticeships.Data";
            var databaseProjectPath = AppDomain.CurrentDomain.BaseDirectory + $"\\..\\..\\..\\{databaseProjectName}";
            var databaseName = "Raa2";
            var dacpacFilePath = Path.Combine(databaseProjectPath + $"\\bin\\Local\\{databaseProjectName}.dacpac");
                //TODO get configuration from settings
            var dbInitialiser = new DatabaseInitialiser(dacpacFilePath, ConnectionString, databaseName);
            
            dbInitialiser.Publish(true);
            
            var vacancy = new Vacancy
            {
                VacancyReferenceNumber = VacancyReferenceNumber,
                AV_ContactName = "av contact name",
                VacancyTypeCode = "A",
                VacancyStatusCode = "LIV",
                VacancyLocationTypeCode = "S",
                Title = "Test vacancy",
                TrainingTypeCode = "F",
                LevelCode = "4",
                FrameworkId = 1,
                WageValue = 100.0M,
                WageTypeCode = "CUS",
                ClosingDate = DateTime.Now,
                ContractOwnerVacancyPartyId = 1,
                DeliveryProviderVacancyPartyId = 1,
                EmployerVacancyPartyId = 1,
                ManagerVacancyPartyId = 1,
                OriginalContractOwnerVacancyPartyId = 1,
                ParentVacancyGuid = null,
                OwnerVacancyPartyId = 1,
                DurationValue = 3,
                DurationTypeCode = "Y"
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
                FrameworkId = 1,
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

            var seedScripts = new[]
            {
                AppDomain.CurrentDomain.BaseDirectory + "\\Scripts\\vacancy.wageType.sql"
            };

            dbInitialiser.Seed(seedScripts);
            dbInitialiser.Seed(new object[] {occupation, framework, vacancyParty1, vacancyParty2, vacancy});
        }

        private static ApprenticeshipVacancy GetVacancy(long vacancyReferenceNumber)
        {
            ApprenticeshipVacancy vacancy;

            using (var connection = new SqlConnection(ConnectionString))
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
        public void GetVacancyTest()
        {
            // configure _mapper
            IGetOpenConnection connection = new GetOpenConnectionFromConnectionString(ConnectionString);
            var logger = new Mock<ILogService>();
            IApprenticeshipVacancyReadRepository repository = new ApprenticeshipVacancyRepository(connection, _mapper,
                logger.Object);

            var vacancy = repository.Get(1);
        }

        [Test]
        public void GetVacancyTestByGuid()
        {
            var vacancyGuid = Guid.Empty;
            using (var sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();

                var commandText =
                    $"SELECT [VacancyGuid] FROM [Vacancy].[Vacancy] WHERE [VacancyReferenceNumber] = {VacancyReferenceNumber}";
                using (var command = new SqlCommand(commandText, sqlConnection))
                {
                    vacancyGuid = (Guid) command.ExecuteScalar();
                }

                sqlConnection.Close();
            }

            // configure _mapper
            IGetOpenConnection connection = new GetOpenConnectionFromConnectionString(ConnectionString);
            var logger = new Mock<ILogService>();
            IApprenticeshipVacancyReadRepository repository = new ApprenticeshipVacancyRepository(connection, _mapper,
                logger.Object);

            var vacancy = repository.Get(vacancyGuid);

            vacancy.Status.Should().Be(ProviderVacancyStatuses.Live);
            vacancy.Title.Should().Be("Test vacancy");
            vacancy.WageType.Should().Be(WageType.Custom);
            vacancy.TrainingType = TrainingType.Frameworks;
        }

        [Test]
        public void ReserveVacancyForQaTest()
        {
            IGetOpenConnection connection = new GetOpenConnectionFromConnectionString(ConnectionString);
            var logger = new Mock<ILogService>();
            IApprenticeshipVacancyWriteRepository repository = new ApprenticeshipVacancyRepository(connection, _mapper,
                logger.Object);

            repository.ReserveVacancyForQA(1);

            var vacancy = GetVacancy(1L);
        }
    }
}
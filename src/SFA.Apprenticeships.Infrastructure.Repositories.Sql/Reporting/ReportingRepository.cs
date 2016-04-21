﻿namespace SFA.Apprenticeships.Infrastructure.Repositories.Sql.Reporting
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using Common;
    using Domain.Raa.Interfaces.Reporting;
    using Domain.Raa.Interfaces.Reporting.Models;
    using SFA.Infrastructure.Interfaces;

    public class ReportingRepository : IReportingRepository
    {
        private readonly ILogService _logger;
        private readonly IGetOpenConnection _getOpenConnection;

        public ReportingRepository(IGetOpenConnection getOpenConnection, ILogService logger)
        {
            _getOpenConnection = getOpenConnection;
            _logger = logger;
        }

        public List<ReportVacanciesResultItem> ReportVacanciesList(DateTime fromDate, DateTime toDate)
        {
            _logger.Debug($"Executing report with toDate {toDate} and fromdate {fromDate}...");

            var response = new List<ReportVacanciesResultItem>();

            var command = new SqlCommand("dbo.ReportVacanciesList", (SqlConnection)_getOpenConnection.GetOpenConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("ManagedBy", SqlDbType.Int).Value = -1;
            command.Parameters.Add("Type", SqlDbType.Int).Value = -1;
            command.Parameters.Add("lscRegion", SqlDbType.Int).Value = -1;
            command.Parameters.Add("localauthority", SqlDbType.Int).Value = -1;
            command.Parameters.Add("Postcode", SqlDbType.VarChar).Value = "n/a";
            command.Parameters.Add("sector", SqlDbType.Int).Value = -1;
            command.Parameters.Add("framework", SqlDbType.Int).Value = -1;
            command.Parameters.Add("vacancyType", SqlDbType.Int).Value = -1;
            command.Parameters.Add("dateFrom", SqlDbType.DateTime).Value = fromDate;
            command.Parameters.Add("dateTo", SqlDbType.DateTime).Value = toDate;
            command.Parameters.Add("VacancyStatus", SqlDbType.Int).Value = -1;
            command.Parameters.Add("ProviderSiteID", SqlDbType.Int).Value = -1;
            command.Parameters.Add("RecAgentID", SqlDbType.Int).Value = -1;
            command.Parameters.Add("EmployerID", SqlDbType.Int).Value = -1;
            command.Parameters.Add("rowcount", SqlDbType.Int).Value = 0;

            command.CommandTimeout = 180;
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                response.Add(new ReportVacanciesResultItem()
                {
                    vacancyid = reader[0].ToString(),
                    VacancyTitle = reader[1].ToString(),
                    VacancyType = reader[2].ToString(),
                    Reference = reader[3].ToString(),
                    EmployerName = reader[4].ToString(),
                    EmployerNameActual = reader[5].ToString(),
                    EmployerAnonymousName = reader[6].ToString(),
                    IsEmployerAnonymous = reader[7].ToString(),
                    Postcode = reader[8].ToString(),
                    Sector = reader[9].ToString(),
                    Framework = reader[10].ToString(),
                    FrameworkStatus = reader[11].ToString(),
                    LearningProvider = reader[12].ToString(),
                    NumberOfPositions = reader[13].ToString(),
                    DatePosted = reader[14].ToString(),
                    ClosingDate = reader[15].ToString(),
                    NoOfPositionsAvailable = reader[16].ToString(),
                    NoOfApplications = reader[17].ToString(),
                    Status = reader[18].ToString(),
                    DeliverySite = reader[19].ToString()
                });
            }

            _logger.Debug($"Done executing report with toDate {toDate} and fromdate {fromDate}.");

            return response;
        }
    }
}
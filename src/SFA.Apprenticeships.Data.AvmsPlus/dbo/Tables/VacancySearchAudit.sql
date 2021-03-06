﻿CREATE TABLE [dbo].[VacancySearchAudit] (
    [VacancySearchAuditId]     INT             IDENTITY (-1, -1) NOT FOR REPLICATION NOT NULL,
    [SearchType]               INT             NOT NULL,
    [SearchTerm]               NVARCHAR (200)  NULL,
    [ApprenticeshipOccupation] INT             NULL,
    [ApprenticeFrameworks]     NVARCHAR (4000) NULL,
    [LocationId]               INT             NULL,
    [VacancyPostedSince]       INT             NULL,
    [PostCode]                 NVARCHAR (8)    NULL,
    [DistanceFromInMiles]      INT             NULL,
    [DistanceFromInMeters]     INT             NULL,
    [Easting]                  INT             NULL,
    [Northing]                 INT             NULL,
    [WeeklyWagesFrom]          INT             NULL,
    [WeeklyWagesTo]            INT             NULL,
    [PageNo]                   INT             NULL,
    [PageSize]                 INT             NULL,
    [SortByField]              NVARCHAR (100)  NULL,
    [SortOrder]                NVARCHAR (50)   NULL,
    [TotalVacancies]           INT             NULL,
    [TotalPositions]           INT             NULL,
    [SearchDate]               DATETIME        NOT NULL,
    [ApprenticeshipTypeId]     INT             NULL,
    CONSTRAINT [PK_VacancySearchAudit] PRIMARY KEY CLUSTERED ([VacancySearchAuditId] ASC)
);


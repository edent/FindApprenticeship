﻿CREATE TABLE [dbo].[VacancyTextField] (
    [VacancyTextFieldId] INT            IDENTITY (1, 1) NOT FOR REPLICATION NOT NULL,
    [VacancyId]          INT            NOT NULL,
    [Field]              INT            NOT NULL,
    [Value]              NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_VacancyTextField] PRIMARY KEY CLUSTERED ([VacancyTextFieldId] ASC) WITH (FILLFACTOR = 90) ON [PRIMARY],
    CONSTRAINT [FK_VacancyTextField_Vacancy] FOREIGN KEY ([VacancyId]) REFERENCES [dbo].[Vacancy] ([VacancyId]),
    CONSTRAINT [FK_VacancyTextField_VacancyTextFieldValue] FOREIGN KEY ([Field]) REFERENCES [dbo].[VacancyTextFieldValue] ([VacancyTextFieldValueId])
) TEXTIMAGE_ON [PRIMARY];


GO
CREATE NONCLUSTERED INDEX [idx_VacancyTextField_VacancyId]
    ON [dbo].[VacancyTextField]([VacancyId] ASC) WITH (FILLFACTOR = 90)
    ON [Index];

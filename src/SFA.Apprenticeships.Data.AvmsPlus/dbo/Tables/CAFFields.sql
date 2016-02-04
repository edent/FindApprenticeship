﻿CREATE TABLE [dbo].[CAFFields] (
    [CAFFieldsId]   INT             IDENTITY (1, 1) NOT FOR REPLICATION NOT NULL,
    [CandidateId]   INT             NOT NULL,
    [ApplicationId] INT             NULL,
    [Field]         SMALLINT        NOT NULL,
    [Value]         NVARCHAR (4000) NULL,
    CONSTRAINT [PK_CAFFields_1] PRIMARY KEY CLUSTERED ([CAFFieldsId] ASC) WITH (FILLFACTOR = 90) ON [PRIMARY],
    CONSTRAINT [FK_CAFFields_Application] FOREIGN KEY ([ApplicationId]) REFERENCES [dbo].[Application] ([ApplicationId]),
    CONSTRAINT [FK_CAFFields_CAFFieldsFieldType] FOREIGN KEY ([Field]) REFERENCES [dbo].[CAFFieldsFieldType] ([CAFFieldsFieldTypeId]),
    CONSTRAINT [FK_CAFFields_Candidate] FOREIGN KEY ([CandidateId]) REFERENCES [dbo].[Candidate] ([CandidateId]),
    CONSTRAINT [uq_idx_CAFFields] UNIQUE NONCLUSTERED ([CandidateId] ASC, [ApplicationId] ASC, [Field] ASC) WITH (FILLFACTOR = 90) ON [Index]
);


GO
CREATE NONCLUSTERED INDEX [idx_CAFFields_ApplicationId]
    ON [dbo].[CAFFields]([ApplicationId] ASC) WHERE ([ApplicationID] IS NOT NULL)
    ON [Index];

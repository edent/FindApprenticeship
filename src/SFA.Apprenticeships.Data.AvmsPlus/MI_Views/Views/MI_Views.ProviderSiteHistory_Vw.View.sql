CREATE VIEW [MI_Views].[ProviderSiteHistory_Vw]
AS
     SELECT TrainingProviderHistoryId,
            TrainingProviderId,
            UserName,
            HistoryDate,
            EventTypeId,
            Comment
     FROM dbo.ProviderSiteHistory;
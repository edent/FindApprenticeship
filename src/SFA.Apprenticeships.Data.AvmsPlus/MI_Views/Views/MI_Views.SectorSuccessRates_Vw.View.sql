CREATE VIEW [MI_Views].[SectorSuccessRates_Vw]
AS
     SELECT ProviderID,
            SectorID,
            PassRate,
            New
     FROM dbo.SectorSuccessRates;
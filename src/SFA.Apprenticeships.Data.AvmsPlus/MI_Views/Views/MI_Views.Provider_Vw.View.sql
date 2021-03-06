CREATE VIEW [MI_Views].[Provider_Vw]
AS
     SELECT ProviderID,
            UPIN,
            UKPRN,
            FullName,
            TradingName,
            IsContracted,
            ContractedFrom,
            ContractedTo,
            ProviderStatusTypeID,
            IsNASProvider
     FROM dbo.Provider;
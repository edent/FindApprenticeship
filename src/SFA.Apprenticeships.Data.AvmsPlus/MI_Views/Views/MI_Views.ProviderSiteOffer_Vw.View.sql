CREATE VIEW [MI_Views].[ProviderSiteOffer_Vw]
AS
     SELECT ProviderSiteOfferID,
            ProviderSiteLocalAuthorityID,
            ProviderSiteFrameworkID,
            Apprenticeship,
            AdvancedApprenticeship,
            HigherApprenticeship
     FROM dbo.ProviderSiteOffer;
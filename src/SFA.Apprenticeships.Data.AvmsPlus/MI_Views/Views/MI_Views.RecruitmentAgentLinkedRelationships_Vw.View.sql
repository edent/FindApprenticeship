CREATE VIEW [MI_Views].[RecruitmentAgentLinkedRelationships_Vw]
AS
     SELECT ProviderSiteRelationshipID,
            VacancyOwnerRelationshipID
     FROM dbo.RecruitmentAgentLinkedRelationships;
﻿/* DROP FUNCTION [dbo].[fnGetIdsForApi] */
CREATE FUNCTION [dbo].[fnGetIdsForApi]
(
    @vacancyReferenceNumber INT,
    @frameworkCode          VARCHAR(3),
    @occupationCode         VARCHAR(3),
    @countyCode             VARCHAR(3),
    @town                   VARCHAR(255),
    @regionCode             VARCHAR(6),
    @vacancyPublishedDate   DATETIME,
    @locationType           INT
)
RETURNS @Result TABLE
(
	Sort_Id				   INT IDENTITY PRIMARY KEY,
	VacancyId              INT,
	VacancyReferenceNumber VARCHAR(100)
)
AS
BEGIN
    -- Obtain the vacancy live status ID for use in the main query
    DECLARE @liveVacancyStatusID INT = (
                                            SELECT	VacancyStatusTypeId 
                                            FROM	VacancyStatusType 
                                            WHERE	CodeName = 'Lve' 
                                        );

    -- Obtain Apprenticeship Framework Id from parameter supplied			
    DECLARE @frameworkId int = null
    IF @frameworkCode IS NOT NULL AND @frameworkCode <> ''
        SELECT	@frameworkId = ApprenticeshipFrameworkId
        FROM	ApprenticeshipFramework
        WHERE	CodeName = @frameworkCode;
	ELSE
		SELECT @frameworkId = -1;

    -- Obtain Occupation Id from parameter supplied			
    DECLARE @occupationId int =	null
    IF @occupationCode IS NOT NULL AND @occupationCode <> ''
        SELECT	@occupationId = ApprenticeshipOccupationId
        FROM	ApprenticeshipOccupation
        WHERE	Codename = @occupationCode;
	ELSE
		SELECT @occupationId = -1;

    -- Obtain County Id from parameter supplied			
    DECLARE @countyId int = null
    IF @countyCode IS NOT NULL AND @countyCode <> ''
        SELECT  @countyId = CountyId
        FROM    County
        WHERE   CodeName = @countyCode;
	ELSE
		SELECT @countyId = -1;

	IF @vacancyReferenceNumber = -1 AND @frameworkId = -1 AND @occupationId = -1 AND @vacancyPublishedDate IS NULL AND @countyId = -1 AND (@town IS NULL OR @town = '') AND (@regionCode IS NULL OR @regionCode = '')
		INSERT @Result
		SELECT
			vac.VacancyId, VacancyReferenceNumber
		FROM 
			Vacancy vac
		WHERE   vac.VacancyStatusId = @liveVacancyStatusID
			AND     (
						(@locationType = 1 AND vac.VacancyLocationTypeId = 3) 
						OR
						(@locationType = 0 AND vac.VacancyLocationTypeId IN (1,2))
					)
		ORDER BY VacancyReferenceNumber;
	ELSE IF @vacancyReferenceNumber = -1 AND @frameworkId = -1 AND @occupationId = -1 AND @vacancyPublishedDate IS NOT NULL AND @countyId = -1 AND (@town IS NULL OR @town = '') AND (@regionCode IS NULL OR @regionCode = '')
		INSERT @Result
		SELECT
			vac.VacancyId, VacancyReferenceNumber
		FROM 
			Vacancy vac		
			JOIN    VacancyHistory vh            ON  vh.VacancyId = vac.VacancyId 
												 AND vh.VacancyHistoryEventSubTypeId = @liveVacancyStatusID
												 AND vh.VacancyHistoryId = (
													SELECT	max(vh1.VacancyHistoryId)  
													FROM	VacancyHistory vh1
													WHERE	vh1.VacancyId = vac.VacancyId 
													AND		vh1.VacancyHistoryEventSubTypeId = @liveVacancyStatusID
												 )
		WHERE   vac.VacancyStatusId = @liveVacancyStatusID
			AND     (vh.HistoryDate                 > @vacancyPublishedDate   OR @vacancyPublishedDate   IS NULL)
			
			AND     (
						(@locationType = 1 AND vac.VacancyLocationTypeId = 3) 
						OR
						(@locationType = 0 AND vac.VacancyLocationTypeId IN (1,2))
					)
		ORDER BY VacancyReferenceNumber;
	ELSE
		INSERT @Result
		SELECT
			vac.VacancyId, VacancyReferenceNumber
		FROM 
			Vacancy vac
			LEFT OUTER JOIN    ApprenticeshipFramework  fwk ON  vac.ApprenticeshipFrameworkId  = fwk.ApprenticeshipFrameworkId
			LEFT OUTER JOIN    ApprenticeshipOccupation occ ON  fwk.ApprenticeshipOccupationId = occ.ApprenticeshipOccupationId
			JOIN    VacancyHistory vh            ON  vh.VacancyId = vac.VacancyId 
												 AND vh.VacancyHistoryEventSubTypeId = @liveVacancyStatusID
												 AND vh.VacancyHistoryId = (
													SELECT	max(vh1.VacancyHistoryId)  
													FROM	VacancyHistory vh1
													WHERE	vh1.VacancyId = vac.VacancyId 
													AND		vh1.VacancyHistoryEventSubTypeId = @liveVacancyStatusID
												 )
			LEFT OUTER JOIN dbo.LocalAuthority                la   ON  vac.LocalAuthorityId                  = la.LocalAuthorityId		
			LEFT OUTER JOIN dbo.LocalAuthorityGroupMembership LAGM ON  LA.LocalAuthorityId                   = LAGM.LocalAuthorityID
			LEFT OUTER JOIN dbo.LocalAuthorityGroup           LAG  ON  LAGM.LocalAuthorityGroupID            = LAG.LocalAuthorityGroupID
			LEFT OUTER JOIN dbo.LocalAuthorityGroupType       LAGT ON  LAG.LocalAuthorityGroupTypeID         = LAGT.LocalAuthorityGroupTypeID
			LEFT OUTER JOIN dbo.ProviderSite                  DO   ON  DO.ProviderSiteId                     = vac.DeliveryOrganisationId
			LEFT OUTER JOIN ProviderSiteRelationship          DOR  ON  DOR.ProviderSiteId                    = vac.DeliveryOrganisationID
			LEFT OUTER JOIN ProviderSiteRelationshipType      DORT ON  DORT.ProviderSiteRelationshipTypeID   = DOR.ProviderSiteRelationshipTypeID
			LEFT OUTER JOIN County                            CY   ON  CY.CountyId                           = la.CountyId
		                                                       
		WHERE   vac.VacancyStatusId = @liveVacancyStatusID
		AND     lagt.LocalAuthorityGroupTypeName      = 'Region'
		AND     DORT.ProviderSiteRelationshipTypeName = 'Owner'
		AND     (vac.VacancyReferenceNumber     = @vacancyReferenceNumber OR @vacancyReferenceNumber = -1) 
		AND     (vac.ApprenticeshipFrameworkId  = @frameworkId            OR @frameworkId            = -1)
		AND     (occ.ApprenticeshipOccupationId = @occupationId           OR @occupationId           = -1)
		AND     (vh.HistoryDate                 > @vacancyPublishedDate   OR @vacancyPublishedDate   IS NULL)
		AND     (
					(@locationType = 1 AND vac.VacancyLocationTypeId = 3) 
					OR
					(     @locationType = 0
					  AND vac.VacancyLocationTypeId IN (1,2)
					  AND (vac.CountyId = @countyId   OR CY.CountyId = @countyId OR @countyId = -1)
					  AND (vac.Town     = @town       OR @town           IS NULL OR @town = '')
					  AND (LAG.CodeName = @regionCode OR @regionCode     IS NULL OR @regionCode = '')
					)
				)
	
		ORDER BY VacancyReferenceNumber;

	RETURN
END;
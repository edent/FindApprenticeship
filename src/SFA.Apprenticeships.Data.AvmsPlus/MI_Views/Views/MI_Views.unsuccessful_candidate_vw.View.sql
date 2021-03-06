CREATE VIEW [MI_Views].[unsuccessful_candidate_vw]
AS
     SELECT can.candidateid, 
            -- Candidate Identity
            p.FirstName AS FirstName,
            p.MiddleNames AS MiddleName,
            p.SurName AS SurName,
            CASE
                WHEN gen.candidateGenderId = 0
                THEN 'Unspecified'
                ELSE gen.Fullname
            END AS Gender,
            can.DateofBirth,
            CASE
                WHEN Disability = 0
                     OR Disability = 14
                THEN 'No'
                ELSE 'Yes'
            END AS Disability,
            can.AllowMarketingMessages,
            can.AddressLine1,
            can.AddressLine2,
            can.AddressLine3,
            can.AddressLine4,
            can.AddressLine5,
            can.Postcode,
            can.Town,
            county.FullName AS AuthorityArea,
            can.Town+', '+can.Postcode 'ShortAddress',
            p.LandlineNumber AS TelephoneNumber,
            p.MobileNumber,
            p.Email,
            la.LocalAuthorityId,
            la.FullName AS LocalAuthorityName,
		
            -- Number of applications by candidate
            isnull(
                  (
                      SELECT COUNT(*)
                      FROM [application] app
                      WHERE ApplicationStatusTypeId = 5
                            AND app.candidateid = outerApp.candidateid
                  ), 0) AS Unsuccessful,
            isnull(
                  (
                      SELECT COUNT(*)
                      FROM [application] app
                      WHERE ApplicationStatusTypeId IN(2, 3)
                      AND app.candidateid = outerApp.candidateid
                  ), 0) AS Ongoing,
            isnull(
                  (
                      SELECT COUNT(*)
                      FROM [application] app
                      WHERE ApplicationStatusTypeId = 4
                            AND app.candidateid = outerApp.candidateid
                  ), 0) AS Withdrawn,
			
     -- Application detail
            ahApplied.ApplicationHistoryEventDate AS DateApplied,
            vac.ApplicationClosingDate AS VacancyClosingDate,
            ah.ApplicationHistoryEventDate AS DateOfUnsuccessfulNotification,
            tp.FullName+' ('+tp.Town+', '+tp.PostCode+')' AS LearningProvider,
            pr.UKPRN AS LearningProviderUKPRN,
            'VAC'+REPLACE(RIGHT('000000000'+STR(vac.VacancyReferenceNumber), 9), ' ', '0') AS VacancyReferenceNumber,
            vac.Title AS VacancyTitle,
            aprtype.FullName AS VacancyLevel,
            sec.Fullname AS Sector,
            fr.Fullname AS Framework,
            aurt.FullName AS UnsuccessfulReason,
            outerApp.OutcomeReasonOther AS Notes,
            aurt.ReferralPoints AS Points
     FROM [application] outerApp
          INNER JOIN candidate can ON can.candidateid = outerApp.candidateid
          INNER JOIN person p ON p.PersonId = can.PersonId
          INNER JOIN candidategender gen ON can.Gender = gen.CandidateGenderId
          INNER JOIN county ON can.CountyId = county.CountyId
          INNER JOIN vacancy vac ON outerApp.VacancyId = vac.VacancyId
          INNER JOIN VacancyOwnerRelationship vpr ON vac.VacancyOwnerRelationshipId = vpr.VacancyOwnerRelationshipId
          INNER JOIN ProviderSite tp ON vpr.ProviderSiteId = tp.ProviderSiteId
          INNER JOIN ProviderSiteRelationship psr ON psr.ProviderSiteID = tp.ProviderSiteID
                                                     AND vac.ContractOwnerId = psr.ProviderID
          INNER JOIN Provider pr ON pr.ProviderID = psr.ProviderID
          INNER JOIN apprenticeshiptype aprtype ON vac.ApprenticeshipType = aprtype.ApprenticeshipTypeId
          INNER JOIN apprenticeshipframework fr ON vac.ApprenticeshipFrameworkId = fr.ApprenticeshipFrameworkId
          INNER JOIN apprenticeshipoccupation sec ON fr.ApprenticeshipOccupationId = sec.ApprenticeshipOccupationId
          INNER JOIN ApplicationUnsuccessfulReasonType aurt ON outerApp.UnsuccessfulReasonId = aurt.ApplicationUnsuccessfulReasonTypeId
          INNER JOIN applicationhistory ah ON outerApp.ApplicationId = ah.ApplicationId
                                              AND ah.ApplicationHistoryEventTypeId = 1
                                              AND ah.ApplicationHistoryEventSubTypeId = 5
          INNER JOIN applicationhistory ahApplied ON outerApp.ApplicationId = ahApplied.ApplicationId
                                                     AND ahApplied.ApplicationHistoryEventTypeId = 1
                                                     AND ahApplied.ApplicationHistoryEventSubTypeId = 2
          INNER JOIN LocalAuthority LA ON LA.LocalAuthorityId = can.LocalAuthorityId
     WHERE can.CandidateStatusTYpeId = 2
           AND NOT EXISTS
     (	-- FILTER: only return candidates that don't have a single successful application
         SELECT candidateid
         FROM [application]
         WHERE ApplicationStatusTypeId = 6
               AND CandidateId = outerApp.CandidateId
     );
CREATE VIEW [MI_Views].[successful_candidate_vw]
AS
     SELECT isnull(p.FirstName+' ', '')+p.Surname AS Name,
            CASE
                WHEN c.Gender = 0
                THEN 'Unspecified'
                ELSE CG.FullName
            END AS Gender,
            c.DateofBirth,
            c.Postcode,
            la.LocalAuthorityId,
            la.FullName AS LocalAuthorityName,
            tp.TradingName+' ('+tp.Town+', '+tp.PostCode+')' LearningProvider,
            'VAC'+REPLACE(RIGHT('000000000'+STR(v.VacancyReferenceNumber), 9), ' ', '0') AS VacancyReferenceNumber,
            v.Title VacancyTitle,
            at.FullName VacancyType,
            (AO.ShortName+' '+AO.FullName) Sector,
            (AF.CodeName+' '+AF.FullName) Framework,
            AFST.Fullname AS FrameworkStatus,
            e.TradingName+' ('+e.Town+', '+e.PostCode+')' Employer,

            -- 17/02/2014 Find all Successful Application Dates
            --	    (select min(AH.ApplicationHistoryEventDate) from ApplicationHistory AH
            --							where AH.ApplicationId = a.ApplicationId) SuccessfulAppDate,
            AH.ApplicationHistoryEventDate AS SuccessfulAppDate,
            sv.startdate AS ILRStartDate,
            sv.ILRNumber AS ILRReference
     FROM Application a
          INNER JOIN ApplicationHistory ah ON ah.ApplicationId = a.ApplicationId -- 17/02/2014 Join on every Application History record for the Application Id
          --			AND ah.ApplicationHistoryId = (SELECT MIN(ApplicationHistoryId)
          --							FROM ApplicationHistory ah1
          --							WHERE ah1.applicationid = a.applicationid)
          INNER JOIN Candidate c ON c.CandidateId = a.CandidateId
          INNER JOIN CandidateGender cg ON c.Gender = cg.CandidateGenderId
          INNER JOIN Person p ON c.PersonId = p.PersonId
          INNER JOIN Vacancy v ON v.VacancyId = a.VacancyId
          INNER JOIN ApprenticeshipType at ON v.apprenticeshiptype = at.apprenticeshiptypeid
          INNER JOIN ApprenticeshipFramework af ON af.ApprenticeshipFrameworkId = v.ApprenticeshipFrameworkId
          INNER JOIN ApprenticeshipOccupation ao ON ao.ApprenticeshipOccupationId = af.ApprenticeshipOccupationId
          INNER JOIN ApprenticeshipFrameworkStatusType AFST ON AF.ApprenticeshipFrameworkStatusTypeId = AFST.ApprenticeshipFrameworkStatusTypeId
          INNER JOIN VacancyOwnerRelationship vpr ON vpr.VacancyOwnerRelationshipId = v.VacancyOwnerRelationshipId
          INNER JOIN ProviderSIte tp ON tp.ProviderSiteID = vpr.ProviderSIteID
          INNER JOIN Employer e ON e.EmployerId = vpr.EmployerId
          JOIN dbo.LocalAuthority la ON la.LocalAuthorityId = c.LocalAuthorityId
          LEFT OUTER JOIN SubVacancy sv ON sv.AllocatedApplicationId = a.ApplicationId
                                           AND sv.vacancyid = v.vacancyid
     WHERE a.applicationStatusTypeId = 6;
GO
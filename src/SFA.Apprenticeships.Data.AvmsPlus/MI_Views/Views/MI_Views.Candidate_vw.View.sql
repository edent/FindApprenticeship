CREATE VIEW [MI_Views].[Candidate_vw]
AS
     SELECT c.CandidateId,
            c.PersonId,
            CASE
                WHEN cs.fullname = 'Pre-Registered'
                THEN CASE
                         WHEN DATEPART(month, dateofbirth) = DATEPART(month, ch.eventdate)
                              AND DATEPART(day, dateofbirth) > DATEPART(day, ch.eventdate)
                         THEN CONVERT( FLOAT, DATEDIFF(mm, DateofBirth, ch.eventdate) / 12, 0) - 1
                         ELSE CONVERT(FLOAT, DATEDIFF(mm, DateofBirth, ch.eventdate) / 12, 0)
                     END
                ELSE CONVERT(FLOAT, DATEDIFF(mm, DateofBirth, GETDATE()) / 12, 0)
            END AS 'Age',
            DateofBirth,
            CandidateStatusTypeId,
            '' AS AddressLine1,
            '' AS AddressLine2,
            '' AS AddressLine3,
            '' AS AddressLine4,
            '' AS AddressLine5,
            '' AS Town,
            '' AS CountyId,
            c.Postcode,
            isnull(lk.Ward_03_Code, 'Unknown Ward 2003 Code') AS 'Ward_03_Code',
            LocalAuthorityId,
            Longitude,
            Latitude,
            GeocodeEasting,
            GeocodeNorthing,
            NiReference,
            VoucherReferenceNumber,
            UniqueLearnerNumber,
            UlnStatusId,
            Gender,
            EthnicOrigin,
            EthnicOriginOther,
            ApplicationLimitEnforced,
            LastAccessedDate,
            '' AS AdditionalEmail,
            Disability,
            DisabilityOther,
            HealthProblems,
            ReceivePushedContent,
            ReferralAgent,
            DisableAlerts,
            UnconfirmedEmailAddress,
            MobileNumberUnconfirmed,
            DoBFailureCount,
            ForgottenUsernameRequested,
            ForgottenPasswordRequested,
            TextFailureCount,
            EmailFailureCount,
            LastAccessedManageApplications,
            ReferralPoints,
            BeingSupportedBy,
            LockedForSupportUntil,
            NewVacancyAlertEmail,
            NewVacancyAlertSMS      ,
            -- INC9970977/SDE485653/CRQ1610257 Re-instate two lines below. James G Taylor 29/10/2013
            AllowMarketingMessages,
            ReminderMessageSent
     FROM Candidate c
          LEFT OUTER JOIN candidatehistory ch ON c.candidateid = ch.candidateid
                                                 AND ch.CandidateHistorySubEventTypeId = 1
          LEFT OUTER JOIN candidatestatus cs ON isnull(ch.CandidateHistorySubEventTypeId, '') = isnull(cs.CandidateStatusId, '')
          LEFT OUTER JOIN lk_postcode_ward lk ON isnull(c.postcode, '') = isnull(lk.postcode, '') COLLATE Latin1_General_CI_AS;
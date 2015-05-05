﻿namespace SFA.Apprenticeships.Domain.Entities.Candidates
{
    public static class CandidateHelper
    {
        public static bool MobileVerificationRequired(this Candidate candidate)
        {
            var communicationPreferences = candidate.CommunicationPreferences;

            return !communicationPreferences.VerifiedMobile &&
                   (communicationPreferences.IsAnyTextCommunicationEnabled());
        }

        public static bool AllowsCommunication(this Candidate candidate)
        {
            var communicationPreferences = candidate.CommunicationPreferences;

            return communicationPreferences.IsAnyEmailCommunicationEnabled() ||
                   (communicationPreferences.IsAnyTextCommunicationEnabled() && communicationPreferences.VerifiedMobile);
        }

        public static bool ShouldSendSavedSearchAlerts(this Candidate candidate)
        {
            var communicationPreferences = candidate.CommunicationPreferences;
            var savedSearchPreferences = communicationPreferences.SavedSearchPreferences;

            return savedSearchPreferences.EnableEmail ||
                   (savedSearchPreferences.EnableText && communicationPreferences.VerifiedMobile);
        }
    }
}
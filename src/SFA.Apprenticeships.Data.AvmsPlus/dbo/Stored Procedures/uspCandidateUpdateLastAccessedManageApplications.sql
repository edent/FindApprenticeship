﻿CREATE PROCEDURE [dbo].[uspCandidateUpdateLastAccessedManageApplications]      
  @CandidateId int 
  --@LastAccessedManag=eApplicationsDate datetime     
AS      
BEGIN      
 SET NOCOUNT ON      
       
    UPDATE Candidate 
        SET LastAccessedManageApplications = getdate()
    WHERE
        CANDIDATEID = @CandidateId
          
    SET NOCOUNT OFF      
END
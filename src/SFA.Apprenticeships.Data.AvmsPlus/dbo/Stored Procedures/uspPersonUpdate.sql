﻿CREATE PROCEDURE [dbo].[uspPersonUpdate]        
     @PersonId INT,        
        @ADUsername nvarchar(50) = NULL,        
        @Title int = NULL,        
        @OtherTitle nvarchar(10) = NULL,        
        @FirstName nvarchar(35) = NULL,        
        @MiddleNames nvarchar(35)= NULL,        
        @Surname nvarchar(35)= NULL,        
        @LandlineNumber nvarchar(30) = NULL,        
        @MobileNumber nvarchar(30) = NULL,        
        @TextFailureCount smallint = NULL,        
        @Email nvarchar(70) = NULL,        
      --@PersonTypeId int = NULL,        
        @EmailFailureCount smallint = NULL,        
       -- @Type nvarchar(20) = NULL,        
        @EmailAlertSent bit = NULL        
        
AS        
BEGIN        
        
 --The [dbo].[Person] table doesn't have a timestamp column. Optimistic concurrency logic cannot be generated        
 SET NOCOUNT ON        
        
 BEGIN TRY        
        
 /*If a field parameter passed to the stored procedure is null then then stored procedure        
    will not change the values already stored in that field.*/        
        
 UPDATE [dbo].[Person]         
 SET         
  --[ADUsername] = ISNULL(@aDUsername, ADUsername),         
  [Title] = ISNULL(@title,Title),         
  [OtherTitle] = ISNULL(@otherTitle,OtherTitle),        
  [FirstName] = ISNULL(@firstName,FirstName),         
  [MiddleNames] = ISNULL(@middleNames,MiddleNames),         
  [Surname] = ISNULL(@surname,Surname),        
  [LandlineNumber] = ISNULL(@landlineNumber,LandlineNumber),         
  [MobileNumber] = ISNULL(@mobileNumber,MobileNumber),        
 -- [TextFailureCount] = ISNULL(@textFailureCount,TextFailureCount),        
  [Email] = ISNULL(@email,Email),         
  [PersonTypeId]= 2 --ISNULL(@PersonTypeId, PersonTypeId),        
  --[EmailFailureCount] = ISNULL(@emailFailureCount,EmailFailureCount),         
  --[EmailAlertSent] = ISNULL(@emailAlertSent,EmailAlertSent),        
  --[LastAccessed] = GETDATE()        
 WHERE [PersonId]=@personId        
                
 IF @@ROWCOUNT = 0        
 BEGIN        
  RAISERROR('Concurrent update error. Updated aborted.', 16, 2)        
 END        
    END TRY        
        
    BEGIN CATCH        
  EXEC RethrowError;        
 END CATCH         
        
 SET NOCOUNT OFF        
END        
         
        
        
        
        
   -- select * from candidate*/
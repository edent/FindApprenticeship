﻿CREATE PROCEDURE [dbo].[uspEmployerSelectByNameAndPostcodeAndCity]                
 -- Add the parameters for the stored procedure here                
 @EmployerName varchar(255),                
 @Postcode varchar(10),                
 @Town varchar(100),          
 @RegionId INT = 0,          
 @PageIndex int =  1,                  
@PageSize int = 50,                  
@IsSortAsc bit= 1,                  
@SortByField nvarchar(100) = 'EmployerName'                  
AS                
BEGIN                
 -- SET NOCOUNT ON added to prevent extra result sets from                
 -- interfering with SELECT statements.              
           
 SET NOCOUNT ON;                 
           
 IF @RegionId = 0 SET @RegionId = null             
/*********Set Page Number**********************************************/                  
declare @StartRowNo int                  
declare @EndRowNo int                  
set @StartRowNo =((@PageIndex-1)* @PageSize)+1                   
set @EndRowNo =(@PageIndex * @PageSize)                      
/***********************************************************************/                  
          
/**************Total Number of Rows*************************************/                  
declare @TotalRows int                  
select @TotalRows= count(1)   FROM                 
 dbo.Employer E                 
 Left Outer Join County on County.CountyId = E.CountyId 
 INNER JOIN dbo.LocalAuthority LA ON E.LocalAuthorityId = LA.LocalAuthorityId
 INNER JOIN dbo.LocalAuthorityGroupMembership LAGM ON LA.LocalAuthorityId = LAGM.LocalAuthorityID
 INNER JOIN dbo.LocalAuthorityGroup LAG ON LAGM.LocalAuthorityGroupID = LAG.LocalAuthorityGroupID
 INNER JOIN dbo.LocalAuthorityGroupType LAGT ON LAG.LocalAuthorityGroupTypeID = LAGT.LocalAuthorityGroupTypeID
 AND LocalAuthorityGroupTypeName = N'Region'   
                 
--left outer join LSCRegion on LSCRegion.LSCRegionId = E.LSCRegionId                    
--    INNER JOIN dbo.EmployerSite Site                
-- ON E.EmployerId=Site.EmployerId                 
 WHERE                  
 ((E.FullName like '%' + @EmployerName + '%' OR E.TradingName like '%' + @EmployerName + '%') OR       
  @EmployerName IS null) AND                 
 (E.Postcode like  '%' + @Postcode + '%' OR @Postcode IS NULL) AND                
 (LAG.LocalAuthorityGroupID =  @RegionId  OR @RegionId IS NULL) AND                
 (E.Town like  '%' + @Town + '%' OR @Town IS NULL)                             
/***********************************************************************/                  
/*********set the order by**********************************************/                  
                  
declare @OrderBywithSort varchar(500)                  
                  
 if @IsSortAsc = 1 BEGIN set  @SortByField = @SortByField + ' Asc' END                  
 if @IsSortAsc = 0 BEGIN  set  @SortByField = @SortByField + ' desc' END             
/***********************************************************************/                  
           
                
SELECT *,@TotalRows  as 'TotalRows' FROM                  
(                   
SELECT  ROW_NUMBER() OVER( ORDER BY                   
 Case when @SortByField='EmployerName Asc'  then E.FullName  End ASC,                  
    Case when @SortByField='EmployerName desc'  then E.FullName  End DESC,  
  
Case when @SortByField='TradingName Asc'  then E.TradingName  End ASC,                  
    Case when @SortByField='TradingName desc'  then E.TradingName  End DESC,           
        
Case when @SortByField='VacancyTown Asc'  then E.Town  End ASC,                  
    Case when @SortByField='VacancyTown desc'  then E.Town  End DESC,           
        
Case when @SortByField='PostCode Asc'  then E.PostCode   End ASC,                  
    Case when @SortByField='PostCode desc'  then E.PostCode  End DESC ,          
        
Case when @SortByField='SICCode Asc'  then dbo.fnx_GetSICCodes(E.EmployerId)  End ASC,                  
    Case when @SortByField='SICCode desc'  then dbo.fnx_GetSICCodes(E.EmployerId)  End DESC            
                
 ) as RowNum,                 
    E.EmployerId                
    ,E.FullName    
    ,E.TradingName               
    ,E.EdsUrn               
    ,E.AddressLine1                
    ,E.AddressLine2                
    ,E.AddressLine3                
    ,E.AddressLine4        
    ,E.Town                
    ,County.FullName as 'County'                    
    ,LAG.FullName as 'Region'                
    ,E.PostCode                
    ,E.Longitude                
    ,E.Latitude            
    ,E.CountyId            
    ,LAG.LocalAuthorityGroupID
    ,dbo.fnx_GetSICCodes(E.EmployerId) as 'SICCodes'               
 FROM                 
 dbo.Employer E                 
 Left Outer Join County on County.CountyId = E.CountyId                    
 INNER JOIN dbo.LocalAuthority LA ON E.LocalAuthorityId = LA.LocalAuthorityId
 INNER JOIN dbo.LocalAuthorityGroupMembership LAGM ON LA.LocalAuthorityId = LAGM.LocalAuthorityID
 INNER JOIN dbo.LocalAuthorityGroup LAG ON LAGM.LocalAuthorityGroupID = LAG.LocalAuthorityGroupID
 INNER JOIN dbo.LocalAuthorityGroupType LAGT ON LAG.LocalAuthorityGroupTypeID = LAGT.LocalAuthorityGroupTypeID
 AND LocalAuthorityGroupTypeName = N'Region'

--left outer join LSCRegion on LSCRegion.LSCRegionId = E.LSCRegionId                    
--    INNER JOIN dbo.EmployerSite Site                
-- ON E.EmployerId=Site.EmployerId                 
 WHERE                   
 ((E.FullName like '%' + @EmployerName + '%' OR E.TradingName like '%' + @EmployerName + '%') OR       
  @EmployerName IS null) AND         
 (E.Postcode like  '%' + @Postcode + '%' OR @Postcode IS NULL) AND                
 (LAG.LocalAuthorityGroupID =  @RegionId  OR @RegionId IS NULL) AND                
 (E.Town like  '%' + @Town + '%' OR @Town IS NULL)  ) as DerivedTable                  
WHERE RowNum BETWEEN @StartRowNo AND @EndRowNo                
                
END
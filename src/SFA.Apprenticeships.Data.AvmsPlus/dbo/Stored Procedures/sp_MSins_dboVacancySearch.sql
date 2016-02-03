﻿create procedure [sp_MSins_dboVacancySearch]
    @c1 int,
    @c2 int,
    @c3 int,
    @c4 nvarchar(256),
    @c5 nvarchar(256),
    @c6 nvarchar(256),
    @c7 int,
    @c8 int,
    @c9 decimal(13,10),
    @c10 decimal(13,10),
    @c11 int,
    @c12 datetime,
    @c13 nvarchar(100),
    @c14 nvarchar(256),
    @c15 nvarchar(max),
    @c16 int,
    @c17 datetime,
    @c18 int,
    @c19 nvarchar(200),
    @c20 nvarchar(200),
    @c21 int,
    @c22 money,
    @c23 int,
    @c24 nvarchar(40),
    @c25 int,
    @c26 int,
    @c27 nvarchar(max),
    @c28 nvarchar(max),
    @c29 bit
as
begin  
	insert into [dbo].[VacancySearch](
		[VacancySearchId],
		[VacancyId],
		[VacancyReferenceNumber],
		[EmployerName],
		[VacancyOwnerName],
		[DeliveryOrganisationName],
		[GeocodeEasting],
		[GeocodeNorthing],
		[Latitude],
		[Longitude],
		[LocalAuthorityID],
		[VacancyPostedDate],
		[Title],
		[ShortDescription],
		[Description],
		[Status],
		[ApplicationClosingDate],
		[ApprenticeshipFrameworkId],
		[ApprenticeshipOccupationName],
		[ApprenticeshipFrameworkName],
		[CountyId],
		[WeeklyWage],
		[WageType],
		[Town],
		[ApprenticeshipType],
		[ApplicationClosingDateAsInt],
		[RealityCheck],
		[OtherImportantInformation],
		[NationalVacancy]
	) values (
    @c1,
    @c2,
    @c3,
    @c4,
    @c5,
    @c6,
    @c7,
    @c8,
    @c9,
    @c10,
    @c11,
    @c12,
    @c13,
    @c14,
    @c15,
    @c16,
    @c17,
    @c18,
    @c19,
    @c20,
    @c21,
    @c22,
    @c23,
    @c24,
    @c25,
    @c26,
    @c27,
    @c28,
    @c29	) 
end
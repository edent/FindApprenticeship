﻿create procedure [sp_MSins_dboVacancySearchAudit]
    @c1 int,
    @c2 int,
    @c3 nvarchar(200),
    @c4 int,
    @c5 nvarchar(4000),
    @c6 int,
    @c7 int,
    @c8 nvarchar(8),
    @c9 int,
    @c10 int,
    @c11 int,
    @c12 int,
    @c13 int,
    @c14 int,
    @c15 int,
    @c16 int,
    @c17 nvarchar(100),
    @c18 nvarchar(50),
    @c19 int,
    @c20 int,
    @c21 datetime,
    @c22 int
as
begin  
	insert into [dbo].[VacancySearchAudit](
		[VacancySearchAuditId],
		[SearchType],
		[SearchTerm],
		[ApprenticeshipOccupation],
		[ApprenticeFrameworks],
		[LocationId],
		[VacancyPostedSince],
		[PostCode],
		[DistanceFromInMiles],
		[DistanceFromInMeters],
		[Easting],
		[Northing],
		[WeeklyWagesFrom],
		[WeeklyWagesTo],
		[PageNo],
		[PageSize],
		[SortByField],
		[SortOrder],
		[TotalVacancies],
		[TotalPositions],
		[SearchDate],
		[ApprenticeshipTypeId]
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
    @c22	) 
end
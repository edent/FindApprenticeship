/*
Added to support the existing Data Science ETL process used to produce MI reports
*/
CREATE TABLE [dbo].[TeamMembership](
	[systemuserid] [uniqueidentifier] NULL,
	[teamid] [uniqueidentifier] NULL,
	[teammembershipid] [uniqueidentifier] NULL
) ON [PRIMARY]
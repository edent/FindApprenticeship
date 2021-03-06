/*
Added to support the existing Data Science ETL process used to produce MI reports
*/
CREATE TABLE [dbo].[SystemUserRoles](
	[roleid] [uniqueidentifier] NULL,
	[systemuserid] [uniqueidentifier] NULL,
	[systemuserroleid] [uniqueidentifier] NULL
) ON [PRIMARY]
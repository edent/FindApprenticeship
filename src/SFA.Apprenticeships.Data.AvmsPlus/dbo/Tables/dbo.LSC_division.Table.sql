/*
Added to support the existing Data Science ETL process used to produce MI reports
*/
CREATE TABLE [dbo].[LSC_division](
	[createdby] [uniqueidentifier] NULL,
	[createdbydsc] [int] NULL,
	[createdbyname] [nvarchar](160) NULL,
	[createdon] [datetime] NULL,
	[createdonutc] [datetime] NULL,
	[importsequencenumber] [int] NULL,
	[lsc_divisionid] [uniqueidentifier] NULL,
	[lsc_name] [nvarchar](100) NULL,
	[modifiedby] [uniqueidentifier] NULL,
	[modifiedbydsc] [int] NULL,
	[modifiedbyname] [nvarchar](160) NULL,
	[modifiedon] [datetime] NULL,
	[modifiedonutc] [datetime] NULL,
	[organizationid] [uniqueidentifier] NULL,
	[organizationiddsc] [int] NULL,
	[organizationidname] [nvarchar](160) NULL,
	[overriddencreatedon] [datetime] NULL,
	[overriddencreatedonutc] [datetime] NULL,
	[statecode] [int] NULL,
	[statecodename] [nvarchar](255) NULL,
	[statuscode] [int] NULL,
	[statuscodename] [nvarchar](255) NULL,
	[timezoneruleversionnumber] [int] NULL,
	[utcconversiontimezonecode] [int] NULL
) ON [PRIMARY]
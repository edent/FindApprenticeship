/*
Added to support the existing Data Science ETL process used to produce MI reports
*/
CREATE TABLE [dbo].[LSC_siccode](
	[createdby] [uniqueidentifier] NULL,
	[createdbydsc] [int] NULL,
	[createdbyname] [nvarchar](160) NULL,
	[createdon] [datetime] NULL,
	[createdonutc] [datetime] NULL,
	[importsequencenumber] [int] NULL,
	[lsc_siccode] [nvarchar](10) NULL,
	[lsc_siccodeid] [uniqueidentifier] NULL,
	[lsc_siccodename] [nvarchar](4000) NULL,
	[lsc_siccodeyear] [nvarchar](4) NULL,
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
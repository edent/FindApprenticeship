/*
Added to support the existing Data Science ETL process used to produce MI reports
*/
CREATE TABLE [dbo].[Role](
	[createdby] [uniqueidentifier] NULL,
	[createdbydsc] [int] NULL,
	[createdbyname] [nvarchar](160) NULL,
	[createdbyyominame] [nvarchar](160) NULL,
	[createdon] [datetime] NULL,
	[createdonutc] [datetime] NULL,
	[importsequencenumber] [int] NULL,
	[modifiedby] [uniqueidentifier] NULL,
	[modifiedbydsc] [int] NULL,
	[modifiedbyname] [nvarchar](160) NULL,
	[modifiedbyyominame] [nvarchar](160) NULL,
	[modifiedon] [datetime] NULL,
	[modifiedonutc] [datetime] NULL,
	[name] [nvarchar](100) NULL,
	[organizationid] [uniqueidentifier] NULL,
	[organizationiddsc] [int] NULL,
	[organizationidname] [nvarchar](160) NULL,
	[businessunitid] [uniqueidentifier] NULL,
	[businessunitiddsc] [int] NULL,
	[businessunitidname] [nvarchar](160) NULL,
	[overriddencreatedon] [datetime] NULL,
	[overriddencreatedonutc] [datetime] NULL,
	[parentroleid] [uniqueidentifier] NULL,
	[parentroleiddsc] [int] NULL,
	[parentroleidname] [nvarchar](100) NULL,
	[roleid] [uniqueidentifier] NULL,
	[roletemplateid] [uniqueidentifier] NULL
) ON [PRIMARY]
/*
Added to support the existing Data Science ETL process used to produce MI reports
*/
CREATE TABLE [dbo].[Resource](
	[name] [nvarchar](300) NULL,
	[organizationid] [uniqueidentifier] NULL,
	[organizationiddsc] [int] NULL,
	[organizationidname] [nvarchar](160) NULL,
	[businessunitid] [uniqueidentifier] NULL,
	[businessunitiddsc] [int] NULL,
	[businessunitidname] [nvarchar](160) NULL,
	[calendarid] [uniqueidentifier] NULL,
	[displayinserviceviews] [bit] NULL,
	[displayinserviceviewsname] [nvarchar](255) NULL,
	[isdisabled] [bit] NULL,
	[isdisabledname] [nvarchar](255) NULL,
	[objecttypecode] [int] NULL,
	[objecttypecodename] [nvarchar](255) NULL,
	[resourceid] [uniqueidentifier] NULL,
	[siteid] [uniqueidentifier] NULL,
	[siteiddsc] [int] NULL,
	[siteidname] [nvarchar](160) NULL
) ON [PRIMARY]
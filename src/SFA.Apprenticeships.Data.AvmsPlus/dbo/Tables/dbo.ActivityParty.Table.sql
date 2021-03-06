/*
Added to support the existing Data Science ETL process used to produce MI reports
*/
CREATE TABLE [dbo].[ActivityParty](
	[activityid] [uniqueidentifier] NULL,
	[activitypartyid] [uniqueidentifier] NULL,
	[addressused] [nvarchar](200) NULL,
	[donotemail] [bit] NULL,
	[donotemailname] [nvarchar](255) NULL,
	[donotfax] [bit] NULL,
	[donotfaxname] [nvarchar](255) NULL,
	[donotphone] [bit] NULL,
	[donotphonename] [nvarchar](255) NULL,
	[donotpostalmail] [bit] NULL,
	[donotpostalmailname] [nvarchar](255) NULL,
	[effort] [float] NULL,
	[exchangeentryid] [nvarchar](1024) NULL,
	[participationtypemask] [int] NULL,
	[participationtypemaskname] [nvarchar](255) NULL,
	[partyid] [uniqueidentifier] NULL,
	[partyiddsc] [int] NULL,
	[partyidname] [nvarchar](400) NULL,
	[partyobjecttypecode] [int] NULL,
	[resourcespecid] [uniqueidentifier] NULL,
	[resourcespeciddsc] [int] NULL,
	[resourcespecidname] [nvarchar](160) NULL,
	[scheduledend] [datetime] NULL,
	[scheduledendutc] [datetime] NULL,
	[scheduledstart] [datetime] NULL,
	[scheduledstartutc] [datetime] NULL
) ON [PRIMARY]
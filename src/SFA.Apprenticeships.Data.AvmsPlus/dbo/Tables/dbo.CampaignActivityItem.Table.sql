/*
Added to support the existing Data Science ETL process used to produce MI reports
*/
CREATE TABLE [dbo].[CampaignActivityItem](
	[campaignactivityid] [uniqueidentifier] NULL,
	[campaignactivityitemid] [uniqueidentifier] NULL,
	[itemid] [uniqueidentifier] NULL,
	[itemobjecttypecode] [int] NULL,
	[itemobjecttypecodename] [nvarchar](255) NULL,
	[owningbusinessunit] [uniqueidentifier] NULL,
	[owninguser] [uniqueidentifier] NULL
) ON [PRIMARY]
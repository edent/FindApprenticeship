/*
Added to support the existing Data Science ETL process used to produce MI reports
*/
CREATE TABLE [dbo].[RelationshipRoleMap](
	[createdby] [uniqueidentifier] NULL,
	[createdbydsc] [int] NULL,
	[createdbyname] [nvarchar](160) NULL,
	[createdbyyominame] [nvarchar](160) NULL,
	[createdon] [datetime] NULL,
	[createdonutc] [datetime] NULL,
	[modifiedby] [uniqueidentifier] NULL,
	[modifiedbydsc] [int] NULL,
	[modifiedbyname] [nvarchar](160) NULL,
	[modifiedbyyominame] [nvarchar](160) NULL,
	[modifiedon] [datetime] NULL,
	[modifiedonutc] [datetime] NULL,
	[organizationid] [uniqueidentifier] NULL,
	[associateobjecttypecode] [int] NULL,
	[associateobjecttypecodename] [nvarchar](255) NULL,
	[primaryobjecttypecode] [int] NULL,
	[primaryobjecttypecodename] [nvarchar](255) NULL,
	[relationshiproleid] [uniqueidentifier] NULL,
	[relationshiproleiddsc] [int] NULL,
	[relationshiproleidname] [nvarchar](100) NULL,
	[relationshiprolemapid] [uniqueidentifier] NULL
) ON [PRIMARY]
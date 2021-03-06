/*
Added to support the existing Data Science ETL process used to produce MI reports
*/
CREATE TABLE [dbo].[StatusMap](
	[FilteredViewName] [nvarchar](64) NULL,
	[StateCode] [int] NULL,
	[StateCodeName] [nvarchar](255) NULL,
	[StatusCode] [int] NULL,
	[StatusCodeName] [nvarchar](255) NULL,
	[IsDefault] [bit] NULL
) ON [PRIMARY]
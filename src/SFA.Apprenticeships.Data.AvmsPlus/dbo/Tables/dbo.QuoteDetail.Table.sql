/*
Added to support the existing Data Science ETL process used to produce MI reports
*/
CREATE TABLE [dbo].[QuoteDetail](
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
	[timezoneruleversionnumber] [int] NULL,
	[transactioncurrencyid] [uniqueidentifier] NULL,
	[transactioncurrencyiddsc] [int] NULL,
	[transactioncurrencyidname] [nvarchar](100) NULL,
	[utcconversiontimezonecode] [int] NULL,
	[description] [ntext] NULL,
	[importsequencenumber] [int] NULL,
	[overriddencreatedon] [datetime] NULL,
	[overriddencreatedonutc] [datetime] NULL,
	[baseamount] [money] NULL,
	[baseamount_base] [money] NULL,
	[exchangerate] [numeric](23, 10) NULL,
	[extendedamount] [money] NULL,
	[extendedamount_base] [money] NULL,
	[ispriceoverridden] [bit] NULL,
	[ispriceoverriddenname] [nvarchar](255) NULL,
	[isproductoverridden] [bit] NULL,
	[isproductoverriddenname] [nvarchar](255) NULL,
	[lineitemnumber] [int] NULL,
	[manualdiscountamount] [money] NULL,
	[manualdiscountamount_base] [money] NULL,
	[owningbusinessunit] [uniqueidentifier] NULL,
	[owninguser] [uniqueidentifier] NULL,
	[priceperunit] [money] NULL,
	[priceperunit_base] [money] NULL,
	[pricingerrorcode] [int] NULL,
	[pricingerrorcodename] [nvarchar](255) NULL,
	[productdescription] [nvarchar](500) NULL,
	[productid] [uniqueidentifier] NULL,
	[productiddsc] [int] NULL,
	[productidname] [nvarchar](100) NULL,
	[quantity] [numeric](23, 10) NULL,
	[quotedetailid] [uniqueidentifier] NULL,
	[quoteid] [uniqueidentifier] NULL,
	[quotestatecode] [int] NULL,
	[quotestatecodename] [nvarchar](255) NULL,
	[requestdeliveryby] [datetime] NULL,
	[requestdeliverybyutc] [datetime] NULL,
	[salesrepid] [uniqueidentifier] NULL,
	[salesrepiddsc] [int] NULL,
	[salesrepidname] [nvarchar](160) NULL,
	[salesrepidyominame] [nvarchar](160) NULL,
	[shipto_addressid] [uniqueidentifier] NULL,
	[shipto_city] [nvarchar](50) NULL,
	[shipto_contactname] [nvarchar](150) NULL,
	[shipto_country] [nvarchar](50) NULL,
	[shipto_fax] [nvarchar](50) NULL,
	[shipto_freighttermscode] [int] NULL,
	[shipto_freighttermscodename] [nvarchar](255) NULL,
	[shipto_line1] [nvarchar](50) NULL,
	[shipto_line2] [nvarchar](50) NULL,
	[shipto_line3] [nvarchar](50) NULL,
	[shipto_name] [nvarchar](200) NULL,
	[shipto_postalcode] [nvarchar](20) NULL,
	[shipto_stateorprovince] [nvarchar](50) NULL,
	[shipto_telephone] [nvarchar](50) NULL,
	[tax] [money] NULL,
	[tax_base] [money] NULL,
	[uomid] [uniqueidentifier] NULL,
	[uomiddsc] [int] NULL,
	[uomidname] [nvarchar](100) NULL,
	[volumediscountamount] [money] NULL,
	[volumediscountamount_base] [money] NULL,
	[willcall] [bit] NULL,
	[willcallname] [nvarchar](255) NULL,
	[crm_moneyformatstring] [nvarchar](255) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
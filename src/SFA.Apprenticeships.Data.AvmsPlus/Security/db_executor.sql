﻿CREATE ROLE [db_executor]
    AUTHORIZATION [dbo];
GO

ALTER ROLE [db_executor] ADD MEMBER [apisvcadmin];
GO

ALTER ROLE [db_executor] ADD MEMBER [apisvc];
GO

ALTER ROLE [db_executor] ADD MEMBER [faa_user];
GO
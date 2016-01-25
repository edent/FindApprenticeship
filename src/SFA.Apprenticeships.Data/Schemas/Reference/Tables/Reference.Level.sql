﻿CREATE TABLE [Reference].[Level]
(
	[LevelCode] CHAR NOT NULL, 
    [FullName] NVARCHAR(MAX) NOT NULL, 
    CONSTRAINT [PK_Reference_Level] PRIMARY KEY ([LevelCode]) 
)

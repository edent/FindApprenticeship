﻿create procedure [sp_MSupd_dboSearchFrameworks]
		@c1 int = NULL,
		@c2 int = NULL,
		@c3 int = NULL,
		@pkc1 int = NULL,
		@bitmap binary(1)
as
begin  
update [dbo].[SearchFrameworks] set
		[FrameworkId] = case substring(@bitmap,1,1) & 2 when 2 then @c2 else [FrameworkId] end,
		[SavedSearchCriteriaId] = case substring(@bitmap,1,1) & 4 when 4 then @c3 else [SavedSearchCriteriaId] end
where [SearchFrameworksId] = @pkc1
if @@rowcount = 0
    if @@microsoftversion>0x07320000
        exec sp_MSreplraiserror 20598
end
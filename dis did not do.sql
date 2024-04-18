-- check for any database objects belonging to the wrong user
declare @owner varchar(50), @count int
set @owner = 'dbo' -- who should all tables etc.. belong to?

select @count = count(*) from sysobjects T1
JOIN sysusers T2 ON T1.uid = T2.uid WHERE xtype = 'U' AND T2.name != @owner

if @count > 0
begin
	print 'Found '+convert(varchar(4),@count)+' database objects need changing ownership...' + char(13)
	declare @name varchar(100), @old_owner varchar(100), @object varchar(200)
	declare objcur insensitive cursor for
		select T1.name, T2.name from sysobjects T1 JOIN sysusers T2 ON T1.uid = T2.uid
			WHERE xtype = 'U' AND T2.name != @owner ORDER BY T1.name
	open objcur
	fetch next from objcur into @name, @old_owner
	while (@@fetch_status = 0)
	begin
		set @object = @old_owner + '.' + @name
		exec sp_changeobjectowner @object, @owner
		print '- ' + @object + ' changed to ' + @owner + '.' + @name + '.'
		Fetch next from objcur into @name, @old_owner
	end
	print 'Object ownership changes complete.' + char(13)
	close objcur
	deallocate objcur
end
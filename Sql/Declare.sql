--declare @num int

--set @num = 123

--print @num
--print (@num + 100)

--select @num + len(Name)
--from People


-- print ISNULL(@num, 123)






--declare @maxName int

----select @@maxName = len(p.Name)
----from People p

--select top 1 @maxName = max(len(Name)) from People
--print @maxName

--update People
--set Name = NULL
--where len(Name) = @maxName


--select *
--from People
--where len(Email) = (select max(len(Email)) from People)

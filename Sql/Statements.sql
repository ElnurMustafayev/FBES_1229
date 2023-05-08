--drop proc GetNumberName
--create proc GetNumberName
--@number int
--as
--begin
--	declare @NumbersStr table ([Number] int primary key, [Word] varchar(10))

--	insert into @NumbersStr([Number], [Word])
--	values(1, 'One'), (2, 'Two'), (3, 'Three'), (4, 'Four'), (5, 'Five')

--	declare @result varchar(10)

--	select top 1 @result = [Word]
--	from @NumbersStr
--	where Number = @number

--	print @result
--end


-- GetNumberName 2


-- T-SQL
-- IF, ELSE IF, ELSE
-- CASE WHEN
-- WHILE
-- TRY CATCH

--select case
--when p.GenderId = 1 then 'MALE'
--when p.GenderId = 2 then 'FEMALE'
--when p.GenderId is NULL then 'NOT SET'
--else 'UNKNOWN'
--end
--from People p

--select IIF(p.GenderId = 1, 'MALE', 'FEMALE')
--from People p

--select *
--from People p
--where p.GenderId is null

--update People
--set GenderId = null
--where Id % 15 = 0



--create proc GetPersonGenderStrById
--@id int
--as
--begin
--	declare @result nvarchar(10)

--	select @result = case
--		when p.GenderId = 1 then 'MALE'
--		when p.GenderId = 2 then 'FEMALE'
--		when p.GenderId is NULL then 'NOT SET'
--		else 'UNKNOWN'
--	end
--	from People p

--	print(@result)
--end

--GetPersonGenderStrById 15



--BEGIN TRY
--	declare @num smallint = 10

--	WHILE @num <> 15
--	begin
--		set @num = @num - 1

--		--print(@num)
--	end
--END TRY

--BEGIN CATCH
--	declare @message nvarchar(max)
--	select @message = ERROR_MESSAGE()

--	print 'ERROR: ' + @message
--	print 'CODE: '
--	print ERROR_NUMBER()
--END CATCH


--select p.Name
--from People p
--order by p.Id
--offset 2 rows
--fetch next 10 rows only


--select p.Id, p.Name
--from People p
--where p.Name in (select top 10 p.Name
--				from People p
--				group by p.Name)
--where p.Name = 'Layla' or p.Name = 'Minerva' or p.Name = 'John'





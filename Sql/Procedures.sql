--create procedure PrintHello
--as
--	print 'Hello World'


--drop proc PrintSomething
--alter procedure PrintSomething
--as
--begin
--	print 'one'
--	print 'two'
--	print 'three'
--	print 'four'
--	print 'five'
--end

--execute  PrintSomething




--alter proc ShowPeopleNames
--as
--begin
--	select Name
--	from People
--end

--exec ShowPeopleNames


--alter proc SearchPersonByIdAndName
--	@id int,
--	@name nvarchar(20)
--as
--begin
--	--declare @num int

--	--set @num = 1

--	if @id <= 0
--	begin
--		print 'id can not be less than 0!'
--	end

--	else
--	begin
--		select * 
--		from People
--		where Id = @id or [Name] = @name
--	end
--end

--exec SearchPersonByIdAndName -1, 'Eunice'





alter proc GetMaxPersonIdAndName
	@maxId int output,
	@maxName nvarchar(20) output
as
begin
	--declare @maxId int
	select @maxId = max(Id) from People

	--declare @maxName nvarchar(20)
	select @maxName = max(Name) from People
end



declare @maxId int
declare @maxName nvarchar(20)

--exec @maxId = GetMaxPersonId
exec GetMaxPersonIdAndName @maxId output, @maxName output

print @maxId
print @maxName












alter proc TestProc (@num int)
as
begin
	print @num

	if @num > 0
		return @num + 1
	else
		select * from Users
end

declare @result int

exec @result = TestProc -12

print @result
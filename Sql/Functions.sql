alter function GetMaxAge(@test int)
returns int
as
begin
	declare @result int

	select @result = max(ap.Age)
	from Users u
	join AdultPeople ap on ap.Name = u.Name or ap.Age = u.Age

	return @result
end


create function GetTable()
returns table
as
	return select * from Users

select t.Age from dbo.GetTable() t



declare @result int
select @result = dbo.GetMaxAge(123) from Users

print @result




--alter function TestFunc()
--returns int
--as
--begin
--	insert into Users([Name])
--	values('test')

--	return 123
--end




-- dbo.GetProductsCount (ExpDateFrom, ExpDateTo)

create table Products (
	[Id] int primary key identity,
	[Name] nvarchar(50),
	[ExpDate] datetime
)

create function GetProductsCount(@ExpDateFrom datetime, @ExpDateTo datetime)
returns int
as
begin
	if @ExpDateFrom >= @ExpDateTo
		return 0

	return	(select count(*)
			from Products p
			where p.ExpDate between @ExpDateFrom and @ExpDateTo)
end

select dbo.GetProductsCount('2020-01-01', '2030-01-01')
select dbo.GetProductsCount('2025-01-01', '2030-01-01')
select dbo.GetProductsCount('2035-01-01', '2030-01-01')
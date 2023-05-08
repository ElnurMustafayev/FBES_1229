--declare @Animals table([Name] nvarchar(20) not null)

--insert into @Animals([Name])
--values('Cat'),('Dog'),('Parrot')

--select *
--from @Animals



--drop table #TempTable
--create table #TempTable (
--	[One] nvarchar(20),
--	[Two] int,
--	[Three] bit,

--	constraint CK_TEMP_ONE check([Two] between 1 and 5)
--)

--insert into #TempTable([Two])
--values(3),(8),(1)

--select *
--from #TempTable

create proc MyProc
as
begin
	declare @Users table([Name] nvarchar(20), [Surname] nvarchar(20))

	insert into @Users([Name], [Surname])
	values('Ann', 'Brown'),
		('Bob', 'Marley'),
		('John', 'White')

	select max(len([Name])) from @Users
end


exec MyProc
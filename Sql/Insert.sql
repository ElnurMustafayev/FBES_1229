--use GettingStarted;

--select *
--from Products

--use EShopDb;

--select *
--from GettingStarted.dbo.Users



--create database Arkhun;
--use Arkhun;



use GettingStarted;

select *
from Users u
where u.Age >= 18 or u.Name = N'Dəniz'

select N'Dəniz'
select 'Dəniz'
select (10 + 12) 'sum'



--select *
--from Users u
--where not(1 <> 1)


--select 'test', 123
--from Users u
--where u.Age >= 18


insert into Users (Name, Surname, Age)
values('Tamerlan', 'Dadashov', null)

select * from Users



drop table Users
create table Users (
	[Email] nvarchar(50), -- not null unique,
	[Name] nvarchar(50),
	[Surname] nvarchar(50),
	[BirthDate] date check([BirthDate] between '1900-01-01' and GETDATE()),
	[Age] int default(10)
	--[Age] int check([Age] > 0),
)

insert into Users([BirthDate])
values('2023.04.19')

select * from Users
--where [BirthDate] > GETDATE()
--where [BirthDate] > '2000-01-01' and [BirthDate] < '2010-01-01'
--where [BirthDate] between '2000-01-01' and '2010-01-01'

-- 1900-01-01 00:00:00.000











select *
from Users u
where u.Name like 'g%b' or u.Surname like '%a%'
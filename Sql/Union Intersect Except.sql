create table Cars(
	[Model] nvarchar(max),
	[Brand] nvarchar(max),
);

insert into Cars([Model], [Brand])
values	('M5', 'BMW'),
		('M5', 'BMW'),
		('Amg', 'Mercedes'),
		('740', 'BMW'),
		('A8', 'Audi'),
		('RS7', 'Audi');


--select [Model]
--from Cars

--union

--select [Brand]
--from Cars



--select top 1 [Brand] 
--from Cars c
--order by len([Brand]) desc

--select [Brand]
--from Cars
--where len([Brand]) = (select max(len([Brand])) from Cars)



--select [Brand], [Model], count(*)
--from Cars c
--where [Brand] <> 'BMW'
--group by [Brand], [Model]

--select [Brand], [Model], count(*)
--from Cars c
--group by [Brand], [Model]
--having [Brand] <> 'BMW'


--select [Brand], [Model], count(*)
--from Cars c
--group by [Brand], [Model]
--having count(*) > 1









create table Employers (
	[Name] nvarchar(max),
	[Birthdate] date,
	[Salary] money,
);

create table Person (
	[Name] nvarchar(max),
	[Birthdate] date,
	[Surname] nvarchar(max),
);

-- Person:		Bob | NULL		| Jesica
-- Employers:	Bob | Sergey	| Ann

select [Name], [Birthdate]
from Person
except
select [Name], [Birthdate]
from Employers

select [Name], [Birthdate]
from Person
intersect
select [Name], [Birthdate]
from Employers

select [Name], [Birthdate]
from Person
union all
select [Name], [Birthdate]
from Employers









-- Students: Id, Name, GenderId, EducationDepartmentId, RoomId

-- Lectures: Id, Name, RoomId
-- Rooms: CorpusId, Floor
-- ..: ..., ..., ...,
-- ..: ..., ..., ...,
-- Colors: Red, Blue
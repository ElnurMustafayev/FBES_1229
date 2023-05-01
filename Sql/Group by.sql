create table Departments(
	[Id] int primary key identity(1,1),
	[Name] nvarchar(50),
)

insert into Departments([Name])
values('Programming'),
	('Design'),
	('IT'),
	('Devops');

create table Teachers(
	[Id] int primary key identity(1,1),
	[Name] nvarchar(50),
	[Surname] nvarchar(50),
	[DepartmentId] int foreign key references Departments([Id])
)


select count(*) 
from Teachers t
where t.DepartmentId =	(select top 1 d.Id
						from Departments d
						where d.Name like '%prog%')

--select count(*)
--from Teachers t
--join Departments d on t.DepartmentId = d.Id
--where d.Name like '%prog%'

--union

--select count(*) 
--from Teachers t
--join Departments d on t.DepartmentId = d.Id
--where d.Name like '%des%'

--union

--select count(*)
--from Teachers t
--join Departments d on t.DepartmentId = d.Id
--where d.Name like '%it%'

--union

--select count(*) 
--from Teachers t
--join Departments d on t.DepartmentId = d.Id
--where d.Name like '%devop%'



select d.Name, count(*) 'teachersCount'
from Teachers t
join Departments d on t.DepartmentId = d.Id
where t.Id < 800
group by d.Name
having count(*) > 200

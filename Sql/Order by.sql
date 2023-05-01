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

select t.Name 
from Teachers t
where t.Id between 800 and 900
order by t.Name desc -- descending



select [Name], [Surname]
from Teachers
where Teachers.Id = (select max(Id) 
					from Teachers)

select top 5 t.Name
from Teachers t
order by t.Id desc
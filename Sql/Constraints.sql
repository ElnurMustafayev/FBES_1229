--drop table Genders
create table Genders(
	[Id] int primary key,
	[Name] nvarchar(50) not null unique,
)
insert into Genders([Id], [Name])
values	(1, 'Male'), 
		(2, 'Female')

alter table Genders
drop column [Test]
-- alter table Genders
-- add [Test] nvarchar(100) not null





-- drop table People
create table People(
	[Id] int identity,
	[Name] nvarchar(50),
	[Email] nvarchar(50),
	[GenderId] int constraint [DF_People_GenderId] default(1),

	constraint [CK_People_Name] check([Name] like '[A-Z]%'),
	constraint [CK_People_Email] check([Email] like '%@%'),
	foreign key([GenderId]) references Genders([Id]),
	primary key([Id]),
	unique([Email])
);



drop table People
create table People(
	[Id] int primary key identity,
	[Name] nvarchar(50) check([Name] like '[A-Z]%'),
	[Email] nvarchar(50) unique check([Email] like '%@%'),
	[GenderId] int foreign key references Genders([Id]) default(1)
);



insert into People([Name], [Email])
values	('Bob', 'bob@gmail.com')




--alter table People
--add constraint CK__People__Name check([Name] like '[A-Z]%')
--drop constraint CK__People__Name__4222D4EF


select *
from People p
where p.Name like '%a%' or p.Email like '%b%'
order by p.Email
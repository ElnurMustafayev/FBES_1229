use ShopDb;

create table Countries (
	[Id] int primary key identity (1, 1),
	[Name] nvarchar (50) unique not null,
	[Capital] nvarchar (50),
	[Population] int,
);

insert into Countries([Name], [Capital], [Population])
values('Azerbaijan', 'Baku', 10000000),
	('Russia', 'Moscow', 140000000),
	('Turkey', 'Ankara', null);

create table Accounts (
    [Id] int primary key identity (1, 1),
    [Username] nvarchar (50) unique not null,
    [Password] nvarchar (50) not null,
	[CountryId] int foreign key references Countries([Id])
);

insert into Accounts([Username], [Password], [CountryId])
values('Timur', 'LoveChess777', 2);

insert into Accounts([Username], [Password], [CountryId])
values(N'Rüfət', 'Secret12345', 1);

insert into Accounts([Username], [Password], [CountryId])
values(N'Даниз', 'Art228', 3);

insert into Accounts([Username], [Password], [CountryId])
values(N'Samra', '17years', 1);




select a.Username, c.Name
from Accounts a
join Countries c on c.Id = a.CountryId





--select c.Name
--from Countries c
--where c.Id =	(select a.CountryId
--				from Accounts a
--				where a.Id =	(select max(Id) 
--								from Accounts))

create table Statuses (
	[Id] int primary key identity(1,1),
	[Name] nvarchar(30) not null,
)

insert into Statuses([Name])
values('Ok'), ('Blocked'), ('Created')


create table Users (
	[Id] int primary key identity(1,1),
	[Name] nvarchar(30) not null,
	[StatusId] int foreign key references Statuses([Id]),
)

insert into Users([Name], [StatusId])
values	('Bob', 2),
		('Ann', 1),
		('Jane', null);


select Users.Name, Statuses.Name
from Users
join Statuses on Statuses.Id = Users.StatusId





-- MANY-TO-MANY
create table Members (
	[Id] int primary key identity(1,1),
	[Name] nvarchar(30) not null,
)

create table Teams (
	[Id] int primary key identity(1,1),
	[Name] nvarchar(30) not null,
)

create table MembersTeams (
	[Id] int primary key identity(1,1),
	[MemberId] int foreign key references Members([Id]) not null,
	[TeamId] int foreign key references Teams([Id]) not null,
)

insert into Members([Name])
values('Bob'),('Ann'),('Jane')

insert into Teams([Name])
values('BoysTeam'),('GirlsTeam')

insert into MembersTeams([MemberId], [TeamId])
values (1, 1), (2, 2), (3, 2)

insert into MembersTeams([MemberId], [TeamId])
values (1, 2)




--select m.Name, t.Name
--from MembersTeams mt
--join Members m on mt.MemberId = m.Id
--join Teams t on mt.TeamId = t.Id


select m.Name
from MembersTeams mt
join Members m on m.Id = mt.MemberId
where mt.TeamId =	(select top 1 t.Id 
					from Teams t 
					where t.Name = 'GirlsTeam')

select m.Name
from MembersTeams mt
join Members m on m.Id = mt.MemberId
join Teams t on t.Id = mt.TeamId
where t.Name = 'GirlsTeam'
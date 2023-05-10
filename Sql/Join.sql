drop table Users
create table Users (
	[Id] int primary key identity,
	[Name] nvarchar(100),
	[Surname] nvarchar(100),
)

drop table Accounts
create table Accounts (
	[Id] int primary key identity,
	[Email] nvarchar(100) not null unique check([Email] like '%@%'),
	[UserId] int foreign key references Users([Id])
)



insert into Users
values	('Elnur', 'Mustafayev'),
		('Bob', 'Test')

insert into Accounts
values	('elnurrrr@gmail.com', 1),
		('test@test', 2)

select *
from Accounts a
--inner join Users u on a.UserId = u.Id
--full join Users u on a.UserId = u.Id
--left join Users u on a.UserId = u.Id
--right join Users u on a.UserId = u.Id
join Users u on a.UserId = u.Id

-- left, right, full, innder


select *
from Accounts a
join	(select u.Name as 'nickname', u.Id
		from Users u
		where len(u.Name) > 3) u on a.UserId = u.Id
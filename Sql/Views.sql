create table Users(
	[Id] int primary key identity,
	[Name] nvarchar(50),
	[Age] int,
)

insert into Users([Name], [Age])
values	('Bob', 13),
		('Ann', 19),
		('John', 25),
		('Jane', 6)

alter view AdultPeople
as
	select u.Name, u.Age
	from Users u
	where u.Age >= 18


select ap.Age from AdultPeople ap
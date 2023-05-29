create table Students (
	[Id] int primary key identity,
	[Name] nvarchar(50),
	[Surname] nvarchar(50),
)


select * from Students
where Id = 777
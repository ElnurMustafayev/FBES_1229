drop table Blog

create table Blogs (
	[Id] int primary key identity,
	[Title] nvarchar(100),
	[AuthorId] int foreign key references Users([Id]) on delete cascade
)

create table Comments (
	[Id] int primary key identity,
	[Content] nvarchar(100),
	[BlogId] int foreign key references Blogs([Id]) on delete cascade not null
)

insert into Users(Name, Age)
values('Samra', 17),
('Rufat', 19),
('Vasiliy', 60),
('Igor', 7)

select * from Users

insert into Blogs(Title, AuthorId)
values('Test blog 4', 13),
('Test blog 2', 7),
('Test blog 3', 8),
('Test blog 4', 9)

select * from Blogs

insert into Comments(Content, BlogId)
values ('hahahha', 12),
('looool', 12),
('test', 12)


select b.Title, u.Name, u.Id
from Blogs b
join Users u on b.AuthorId = u.Id

delete from Comments
select * from Comments
truncate table Comments

delete from Users where Id = 5



create database BlogApp;

use BlogApp;

create table Users ( 
	[Id] int primary key identity,
	[Login] nvarchar(50) unique not null,
	[Password] nvarchar(50) not null,
	[FirstName] nvarchar(50),
	[LastName] nvarchar(50),
	[BirthDate] datetime2,
)
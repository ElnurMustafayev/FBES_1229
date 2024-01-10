create database AuthDb;

use AuthDb;

create table Users (
    [Id] int primary key identity,
    [Login] nvarchar(50) not null,
    [Password] nvarchar(50) not null,
)
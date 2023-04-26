use ShopDb;

drop table Products
create table Products(
	[Id] int primary key identity(1,1),
	[Name] nvarchar(50),
	[Category] nvarchar(20),
	[Price] money,
	[Count] int,
)

insert into Products([Name], [Category], [Price], [Count])
values	('Iphone 14 Pro', 'Phone', 1500, 15),
	('Door', 'Furneture', 500, 3),
	('Apple', 'Fruit', 5, 300)

--insert into Products([Id], [Name], [Category], [Price], [Count])
--values	(1, 'Iphone 14 Pro', 'Phone', 1500, 15),
--	(2, 'Door', 'Furneture', 500, 3),
--	(3, 'Apple', 'Fruit', 5, 300)
		

select *
from Products p
--where Id > 5 or p.Name like '%iphone%'


delete from Products
--where Id between 10 and 12
--where Name = 'Door'
--where Category like '%neture%' or (Price between 1000 and 2000)
--where [Name] = 'Apple'

select *
from Products p



-- select (read)
-- delete (delete)
-- insert (create)
-- update (update)

-- 3	Apple	Fruit	5,00	300

update Products
set Count = 200, Price = 8.50
where Id = 3

select *
from Products p
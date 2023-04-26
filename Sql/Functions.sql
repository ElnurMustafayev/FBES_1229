USE ShopDb;

CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY (1, 1),
    Firstname NVARCHAR (50) NOT NULL,
    Surname NVARCHAR (50) NOT NULL,
    Age INT NOT NULL,
	Gender NVARCHAR(10),
);

--select RAND()
--select FLOOR(RAND() * 100)

--select top 5 *
--from Users
--where Gender is null

-- 152949, 50
select sum(u.Age) as 'Sum of age', avg(u.Age) as 'Average of age'
from Users u

select u.Firstname, len(u.Firstname) --,  max(len(u.Firstname))
from Users u
where u.Firstname like '%ann%'

select *, len(u.Firstname)
from Users u
where len(u.Firstname) >= 10


select top 10 u.Firstname + '.com'
from Users u

select CHARINDEX('a', 'Salam', 4)



-- subquery
select top 5 u.Firstname
from Users u
where u.Age = (select avg(Age) from Users)
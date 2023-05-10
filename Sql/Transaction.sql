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


select u.Name, u.Surname, a.Email
from Accounts a
join Users u on a.UserId = u.Id

select u.Name, u.Surname
from Users u


begin transaction
	begin try
		-- create user & account
		declare @userId int

		insert into Users
		values('Bob', 'Marley')
		print 'User created'

		select @userId = max(Id) from Users

		insert into Accounts
		values('bob777@gmail.com', @userId)
		print 'Account created'

		commit transaction
	end try
	begin catch
		print error_message()
		rollback transaction
	end catch




-- Accounts
-- 	id
-- 	name
-- 	surname
-- 	amount check(amount >= 0)

-- procedure (account1Id int, account2Id int, amount money)
-- 	transaction
-- 		account2Id.amount += amount
-- 		account1Id.amount -= amount



create table Accounts(
	[Id] int primary key identity,
	[Name] nvarchar(50),
	[Surname] nvarchar(50),
	[Amount] money check([Amount] >= 0)
)

insert into Accounts([Name], [Surname], [Amount])
values	('Elnur', 'Mustafayev', 14500),
		('Bob', 'Marley', 120)

alter proc SendMoney
@senderId int,
@receiverId int,
@amount money
as
begin
	begin transaction 
		begin try
			update Accounts
			set [Amount] = [Amount] + @amount
			where [Id] = @receiverId

			update Accounts
			set [Amount] = [Amount] - @amount
			where [Id] = @senderId

			commit transaction
		end try
		begin catch
			print 'Transaction error: ' + error_message()

			rollback transaction

			print 'Transaction rollbacked'
		end catch
end


select *
from Accounts

exec SendMoney 1, 2, 800
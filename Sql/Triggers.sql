--drop trigger MySelectTriggerForAccounts
alter trigger MyTriggerForAccounts on Accounts
for insert, update
as
	print 'Goodbye'

alter trigger MyDeleteTriggerForAccounts on Accounts
after delete
as
	select count(*) from Accounts
	update Accounts
	set Amount = Amount + 100


insert into Accounts([Name], [Surname], [Amount])
values	('John', 'Black', 150)



select * from Accounts
delete from Accounts
where [Id] = (select max([Id]) from Accounts)



alter table Accounts
disable trigger MyDeleteTriggerForAccounts

alter table Accounts
enable trigger MyDeleteTriggerForAccounts
-- MyDeleteTriggerForAccounts
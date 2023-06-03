use BlogApp;

alter proc LoginUser
	@login nvarchar(50),
	@password nvarchar(50)
as
begin
	select top 1 *
	from Users
	where [Login] = @login and [Password] = @password
end
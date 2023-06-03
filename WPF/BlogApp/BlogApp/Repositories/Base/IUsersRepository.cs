namespace BlogApp.Repositories.Base;

public interface IUsersRepository<TUser> {
    TUser Login(string login, string password);
}
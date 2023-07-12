using MyClassLib.Models;

namespace MyClassLib.Repositories.Base;

public interface IUserRepository {
    Task<User> GetUserByLoginAsync(string login);
}
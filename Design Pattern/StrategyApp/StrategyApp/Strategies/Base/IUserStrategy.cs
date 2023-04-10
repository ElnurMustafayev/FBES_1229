namespace StrategyApp.Strategies.Base {
    public interface IUserStrategy {
        IEnumerable<User>? GetUsers();
        User? SelectOne(IEnumerable<User> users);
    }
}

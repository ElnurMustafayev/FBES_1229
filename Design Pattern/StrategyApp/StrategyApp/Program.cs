using StrategyApp.Strategies;

namespace StrategyApp {
    public class Program {
        static void Main() {
            var strategy = new UserStrategyB();

            UsersAlgorigthms algorigthms = new UsersAlgorigthms(strategy);

            var user = algorigthms.SomeAlgorithm();

            Console.WriteLine(user.Name);
        }
    }
}
using FactoryMethodApp.Models;

namespace FactoryMethodApp.Creators {
    public interface ICardCreator {
        Card Create();
        void ShowNewCardTemplate();
    }
}

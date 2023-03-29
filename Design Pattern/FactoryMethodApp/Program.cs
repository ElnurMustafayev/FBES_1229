using FactoryMethodApp.Creators;
using FactoryMethodApp.Models;

//ICardCreator creator = new BakikartCreator();
//creator.ShowNewCardTemplate();
//var card = creator.Create();

ICardCreator creator = new SocialTransportCardCreator();


var user = new User("Elnur", "Mustafayev");

user.AddCard(creator);
user.AddCard(new VipCreditCardCreator("usd"));
user.AddCard(creator.Create());
user.AddCard(new BakikartCreator());

user.ShowInfo();
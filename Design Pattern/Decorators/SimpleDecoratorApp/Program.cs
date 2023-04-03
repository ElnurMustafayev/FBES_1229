namespace SimpleDecoratorApp {

    interface INotification {
        void Notify(string dest, string message);
    }


    class Notification : INotification {
        public void Notify(string dest, string message) {
            Console.WriteLine($"Notification sending to {dest}...");
        }
    }

    // wrapper / decorator
    class NotificationLogDecorator : INotification {
        INotification notification;

        public NotificationLogDecorator(INotification notification) {
            this.notification = notification;
        }

        public void Notify(string dest, string message) {
            Console.WriteLine("Decorator start");

            notification.Notify(dest, message);

            Console.WriteLine("Decorator end");
        }
    }




    internal class Program {
        static void Main() {
            INotification notification = new Notification();
            INotification decorator = new NotificationLogDecorator(notification);

            decorator.Notify("Elnur", "Hello, Elnur!");
        }
    }
}
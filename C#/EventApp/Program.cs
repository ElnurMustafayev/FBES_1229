namespace EventApp {

    delegate void DoSomethingDel(object obj);

    public class Program {

        private static event DoSomethingDel MyEvent;
        //private static DoSomethingDel del;

        static void ShowObject(object obj) {
            Console.WriteLine(obj);
        }

        static void Main() {
            DoSomethingDel del = ShowObject;
            del += ShowObject;
            del += ShowObject;

            MyEvent += ShowObject;
            MyEvent += ShowObject;
            MyEvent += ShowObject;

            del.Invoke("Delegate");
            MyEvent.Invoke("Event");
        }
    }
}
using ChainOfResponsibilityApp.Handlers;

namespace ChainOfResponsibilityApp;

internal class Program {
    static void Main() {
        Handler1 h1 = new Handler1();
        Handler2 h2 = new Handler2();
        Handler3 h3 = new Handler3();

        h2.SetNext(h1).SetNext(h3);

        h2.Handle("message for proceed...");
    }
}
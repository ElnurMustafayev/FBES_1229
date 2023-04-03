using ChainOfResponsibilityApp.Handlers.Base;

namespace ChainOfResponsibilityApp.Handlers;

public class Handler3 : HandlerBase {
    public override void Handle(string message) {
        Console.WriteLine($"Handler3: {message}");

        base.Handle(message);
    }
}
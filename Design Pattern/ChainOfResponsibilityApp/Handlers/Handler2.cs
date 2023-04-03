using ChainOfResponsibilityApp.Handlers.Base;

namespace ChainOfResponsibilityApp.Handlers;

public class Handler2 : HandlerBase {
    public override void Handle(string message) {
        Console.WriteLine($"Handler2: {message}");

        base.Handle(message);
    }
}
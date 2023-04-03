using ChainOfResponsibilityApp.Handlers.Base;

namespace ChainOfResponsibilityApp.Handlers;

public class Handler1 : HandlerBase {
    public override void Handle(string message) {
        Console.WriteLine($"Handler1: {message}");

        base.Handle(message);
    }
}
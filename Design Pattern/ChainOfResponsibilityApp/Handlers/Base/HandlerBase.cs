namespace ChainOfResponsibilityApp.Handlers.Base;

public class HandlerBase {
    private HandlerBase? next;
    public virtual void Handle(string message) {
        //Console.WriteLine($"Base Handler: {message}");
        
        this.next?.Handle(message);
    }

    public HandlerBase SetNext(HandlerBase next) {
        this.next = next;
        return this.next;
    }
}
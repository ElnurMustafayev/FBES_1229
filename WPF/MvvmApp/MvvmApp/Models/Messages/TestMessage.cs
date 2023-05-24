using MvvmApp.Models.Messages.Base;

namespace MvvmApp.Models.Messages;

public class TestMessage : IMessage {
    public string Text { get; set; }
    public TestMessage(string text) {
        this.Text = text;
    }
}
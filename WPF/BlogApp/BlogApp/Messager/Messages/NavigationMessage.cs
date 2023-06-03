namespace BlogApp.Messager.Messages;

using BlogApp.Messager.Messages.Base;
using System;

public class NavigationMessage : IMessage {
    public Type NavigateTo { get; set; }

    public NavigationMessage(Type navigateTo)
    {
        this.NavigateTo = navigateTo;
    }
}
namespace MvvmApp.Models.Messages;

using MvvmApp.Models.Messages.Base;
using System;

public class NavigationMessage : IMessage {
    public NavigationMessage(Type destinationViewModelType) {
        DestinationViewModelType = destinationViewModelType;
    }

    public Type DestinationViewModelType { get; set; }
}
using MvvmApp.Models.Messages.Base;
using MvvmApp.Services.Base;
using System;
using System.Collections.Generic;

namespace MvvmApp.Services;

public class Messenger : IMessenger {
    private Dictionary<Type, List<Action<IMessage>>> dict;

    public Messenger() {
        this.dict = new Dictionary<Type, List<Action<IMessage>>>();
    }

    public void Subscribe<TKey>(Action<IMessage> action) where TKey : IMessage {
        Type keyType = typeof(TKey);

        if (this.dict.ContainsKey(keyType) == false)
            this.dict.Add(keyType, new List<Action<IMessage>>());

        this.dict[keyType].Add(action);
    }

    public void Send<TKey>(TKey arg) where TKey : IMessage {
        Type keyType = typeof(TKey);

        if (this.dict.ContainsKey(keyType) == false)
            return;

        var actions = this.dict[keyType];

        foreach (var action in actions) {
            action.Invoke(arg);
        }
    }
}

using System;
using System.Windows;
using System.Windows.Input;

namespace MvvmApp.Tools;

public class MyCommand : ICommand {
    private readonly Action action;

    public event EventHandler? CanExecuteChanged;

    public MyCommand(Action action) {
        this.action = action;
    }

    public bool CanExecute(object? parameter) {
        return true;
    }

    public void Execute(object? parameter) {
        action.Invoke();
    }
}

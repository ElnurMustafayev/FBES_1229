namespace BlogApp.ViewModels;

using BlogApp.Data.EfCore;
using BlogApp.Entities;
using BlogApp.Messager.Messages;
using BlogApp.Messager.Messages.Base;
using BlogApp.Messager.Services.Base;
using BlogApp.Repositories.Base;
using BlogApp.Tools;
using BlogApp.ViewModels.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.ObjectModel;
using System.Reflection.Metadata;

public class BlogsViewModel : ViewModelBase
{
    private User? currentUser;
    private readonly IMessenger messenger;
    private readonly IBlogsRepository<Blog> blogsRepository;

    public ObservableCollection<Blog> Blogs { get; set; } = new ObservableCollection<Blog>();

    public User? CurrentUser
    {
        get { return currentUser; }
        set => base.PropertyChange(out currentUser, value);
    }


    private MyCommand? logoutCommand;

    public MyCommand LogoutCommand
    {
        get => this.logoutCommand ??= new MyCommand(
            action: () =>
            {
                this.CurrentUser = null;
                this.messenger.Send(new NavigationMessage(typeof(LoginViewModel)));
            },
            predicate: () => true);
        set => base.PropertyChange(out this.logoutCommand, value);
    }

    private MyCommand? searchCommand;

    public MyCommand SearchCommand {
        get => this.searchCommand ??= new MyCommand(
            action: () => {
                
            },
            predicate: () => true);
        set => base.PropertyChange(out this.searchCommand, value);
    }


    private MyCommand? loadCommand;

    public MyCommand LoadCommand {
        get => this.loadCommand ??= new MyCommand(
            action: () => {
                this.Blogs.Clear();

                foreach (var blog in blogsRepository.Get(authorId: 1)) {
                    this.Blogs.Add(blog);
                }
            },
            predicate: () => true);
        set => base.PropertyChange(out this.loadCommand, value);
    }


    public BlogsViewModel(IMessenger messenger, IBlogsRepository<Blog> blogsRepository)
    {
        this.messenger = messenger;
        this.blogsRepository = blogsRepository;
        this.messenger.Subscribe<SendLoginedUserMessage>(obj =>
        {
            if (obj is SendLoginedUserMessage message)
            {
                this.CurrentUser = message.LoginedUser;
            }
        });
    }
}
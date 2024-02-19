namespace MediatorApp.Controllers;

using MediatorApp.Handlers.Users;
using MediatorApp.Services.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/api/[controller]/[action]")]
public class UserController : ControllerBase
{
    private readonly ISender sender;

    public UserController(ISender sender)
    {
        this.sender = sender;
    }
    public async Task<IActionResult> Get(int id)
    {
        //var handler = new GetUserHandler();

        var command = new GetUserCommand(id);

        //var vm = await handler.Handle(command, CancellationToken.None);

        var vm = await this.sender.Send(command);

        return base.Ok(vm);

        // var user = this.userService.Get(id);
        // return base.Ok(user);
    }
}

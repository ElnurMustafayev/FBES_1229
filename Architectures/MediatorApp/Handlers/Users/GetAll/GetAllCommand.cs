using MediatorApp.Models;
using MediatR;

namespace MediatorApp.Handlers.Users.GetAll
{
    public class GetAllCommand : IRequest<IEnumerable<User>>
    {
        
    }
}
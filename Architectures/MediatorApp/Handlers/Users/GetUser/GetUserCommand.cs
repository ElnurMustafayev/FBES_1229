using MediatR;

namespace MediatorApp.Handlers.Users.GetUser
{
    public class GetUserCommand : IRequest<GetUserViewModel>
    {
        public int? Id { get; set; }

        public GetUserCommand(int id)
        {
            this.Id = id;
        }

        public GetUserCommand() {}
    }
}
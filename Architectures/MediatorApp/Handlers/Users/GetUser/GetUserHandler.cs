using MediatorApp.Repositories.Base;
using MediatR;

namespace MediatorApp.Handlers.Users.GetUser
{
    public class GetUserHandler : IRequestHandler<GetUserCommand, GetUserViewModel>
    {
        private readonly IUserRepository userRepository;
        public GetUserHandler(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
            
        }
        public async Task<GetUserViewModel> Handle(GetUserCommand request, CancellationToken cancellationToken)
        {
            ArgumentNullException.ThrowIfNull(request.Id);

            var user = userRepository.GetUser((int)request.Id);

            return new GetUserViewModel() {
                Name = user.Name,
                Age = user.Age
            };
        }
    }
}
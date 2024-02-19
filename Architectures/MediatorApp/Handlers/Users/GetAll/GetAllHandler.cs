using MediatorApp.Models;
using MediatorApp.Repositories.Base;
using MediatR;

namespace MediatorApp.Handlers.Users.GetAll
{
    public class GetAllHandler : IRequestHandler<GetAllCommand, IEnumerable<User>>
    {
        private readonly IUserRepository userRepository;

        public GetAllHandler(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public async Task<IEnumerable<User>> Handle(GetAllCommand request, CancellationToken cancellationToken)
        {
            return this.userRepository.GetAll();
        }
    }
}
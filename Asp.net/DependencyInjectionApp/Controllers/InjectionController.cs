using DependencyInjectionApp.Repositories;
using DependencyInjectionApp.Repositories.Base;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionApp.Controllers
{
    public class InjectionController : Controller
    {
        public static string repoName = nameof(UserTestRepository);

        private readonly IUserRepository userRepository;
        public InjectionController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpPost]
        public IActionResult SetTest() {
            InjectionController.repoName = nameof(UserTestRepository);
            return base.Ok();
        }

        [HttpPost]
        public IActionResult SetFile() {
            InjectionController.repoName = nameof(UserFileRepository);
            return base.Ok();
        }
    }
}
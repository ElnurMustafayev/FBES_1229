using ConsoleApp.Models;

namespace ConsoleApp.Services.Base
{
    public interface IEmailService
    {
        public void Send(EmailMessage message);
    }
}
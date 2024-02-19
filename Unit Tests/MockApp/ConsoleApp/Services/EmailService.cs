/*
using ConsoleApp.Models;
using ConsoleApp.Services.Base;

namespace ConsoleApp.Services
{
    public class EmailService : IEmailService
    {
        private readonly ILogger logger;

        public EmailService(ILogger logger)
        {
            this.logger = logger;
        }

        public void Send(EmailMessage message)
        {
            this.logger.Log($"Start...");
            if(message.To is null || message.From is null) {
                throw new ArgumentNullException();
            }
            // ...

            this.logger.Log($"Message sent. {message.From}:{message.To}");
        }
    }

    [Fact]
    public void Send_CheckIsToNotSend_ThrowsArgumentNullException() {
        Mock<ILogger> mock = new Mock<ILogger>();

        mock.Setup((logger) => logger.Log("test"));

        EmailService emailService = new EmailService(mock.Object);

        emailService.Send(new EmailMessage());

        
    }  
}
*/
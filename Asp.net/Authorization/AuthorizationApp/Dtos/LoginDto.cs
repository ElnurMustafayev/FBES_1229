namespace AuthorizationApp.Dtos
{
    public class LoginDto
    {
        public string ReturnUrl { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
using Microsoft.AspNetCore.Identity;

namespace AspnetIdentityApp.Models
{
    public class MyCustomIdentityUser : IdentityUser
    {
        public int MyProperty { get; set; }
    }
}
using Microsoft.AspNetCore.Identity;

namespace TPIdentity.Models{

    public class ApplicationUser : IdentityUser{
        public string City {get; set;}
    }
}
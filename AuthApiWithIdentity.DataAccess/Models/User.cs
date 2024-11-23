namespace UsersApi.DataAccess.Models
{
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Identity;

    public class User : IdentityUser
    {
        public override string Email { get; set; }
        [StringLength(30, MinimumLength = 2)]
        public string FirstName { get; set; }

        [StringLength(30, MinimumLength = 2)]
        public string LastName { get; set; }
        public string? Image { get; set; }
    }
}

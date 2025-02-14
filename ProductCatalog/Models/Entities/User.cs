using Microsoft.AspNetCore.Identity;

namespace ProductCatalog.Models.Entities
{
    public class User : IdentityUser
    {
        public required string FirstName { get; set; }
        public required int LastName { get; set; }
    }
}

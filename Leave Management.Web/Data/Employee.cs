using Microsoft.AspNetCore.Identity;

namespace Leave_Management.Web.Data
{
    public class Employee : IdentityUser
    {
        public string? TaxId { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }


    }
}

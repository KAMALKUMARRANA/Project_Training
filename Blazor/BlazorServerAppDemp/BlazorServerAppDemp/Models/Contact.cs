using System.ComponentModel.DataAnnotations;

namespace BlazorServerAppDemp.Models
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace BlazorServerAppDemo2.Models
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}

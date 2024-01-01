using BlazorServerAppDemo2.Models;

namespace BlazorServerAppDemo2.Pages
{
    public partial class Index
    {
        private List<Contact> contacts;
        public bool DisplayEmail = true;
        public Dictionary<string, object> MyTextBoxAttributes = new Dictionary<string, object>
    {
         {"placeholder","Email"},
         {"type","text"}
    };

        private void DeleteContact(Contact contact)
        {
            contacts.Remove(contact);
        }
        protected override void OnInitialized()
        {
            base.OnInitialized();
            contacts = new List<Contact>
        {
            new Contact
            {
              FirstName="John",
              LastName="Thomas",
              Email="john@gmail.com"

            },
             new Contact
            {
              FirstName="Piter",
              LastName="Thomas",
              Email="piter@gmail.com"

            },
             new Contact
            {
              FirstName="Jony",
              LastName="Thomas",
              Email="jony@gmail.com"

            },
        };
        }
    }
}


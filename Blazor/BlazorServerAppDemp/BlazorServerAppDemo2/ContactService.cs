using BlazorServerAppDemo2.Models;

namespace BlazorServerAppDemo2
{
    public class ContactService
    {
        public List<Contact> ContactList=new List<Contact>();
        public void AddContact(Contact contact)
        {
            ContactList.Add(contact);
        }
        public void UpdateContact(Contact contact) { 
       
        
        }
    }
}

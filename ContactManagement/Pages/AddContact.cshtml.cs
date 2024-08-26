using ContactManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContactManagement.Pages
{
    public class AddContactModel : PageModel
    {
       ContactsDbContext dc = new ContactsDbContext();

        public string result {  get; set; }
        public void OnPost(Contact c) { 

            dc.Contacts.Add(c);
            int i=dc.SaveChanges();

            if (i > 0)
            {
                result = "New Contact Added Successfully !!";
            }
            else
            {
                result = "Could not contact try again!!";
            }
            

        }
    }

   
}

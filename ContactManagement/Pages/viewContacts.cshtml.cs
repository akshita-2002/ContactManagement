using ContactManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ContactManagement.Models;


namespace ContactManagement.Pages
{
    public class viewContactsModel : PageModel
    {
        ContactsDbContext dc = new ContactsDbContext();

        public List<Contact> li = new List<Contact>();
        public void OnGet()
        {

             li = (from t in dc.Contacts
                      select t).ToList();


        }
    }
}

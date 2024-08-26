using ContactManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Security;

namespace ContactManagement.Pages
{
    public class editContactModel : PageModel
    {
        //public string a { get; set; }

        ContactsDbContext dc = new ContactsDbContext();

        public Contact c = new Contact();
        public string result;

        [BindProperty]
        public string Contactid { get; set; }

        public string cid { get; set; }
        
        // this cid reads data from query string (written in view)
        // once we move to edit page from view page get method is called
        public void OnGet(string cid)
        {


            // a = cid;
            int id = int.Parse(cid);
            var res = dc.Contacts.Where(t => t.Contactid == id).First();
            c = res;


        }

        public void OnPost(Contact c)
        {
            dc.Contacts.Update(c);
            int i = dc.SaveChanges();

            if (i > 0)
            {
                result = "Edited Successfully !!";
            }
            else
            {
                result = "Could not edit contact try again!!";
            }
        }
    }
}

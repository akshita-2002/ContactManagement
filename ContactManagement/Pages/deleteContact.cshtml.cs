using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Runtime.InteropServices;
using ContactManagement.Pages;

using ContactManagement.Models;

namespace ContactManagement.Pages
{
    public class deleteContactModel : PageModel
    {
        ContactsDbContext dc = new ContactsDbContext();
        public string result { get; set; }
        public void OnGet(string cid)
        {
            int id = int.Parse(cid);
         var res = (from t in dc.Contacts
                   where t.Contactid == id
                   select t).First();

            dc.Remove(res);
            int i = dc.SaveChanges();
            if (i > 0)
            {
                result = "Contact id" +id+" Deleted successfully!!";

            }
            else
            {
                result = "Could not delete try again!!";
            }
        }

        
    }
}

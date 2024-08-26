using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContactManagement.Pages
{
    public class loginModel : PageModel
    {
        [BindProperty]
        public string uname { get; set; }
        [BindProperty]
        public string pwd { get; set; }
        public string errormsg { get; set; }
        public void OnGet()
        {
        }


        //IActionResult represents the method can return any type (string, null,int,...)
        //if condition is satisfied something is printed , if not something is printed
        public IActionResult OnPost()
        {
            if(uname=="admin" &&  pwd == "india")
            {
                // to move from login to view 
               return  RedirectToPage("viewContacts");

            }else
            {
                errormsg = "Invalid credentails";
                // if condition not satisfied be in the same page -> Page()
                return Page();

            }
        }
    }
}

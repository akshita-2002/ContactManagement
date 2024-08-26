using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestingRazorPrj.Pages
{
    public class myPageModel : PageModel
    {
        public string result;
        public void OnGet()
        {

            int a = 10;
            int b = 0;
            int c = a / b;

            result = "The division is " + c;
        }
    }
}

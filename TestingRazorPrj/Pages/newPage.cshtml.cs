using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestingRazorPrj.Pages
{
    public class newPageModel : PageModel
    {


        //  MyMathCls ob = new MyMathCls();

        IMyinter i;
        public newPageModel(IMyinter obj,ILogger<newPageModel> l)
        {
            i = obj;
            //built in interface 
            l.LogInformation("New Page class accessed by user on :"+DateTime.Now);

        }

        public string result;
        public void OnGet()
        {
            // result=  i.AddNums(10, 10);

            //  Guid g = Guid.NewGuid();
            result = i.displayguid();

        }


    }
}

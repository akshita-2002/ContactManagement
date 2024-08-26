using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContactManagement.Pages
{
    public class IndexModel : PageModel
    {
        //to map the property to the input element with name txt1
        //[BindProperty]
        //public string txt1 { get; set; }

        //[BindProperty]
        //public string txt2 { get; set; }

        public int res { get; set; }


        public void OnPost(mycls obj)
        {
            //this logic will be executed when submit is clicked
             res = int.Parse(obj.txt1) + int.Parse(obj.txt2);

        }




        public string custname = "Akshtia";

        public List<students> li = new List<students>()
        {

            new students(){sid=100,name="raj",marks=90},
            new students(){sid=200,name="akshita",marks=95 },
            new students(){sid=300,name="Siya",marks=100}



        };

        public void OnGet()
        {

            //this logic is executed when the page is loaded
            //all inialization code is written here
        }

        public string multiply(int a , int b)
        {
            return "the result is :" + (a * b);
        }
    }

    public  class students
    {
        public int sid { get; set; }
        public string name { get; set; }

        public int marks { get; set; }

    }


    public class mycls()
    {

        public string txt1 { get; set;}
        public string txt2 { get; set;}

    }
}

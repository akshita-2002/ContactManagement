namespace TestingRazorPrj.Pages
{
    public interface IMyinter
    {
        string AddNums(int num1, int num2);
        string DivideNums(int num1, int num2);

        string displayguid();
    }
    public class myMathcls : IMyinter
    {
        Guid g;
        public myMathcls()
        {
            g = Guid.NewGuid();

        }
        public string displayguid()
        {
            return g.ToString();
        }
        public string AddNums(int num1, int num2)
        {
            return "The sums is " + (num1 + num2);
        }

        public string DivideNums(int num1, int num2)
        {
            return "The Division is " + (num1 / num2);
        }
    }
}

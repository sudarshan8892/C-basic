using System.Linq;

namespace OOPS.Method
{
    public partial class ProgramMethod
    {
        public class Calculator
        {
             public int add(params int[] number)
             {
                // same  code using  linq
                //var sum = 0;
                //foreach (var item in number)
                //{
                //    sum += item;
                //}
                //return sum;

                return number.Sum();
            }
        } 
        
    }
}

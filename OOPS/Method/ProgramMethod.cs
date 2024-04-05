using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Method
{
    public partial class ProgramMethod
    {
        static void Main(string[] args)
        {
            Calculator calculator   = new Calculator();
            Console.WriteLine(calculator.add(1, 2) ); 
            Console.WriteLine(calculator.add(new int[] {1,2,3,5,6 }) ); 

        }
            static void UsePoints()
            {
                try
                {
                    var point = new Point(1, 2);
                    point.Move(null);
                    Console.WriteLine("point is at:{0},{1}", point.X, point.Y);
                    point.Move(new Point(10, 20));
                    Console.WriteLine("point is at:{0},{1}", point.X, point.Y);

                }
                catch (Exception)
                {

                    Console.WriteLine("some error ");
                }
            }
        
    }
}

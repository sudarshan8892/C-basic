using System;
using CSharpBasic.Math;
namespace CSharpBasic
{
    public class maxnum
    {
        public static void compare(int num1, int num2)
        {
            int maxinum = (int)MathF.Max(num1, num2);
            Console.WriteLine($"The maximum of {num1} and {num2} is: {maxinum}");

        }
    }
}
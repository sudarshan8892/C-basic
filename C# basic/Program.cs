using CSharpBasic.Math;
using System;
namespace CSharpBasic
{
    class program
    {
        static void Main(String[] arg)
        {
            person objperson = new person();
            objperson.FirstName = " sudarshan";
            objperson.LastName = "shetty";
            objperson.introduce();  

            calculator calculator   = new calculator();
             var result =calculator.add(10, 20);
            Console.WriteLine(result);

            //arry  is-- A data stracture  to store a collection of variable of the same type 
            int[] number = new int[3];
            

            number[0] = 1;
            number[1] = 2;
            number[2] = 3;
            Console.WriteLine(number[0]);
            Console.WriteLine(number[1]);
            Console.WriteLine(number[2]) ;

            string[] stringArray = { "hello", "jhon", "shetty" };
            Console.WriteLine(stringArray[0]);
            Console.WriteLine(stringArray[1]);
            Console.WriteLine(stringArray[2]);

            int[] num = { 1, 2, 3 };
            Console.WriteLine(num[0]);
            Console.WriteLine(num[1]);
            Console.WriteLine(num[2]);
        }
    }
}
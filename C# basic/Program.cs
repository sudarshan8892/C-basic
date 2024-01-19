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



            // string  demo 

            var FirstName = "sudarshan";
            var LastName = "shetty";

            Console.WriteLine("my Name Is:"+ FirstName +" "+ LastName );
            var FullName = String.Format("My name IS: {0} {1}", FirstName, LastName);
            Console.WriteLine( FullName );

            string[] Name= new string[3];//decalear Array 1
            var Names = new string[3] { "sudarshan", "shetty", "shetty" };//decalear Array 2
            string[] NamesFormate =  { "sudarshan", "shetty", "shetty" };//decalear Array 3
            var NAmeformate = String.Join(",", NamesFormate);
            Console.WriteLine( NAmeformate);
        }
    }
}
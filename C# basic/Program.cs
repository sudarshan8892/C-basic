using CSharpBasic.Math;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
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

            var text = @"hi shetty
            look at this
            c:\folder1\folder2
            c:\folder1\n folder2";
            Console.WriteLine(text);



            //conditionals
            int hour = 10;
            if(hour>0 && hour<=10)
            {
                Console.WriteLine("its morning");
            }
            else if(hour>12 &&  hour <18)
            {
                Console.WriteLine( "its afternoon");
            }
            else
            {
                Console.WriteLine("its night!");
            }

            bool isGoldcustomer = true;
            float prices;
            if(isGoldcustomer)
            {
                prices = 20.88f;
            }
            else
            {
                prices = 30.00f;
            }
            Console.WriteLine(prices);
            float price = (isGoldcustomer) ? 20.88f : 30.00f;
            Console.WriteLine(prices);

            //switch case
            var card = Card.gold;
            switch(card)
            {
                case Card.gold:
                    Console.WriteLine(  "its  gold ");
                break;


                case Card.siliver:
                    Console.WriteLine(  "its siliver");
                break;
                default:
                    Console.WriteLine( "no type card");
                break;



                   
            }
            Console.Write("enter  a number between  1 to 10 : ");
            try
            {

                int input = int.Parse(Console.ReadLine());
                exercises.validate(input);
            }
            catch (Exception)
            {
                Console.WriteLine( "Invlid input . pls  enter a num btw 1 to 10:");

            }
        }
    }
}
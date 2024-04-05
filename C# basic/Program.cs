using CSharpBasic.Math;
using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
namespace CSharpBasic
{
    class program
    {
        static void Main(String[] arg)
        {
            /*
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
              //exercises3
              Console.WriteLine("enter  a number:");
              var temp1 = int.Parse(Console.ReadLine());
              Console.WriteLine("Enter a number :");
              int temp2 = int.Parse(Console.ReadLine());
              maxnum.compare(temp1,temp2);

              Console.WriteLine("type in the width of  an image to know if its on  landscape or portrait: ");
              Console.WriteLine(  "width:");
              var width = int.Parse(Console.ReadLine());

              Console.WriteLine( "Height:");
              var height = int.Parse(Console.ReadLine());

              Console.WriteLine( exercises3.getImage(width,height));



              Console.WriteLine(  "Enter the speed limit Km/hr:  ");
              int  speedlimit = int.Parse(Console.ReadLine());

              Console.WriteLine( "Enter the  speed of the car (KM/hr):");
              int carSpeed = int.Parse(Console.ReadLine());

              Console.WriteLine(exercisis4.speedLimit(speedlimit, carSpeed));
              */

            /* debugging*/
            //var numberlist = new List<int> { 1, 2, 3, 4, 5, 6 };
            /*if  user  enter  just  two  integer  and  count  passing  3  index  out of range */
            //var numberlist = new List<int> { 1, 2};
            /*if  list  is zero  */
            var numberlist = new List<int>();

            /*if  list  is zero  */
            var smallest = getsmallest(null, 3);
            foreach (var item in smallest)
            {
                Console.WriteLine(item);
            }

        }
        public static List<int> getsmallest(List<int>list,int counts)
        {
             if(list== null)
            {
                throw new NullReferenceException("  the list, should  be between  1 and  count of number of element in the lis");
            }
            if(counts>list.Count || counts<=0)
            {
                throw new ArgumentOutOfRangeException("counts", "counts can't be greater then then number list count");
            }
            var buffer = new List<int>(list);

            var smalllests = new List<int>();

            while(smalllests.Count<counts)
            {
                var minnumber = getsmallest(buffer);
                smalllests.Add(minnumber);
                buffer.Remove(minnumber);
            }
            return smalllests;
        }
        public static int  getsmallest(List<int> list)
        {
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }
          
    }
}
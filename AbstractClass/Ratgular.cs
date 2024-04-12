
namespace AbstractClass
{
   
  
        public class Ratgular : Shape
        {
            public override void Draw()//3) must implemnet  all abstrat member in the base  anstract class
            {
                int area = Width * Height;
                Console.WriteLine($"Area of Rectangle: {area}");
            }
        }


   
}
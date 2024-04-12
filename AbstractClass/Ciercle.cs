
namespace AbstractClass
{
   
        public class Ciercle : Shape
        {
            public int Radius { get; set; }
            public override void Draw()
            {
                double area = Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
                Console.WriteLine($"Area of Circle: {area}");


            }
        }


}
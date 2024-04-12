using System.Threading.Channels;

namespace MethodOverrid
{

    public class Ciercle : Shape
    {
        public int Radius { get; set; }
        public override void Draw()
        {
            double area = Math.Round( Math.PI * Math.Pow(Radius, 2),2);
            Console.WriteLine($"Area of Circle: {area}");
         

        }
    }
    public class Ratgular:Shape
    {
        public override void Draw()
        {
            int area = Width * Height;
            Console.WriteLine($"Area of Rectangle: {area}");
        }
    }
    public class Trigular : Shape
    {
        public  void Draw()// bescuse we dont mention ovarride key so this method become new method 
        {
            
        }
    }
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Postion { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine( "base class");
        }
    }
    

}

using AbstractClass.MethodOverrid;

namespace AbstractClass
{
    public class Program
    {
        public static void Main(String[] arga)
        {
            var circle = new Ciercle();
            circle.Draw();
            var triangular = new Triangular();
            triangular.Draw();
        }
    }
}
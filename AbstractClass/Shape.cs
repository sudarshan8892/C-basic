
namespace AbstractClass
{

    public abstract class Shape  // 1)the cantainig class need  to be be declare abstract 2) cont be instantiated
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract  void Draw(); //4)member not implemnet



    }



}
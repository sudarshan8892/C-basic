namespace MethodOverrid
{
    public class program
    {
        public static void Main(string[] arg)
        {
            var shape = new List<Shape>();
            shape.Add(new Ciercle
            {
               Radius= 2,
            });
            shape.Add(new Ratgular
            {
                Width = 1,  
                Height=3

            });
            var canvas = new Canavs();
            canvas.drawshap(shape); 
        }


    }
}
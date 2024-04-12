namespace MethodOverrid
{
    public class Canavs
    {
        public void drawshap(List<Shape> shapes)
        {
            foreach (var item in shapes)
            {
                item.Draw();
            }

        }
    }

}
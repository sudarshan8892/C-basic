namespace CSharpBasic
{
    public class   exercises3
    {
        public  static string getImage( int width, int height)
        {
            if(width ==height)
            {
                return "both values  are the same . the image has  a 1:1 ratio";
            }
            else if(width>height)
            {
                return "Landscape";
            }
            return "portrait";
        }
    }
}
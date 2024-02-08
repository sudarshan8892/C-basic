namespace CSharpBasic
{
    public class exercisis4
    {
        public  static string speedLimit(int speedLimit ,int carSpeed)
        {
            if (carSpeed <=speedLimit)
            {
                return "ok ";
            }
            else
            {
                int point =(carSpeed-speedLimit)/5;
                if (point > 12)
                {
                    return "License Suspended";
                }
                return point.ToString();

               
            }
           
        }  
    }
}
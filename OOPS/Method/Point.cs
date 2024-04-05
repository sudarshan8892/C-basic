namespace OOPS.Method
{


    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x ,int y )
        {
            this.X = x;
            this.Y=y;  
        }

        public void Move(int x ,int y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Move(Point newloaction)
        {
            if (newloaction == null)
            {
                throw new ArgumentNullException("new location");
            }
            //this.X = newloaction.X;
            //this.Y = newloaction.Y;
            Move (newloaction.X,newloaction.Y);
        }
    }

}

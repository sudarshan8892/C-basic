namespace Interface_Logger
{


    public partial class Program
    {
        public static void Main(string[] args)
        {
            var dbmigration = new Migration(new FileLogger("D:\\icon\\C# basic\\Interface_Logger\\Logger\\log.txt"));
            dbmigration.migration();


        }
    }
}

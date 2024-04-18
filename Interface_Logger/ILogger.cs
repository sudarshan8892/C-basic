namespace Interface_Logger
{
    public partial class Migration
    {
        public interface ILogger
        {


            void LogError(string message);
            void LogInfo(string message);

            //public void newmethod()
            //{
            //    Console.WriteLine("");
            //}

    }
}

}

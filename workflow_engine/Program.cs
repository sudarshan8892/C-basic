
namespace workflow_engine
{
    public class Program
    {
        public static void Main(string[] arg)
        {
            var work = new WorkFlow();
            work.Add(new VideoUploder());
            work.Add(new Service());
            work.Add(new SendEmail());
            work.Add(new changeStatus());
            var flowEngine = new WorkFlowEngine();
            flowEngine.Run(work);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workflow_engine
{
    public interface ITask
    {
        void excute();
    }

    public class VideoUploder : ITask
    {
        public void excute()
        {
            Console.WriteLine("wait Video Uploading..");
        }
    }
    public class Service : ITask
    {
        public void excute()
        {
            Console.WriteLine("Service Updateing...");
        }
    }

    public class SendEmail : ITask
    {
        public void excute()
        {
            Console.WriteLine("Email Sending...");
        }
    }

    public class changeStatus : ITask
    {
        public void excute()
        {
            Console.WriteLine( "Status changed!");
        }
    }



}


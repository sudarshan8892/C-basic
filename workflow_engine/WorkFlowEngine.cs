using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workflow_engine
{
    public class WorkFlowEngine
    {
        public void Run(IWorkFlow workFlow) 
        {
            foreach (var item in workFlow.GetTasks())
            {
                item.excute();
            }
        }
    }
}

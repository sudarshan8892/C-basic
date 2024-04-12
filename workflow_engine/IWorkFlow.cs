namespace workflow_engine
{
    public interface IWorkFlow
    {
         void Add(ITask task);
         void Remove(ITask task);
         IEnumerable<ITask> GetTasks();
    }



}


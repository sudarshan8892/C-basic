using System.IO;
using static Interface_Logger.Migration;

namespace Interface_Logger
{

    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            this._path = path;
        }
        public void LogError(string message)
        {

            log(message, "Error",TimeOnly.FromDateTime(DateTime.Now));
        }

        public void LogInfo(string message)
        {

            log(message, "Info", TimeOnly.FromDateTime(DateTime.Now));
        }

        private void log(string message, string massgeType, TimeOnly time)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(massgeType+ ": "+  message +": " + time);
            }

        } 
    }


}

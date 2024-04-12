using System.Data;

namespace DbConnection
{
    public abstract class Dbconnctions
    {

        public string? ConnectionString { get; set; }
        public TimeSpan TimeSpan { get; set; }
        public Dbconnctions(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString)) throw new ArgumentNullException();
            ConnectionString = connectionString;
            this.TimeSpan = TimeSpan.FromSeconds(30);
        }
       
        public abstract void opening();

        public abstract void closed();
        

    }
}


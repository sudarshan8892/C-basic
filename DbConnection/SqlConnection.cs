using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnection
{
    public class SqlConnection : Dbconnctions
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }
        public override void closed()
        {
            Console.WriteLine("Opening Oracle connection...");
            // Actual implementation for opening Oracle connection would go here
            Console.WriteLine("Oracle connection opened successfully.");
        }

        public override void opening()
        {
            Console.WriteLine("Opening Oracle connection...");
            // Actual implementation for opening Oracle connection would go here
            Console.WriteLine("Oracle connection opened successfully.");
        }
    }
}

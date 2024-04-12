using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DbConnection
{
    public class DbCommand
    {
        private readonly Dbconnctions _dbconnctions;
        private readonly string _Instruction;

        public DbCommand(Dbconnctions dbconnctions, string instruction)
        {
           _dbconnctions=    dbconnctions ?? throw new ArgumentNullException(nameof(dbconnctions), "Connection cannot be null.");

            _Instruction = instruction;
        }

        public void Execute()
        {
            _dbconnctions.opening();
            Console.WriteLine($"Executing instruction: {_Instruction}");
            _dbconnctions.closed();
        }
    }
}

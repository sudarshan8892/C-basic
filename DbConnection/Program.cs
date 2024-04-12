using System.Diagnostics;

namespace DbConnection
{
    public class Program
    {
       
        public static void Main(string[] atg)
        {
           
            var sqlConnection = new SqlConnection("SQL Connection String");//Ensure that you're creating instances of the derived classes SqlConnection or OracleConnection,
                                                                           //not the abstract class Dbconnctions.
            var oracleConnection = new OracleConnection("Oracle Connection String");

            Stopwatch stopwatch = Stopwatch.StartNew();

            sqlConnection.opening();
            sqlConnection.closed();

            oracleConnection.opening();
            oracleConnection.closed();
         
            Console.WriteLine( "time"+ stopwatch.ElapsedMilliseconds +" ms" );

            var dbcommand =  new DbCommand(sqlConnection, "select * from table");
            var dbarclecomamd = new DbCommand(oracleConnection, "Select * from #table");
            dbcommand.Execute();
            dbarclecomamd.Execute();
            stopwatch.Stop();


        }
    }
}


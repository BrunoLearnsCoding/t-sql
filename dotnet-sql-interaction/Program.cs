// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
namespace dotnet_sql_interaction;
using System.Data;
using System.Data.SqlClient;
using System.Formats.Asn1;
using Dapper;

internal class Program
{
    private static void Main(string[] args)
    {
        string connectionString = "Server=172.16.8.198,1435;Database=StackOverflowClone;User Id=sa;Password=Obst@1354;";

        IEnumerable<Answer> answers = new List<Answer>();

        using (IDbConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            answers = connection.Query<Answer>("SELECT TOP 10 * FROM Answers");
        }

        foreach (var answer in answers) {
            System.Console.WriteLine(answer.ToString());
        }
    }
}
using Dapper;
using System.Data;
using System.Data.SQLite;

namespace ClassLibrary
{
    public static class DataAccess
    {
        public static void SaveGameHistoryToSQLiteDB(string playerChoice, string computerChoice, string matchResult, Guid gameSessionId)
        {
            string pathToDb = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName.Replace("bin", "DB") + "\\GameHistoryDB.db";
            string connectionString = $"Data Source={pathToDb};Version=3;";

            using(IDbConnection con = new SQLiteConnection(connectionString)) 
            {
                con.Execute($"INSERT INTO GameHistory (PlayerChoice, ComputerChoice, MatchResult, GameSessionId) values ('{playerChoice}', '{computerChoice}', '{matchResult}', '{gameSessionId.ToString()}')");
            }       
        }
    }
}

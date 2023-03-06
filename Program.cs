using flashcards;
using Microsoft.Data.Sqlite;

namespace Program
{
    class Program
    {
        static void Main()
        {
            using (var connection = new SqliteConnection(Helpers.ConnectionString))
            {
                connection.Open();
                var tableCmd = connection.CreateCommand();

                tableCmd.CommandText = @"CREATE TABLE IF NOT EXISTS flashcards (
                                id INTEGER PRIMARY KEY AUTOINCREMENT,
                                Name TEXT,
                                Cards INTEGER)";
                tableCmd.ExecuteNonQuery();
                connection.Close();
            }
            Menu.MainMenu();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace flashcards
{
    internal class StackActions
    {
        internal void ViewStack()
        {
            Console.Clear();
            
            using (var connection = new SqliteConnection(Helpers.ConnectionString))
            {
                connection.Open();

                var ViewAll = connection.CreateCommand();

                ViewAll.CommandText =
                    $"SELECT * FROM flashcards ";

                List<Flashcard> tabledata = new();

                SqliteDataReader reader = ViewAll.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tabledata.Add(
                            new Flashcard
                            {
                                id = reader.GetInt32(0),
                                name = reader.GetString(1),
                                cards = reader.GetInt32(3)
                            });
                    }
                }

                else
                {
                    Console.WriteLine("No rows found");
                    Console.ReadKey();
                    Menu.MainMenu();
                }

                connection.Close();

                foreach (var ent in tabledata)
                {
                    Console.WriteLine($"ID: {ent.id}\n" +
                        $"Name: {ent.name}\n" +
                        $"Cards: {ent.cards}\n");
                }
                Console.ReadKey();
            }
        }

        internal void CreateStack()
        {
            Console.Clear();
            Console.WriteLine("What would you like your new stack to be called?\nType 0 to return to the main menu");
            string StackName = Console.ReadLine();

            if (StackName == "0")
            {
                Menu.MainMenu();
            }

            using (var connection = new SqliteConnection(Helpers.ConnectionString))
            {
                connection.Open();
                var tableCmd = connection.CreateCommand();

                tableCmd.CommandText = $@"CREATE TABLE IF NOT EXISTS {StackName} (
                                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        Name TEXT,
                                        Cards INTEGER)";

                tableCmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        internal void DeleteStack()
        {
            Console.Clear();
            Console.WriteLine("Delete stack page");
        }
    }
}

internal class Flashcard
{
    public int id { get; set; }
    public string name { get; set; }
    public int cards { get; set; }
}
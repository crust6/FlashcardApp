using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace FlashcardApp
{
    public class Database
    {
        private static string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "FlashcardApp.db");

        public static SQLiteConnection GetConnection()
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
                Console.WriteLine("📂 Database Created at: " + dbPath);
            }

            return new SQLiteConnection($"Data Source={dbPath};Version=3;");
        }

        public static void CreateTables()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = @"
                    CREATE TABLE IF NOT EXISTS Flashcards (
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Prompt TEXT NOT NULL,
                        Answer TEXT NOT NULL,
                        Category TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS QuizAttempts (
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Date TEXT NOT NULL,
                        Score INTEGER NOT NULL,
                        Category TEXT NOT NULL
                    );
                ";
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                command.ExecuteNonQuery();
                Console.WriteLine("✅ Tables Created (if not existing)");
            }
        }

        public static int AddFlashcard(string prompt, string answer, string category)
        {
            using (var conn = GetConnection())
            {
                conn.Open();

                // Find the smallest available ID (reusing deleted IDs)
                string findIDQuery = "SELECT MIN(t1.ID + 1) AS newID FROM Flashcards t1 LEFT JOIN Flashcards t2 ON t1.ID + 1 = t2.ID WHERE t2.ID IS NULL";
                SQLiteCommand idCommand = new SQLiteCommand(findIDQuery, conn);
                object result = idCommand.ExecuteScalar();
                //   int newFlashcardID = (result != DBNull.Value && result != null) ? Convert.ToInt32(result) : 1;
                int newFlashcardID = Database.GetNextFlashcardID();
                // Insert the new flashcard with the chosen ID
                string sql = "INSERT INTO Flashcards (ID, Prompt, Answer, Category) VALUES (@id, @prompt, @answer, @category)";
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                command.Parameters.AddWithValue("@id", newFlashcardID);
                command.Parameters.AddWithValue("@prompt", prompt);
                command.Parameters.AddWithValue("@answer", answer);
                command.Parameters.AddWithValue("@category", category);
                command.ExecuteNonQuery();

                return newFlashcardID; // Return the assigned Flashcard ID
            }
        }

        public static void DeleteFlashcard(int flashcardID)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM Flashcards WHERE ID = @id";
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                command.Parameters.AddWithValue("@id", flashcardID);
                command.ExecuteNonQuery();
            }
        }


        public static int GetNextFlashcardID()
        {
            using (var conn = GetConnection())
            {
                conn.Open();

                // Find the smallest available ID (reusing deleted IDs)
                string findIDQuery = "SELECT MIN(t1.ID + 1) AS newID FROM Flashcards t1 LEFT JOIN Flashcards t2 ON t1.ID + 1 = t2.ID WHERE t2.ID IS NULL";
                SQLiteCommand idCommand = new SQLiteCommand(findIDQuery, conn);
                object result = idCommand.ExecuteScalar();
                return (result != DBNull.Value && result != null) ? Convert.ToInt32(result) : 1;
            }
        }

        public static (int, string, string, string)? GetFlashcardByID(int flashcardID)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM Flashcards WHERE ID = @id";
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                command.Parameters.AddWithValue("@id", flashcardID);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return (reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                    }
                }
            }
            return null;
        }
        public static void UpdateFlashcard(int flashcardID, string prompt, string answer, string category)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = "UPDATE Flashcards SET Prompt = @prompt, Answer = @answer, Category = @category WHERE ID = @id";
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                command.Parameters.AddWithValue("@prompt", prompt);
                command.Parameters.AddWithValue("@answer", answer);
                command.Parameters.AddWithValue("@category", category);
                command.Parameters.AddWithValue("@id", flashcardID);
                command.ExecuteNonQuery();
            }
        }


        public static List<(int, string, string, string)> GetAllFlashcards()
        {
            var flashcards = new List<(int, string, string, string)>();

            using (var conn = GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM Flashcards";
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        flashcards.Add((reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)));
                    }
                }
            }
            return flashcards;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashcardApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database.CreateTables();
           // Database.AddFlashcard("What is 2+2?", "4", "Math");

            var flashcards = Database.GetAllFlashcards();
            foreach (var card in flashcards)
            {
                
                Console.WriteLine($"ID: {card.Item1}, Q: {card.Item2}, A: {card.Item3}, Category: {card.Item4}");
            }

            Database.CreateTables(); // Ensure the database & tables exist
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmHomePage());
        }
    }
}

using System;
using System.IO;
using Newtonsoft.Json;

namespace FlashcardApp
{
    public class AppData
    {
        public int FlashcardsCreated { get; set; }
        public int QuizzesTaken { get; set; }

        private static string filePath = "appData.json";

        // Load data from JSON file
        public static AppData Load()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<AppData>(json) ?? new AppData();
            }
            return new AppData();
        }

        // Save data to JSON file
        public void Save()
        {
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}

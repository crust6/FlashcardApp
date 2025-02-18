using System;
using System.IO;
using Newtonsoft.Json;

namespace FlashcardApp
{
    public class AppData
    {
        public int FlashcardsCreated { get; set; }
        public int QuizzesTaken { get; set; }

        private static string filePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "FlashcardAppData.json"
        );

        public static AppData Load()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    return JsonConvert.DeserializeObject<AppData>(json) ?? new AppData();
                }
                catch
                {
                    // If the file is corrupted or unreadable, reset it
                    return new AppData();
                }
            }
            else
            {
                // File does not exist, create a new one with default values
                AppData newData = new AppData();
                newData.Save();  // Save to create the file
                return newData;
            }
        }

        public void Save()
        {
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}
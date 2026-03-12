using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Bank_Application.NewFolder;

namespace Bank_Application.Classes
{
    internal static class DataManager
    {
        private static string filePath = "bank_data.json";
        public static List<User> Users { get; set; } = new List<User>();
        public static User CurrentUser { get; set; }

        public static void Save()
        {
            string json = JsonSerializer.Serialize(Users);
            File.WriteAllText(filePath, json);
        }

        public static void Load()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                Users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
            }
        }
    }
}
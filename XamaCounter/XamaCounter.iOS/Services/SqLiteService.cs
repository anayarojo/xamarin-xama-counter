using System;
using System.IO;
using SQLite;
using XamaCounter.iOS.Services;
using XamaCounter.Services;
using XamaCounter.Settings;

[assembly: Xamarin.Forms.Dependency(typeof(SqLiteService))]
namespace XamaCounter.iOS.Services
{
    public class SqLiteService : ISqLiteService
    {
        public SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(GetDatabasePath());
        }

        public SQLiteAsyncConnection GetConnectionAsync()
        {
            return new SQLiteAsyncConnection(GetDatabasePath());
        }

        private static string GetDatabasePath()
        {
            var dbName = GlobalSettings.DB_NAME;
            var iosPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var dataPath = Path.Combine(iosPath, "..", "Data");

            if (!Directory.Exists(dataPath))
            {
                Directory.CreateDirectory(dataPath);
            }

            return Path.Combine(dataPath, dbName);
        }
    }
}
using System;
using System.IO;
using SQLite;
using XamaCounter.Droid.Services;
using XamaCounter.Services;
using XamaCounter.Settings;

[assembly: Xamarin.Forms.Dependency(typeof(SqLiteService))]
namespace XamaCounter.Droid.Services
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
            var androidPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(androidPath, dbName);
        }
    }
}
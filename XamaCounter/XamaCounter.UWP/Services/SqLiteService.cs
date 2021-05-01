using System;
using System.IO;
using Windows.Storage;
using SQLite;
using XamaCounter.Services;
using XamaCounter.Settings;
using XamaCounter.UWP.Services;

[assembly: Xamarin.Forms.Dependency(typeof(SqLiteService))]
namespace XamaCounter.UWP.Services
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
            return Path.Combine(ApplicationData.Current.LocalFolder.Path, dbName);
        }
    }
}
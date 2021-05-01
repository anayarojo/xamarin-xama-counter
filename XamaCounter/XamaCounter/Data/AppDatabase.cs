using SQLite;
using XamaCounter.Models;

namespace XamaCounter.Data
{
    public class AppDatabase
    {
        private readonly SQLiteAsyncConnection connection;

        public AppDatabase(string dbPath)
        {
            connection = new SQLiteAsyncConnection(dbPath);
            connection.CreateTableAsync<AppState>().Wait();
        }
    }
}
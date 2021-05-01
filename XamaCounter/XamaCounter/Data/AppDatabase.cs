using SQLite;
using XamaCounter.Data.Models;

namespace XamaCounter.Data
{
    public class AppDatabase
    {
        private readonly SQLiteAsyncConnection _connection;

        public AppDatabase(SQLiteAsyncConnection connection)
        {
            _connection = connection;
            _connection.CreateTableAsync<AppState>().Wait();
        }
    }
}
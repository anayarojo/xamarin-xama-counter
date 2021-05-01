using System.Threading.Tasks;
using SQLite;
using XamaCounter.Data.Models;
using XamaCounter.Services;

namespace XamaCounter.Data
{
    public class AppDatabase
    {
        private readonly SQLiteAsyncConnection _connection;

        public AppDatabase(ISqLiteService sqLiteService)
        {
            _connection = sqLiteService.GetConnectionAsync();
            _connection.CreateTableAsync<Session>().Wait();
        }

        public async Task<int> SetLogged(bool isLogged)
        {
            if (!(await HasAppStateAsync()))
            {
                return await _connection.InsertAsync(new Session()
                {
                    IsLogged = isLogged
                });
            }

            var appSettings = await GetAppStateAsync();
            appSettings.IsLogged = isLogged;

            return await _connection.UpdateAsync(appSettings);
        }

        public async Task<bool> IsLogged()
        {
            if (!(await HasAppStateAsync()))
            {
                return false;
            }

            var appSettings = await  GetAppStateAsync();

            return appSettings.IsLogged;
        }

        private async Task<bool> HasAppStateAsync()
        {
            var count = await _connection.Table<Session>()
                .CountAsync();

            return count > 0;
        }
        
        private async Task<Session> GetAppStateAsync()
        {
            return await _connection.Table<Session>()
                .FirstOrDefaultAsync();
        }
    }
}
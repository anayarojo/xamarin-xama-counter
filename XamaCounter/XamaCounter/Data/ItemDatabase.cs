using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using XamaCounter.Data.Interfaces;
using XamaCounter.Data.Models;
using XamaCounter.Services;

namespace XamaCounter.Data
{
    public class ItemDatabase : IGenericDatabase<Item>
    {
        private readonly SQLiteAsyncConnection _connection;

        public ItemDatabase(ISqLiteService sqLiteService)
        {
            _connection = sqLiteService.GetConnectionAsync();
            _connection.CreateTableAsync<Item>().Wait();
        }

        public async Task<List<Item>> GetAsync()
        {
            return await _connection.Table<Item>().ToListAsync();
        }

        public async Task<Item> GetAsync(int id)
        {
            return await _connection.Table<Item>()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<int> SaveAsync(Item model)
        {
            if (model.Id != 0)
            {
                return await _connection.UpdateAsync(model);
            }

            return await _connection.InsertAsync(model);
        }

        public async Task<int> DeleteAsync(Item model)
        {
            return await _connection.DeleteAsync(model);
        }
    }
}
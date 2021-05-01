using SQLite;

namespace XamaCounter.Services
{
    public interface ISqLiteService
    {
        SQLiteConnection GetConnection();

        SQLiteAsyncConnection GetConnectionAsync();
    }
}
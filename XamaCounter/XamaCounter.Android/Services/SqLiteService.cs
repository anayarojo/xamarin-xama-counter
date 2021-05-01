using SQLite;
using XamaCounter.Droid.Services;
using XamaCounter.Services;
using XamaCounter.Settings;

[assembly: Xamarin.Forms.Dependency(typeof(SqLiteService))]
namespace XamaCounter.Droid.Services
{
    public class SqLiteService : ISqLiteService
    {
        private readonly FileService _fileService;

        public SqLiteService()
        {
            _fileService = new FileService();
        }

        public SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(GetDatabasePath());
        }

        public SQLiteAsyncConnection GetConnectionAsync()
        {
            return new SQLiteAsyncConnection(GetDatabasePath());
        }

        private string GetDatabasePath()
        {
            var dbName = GlobalSettings.DB_NAME;
            return _fileService.GetLocalFilePath(dbName);
        }
    }
}
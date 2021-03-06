using SQLite;
using XamaCounter.Services;
using XamaCounter.Settings;
using XamaCounter.UWP.Services;

[assembly: Xamarin.Forms.Dependency(typeof(SqLiteService))]
namespace XamaCounter.UWP.Services
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
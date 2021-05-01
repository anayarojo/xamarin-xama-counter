using XamaCounter.Data;
using XamaCounter.Services;
using Xamarin.Forms;

namespace XamaCounter
{
    public partial class App : Application
    {
        private static AppDatabase _database;

        public static AppDatabase Database
        {
            get
            {
                if (_database == null)
                {
                    var sqLiteService = DependencyService.Get<ISqLiteService>();
                    _database = new AppDatabase(sqLiteService);
                }

                return _database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

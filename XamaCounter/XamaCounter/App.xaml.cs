using System;
using XamaCounter.Data;
using XamaCounter.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
                    var fileService = DependencyService.Get<IFileService>();
                    _database = new AppDatabase(fileService.GetLocalFilePath("appDb.db3"));
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

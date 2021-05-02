using System.Threading.Tasks;
using XamaCounter.Cache;
using XamaCounter.Views;
using Xamarin.Forms;

namespace XamaCounter.ViewModels
{
    public class DashboardViewModel : BaseViewModel, ICacheSubscriber
    {
        private readonly DashboardPage _dashboardPage;
        private int _backgroundCounter;
        private int _timerCounter;

        public int BackgroundCounter
        {
            get => _backgroundCounter;
            set => SetProperty(ref _backgroundCounter, value);
        }

        public int TimerCounter
        {
            get => _timerCounter;
            set => SetProperty(ref _timerCounter, value);
        }

        public Command NavigateToProfileCommand { get; set; }
        public Command NavigateToAboutCommand { get; set; }
        public Command LogoutCommand { get; set; }

        public DashboardViewModel(DashboardPage dashboardPage)
        {
            _dashboardPage = dashboardPage;

            Title = "Dashboard";
            NavigateToProfileCommand = new Command(async () => await OnNavigateToProfile());
            NavigateToAboutCommand = new Command(async () => await OnNavigateToAbout());
            LogoutCommand = new Command(async () => await OnLogout());

            CacheManager.Subscribe(this);
            BackgroundCounter = CacheManager.Data.BackgroundCounter;
            TimerCounter = CacheManager.Data.TimerCounter;
        }

        ~DashboardViewModel()
        {
            CacheManager.Unsubscribe(this);
        }

        private async Task OnNavigateToProfile()
        {
            await _dashboardPage.Navigation.PushAsync(new ProfilePage());
        }

        private async Task OnNavigateToAbout()
        {
            await _dashboardPage.Navigation.PushAsync(new AboutPage());
        }

        private async Task OnLogout()
        {
            await _dashboardPage.Navigation.PopToRootAsync();
        }

        public void OnUpdateCacheData((int BackgroundCounter, int TimerCounter) data)
        {
            BackgroundCounter = data.BackgroundCounter;
            TimerCounter = data.TimerCounter;
        }
    }
}

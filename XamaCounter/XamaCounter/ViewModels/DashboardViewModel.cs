using System.Threading.Tasks;
using XamaCounter.Views;
using Xamarin.Forms;

namespace XamaCounter.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        private readonly DashboardPage _dashboardPage;

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
    }
}

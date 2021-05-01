using System.Threading.Tasks;
using XamaCounter.Views;
using Xamarin.Forms;

namespace XamaCounter.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly LoginPage _loginPage;

        public Command LoginCommand { get; set; }

        public LoginViewModel(LoginPage loginPage)
        {
            _loginPage = loginPage;

            Title = "Login";
            LoginCommand = new Command(async () => await OnLogin());
        }

        private async Task OnLogin()
        {
            await _loginPage.Navigation.PushAsync(new DashboardPage());
        }
    }
}
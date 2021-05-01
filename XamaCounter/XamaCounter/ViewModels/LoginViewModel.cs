using XamaCounter.Views;

namespace XamaCounter.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly LoginPage _loginPage;

        public LoginViewModel(LoginPage loginPage)
        {
            _loginPage = loginPage;

            Title = "Login";
        }
    }
}
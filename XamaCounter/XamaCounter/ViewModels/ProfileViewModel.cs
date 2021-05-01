using XamaCounter.Views;

namespace XamaCounter.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {
        private readonly ProfilePage _profilePage;

        public ProfileViewModel(ProfilePage profilePage)
        {
            _profilePage = profilePage;

            Title = "Profile";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using XamaCounter.Views;

namespace XamaCounter.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private readonly AboutPage _aboutPage;

        public AboutViewModel(AboutPage aboutPage)
        {
            _aboutPage = aboutPage;

            Title = "About";
        }
    }
}

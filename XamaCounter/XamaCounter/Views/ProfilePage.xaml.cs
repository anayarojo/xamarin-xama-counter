using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaCounter.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamaCounter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        private readonly ProfileViewModel _viewModel;

        public ProfilePage()
        {
            InitializeComponent();

            _viewModel = new ProfileViewModel(this);
            BindingContext = _viewModel;
        }
    }
}
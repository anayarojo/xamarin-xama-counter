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
    public partial class LoginPage : ContentPage
    {
        private readonly LoginViewModel _viewModel;

        public LoginPage()
        {
            InitializeComponent();

            _viewModel = new LoginViewModel(this);
            BindingContext = _viewModel;
        }
    }
}
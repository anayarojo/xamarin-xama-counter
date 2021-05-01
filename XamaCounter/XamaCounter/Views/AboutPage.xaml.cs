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
    public partial class AboutPage : ContentPage
    {
        private readonly AboutViewModel _viewModel;

        public AboutPage()
        {
            InitializeComponent();

            _viewModel = new AboutViewModel(this);
            BindingContext = _viewModel;
        }
    }
}
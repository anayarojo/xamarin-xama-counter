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
    public partial class DashboardPage : ContentPage
    {
        private readonly DashboardViewModel _viewModel;

        public DashboardPage()
        {
            InitializeComponent();

            _viewModel = new DashboardViewModel(this);
            BindingContext = _viewModel;
        }
    }
}
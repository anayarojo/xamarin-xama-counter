using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaCounter.Cache;
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

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    var newData = CacheManager.Data;
                    newData.TimerCounter += 1;
                    CacheManager.Update(newData);
                });

                return true;
            });
        }
    }
}
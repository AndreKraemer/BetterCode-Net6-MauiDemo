using BetterCodeMauiDemo.Common;
using BetterCodeMauiDemo.ViewModels;
using Microsoft.Maui.Controls;

namespace BetterCodeMauiDemo.Views
{

    public partial class SessionDetailPage : ContentPage
    {
        public SessionDetailPage()
        {
            InitializeComponent();
            this.BindingContext = ViewModel = ServiceProvider.GetService<SessionDetailPageViewModel>();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ViewModel.OnAppearing();
        }

        public SessionDetailPageViewModel ViewModel { get; }
    }
}
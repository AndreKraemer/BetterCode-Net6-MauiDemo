using BetterCodeMauiDemo.Common;
using BetterCodeMauiDemo.ViewModels;
using Microsoft.Maui.Controls;

namespace BetterCodeMauiDemo.Views
{

    public partial class SessionsPage : ContentPage
    {
        public SessionsPage()
        {
            InitializeComponent();
            this.BindingContext = ViewModel = ServiceProvider.GetService<SessionsPageViewModel>();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ViewModel.OnAppearing();
        }

        public SessionsPageViewModel ViewModel { get; }
    }
}
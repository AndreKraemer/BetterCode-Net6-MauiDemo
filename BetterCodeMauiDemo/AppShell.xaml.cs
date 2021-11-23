using System;
using BetterCodeMauiDemo.Views;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace BetterCodeMauiDemo
{
    public partial class AppShell: Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(SessionDetailPage), typeof(SessionDetailPage));
        }
    }
}
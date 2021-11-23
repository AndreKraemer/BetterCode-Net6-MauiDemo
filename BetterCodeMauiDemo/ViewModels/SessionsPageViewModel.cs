using BetterCodeMauiDemo.Services;
using BetterCodeMauiDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using BetterCodeMauiDemo.Views;

namespace BetterCodeMauiDemo.ViewModels
{
    public class SessionsPageViewModel : BaseViewModel
    {
        private readonly IDataService _dataService;

        private readonly ObservableCollection<Session> _sessions = new ObservableCollection<Session>();

        public SessionsPageViewModel(IDataService dataService)
        {
            _dataService = dataService;
            NavigateToDetailsCommand = new Command<int>(NavigateToDetailsPage);
        }

        private void NavigateToDetailsPage(int sessionId)
        {
            Shell.Current.GoToAsync($"{nameof(SessionDetailPage)}?SessionId={sessionId}");
        }

        public ObservableCollection<Session> Sessions => _sessions;

        public ICommand NavigateToDetailsCommand { get; set; }

        public void OnAppearing()
        {
            _sessions.Clear();
            var sessions = _dataService.GetSessions();
            foreach (var session in sessions)
            {
                _sessions.Add(session);
            }
        }
    }
}

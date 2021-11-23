using BetterCodeMauiDemo.Services;
using BetterCodeMauiDemo.Models;
using Microsoft.Maui.Controls;
using System.Windows.Input;
using Microsoft.Maui.Essentials;

namespace BetterCodeMauiDemo.ViewModels
{
    [QueryProperty(nameof(SessionId), nameof(SessionId))]
    public class SessionDetailPageViewModel : BaseViewModel
    {
        private readonly IDataService _dataService;

        public SessionDetailPageViewModel(IDataService dataService)
        {
            _dataService = dataService;
            OpenTwitterCommand = new Command(OpenTwitter);
            CallSpeakerCommand = new Command(CallSpeaker);
        }

        public ICommand OpenTwitterCommand { get; set; }
        public ICommand CallSpeakerCommand { get; set; }
        public int SessionId { get; set; }

        private Session _session = new Session();
        public Session Session
        {
            get => _session;
            set => SetProperty(ref _session, value);
        }



        public void OnAppearing()
        {
            Session = _dataService.GetSession(SessionId);
        }

        private void OpenTwitter()
        {
            Browser.OpenAsync(Session.Speaker.TwitterUrl);
        }

        private void CallSpeaker()
        {
            try
            {
                PhoneDialer.Open("12345678");
            }
            catch (FeatureNotSupportedException ex)
            {
                System.Diagnostics.Debug.WriteLine("Feature nicht untersützt");
            }
        }


    }
}

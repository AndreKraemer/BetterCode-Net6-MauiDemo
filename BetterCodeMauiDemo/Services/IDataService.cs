using BetterCodeMauiDemo.Models;
using System.Collections.Generic;

namespace BetterCodeMauiDemo.Services
{
    public interface IDataService
    {
        Session GetSession(int id);
        IEnumerable<Session> GetSessions();
        Speaker GetSpeaker(int id);
        IEnumerable<Speaker> GetSpeakers();
    }
}
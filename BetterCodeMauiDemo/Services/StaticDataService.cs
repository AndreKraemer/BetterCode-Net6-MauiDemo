using BetterCodeMauiDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterCodeMauiDemo.Services
{
    public class StaticDataService : IDataService
    {

        #region Dummy Data

        private List<Speaker> _speakers = new List<Speaker>();
        private List<Session> _sessions = new List<Session>();

        public StaticDataService()
        {
            _speakers.Add(new Speaker
            {
                Id = 1,
                Name = "Dr. Holger Schwichtenberg",
                Company = "IT-Visions.de | MAXIMAGO",
                TwitterUrl = "https://twitter.com/DOTNETDOKTOR",
                Image = "hs.jpg",
                Bio = "Dr. Holger Schwichtenberg ist einer der bekanntesten Experten für .NET in Deutschland. Zusammen mit rund 50 weiteren Experten unterstützt er im Rahmen der Firma IT-Visions.de mittlere und große Unternehmen durch Beratung und Schulungen beim Erstellen von Software. Zudem ist er Chief Technology Expert bei der Softwareschmiede MAXIMAGO."
            });

            _speakers.Add(new Speaker
            {
                Id = 2,
                Name = "Rainer Stropek",
                Company = "software architects | IT-Visions.at",
                TwitterUrl = "https://twitter.com/rstropek",
                Image = "rs.jpg",
                Bio = "Rainer Stropek ist seit 2008 Mitbegründer und CEO der Firma software architects. Zudem leitet Rainer die österreichische Niederlassung des Beratung- und Schulungsunternehmens IT-Visions. Er ist Experte für .NET- und Webentwicklung, Softwarearchitektur, Datenbanken und Cloud Computing."
            });

            _speakers.Add(new Speaker
            {
                Id = 3,
                Name = "Christian Wenz",
                Company = "Arrabiata Solutions",
                TwitterUrl = "https://twitter.com/chwenz",
                Image = "cw.jpg",
                Bio = "Christian Wenz ist Berater, Trainer und Autor für Webtechnologien. Als Teilhaber der Arrabiata Solutions GmbH sorgt er für schnellere und sicherere Webanwendungen. Er ist ASP.NET MVP und ASPInsider, Hauptautor der Zend PHP Certification, Contributor mehrerer Open-Source-Projekte und spricht regelmäßig auf Entwicklerkonferenzen rund um den Globus."
            });

            _speakers.Add(new Speaker
            {
                Id = 4,
                Name = "Thomas Claudius Huber",
                Company = "Trivadis",
                TwitterUrl = "https://twitter.com/thomasclaudiush",
                Image = "tch.jpg",
                Bio = "Thomas Claudius Huber ist Microsoft MVP im Bereich Windows Development und Senior Principal Consultant bei der Trivadis AG. Als Trainer, Berater und Entwickler ist er in den Bereichen C#, XAML, TypeScript, und Azure unterwegs. Da ihn Benutzeroberflächen schon seit seinem Informatikstudium faszinierten, setzte er sich seit der ersten WPF-Version mit der UI-Programmierung mit XAML auseinander."
            });


            _speakers.Add(new Speaker
            {
                Id = 5,
                Name = "André Krämer",
                Company = "Quality Bytes | IT-Visions.de",
                TwitterUrl = "https://twitter.com/codemurai",
                Image = "ak.jpg",
                Bio = "André Krämer ist Geschäftsführer der Quality Bytes GmbH und Partner im www.IT-Visions.de-Expertennetzwerk. Seine Schwerpunkte als Entwickler, Trainer und Berater liegen in den Bereichen App-Entwicklung mit Xamarin, Webentwicklung mit ASP.NET und JavaScript, Azure DevOps, Dokumentengenerierung und Reporting mit TX Text Control sowie der Analyse von Memory Leaks und Performanceproblemen."
            });

            _speakers.Add(new Speaker
            {
                Id = 6,
                Name = "Alexander Neumann",
                Company = "Heise Academy",
                TwitterUrl = "",
                Image = "an.jpg",
                Bio = ""
            });


            _sessions.Add(new Session
            {
                Id = 1,
                Title = "Begrüßung",
                Start = new TimeOnly(9, 0),
                End = new TimeOnly(9, 15),
            });

            _sessions.Add(new Session
            {
                Id = 2,
                Title = ".NET 6: Neuigkeiten bei den Anwendungsarten und im SDK",
                Description = ".NET 6 ist die seit langem angestrebte Zusammenführung von .NET Framework, .NET Core, Mono und Xamarin. .NET 6 vereinheitlicht nicht nur SDK und Klassenbibliothek, sondern bietet auch eine Reihe neuer Funktionen bei den Basisklassen und den Anwendungsframeworks. Das neue Hot Reloading erhöht die Produktivität der Softwareentwickler. Als neue Anwendungsart ist Blazor Desktop hinzugekommen, mit dem sich hybride Anwendung (HTML-Apps eingebettet in Desktop-Apps) entwickeln lassen",
                Goals = new[] { "Konzept von .NET 6", "Neuerungen im .NET 6 SDK im Vergleich zu .NET 5", "Hot Reloading: Codeänderungen in der laufenden Anwendung", "Verbesserungen beim Deployment", "Hybride Anwendungen mit Blazor Desktop" },
                Start = new TimeOnly(9, 15),
                End = new TimeOnly(10, 0),
                Speaker = _speakers[0]
            });

            _sessions.Add(new Session
            {
                Id = 3,
                Title = "Neuigkeiten in C# 10",
                Description = "Jede neue Version von .NET bringt auch Neuigkeiten in der Sprache C#. In diesem Vortrag sehen wir uns an, was Interessantes für C#-Entwicklerinnen und Entwickler im Paket enthalten ist. Rainer wird die Änderungen und Erweiterungen von C# 10 anhand vieler Codebeispiele zeigen und praktische Tipps und Tricks für den Einsatz in der Praxis weitergeben",
                Goals = new[] { "Was ist neu in C#?", "Wie profitiert man in der täglichen Entwicklung von den Spracherweiterungen?", "In welchem langfristigen Zusammenhang stehen die Erweiterungen von C# 10?", "Worauf muss man bei der Umstellung auf C# 10 achten?" },
                Start = new TimeOnly(10, 15),
                End = new TimeOnly(11, 0),
                Speaker = _speakers[1]
            });


            _sessions.Add(new Session
            {
                Id = 4,
                Title = "Neuigkeiten von ASP.NET Core 6.0 und Blazor 6",
                Description = "In Sachen Webentwicklung mit .NET hat sich Microsoft in den letzten zwei Dekaden eine ganze Menge einfallen lassen und auch einige Kehrtwendungen unternommen. .NET 6 ist ein signifikanter Schritt zur Konsolidierung der Plattform und Ende einer langen Reise – Long Term Support inklusive. Grund genug, einen Blick auf Neuerungen von ASP.NET Core 6.0 und auch auf Blazor 6.0 zu werfen. Was ist neu, wie schmerzvoll ist eine Migration und, vielleicht am wichtigsten, wie geht es weiter?",
                Goals = new[] { "Neue Features in ASP.NET Core 6.0 kennen lernen", "Neue Features in Blazor 6.0 kennenlernen", "Migration von älteren Versionen einschätzen", "Blick in die Zukunft (.NET 7 und darüber hinaus) werfen" },
                Start = new TimeOnly(11, 15),
                End = new TimeOnly(12, 0),
                Speaker = _speakers[2]
            });


            _sessions.Add(new Session
            {
                Id = 5,
                Title = ".NET 6: Neuigkeiten bei den .NET-Basisklassen",
                Description = "In .NET 6 hat Microsoft die Basisklassenbibliothek an verschiedenen Stellen erweitert und optimiert. Dieser Vortrag zeigt praktische Beispiele zu den neuen Klassen und APIs insbesondere im Bereich Datenbankzugriffe mit Entity Framework Core 6.0.",
                Goals = new[] { "Neue Basisklassen wie DateOnly, TimeOnly und PriorityQueue", "Low-Level-Operationen mit System.IO.RandomAccess und System.Runtime.InteropServices.NativeMemory", "Erweiterte APIs im Bereich LINQ, JSON u.a.", "Leistungsverbesserungen der Basisklassen", "Neuerungen in Entity Framework Core 6.0 gegenüber Version 5.0" },
                Start = new TimeOnly(12, 15),
                End = new TimeOnly(13, 0),
                Speaker = _speakers[0]
            });

            _sessions.Add(new Session
            {
                Id = 6,
                Title = "Mittagspause",
                Start = new TimeOnly(13, 0),
                End = new TimeOnly(14, 00),
            });

            _sessions.Add(new Session
            {
                Id = 7,
                Title = "WinUI 3 und das Windows App SDK: Moderne Desktop-Apps für Windows 10 und 11 entwickeln",
                Description = "Mit WinUI 3 hat Microsoft ein brandneues XAML-basiertes UI-Framework auf den Markt gebracht. Brandneu? Nicht ganz. Die XAML Runtime und XAML Controls der Universal Windows Platform (UWP) wurden von Windows entkoppelt und stehen nun unter dem Namen WinUI 3 als Teil des Windows App SDK zur Verfügung. WinUI 3 stellt ist die native UI - Plattform von Windows 10 und 11.Das bedeutet,                dass viele Teile von Windows 10 und 11 mit WinUI 3 entwickelt wurden.Dieses moderne UI Framework können Sie auch für Ihre eigenen Anwendungen einsetzen.",
                Goals = new[] { "Überblick über UWP, WinUI und das Windows App SDK", "Wie eine WinUI-3-App im Live-Coding mit XAML und C# erstellt wird" },
                Start = new TimeOnly(14, 00),
                End = new TimeOnly(14, 45),
                Speaker = _speakers[3]
            });

            _sessions.Add(new Session
            {
                Id = 8,
                Title = "Cross-Plattform-Entwicklung mit .NET Multi-Platform App UI",
                Description = ".NET Multi-Platform App UI (.NET MAUI) ist die Evolution von Xamarin.Forms. Die neue Version von Microsofts Cross-Plattform-Framework integriert sich nicht nur tiefer als je zuvor in Visual Studio und das .NET SDK, sie ist auch weitaus einsteigerfreundlicher. In diesem Vortrag erhalten Sie einen praxisorientierten Überblick über.NET MAUI.Anhand praxisnaher Codebeispiele zeigt Ihnen André, wie Sie die ersten Schritte in der Cross - Plattform - Entwicklung gehen können. Abgerundet wird der Vortrag mit einem Überblick über die notwendigen Schritte zur Migration von bestehenden Apps.",
                Goals = new[] { "Einen praxisnahen Überblick über .NET MAUI erhalten", "Einschätzen können, ob der Einsatz von .NET MAUI im eigenen Projekt vorteilhaft ist", "Den Unterschied zwischen Xamarin.Forms und .NET MAUI verstehen", "Migrationsaufwand von Xamarin.Forms zu .NET MAUI einschätzen können" },
                Start = new TimeOnly(15, 00),
                End = new TimeOnly(15, 45),
                Speaker = _speakers[4]
            });

            _sessions.Add(new Session
            {
                Id = 9,
                Title = "Migration von .NET Framework 4.8 zu .NET 6",
                Description = "Das klassische .NET Framework wird nicht mehr weiterentwickelt, aber bleibt weiterhin ein fester Bestandteil von Windows (auch in Windows 11) und erhält noch Fehlerbehebungen, aber keine neuen Features mehr. Dieser Vortrag von Holger beschäftigt sich mit der Frage, ob und wie man auf.NET 6 umsteigen sollte.Dabei geht es nicht darum, das neue.NET in den Himmel zu loben, sondern objektiv auch dessen Nachteile aufzuzeigen, sodass alle Teilnehmer:innen eine gute Entscheidungsgrundlage erhalten.",
                Goals = new[] { "Migrationsdruck", "Vor- und Nachteile einer Migration", "Entfallene Techniken und deren Alternativen", "Migrationsaufwand", "Migrationsstrategien", "Migrationswerkzeug" },
                Start = new TimeOnly(16, 00),
                End = new TimeOnly(16, 45),
                Speaker = _speakers[0]
            });

            _sessions.Add(new Session
            {
                Id = 9,
                Title = "Frage-/Diskussionsrunde zu .NET 6",
                Description = "Alexander Neumann bewertet mit den Referenten der betterCode() .NET 6 die Neuerungen der Entwicklungsplattform. Die Teilnehmenden der Konferenz haben die Gelegenheit, sich mit Fragen einzubringen.",
                Goals = Array.Empty<string>(),
                Start = new TimeOnly(17, 00),
                End = new TimeOnly(17, 45),
                Speaker = _speakers[5]
            });

        }

        #endregion

        public IEnumerable<Speaker> GetSpeakers()
        {
            return _speakers;
        }

        public Speaker GetSpeaker(int id)
        {
            return _speakers.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Session> GetSessions()
        {
            return _sessions;
        }

        public Session GetSession(int id)
        {
            return _sessions.FirstOrDefault(s => s.Id == id);
        }

    }
}

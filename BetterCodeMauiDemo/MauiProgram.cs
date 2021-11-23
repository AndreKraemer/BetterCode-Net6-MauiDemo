using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Extensions.DependencyInjection;
using BetterCodeMauiDemo.Services;
using BetterCodeMauiDemo.ViewModels;

namespace BetterCodeMauiDemo
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				})
				;

			builder.Services.AddSingleton<IDataService, StaticDataService>();
			builder.Services.AddTransient<SessionsPageViewModel>();
			builder.Services.AddTransient<SessionDetailPageViewModel>();
			return builder.Build();
		}
	}
}
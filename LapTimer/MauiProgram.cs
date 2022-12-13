using Microsoft.Extensions.Logging;
using LapTimer.Data;
using LapTimer.Servicies;

namespace LapTimer;

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
			});

		builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

		builder.Services.AddTransient<TimerButtonsState>()
						.AddTransient<AccelerometerWrapper>()
                        .AddTransient<AccelateViewModel>()
                        .AddSingleton<WeatherForecastService>()
						.AddSingleton<IDbService, DbService>();

        return builder.Build();
	}
}

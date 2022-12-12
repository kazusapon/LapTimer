using Microsoft.Extensions.Logging;
using LapTimer.Data;

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
						.AddSingleton<WeatherForecastService>();

        return builder.Build();
	}
}

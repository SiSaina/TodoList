using Microsoft.Extensions.Logging;
using TodoList.ViewModel;

namespace TodoList
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainPageViewModel>();

            builder.Services.AddTransient<ViewPage>();
            builder.Services.AddTransient<ViewPageViewModel>();

            builder.Services.AddTransient<ModifyPage>();
            builder.Services.AddTransient<ModifyPageViewModel>();

            return builder.Build();
        }
    }
}

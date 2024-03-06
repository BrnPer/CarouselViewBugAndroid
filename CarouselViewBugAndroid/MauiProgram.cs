using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace CarouselViewBugAndroid
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            Routing.RegisterRoute("carouselOnePage", typeof(CarouselOnePage));
            builder.Services.AddSingleton<CarouselOnePage>();
            builder.Services.AddSingleton<CarouselOneViewModel>();

            return builder.Build();
        }
    }
}

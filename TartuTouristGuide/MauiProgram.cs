using Microsoft.Extensions.Logging;
using TartuTouristGuide.Services;
using TartuTouristGuide.ViewModels;
using TartuTouristGuide.Views;

namespace TartuTouristGuide
{
    public static class MauiProgram
    {
        // Entry point: configures dependency injection and app services
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

            // Services: Singleton = shared state across app (visited places persist)
            builder.Services.AddSingleton<VisitedPlacesService>();

            // ViewModels: Transient = new instance each time (fresh data)
            builder.Services.AddTransient<HomeViewModel>();
            builder.Services.AddTransient<CategoryListViewModel>();
            builder.Services.AddTransient<PlaceDetailViewModel>();
            builder.Services.AddTransient<RewardsViewModel>();

            // Pages: Transient = new page instance each navigation
            builder.Services.AddTransient<HomePage>();
            builder.Services.AddTransient<CategoryListPage>();
            builder.Services.AddTransient<PlaceDetailPage>();
            builder.Services.AddTransient<RewardsPage>();
            builder.Services.AddTransient<Tartu101Page>();

#if DEBUG
            // Debug logging only in development builds
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
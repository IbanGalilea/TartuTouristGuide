using Microsoft.Extensions.Logging;
using TartuTouristGuide.Services;
using TartuTouristGuide.ViewModels;
using TartuTouristGuide.Views;

namespace TartuTouristGuide
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

            // Register Services (Singleton pour partager l'état)
            builder.Services.AddSingleton<VisitedPlacesService>();

            // Register ViewModels (Transient pour créer une nouvelle instance à chaque fois)
            builder.Services.AddTransient<HomeViewModel>();
            builder.Services.AddTransient<CategoryListViewModel>();
            builder.Services.AddTransient<PlaceDetailViewModel>();
            builder.Services.AddTransient<RewardsViewModel>();

            // Register Views (Transient)
            builder.Services.AddTransient<HomePage>();
            builder.Services.AddTransient<CategoryListPage>();
            builder.Services.AddTransient<PlaceDetailPage>();
            builder.Services.AddTransient<RewardsPage>();
            builder.Services.AddTransient<Tartu101Page>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
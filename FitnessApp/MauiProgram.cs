using FitnessApp.Services.Interface;
using FitnessApp.Services.Repository;
using FitnessApp.ViewModels;
using FitnessApp.Views;
using Microcharts.Maui;
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace FitnessApp
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
                }).ConfigureSyncfusionCore().UseMicrocharts();
            
            //Dependency injection resolve
            builder.Services.AddSingleton<IWorkoutRepository, WorkoutRepository>();
            builder.Services.AddSingleton<ISessionRepository, SessionRepository>();
            //Pages
            builder.Services.AddSingleton<SessionsPage>();
            builder.Services.AddSingleton<WorkoutsPage>();
           

            // View Models / Controllers
            builder.Services.AddSingleton<WorkoutsPageViewModel>();
            builder.Services.AddSingleton<SessionsPageViewModel>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

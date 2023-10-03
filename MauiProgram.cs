using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using CS341Lab3.Model.Interfaces;
using CS341Lab3.Model;
/**
Name: Joshua T. Hill
Description: Lab 3
Date: 9/26/2023
Bugs: none known
Reflection: Happy to move into using SQL instead of a flat file for the database.
*/
namespace CS341Lab3
{
    /// <summary>
    /// Launch point for application.
    /// </summary>
    public static class MauiProgram
    {
        public static IBusinessLogic BusinessLogic = new BusinessLogic();

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
            return builder.Build();
        }
    }
}
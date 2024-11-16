using Microsoft.Extensions.Logging;

namespace MauiAppEventoFelipe
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
                    fonts.AddFont("RubikWetPaint-Regular.ttf", "RubikWetPaintRegular");
                    fonts.AddFont("PlaywriteGBS-VariableFont_wght.ttf", "PlaywriteGBSVariableFontwght");

                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

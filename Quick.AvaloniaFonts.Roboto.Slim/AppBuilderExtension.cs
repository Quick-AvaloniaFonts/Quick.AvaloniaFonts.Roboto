using Avalonia.Media;

namespace Avalonia;

public static class AppBuilderExtension
{
    public static AppBuilder WithFont_Roboto(this AppBuilder appBuilder)
    {
        var uri = "avares://Quick.AvaloniaFonts.Roboto.Slim/Assets/Fonts#Roboto";
        return appBuilder.With(new FontManagerOptions()
        {
            DefaultFamilyName = uri,
            FontFallbacks = new[] { new FontFallback { FontFamily = new FontFamily(uri) } }
        });
    }
}
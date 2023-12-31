# Quick.AvaloniaFonts.Roboto
* Roboto fonts for Avalonia
* Full version： [![NuGet Downloads](https://img.shields.io/nuget/dt/Quick.AvaloniaFonts.Roboto.svg)](https://www.nuget.org/packages/Quick.AvaloniaFonts.Roboto/)
* Slim version： [![NuGet Downloads](https://img.shields.io/nuget/dt/Quick.AvaloniaFonts.Roboto.Slim.svg)](https://www.nuget.org/packages/Quick.AvaloniaFonts.Roboto.Slim/)

How to use
-------------
Replace ***.WithInterFont()*** to ***.WithFont_Roboto()*** in Program.cs

Example
-------------
```
using Avalonia;
using System;

namespace TestApp;

class Program
{
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args) => BuildAvaloniaApp()
        .StartWithClassicDesktopLifetime(args);

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            //.WithInterFont()()
            .WithFont_Roboto()
            .LogToTrace();
}
```

using BlazorGtkApp;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddGtkBlazorWebView();
#if DEBUG
services.AddBlazorWebViewDeveloperTools();
#endif

var sp = services.BuildServiceProvider();

var app = new App(sp);
return app.Run(args);
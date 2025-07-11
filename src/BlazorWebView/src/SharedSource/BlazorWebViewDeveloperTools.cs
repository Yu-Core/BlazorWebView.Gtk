#if WEBVIEW2_WINFORMS
namespace Microsoft.AspNetCore.Components.WebView.WindowsForms
#elif WEBVIEW2_WPF
namespace Microsoft.AspNetCore.Components.WebView.Wpf
#elif WEBKIT_GTK
namespace Microsoft.AspNetCore.Components.WebView.Gtk
#elif WEBVIEW2_MAUI
namespace Microsoft.AspNetCore.Components.WebView.Maui
#else
#error Must define WEBVIEW2_WINFORMS, WEBVIEW2_WPF, WEBVIEW2_MAUI
#endif
{
    // from https://github.com/jsuarezruiz/maui-linux/blob/main/src/BlazorWebView/src/SharedSource/BlazorWebViewDeveloperTools.cs
    internal class BlazorWebViewDeveloperTools
    {
        public bool Enabled { get; set; } = false;
    }
}

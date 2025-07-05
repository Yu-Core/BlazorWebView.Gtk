using WebKit;

namespace Microsoft.AspNetCore.Components.WebView.Gtk
{
    public class BlazorWebViewWebResourceRequestedEventArgs
    {
        public BlazorWebViewWebResourceRequestedEventArgs(URISchemeRequest request)
        {
            Request = request;
        }

        public URISchemeRequest Request { get; }

        public bool Handled { get; set; }
    }
}

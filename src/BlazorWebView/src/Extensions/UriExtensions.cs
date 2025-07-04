namespace Microsoft.AspNetCore.Components.WebView.Gtk
{
    // from https://github.com/dotnet/maui/blob/main/src/BlazorWebView/src/Maui/Extensions/UriExtensions.cs
    internal static class UriExtensions
    {
        internal static bool IsBaseOfPage(this Uri baseUri, string? uriString)
        {
            if (Path.HasExtension(uriString))
            {
                // If the path ends in a file extension, it's not referring to a page.
                return false;
            }

            var uri = new Uri(uriString!);
            return baseUri.IsBaseOf(uri);
        }
    }
}

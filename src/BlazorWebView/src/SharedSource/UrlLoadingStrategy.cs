namespace Microsoft.AspNetCore.Components.WebView
{
    /// <summary>
    /// URL loading strategy for anchor tags <![CDATA[<a>]]> within a Blazor WebView.
    /// from https://github.com/jsuarezruiz/maui-linux/blob/main/src/BlazorWebView/src/SharedSource/UrlLoadingStrategy.cs
    /// 
    /// Anchor tags with target="_blank" will always open in the default
    /// browser and the UrlLoading event won't be called.
    /// </summary>
    public enum UrlLoadingStrategy
    {
        /// <summary>
        /// Allows loading URLs using an app determined by the system.
        /// This is the default strategy for URLs with an external host.
        /// </summary>
        OpenExternally,

        /// <summary>
        /// Allows loading URLs within the Blazor WebView.
        /// This is the default strategy for URLs with a host matching the app origin.
        /// <para>
        /// This strategy should not be used for external links unless you can ensure they are fully trusted.
        /// </para>
        /// </summary>
        OpenInWebView,

        /// <summary>
        /// Cancels the current URL loading attempt.
        /// </summary>
        CancelLoad
    }
}

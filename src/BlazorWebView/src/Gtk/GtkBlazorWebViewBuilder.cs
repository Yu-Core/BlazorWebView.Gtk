// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.AspNetCore.Components.WebView.Gtk
{
    // from https://github.com/jsuarezruiz/maui-linux/blob/main/src/BlazorWebView/src/Gtk/GtkBlazorWebViewBuilder.cs
    internal class GtkBlazorWebViewBuilder : IGtkBlazorWebViewBuilder
    {
        public IServiceCollection Services { get; }

        public GtkBlazorWebViewBuilder(IServiceCollection services)
        {
            Services = services;
        }
    }
}

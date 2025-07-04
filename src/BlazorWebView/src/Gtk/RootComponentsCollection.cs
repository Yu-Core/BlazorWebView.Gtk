// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Components.Web;
using System.Collections.ObjectModel;

namespace Microsoft.AspNetCore.Components.WebView.Gtk
{
    /// <summary>
    /// A collection of <see cref="RootComponent"/> items.
    /// </summary>
    public class RootComponentsCollection : ObservableCollection<RootComponent>, IJSComponentConfiguration
    {
        /// <inheritdoc />
        public JSComponentConfigurationStore JSComponents { get; } = new();
    }

}

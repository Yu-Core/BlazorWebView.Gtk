using Gio;

namespace BlazorGtkApp
{
    public class App
    {
        private const string applicationId = "com.yucore.blazorgtkapp";

        private readonly Gtk.Application app;

        private readonly IServiceProvider _serviceProvider;

        private Gtk.ApplicationWindow? window;

        public App(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;

            app = Gtk.Application.New(applicationId, Gio.ApplicationFlags.NonUnique);
            GLib.Functions.SetPrgname("BlazorGtkApp");
            // Set the human-readable application name for app bar and task list.
            GLib.Functions.SetApplicationName("BlazorGtkApp");
            app.OnActivate += ApplicationActivate;
        }

        private void ApplicationActivate(Application sender, EventArgs args)
        {
            window = new MainWindow(app, _serviceProvider);
            window.Show();
        }

        public int Run(string[] args)
        {
            try
            {
                string[] argv = [applicationId, .. args];
                return app.RunWithSynchronizationContext(argv);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                return -1;
            }
        }
    }
}

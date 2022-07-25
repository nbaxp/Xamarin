using EmbedIO;
using System.Threading.Tasks;
using xamarin.Rersources;
using Xamarin.Forms;

namespace xamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Task.Factory.StartNew(async () =>
            {
                var options = new WebServerOptions()
                .WithMode(HttpListenerMode.Microsoft)
                .WithUrlPrefix("http://*:8080");
                using (var server = new WebServer(options))
                {
                    server.WithEmbeddedResources("/xamarin/", typeof(Resource).Assembly, "xamarin.Rersources.nodejs.dist");
                    await server.RunAsync();
                }
            });
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
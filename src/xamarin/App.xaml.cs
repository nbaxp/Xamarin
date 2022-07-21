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
                using (var server = new WebServer(HttpListenerMode.EmbedIO, "http://*:8080"))
                {
                    server.WithEmbeddedResources("/", typeof(Resource).Assembly, "xamarin.Rersources.nodejs.dist");
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
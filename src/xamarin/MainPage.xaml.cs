using EmbedIO;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.webView.Source = "http://localhost:8080/";
        }
    }
}
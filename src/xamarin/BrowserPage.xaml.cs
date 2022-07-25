using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BrowserPage : ContentPage
    {
        public BrowserPage()
        {
            InitializeComponent();
            this.webview.Navigating += Webview_Navigating;
            this.button.Clicked += Button_Clicked;
            this.webview.Source = this.editor.Text.Trim();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            this.webview.Source = this.editor.Text.Trim();
        }

        private void Webview_Navigating(object sender, WebNavigatingEventArgs e)
        {
            if (!e.Url.StartsWith("http"))
            {
                e.Cancel = true;
            }
        }
    }
}
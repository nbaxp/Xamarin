using System;
using Xamarin.Forms;

namespace xamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.webView.Navigating += WebView_Navigating;
            this.webView.Source = "http://localhost:8080/";
        }

        private async void WebView_Navigating(object sender, WebNavigatingEventArgs e)
        {
            if (e.Url.StartsWith("http://internal.com/"))
            {
                e.Cancel = true;
                var builder = new UriBuilder(e.Url);
                if (builder.Path == "/test")
                {
                    await this.Navigation.PushModalAsync(new BrowserPage());
                }
            }
        }
    }
}
using Xamarin.Forms;
using Xamarin.Forms.Vonage;
using BrunoTestApp.Message;

namespace BrunoTestApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ButtonProducts.Clicked += ButtonProducts_Clicked;
            ButtonSupport.Clicked += ButtonSupport_Clicked;
        }

        private async void ButtonProducts_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ProductsPage());
        }

        private async void ButtonSupport_Clicked(object sender, System.EventArgs e)
        {
            if (!CrossVonage.Current.TryStartSession())
                Msg.Show("Service is temporarily unavailable, please try again later");

            await Navigation.PushAsync(new SupportPage());
        }
    }
}

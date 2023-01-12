using Xamarin.Forms;
using Xamarin.Forms.Vonage;

namespace BrunoTestApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ButtonProducts.Clicked += async delegate
            {
                await Navigation.PushAsync(new ProductsPage());
            };

            ButtonSupport.Clicked += async delegate
            {
                if (!CrossVonage.Current.TryStartSession())
                {
                    return;
                }

                await Navigation.PushAsync(new SupportPage());
            };
        }
    }
}

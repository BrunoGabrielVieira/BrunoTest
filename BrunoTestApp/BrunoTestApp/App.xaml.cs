using System;
using Xamarin.Forms;
using Xamarin.Forms.Vonage;
using Xamarin.Forms.Xaml;

namespace BrunoTestApp
{
    public partial class App : Application
    {
        public const string API_BASE_ADDRESS = "";
        public const string VONAGE_API_KEY = "";
        public const string VONAGE_USER_TOKEN = "";
        public const string VONAGE_SESSION_ID = "";

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            CrossVonage.Current.ApiKey = App.VONAGE_API_KEY;
            CrossVonage.Current.UserToken = App.VONAGE_USER_TOKEN;
            CrossVonage.Current.SessionId = App.VONAGE_SESSION_ID;
            CrossVonage.Current.ErrorOccurred += (sender, args) => MainPage.DisplayAlert("ERROR", args.Message, "OK");
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

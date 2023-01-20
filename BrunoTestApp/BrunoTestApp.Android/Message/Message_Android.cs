using Android.Widget;
using BrunoTestApp.Droid.Message;
using BrunoTestApp.Message;

[assembly: Xamarin.Forms.Dependency(typeof(Message_Android))]
namespace BrunoTestApp.Droid.Message
{
    public class Message_Android : IMessage
    {
        public void Show(string message)
        {
            Android.Widget.Toast.MakeText(Android.App.Application.Context, message, ToastLength.Long).Show();
        }
    }
}

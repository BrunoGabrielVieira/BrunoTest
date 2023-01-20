using Xamarin.Forms;

namespace BrunoTestApp.Message
{
    public static class Msg
    {
        public static void Show(string message)
        {
            DependencyService.Get<IMessage>().Show(message);
        }
    }
}

using Foundation;

namespace Integracao
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => BaseClient.CreateMauiApp();
    }
}

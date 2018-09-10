using Xamarin.UITest;

namespace MobTest
{
    class AppInstaler
    {
        public static IApp StartApp(Platform platform, string pathToApp)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp.Android.ApkFile(pathToApp).StartApp();
            }
            return ConfigureApp.iOS.StartApp();
        }
    }
}

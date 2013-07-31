using System;

namespace Common
{
    public sealed class GoogleLauncherTask
    {
        public void Show()
        {
            var uri = new Uri("http://www.google.com");
            IPlatformLauncher platformLauncher = PlatformSupport<IPlatformLauncher>.Get();
            platformLauncher.Launch(uri);
        }
    }
}
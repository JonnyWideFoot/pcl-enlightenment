using System;
using Windows.System;

namespace Common.Platform
{
    public sealed class PlatformLauncher : IPlatformLauncher
    {
        public void Launch(Uri uri)
        {
            Launcher.LaunchUriAsync(uri);
        }
    }
}
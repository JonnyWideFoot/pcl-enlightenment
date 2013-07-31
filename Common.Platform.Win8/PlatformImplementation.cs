using System;
using Windows.System;

namespace Common.Platform
{
    public sealed class PlatformImplementation : IPlatformImplementation
    {
        public void Launch(Uri uri)
        {
            Launcher.LaunchUriAsync(uri);
        }
    }
}
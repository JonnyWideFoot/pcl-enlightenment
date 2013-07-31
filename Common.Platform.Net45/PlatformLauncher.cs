using System;
using System.Diagnostics;

namespace Common.Platform
{
    public sealed class PlatformLauncher : IPlatformLauncher
    {
        public void Launch(Uri uri)
        {
            Process.Start(uri.OriginalString);
        }
    }
}
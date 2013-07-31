using System;
using System.Diagnostics;

namespace Common.Platform
{
    public sealed class PlatformImplementation : IPlatformImplementation
    {
        public void Launch(Uri uri)
        {
            Process.Start(uri.OriginalString);
        }
    }
}
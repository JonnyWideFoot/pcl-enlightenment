using System;

namespace Common
{
    public interface IPlatformLauncher
    {
        void Launch(Uri url);
    }
}
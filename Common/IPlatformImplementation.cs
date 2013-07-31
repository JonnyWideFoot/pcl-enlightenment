using System;

namespace Common
{
    public interface IPlatformImplementation
    {
        void Launch(Uri url);
    }
}
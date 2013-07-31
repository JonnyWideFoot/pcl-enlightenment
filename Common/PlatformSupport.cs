using System;
using System.Reflection;

namespace Common
{
    /// <summary>
    /// http://stackoverflow.com/questions/17943929/portable-class-libraries-and-webbrowsertask-vs-windows-system-launcher/17946086
    /// http://blog.stephencleary.com/2012/11/portable-class-library-enlightenment.html
    /// </summary>
    public static class PlatformSupport<T> where T : class
    {
        private static T _cached;

        public static T Get()
        {
            if (_cached == null)
            {
                // Starting from our core assembly, determine the matching enlightenment assembly (with the same version/strong name if applicable)
                var enlightenmentAssemblyName = new AssemblyName(typeof(IPlatformImplementation).FullName)
                {
                    Name = "Common.Platform",
                };

                // Attempt to load the enlightenment provider from that assembly.
                string interfaceName = typeof(T).FullName;
                interfaceName = interfaceName.Replace("Common.I", "Common.Platform.");
                interfaceName = interfaceName + ", " + enlightenmentAssemblyName.FullName;
                Type enlightenmentProviderType = Type.GetType(interfaceName, false);

                if (enlightenmentProviderType == null)
                {
                    throw new InvalidOperationException("Unable to load platform abstraction");
                }

                _cached = (T) Activator.CreateInstance(enlightenmentProviderType);
            }

            return _cached;
        }
    }
}
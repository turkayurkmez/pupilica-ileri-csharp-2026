using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Display.SDK
{
    public static class Helper
    {
        public static List<Plug> GetPlugs(string selectepPath)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(nameof(selectepPath));

            if (!Directory.Exists(selectepPath))
            {
                throw new FileNotFoundException();
            }

            List<Plug> plugs = getPluginsInPath(selectepPath);
            return plugs;
        }

        private static List<Plug> getPluginsInPath(string selectepPath)
        {
            //Belirtilen klasördeki dll dosyalarını referans olarak ekle:
            var dllFiles = Directory.GetFiles(selectepPath, "*.dll");
            var plugs = new List<Plug>();
            dllFiles?.ToList().ForEach(dllFile => addReference(dllFile, plugs));
            return plugs;
        }

        private static void addReference(string dllFile, List<Plug> plugs)
        {
            var assembly = Assembly.LoadFile(dllFile);
            var types = assembly.GetTypes();
            types?.ToList().ForEach(type => {
                Plug plug = handShakeForApp(type, dllFile);
                plugs.Add(plug);
            });
        }

        private static Plug handShakeForApp(Type type, string dllFile)
        {
            Plug plug = null;
            if (type.GetInterface("IPlugin") != null)
            {
                plug = new Plug();
                plug.Path = dllFile;
                plug.FullName = type.FullName;
                //Kare k = new Kare();
                var instance = Activator.CreateInstance(type);
                //plug.Name=k.Name
                plug.Name = instance!.GetType().GetProperty("Name").GetValue(instance).ToString();



            }

            return plug;
        }
    }
}

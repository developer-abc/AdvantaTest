using System.Reflection;

namespace ds.test.impl
{
    public class Plugins : PluginFactory
    {
        private static IPlugin[] _plugins = Assembly.GetExecutingAssembly().GetTypes()
                                    .Where(x => typeof(IPlugin).IsAssignableFrom(x))
                                    .Select(x => x.GetConstructor(Type.EmptyTypes)).Where(x => x != null)
                                    .Select(x => (IPlugin)x!.Invoke(null)).ToArray();

        public static int PluginsCount => _plugins.Length;

        /// <summary>
        /// Вывод имён доступных плагинов
        /// </summary>
        public static string[] GetPluginNames => _plugins.Select(x => x.PluginName).ToArray();

        /// <summary>
        /// Получение плагина по имени
        /// </summary>
        public static IPlugin GetPlugin(string pluginName)
        {
            return _plugins.First(x => x.PluginName == pluginName);
        }
    }
}
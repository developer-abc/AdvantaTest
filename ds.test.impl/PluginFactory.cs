using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    interface PluginFactory
    {
        static abstract int PluginsCount { get; }
        static abstract string[] GetPluginNames { get; }
        static abstract IPlugin GetPlugin(string pluginName);
    }
}

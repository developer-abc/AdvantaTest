using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl.PluginsList
{
    internal class PowerPlugin : AbstractPlugin, IPlugin
    {
        public override string PluginName => "Power Plugin";
        public override string Description => "This plugin raises the first number to the power of the second.";

        public override int Run(int input1, int input2)
        {
            return (int)Math.Pow(input1, input2);
        }
    }

}

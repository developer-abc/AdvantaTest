using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl.PluginsList
{
    internal class AdditionPlugin : AbstractPlugin, IPlugin
    {
        public override string PluginName => "Addition Plugin";
        public override string Description => "This plugin adds two numbers.";

        public override int Run(int input1, int input2)
        {
            return input1 + input2;
        }
    }

}

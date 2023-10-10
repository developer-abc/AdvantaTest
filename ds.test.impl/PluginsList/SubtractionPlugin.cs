using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl.PluginsList
{
    internal class SubtractionPlugin : AbstractPlugin, IPlugin
    {
        public override string PluginName => "Subtraction Plugin";
        public override string Description => "This plugin subtracts the second number from the first.";

        public override int Run(int input1, int input2)
        {
            return input1 - input2;
        }
    }

}

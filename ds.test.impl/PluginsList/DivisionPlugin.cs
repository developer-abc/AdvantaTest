using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl.PluginsList
{
    internal class DivisionPlugin : AbstractPlugin, IPlugin
    {
        public override string PluginName => "Division Plugin";
        public override string Description => "This plugin divides the first number by the second.";

        public override int Run(int input1, int input2)
        {
            if (input2 == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            return input1 / input2;
        }
    }

}

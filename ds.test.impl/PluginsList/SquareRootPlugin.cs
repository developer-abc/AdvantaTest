using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl.PluginsList
{
    internal class SquareRootPlugin : AbstractPlugin, IPlugin
    {
        public  override string PluginName => "Square Root Plugin";
        public override string Description => "This plugin calculates the square root of the first number.";

        public override int Run(int input1, int input2)
        {
            if (input1 < 0)
                throw new ArgumentException("Cannot calculate the square root of a negative number.");

            return (int)Math.Sqrt(input1);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    abstract class AbstractPlugin : IPlugin
    {
        public virtual string PluginName => this.GetType().Name;
        public virtual string Version => "1.0.0.0";
        public virtual System.Drawing.Image Image { get; protected set; }
        public virtual string Description => this.GetType().Name;

        public abstract int Run(int input1, int input2);
    }
}

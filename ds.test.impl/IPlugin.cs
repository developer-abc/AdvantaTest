using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    public interface IPlugin
    {
        /// <summary>
        /// Имя плагина
        /// </summary>
        string PluginName { get; }
        /// <summary>
        /// Версия плагина
        /// </summary>
        string Version { get; }
        System.Drawing.Image Image { get; }
        /// <summary>
        /// Описание плагина
        /// </summary>
        string Description { get; }
        /// <summary>
        /// Выполнение операции с помощью плагина
        /// </summary>
        int Run(int input1, int input2);
    }
}

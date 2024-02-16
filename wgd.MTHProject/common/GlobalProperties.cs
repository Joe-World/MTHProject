using ModbusTCPLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wgd.MTHModels;

namespace wgd.MTHProject.common
{
    public class GlobalProperties
    {
        public static Device Device { set; get; }

        public static Action<int, string> AddLog;

        public static ModbusTCP Modbus { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wgd.MTHDAL;
using wgd.MTHModels;

namespace wgd.MTHBLL
{
    public class SysLogManage
    {
        private SysLogService sysLogService = new SysLogService();

        public bool AddSysLog(SysLog sysLog)
        {
            return sysLogService.AddSysLog(sysLog) == 1;
        }
        public DataTable QuerySysLogByCondition(string start, string end, string alarmType)
        {
            return sysLogService.QuerySysLogByCondition(start, end, alarmType);
        }
    }
}

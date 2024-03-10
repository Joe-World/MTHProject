using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wgd.MTHDAL;
using wgd.MTHModels;

namespace wgd.MTHBLL
{
    public class SysAmdinManage
    {
        private SysAdminService sysAdminService = new SysAdminService();

        public SysAdmin AdminLogin(SysAdmin sysAdmin)
        {
            return sysAdminService.Login(sysAdmin);
        }
    }
}

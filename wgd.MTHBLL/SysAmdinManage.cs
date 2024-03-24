using System.Collections.Generic;
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

        public bool AddSysAdmin(SysAdmin sysAdmin)
        {
            return sysAdminService.AddSysAdmin(sysAdmin) == 1;
        }

        public bool DeleteSysAdmin(int loginld)
        {
            return sysAdminService.DeleteSysAdmin(loginld) == 1;
        }

        public bool ModifysysAdmin(SysAdmin sysAdmin)
        {
            return sysAdminService.ModifySysAdmin(sysAdmin) == 1;
        }
        public List<SysAdmin> QuerySysAdmins()
        {
            return sysAdminService.QuerySysAdmins();

        }
    }
}

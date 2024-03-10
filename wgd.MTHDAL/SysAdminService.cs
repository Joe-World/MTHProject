using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wgd.MTHModels;

namespace wgd.MTHDAL
{
    public class SysAdminService
    {
        public SysAdmin Login(SysAdmin sysAdmin)
        {
            string sql = "Select LoginId, ParamSet,Recipe,HistoryLog,HistoryTrend,UserManage";
            sql += " from SysAdmin where LoginName=@LoginName and LoginPwd=@LoginPwd";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@LoginName", sysAdmin.LoginName),
                new SqlParameter("@LoginPwd", sysAdmin.LoginPwd),
            };
            DataSet dataSet = SQLHelper.GetDataSet(sql, parameters);
            if (dataSet != null && dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count == 1)
            {
                sysAdmin.Loginld = Convert.ToInt32(dataSet.Tables[0].Rows[0]["Loginid"]);
                sysAdmin.ParamSet = Convert.ToBoolean(dataSet.Tables[0].Rows[0]["ParamSet"]);
                sysAdmin.Recipe = Convert.ToBoolean(dataSet.Tables[0].Rows[0]["Recipe"]);
                sysAdmin.HistoryLog = Convert.ToBoolean(dataSet.Tables[0].Rows[0]["HistoryLog"]);
                sysAdmin.HistoryTrend = Convert.ToBoolean(dataSet.Tables[0].Rows[0]["HistoryTrend"]);
                sysAdmin.UserManage = Convert.ToBoolean(dataSet.Tables[0].Rows[0]["UserManage"]);
                return sysAdmin;

            }
            else
            {
                return null;
            }
        }


    }
}

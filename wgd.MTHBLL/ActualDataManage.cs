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
    public class ActualDataManage
    {
        private ActualDataService actualDataServicee = new ActualDataService();

        public bool AddActualData(ActualData actualData)
        {
            return actualDataServicee.AddActualData(actualData) == 1;
        }

        public DataTable QueryActualDataByCondition(string start, string end, List<string> columns)
        {
            return actualDataServicee.QueryActualDataByCondition(start, end, columns);
        }

    }
}

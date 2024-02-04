using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thinger.MTHModels
{
    public class Group
    {
        /// <summary>
        /// 通信组名称
        /// </summary>
        public string GroupName { set; get; }

        /// <summary>
        /// 起始地址
        /// </summary>
        public ushort Start { set; get; }
        /// <summary>
        /// 长度
        /// </summary>
        public ushort Length { get; set; }
        /// <summary>
        /// 存储区名称
        /// </summary>
        public string StoreArea { get; set; }
        /// <summary>
        /// 备注说明
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 变量集合
        /// </summary>
        /// 
        /*[ExcelIgnore]*/
        public List<Variable> VarList { get; set; }
    }
}

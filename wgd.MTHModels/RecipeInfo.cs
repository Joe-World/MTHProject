using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wgd.MTHModels
{
    public class RecipeInfo
    {
        /// <summary>
        /// 配方名称
        /// </summary>
        public string RecipeName { get; set; }

        /// <summary>
        /// 6个站点配方数据
        /// </summary>
        public List<RecipeParam> RecipeParams { get; set; } = new List<RecipeParam>();

    }
}

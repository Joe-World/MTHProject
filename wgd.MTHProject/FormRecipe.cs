
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wgd.MTHModels;
using wgd.Utils;

namespace wgd.MTHProject
{
    public partial class FormRecipe : Form
    {
        public FormRecipe()
        {
            InitializeComponent();
        }

        private string basePath = Application.StartupPath + "\\Recipe";


        #region 获取配方对象
        private RecipeInfo GetRecipelnfo()
        {
            RecipeInfo info = new RecipeInfo()
            {
                RecipeName = this.TextERecipe.Text.Trim(),
                RecipeParams = new List<RecipeParam>
                {
                    this.recipeControl1.RecipeParam,
                    this.recipeControl2.RecipeParam,
                    this.recipeControl3.RecipeParam,
                    this.recipeControl4.RecipeParam,
                    this.recipeControl5.RecipeParam,
                    this.recipeControl6.RecipeParam,
                }
            };

            return info;
        }
        #endregion


        #region 添加配方
        private void AddRecipe(RecipeInfo recipelnfo)
        {
            string path = basePath + "\\" + recipelnfo.RecipeName + ".ini";
            IniHelper.Write("配方", "配方数据", JsonHelper.ObjectToJSON(recipelnfo), path);
        }
        #endregion


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var recipelnfo = GetRecipelnfo();
            try
            {
                AddRecipe(recipelnfo);
            }
            catch (Exception exception)
            {
                new FormMsgBoxWithoutAck($"配方添加失败:{exception.Message}", "添加配方").Show();
                return;
            }
            new FormMsgBoxWithoutAck("配方添加成功!", "添加配方").Show();

        }
    }
}


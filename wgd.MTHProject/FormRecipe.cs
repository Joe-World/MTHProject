
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            
            RefreshRecipe();
        }

        private string basePath = Application.StartupPath + "\\Recipe";
        private List<RecipeInfo> recipelnfos = new List<RecipeInfo>();

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

            RefreshRecipe();
            new FormMsgBoxWithoutAck("配方添加成功!", "添加配方").Show();
        }

        #region 更新配方列表
        private void RefreshRecipe()
        {
            recipelnfos = GetAllRecipe();
            if (recipelnfos.Count > 0)
            {
                this.DgvData.Rows.Clear();
                for (int i = 0; i < recipelnfos.Count; i++)
                {
                    this.DgvData.Rows.Add();
                    this.DgvData.Rows[i].Cells[0].Value = (i + 1).ToString();
                    this.DgvData.Rows[i].Cells[1].Value = recipelnfos[i].RecipeName;
                }
            }
        }
        #endregion

        #region 获取所有配方
        private List<RecipeInfo> GetAllRecipe()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(basePath);
            List<FileInfo> filelnfos = directoryInfo.GetFiles("*.ini").ToList();
            List<RecipeInfo> recipelnfos = new List<RecipeInfo>();
            foreach (var item in filelnfos)
            {
                recipelnfos.Add(GetRecipe(item.FullName));
            }
            return recipelnfos;
        }
        #endregion

        #region 文件变对象
        private RecipeInfo GetRecipe(string path)
        {
            var a = IniHelper.Read("配方", "配方数据", path);
            return JsonHelper.JSONToObject<RecipeInfo>(IniHelper.Read("配方", "配方数据", path));
        }
        #endregion
    }

}




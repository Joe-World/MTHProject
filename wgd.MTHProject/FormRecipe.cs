
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
using thinger.DataConvertLib;
using wgd.MTHModels;
using wgd.MTHProject.common;
using wgd.Utils;

namespace wgd.MTHProject
{
    public partial class FormRecipe : Form
    {
        public FormRecipe(string devicePath)
        {
            InitializeComponent();
            this.DevPath = devicePath;
            string currentRecipe = GlobalProperties.Device.CurrentRecipe;
            this.LabRecipeName.Text = currentRecipe;
            this.TextERecipe.Text = currentRecipe;

            RefreshRecipe();

            
           
        }

        private string DevPath = String.Empty;
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
            // 非空验证
            if (this.TextERecipe.Text.Trim().Length == 0)
            {
                new FormMsgBoxWithoutAck("配方名称为空,请检查!", "添加配方").Show();
                return;
            }
            var info = recipelnfos.Where(c => c.RecipeName == this.TextERecipe.Text.Trim()).FirstOrDefault();
            if (info != null)
            {
                new FormMsgBoxWithoutAck("当前配方名称已存在,请检查!", "添加配方").Show();
                return;
            }


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

                    if (this.TextERecipe.Text == recipelnfos[i].RecipeName)
                    {
                        this.DgvData.Rows[i].Selected = true;
                    }
                    else
                    {
                        this.DgvData.Rows[i].Selected = false;
                    }

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

        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            // 非空验证
            if (this.TextERecipe.Text.Trim().Length == 0)
            {
                new FormMsgBoxWithoutAck("配方名称为空,请检查!", "修改配方").Show();
                return;
            }
            var info = recipelnfos.Where(c => c.RecipeName == this.TextERecipe.Text.Trim()).FirstOrDefault();
            if (info == null)
            {
                new FormMsgBoxWithoutAck("当前配方名称不存在,请检查!", "修改配方").Show();
                return;
            }


            var recipelnfo = GetRecipelnfo();
            try
            {
                AddRecipe(recipelnfo);
            }
            catch (Exception exception)
            {
                new FormMsgBoxWithoutAck($"配方修改失败:{exception.Message}", "修改配方").Show();
                return;
            }

            RefreshRecipe();
            new FormMsgBoxWithoutAck("配方修改成功!", "修改配方").Show();
        }



        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // 非空验证
            if (this.TextERecipe.Text.Trim().Length == 0)
            {
                new FormMsgBoxWithoutAck("配方名称为空,请检查!", "删除配方").Show();
                return;
            }
            var info = recipelnfos.Where(c => c.RecipeName == this.TextERecipe.Text.Trim()).FirstOrDefault();
            if (info == null)
            {
                new FormMsgBoxWithoutAck("当前配方名称不存在,请检查!", "删除配方").Show();
                return;
            }

            DialogResult dialogResult = new FormMsgBoxWithAck("是否确定要删除该配方?", "删除配方").ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                bool result = DeleteRecipe(this.TextERecipe.Text.Trim());
                if (result)
                {
                    RefreshRecipe();
                    new FormMsgBoxWithoutAck("配方删除成功!", "删除配方").Show();
                }
                else
                {

                    new FormMsgBoxWithoutAck("配方删除失败!", "删除配方").Show();
                }
            }
        }

        #region 删除配方
        private bool DeleteRecipe(string recipeName)
        {
            try
            {
                File.Delete(basePath + "\\" + recipeName + ".ini");
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        #endregion


        #region 显示当前配方
        private void SetRecipelnfo(RecipeInfo recipelnfo)
        {
            this.TextERecipe.Text = recipelnfo.RecipeName;
            if (recipelnfo.RecipeParams.Count == 6)
            {
                this.recipeControl1.RecipeParam = recipelnfo.RecipeParams[0];
                this.recipeControl2.RecipeParam = recipelnfo.RecipeParams[1];
                this.recipeControl3.RecipeParam = recipelnfo.RecipeParams[2];
                this.recipeControl4.RecipeParam = recipelnfo.RecipeParams[3];
                this.recipeControl5.RecipeParam = recipelnfo.RecipeParams[4];
                this.recipeControl6.RecipeParam = recipelnfo.RecipeParams[5];
            }
        }
        #endregion

        private void DgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var recipelnfo = recipelnfos[e.RowIndex];
                SetRecipelnfo(recipelnfo);
            }
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            // 非空验证
            if (this.TextERecipe.Text.Trim().Length == 0)
            {
                new FormMsgBoxWithoutAck("配方名称为空,请检查!", "应用配方").Show();
                return;
            }
            var info = recipelnfos.Where(c => c.RecipeName == this.TextERecipe.Text.Trim()).FirstOrDefault();
            if (info == null)
            {
                new FormMsgBoxWithoutAck("当前配方名称不存在,无法应用!", "应用配方").Show();
                return;
            }
            if
            (!GlobalProperties.Device.IsConnected)
            {
                new FormMsgBoxWithoutAck("请检查设备是否连接正常!", "应用配方").Show();
                return;
            }

            if (info.RecipeParams.Count == 6)
            {
                List<short> values = new List<short>();
                // 添加温度和湿度的高低限
                for (int i = 0; i < 6; i++)
                {
                    values.Add(Convert.ToInt16(info.RecipeParams[i].TempHigh * 10));
                    values.Add(Convert.ToInt16(info.RecipeParams[i].TempLow * 10));
                    values.Add(Convert.ToInt16(info.RecipeParams[i].HumidityHigh * 10));
                    values.Add(Convert.ToInt16(info.RecipeParams[i].HumidityLow * 10));
                }

                // 继续添加报警启用
                for (int i = 0; i < 6; i++)
                {
                    values.Add(info.RecipeParams[i].TempAlarmEnable ? (short)1 : (short)0);
                    values.Add(info.RecipeParams[i].HumidityAlarmEnable ? (short)1 : (short)0);
                }

                bool result = GlobalProperties.Modbus.PreSetMultiRegister(42, ByteArrayLib.GetByteArrayFromShortArray(values.ToArray(), GlobalProperties.dataFormat));
                if (result)
                {
                    string recipeName = this.TextERecipe.Text.Trim();
                    IniHelper.Write("配方参数", "当前配方", recipeName, DevPath);
                    GlobalProperties.Device.CurrentRecipe = recipeName;
                    this.LabRecipeName.Text = recipeName;

                    new FormMsgBoxWithoutAck("配方数据写入成功!", "应用配方").Show();
                }
                else
                {
                    new FormMsgBoxWithoutAck("配方数据写入失败,请检查!", "应用配方").Show();
                }

            }
            else
            {
                new FormMsgBoxWithoutAck("配方数据不完整,请检查!", "应用配方").Show();
            }
        }


    }
}





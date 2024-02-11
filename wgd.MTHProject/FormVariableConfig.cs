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
using MiniExcelLibs;

namespace wgd.MTHProject
{
    public partial class FormVariableConfig : Form
    {
        public FormVariableConfig()
        {
            InitializeComponent();

            TotalGroup = GetAllGroup();
            if (TotalGroup.Count > 0)
            {
                foreach (var item in TotalGroup)
                {
                    this.CmbGroupName.Items.Add(item.GroupName);
                }
                this.CmbGroupName.SelectedIndex = 0;
            }
            this.CmbDataType.DataSource = Enum.GetNames(typeof(DataType));
            this.DgvData.AutoGenerateColumns = false;

            TotalVar = GetAllVar();
            RefeVar();
        }

        private List<Group> TotalGroup = new List<Group>();
        private List<Variable> TotalVar = new List<Variable>();
        private string GroupPath = Application.StartupPath + "\\Config\\Group.xlsx";
        private string VarPath = Application.StartupPath + "\\Config\\Var.xlsx";

        private List<Group> GetAllGroup()
        {
            // 防止空集合异常
            try
            {
                return MiniExcel.Query<Group>(GroupPath).ToList();
            }
            catch (Exception)
            {
                return new List<Group>();
            }
        }
        private List<Variable> GetAllVar()
        {
            // 防止空集合异常
            try
            {
                return MiniExcel.Query<Variable>(VarPath).ToList();
            }
            catch (Exception)
            {
                return new List<Variable>();
            }
        }
        private void RefeVar()
        {
            // 不要给dasouce一个空集合
            if (TotalVar != null && TotalVar.Count > 0)
            {
                this.DgvData.DataSource = null;
                this.DgvData.DataSource = TotalVar;
            }
            else
            {
                this.DgvData.DataSource = null;
            }
        }

        private bool VarIsExit(string varName)
        {
            return TotalVar.FindAll(v => v.VarName == varName).ToList().Count > 0;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string varName = this.TextVarName.Text.Trim();
            if (this.TextVarName.Text.Trim().Length == 0)
            {
                new FormMsgBoxWithoutAck("变量名不能为空!", "添加变量").Show();
                return;
            }
            if (VarIsExit(varName))
            {
                new FormMsgBoxWithoutAck("变量名已经存在!", "添加变量").Show();
                return;
            }
            TotalVar.Add(new Variable()
            {
                VarName = this.TextVarName.Text.Trim(),
                Start = (ushort)this.NumStart.Value,
                OffsetOrLength = Convert.ToUInt16(this.NumLength.Value),
                DataType = this.CmbDataType.Text.Trim(),
                GroupName = this.CmbGroupName.Text.Trim(),
                PosAlarm = this.CheckPosAlarm.Checked,
                NegAlarm = this.CheckNegAlarm.Checked,
                Scale = Convert.ToSingle(this.NumScale.Value),
                Offset = Convert.ToSingle(this.NumOffset.Value),
                Remark = this.TextRemark.Text.Trim()
            });

            try
            {
                MiniExcel.SaveAs(VarPath, TotalVar, overwriteFile: true);
                /*new FormMsgBoxWithoutAck("添加变量成功!", "添加变量").Show();*/
                //刷新数据
                RefeVar();
            }
            catch (Exception ex)
            {
                new FormMsgBoxWithoutAck("添加变量失败!：" + ex.Message, "添加变量").Show();
            }
        }




        /// <summary>
        /// 行绘制 生成行号，选中单元格效果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvData_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, new SolidBrush(Color.White), headerBounds, centerFormat);
        }

        /// <summary>
        /// 单元格格式化值方法 检验空字符串-替换为 “---”
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /*// 假设你要检查的列索引为 0  
            if (e.ColumnIndex == 4) // 修改为你需要检查的列索引  
            {
                // 检查单元格的值是否为DBNull或者空字符串  
                if (e.Value == null || string.IsNullOrEmpty(e.Value.ToString()))
                {
                    // 如果值为空，则设置单元格的值为 "-"  
                    e.Value = "--";
                }
            }*/
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (e.Value == null || e.Value.ToString().Length == 0)
                {
                    e.Value = "---";
                }
            }
        }




        private void DgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 点击标题会是 -1
            if (e.RowIndex >= 0)
            {
                var variable = TotalVar[e.RowIndex];
                if (variable != null)
                {
                    this.TextVarName.Text = variable.VarName;
                    this.TextRemark.Text = variable.Remark;
                    this.CmbGroupName.Text = variable.GroupName;
                    this.NumStart.Text = variable.Start.ToString();
                    this.NumLength.Text = variable.OffsetOrLength.ToString();
                    this.CmbDataType.Text = variable.DataType;
                    this.CheckPosAlarm.Checked = variable.PosAlarm;
                    this.CheckNegAlarm.Checked = variable.NegAlarm;
                    this.NumScale.Value = Convert.ToDecimal(variable.Scale);
                    this.NumOffset.Value = Convert.ToDecimal(variable.Offset);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string VariableName = this.TextVarName.Text.Trim();
            if (!VarIsExit(VariableName))
            {
                new FormMsgBoxWithoutAck("变量不存在", "删除变量").Show();
                return;
            }
            TotalVar.RemoveAll(c => c.VarName == VariableName);

            try
            {
                MiniExcel.SaveAs(VarPath, TotalVar, overwriteFile: true);
                new FormMsgBoxWithoutAck("删除变量成功:["+VariableName+"]已被删除！", "删除变量").Show();
                RefeVar();
            }
            catch (Exception ex)
            {
                new FormMsgBoxWithoutAck("删除变量失败:" + ex, "删除变量").Show();
            }
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            if (this.DgvData.SelectedRows.Count > 0)
            {
                var oldVar = TotalVar[this.DgvData.SelectedRows[0].Index];
                string VariableName = this.TextVarName.Text.Trim();
                if (oldVar.VarName != VariableName)
                {
                    new FormMsgBoxWithoutAck("变量名称不允许修改!", "删除变量").Show();
                    this.TextVarName.Text = oldVar.VarName;
                    return;
                }
               
                var variable = TotalVar.Find(c => c.VarName == VariableName);
                variable.Start = (ushort)this.NumStart.Value;
                variable.OffsetOrLength = Convert.ToUInt16(this.NumLength.Value);
                variable.DataType = this.CmbDataType.Text.Trim();
                variable.GroupName = this.CmbGroupName.Text.Trim();
                variable.PosAlarm = this.CheckPosAlarm.Checked;
                variable.NegAlarm = this.CheckNegAlarm.Checked;
                variable.Scale = Convert.ToSingle(this.NumScale.Value);
                variable.Offset = Convert.ToSingle(this.NumOffset.Value);
                variable.Remark = this.TextRemark.Text.Trim();
                try
                {
                    MiniExcel.SaveAs(VarPath, TotalVar, overwriteFile: true);
                    new FormMsgBoxWithoutAck("修改变量成功！", "修改变量").Show();
                    RefeVar();
                }
                catch (Exception ex)
                {
                    new FormMsgBoxWithoutAck("修改变量失败:" + ex, "修改变量").Show();
                }
            }
            else
            {
                new FormMsgBoxWithoutAck("未选中任何变量!", "修改变量").Show();
            }
        }

        #region 通过窗体MouseDown、MouseMove、MouseUp事件实现窗体移动
        Point point; //鼠标按下时的点
        bool isMoving = false;//标识是否拖动

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;//按下的点
            isMoving = true;//启动拖动
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && isMoving)
            {
                Point pNew = new Point(e.Location.X - point.X, e.Location.Y - point.Y);
                //Location = new Point(Location.X + pNew.X, Location.Y + pNew.Y);
                Location += new Size(pNew);
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;//停止
        }
        #endregion

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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

            this.CmbGroupName.DataSource = new string[] { "输入线圈", "输出线圈", "输入寄存器", "输出寄存器" };
            this.DgvData.AutoGenerateColumns = false;

            /*TotalGroup = GetAllGroup();
            RefeGroup();*/
        }

       /* private List<Group> TotalGroup = new List<Group>();
        private string GroupPath = Application.StartupPath + "\\Config\\Group.xlsx";

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
        private void RefeGroup()
        {
            // 不要给dasouce一个空集合
            if (TotalGroup != null && TotalGroup.Count > 0)
            {
                this.DgvData.DataSource = null;
                this.DgvData.DataSource = TotalGroup;
            }
            else
            {
                this.DgvData.DataSource = null;
            }
        }

        private bool GroupNameIsExit(string gruopName)
        {
            return TotalGroup.FindAll(g => g.GroupName == gruopName).ToList().Count > 0;
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // 获取通信组名称
            string groupName = this.TextGroupName.Text.Trim();
            
            // 判空
            if (groupName.Length == 0)
            {
                new FormMsgBoxWithoutAck("通信组名称不能为空！", "添加通信组").Show();
                return;
            }
            // 通信组名称判断重复
            if (GroupNameIsExit(groupName))
            {
                new FormMsgBoxWithoutAck("通信组名称已经存在！", "添加通信组").Show();
                return;
            }
            

            // 创建通信组实例
            TotalGroup.Add(new Group()
            {
                GroupName = groupName,
                Start = (ushort)this.NumStart.Value,
                Length = (ushort)this.NumStart.Value,
                StoreArea = this.CmbGroupName.Text.Trim(),
                Remark = this.TextRemark.Text.Trim()
            });

            try
            {
                MiniExcel.SaveAs(GroupPath, TotalGroup, overwriteFile: true);
                *//*new FormMsgBoxWithoutAck("添加通信组成功", "添加通信组").Show();*//*
                //刷新数据
                RefeGroup();
            }
            catch (Exception ex)
            {
                new FormMsgBoxWithoutAck("添加通信组失败：" + ex.Message, "添加通信组").Show();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
            *//*// 假设你要检查的列索引为 0  
            if (e.ColumnIndex == 4) // 修改为你需要检查的列索引  
            {
                // 检查单元格的值是否为DBNull或者空字符串  
                if (e.Value == null || string.IsNullOrEmpty(e.Value.ToString()))
                {
                    // 如果值为空，则设置单元格的值为 "-"  
                    e.Value = "--";
                }
            }*//*
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
                Group group = TotalGroup[e.RowIndex];
                if (group != null)
                {
                    this.TextGroupName.Text = group.GroupName;
                    this.NumStart.Value = group.Start;
                    this.NumStart.Value = group.Length;
                    this.CmbGroupName.Text = group.StoreArea;
                    this.TextRemark.Text = group.Remark;
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // 获取通信组名称
            string groupName = this.TextGroupName.Text.Trim();

            
            if (!GroupNameIsExit(groupName))
            {
                new FormMsgBoxWithoutAck("通信组不存在！", "删除通信组").Show();
                return;
            }

            TotalGroup.RemoveAll(g => g.GroupName == groupName);

            try
            {
                MiniExcel.SaveAs(GroupPath, TotalGroup, overwriteFile: true);
                //刷新数据
                RefeGroup();
            }
            catch (Exception ex)
            {
                new FormMsgBoxWithoutAck("删除通信组失败：" + ex.Message, "删除通信组").Show();
            }
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            if (this.DgvData.SelectedRows.Count > 0)
            {
                // 老通信组
                Group oldGroup = TotalGroup[this.DgvData.SelectedRows[0].Index];
                // 获取通信组名称
                string groupName = this.TextGroupName.Text.Trim();

                if (oldGroup.GroupName != groupName)
                {
                    new FormMsgBoxWithoutAck("修改通信组失败：通信组名称不允许修改!", "修改通信组").Show();
                    this.TextGroupName.Text = oldGroup.GroupName;
                    return;
                }

                var group = TotalGroup.Find(g => g.GroupName == groupName);
                *//*group.GroupName = groupName;*//*
                group.Start = (ushort)this.NumStart.Value;
                group.Length = (ushort)this.NumStart.Value;
                group.StoreArea = this.CmbGroupName.Text.Trim();
                group.Remark = this.TextRemark.Text.Trim();

                try
                {
                    MiniExcel.SaveAs(GroupPath, TotalGroup, overwriteFile: true);

                    //刷新数据
                    RefeGroup();
                }
                catch (Exception ex)
                {
                    new FormMsgBoxWithoutAck("修改通信组失败：" + ex.Message, "修改通信组").Show();
                }

            }
            else
            {
                new FormMsgBoxWithoutAck("修改通信组失败：未选中任何通信组！", "修改通信组").Show();
            }
        }*/

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

    }
}

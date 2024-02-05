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
    public partial class FormGroupConfig : Form
    {
        public FormGroupConfig()
        {
            InitializeComponent();

            this.CmbStoreArea.DataSource = new string[] { "输入线圈", "输出线圈", "输入寄存器", "输出寄存器" };
            this.DgvData.AutoGenerateColumns = false;

            TotalGroup = GetAllGroup();
            RefeGroup();
        }

        private List<Group> TotalGroup = new List<Group>();
        private string GroupPath = Application.StartupPath + "\\Config\\Group.xlsx";

        private List<Group> GetAllGroup()
        {
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
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // 获取通信组名称
            string groupName = this.TextGroupName.Text.Trim();
            // 判空
            if (groupName.Length == 0)
            {
                new FormMsgBoxWithoutAck("通信组名称不能为空", "请添加通信组").Show();
                return;
            }
            // 创建通信组实例
            TotalGroup.Add(new Group()
            {
                GroupName = groupName,
                Start = (ushort)this.NumStart.Value,
                Length = (ushort)this.NumLength.Value,
                StoreArea = this.CmbStoreArea.Text.Trim(),
                Remark = this.TextRemark.Text.Trim()
            });

            try
            {
                MiniExcel.SaveAs(GroupPath, TotalGroup, overwriteFile: true);
                new FormMsgBoxWithoutAck("添加通信组成功", "添加通信组").Show();
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

        private void DgvData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // 假设你要检查的列索引为 0  
            if (e.ColumnIndex == 4) // 修改为你需要检查的列索引  
            {
                // 检查单元格的值是否为DBNull或者空字符串  
                if (e.Value == null || string.IsNullOrEmpty(e.Value.ToString()))
                {
                    // 如果值为空，则设置单元格的值为 "-"  
                    e.Value = "--";
                }
            }
        }
    }
}

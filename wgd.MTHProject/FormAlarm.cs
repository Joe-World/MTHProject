using MiniExcelLibs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thinger.DataConvertLib;
using wgd.MTHBLL;

namespace wgd.MTHProject
{
    public partial class FormAlarm : Form
    {
        public FormAlarm()
        {
            InitializeComponent();


            this.DgvData.AutoGenerateColumns = false;
            this.CmbAlarmType.Items.AddRange(new string[] { "全部", "触发", "消除" });
            this.CmbAlarmType.SelectedIndex = 0;
            this.DateStart.Value = DateTime.Now.AddHours(-2.0f);
            this.DateEnd.Value = DateTime.Now;
        }

        private SysLogManage sysLogManage = new SysLogManage();
        private OperateResult<DataTable> QueryProcess(string start, string end, string alarmType)
        {
            //判断时间
            DateTime startTime = Convert.ToDateTime(start);
            DateTime endTime = Convert.ToDateTime(end);
            if (startTime >= endTime)
            {
                return OperateResult.CreateFailResult<DataTable>("开始时间不能大于结束时间");
            }
            TimeSpan timeSpan = endTime - startTime;
            /*if (timeSpan.TotalDays > 1.0)
            {
                return OperateResult.CreateFailResult<DataTable>("查询范围不能超过1天");
            }*/
            DataTable dataTable = sysLogManage.QuerySysLogByCondition(start, end, alarmType);
            if (dataTable != null)
            {
                return OperateResult.CreateSuccessResult(dataTable);
            }
            else
            {
                return OperateResult.CreateFailResult<DataTable>("未查询到有效数据");
            }
        }
        private void BtnQuery_Click(object sender, EventArgs e)
        {
            string start = this.DateStart.Text;
            string end = this.DateEnd.Text;
            string alarmType = this.CmbAlarmType.Text == "全部" ? "" : this.CmbAlarmType.Text;
            Task<OperateResult<DataTable>> task1 = Task.Run(() =>
            {
                return QueryProcess(start, end, alarmType);
            });

            var task2 = task1.ContinueWith(task =>
            {
                this.Invoke(new Action(() =>
                {
                    if (task.Result.IsSuccess)
                    {
                        this.DgvData.DataSource = null;
                        this.DgvData.DataSource = task.Result.Content;
                    }
                    else
                    {
                        new FormMsgBoxWithoutAck("查询失败:" + task.Result.Message, "报警查询").Show();
                    }
                }));
            });


        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XLSX文件(*.xlsx)|*.xlsx|所有文件|*.*";
            saveFileDialog.Title = "导出历史报警";
            saveFileDialog.FileName = "历史报警" + DateTime.Now.ToString("yyyy-MM-dd_HHmmss");
            saveFileDialog.DefaultExt = "xlsx";
            saveFileDialog.AddExtension = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                MiniExcel.SaveAs(saveFileDialog.FileName, this.DgvData.DataSource);
                if (new FormMsgBoxWithAck("导出报警成功,是否立即打开?", "打开报警记录").ShowDialog() == DialogResult.OK)
                {
                    Process.Start(saveFileDialog.FileName);
                }
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
    }
}
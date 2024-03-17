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
using wgd.MTHControlLib;

namespace wgd.MTHProject
{
    public partial class FormHistory : Form
    {
        public FormHistory()
        {
            InitializeComponent();

            CheckBoxList.Add(this.checkBoxPro1);
            CheckBoxList.Add(this.checkBoxPro2);
            CheckBoxList.Add(this.checkBoxPro3);
            CheckBoxList.Add(this.checkBoxPro4);
            CheckBoxList.Add(this.checkBoxPro5);
            CheckBoxList.Add(this.checkBoxPro6);
            CheckBoxList.Add(this.checkBoxPro7);
            CheckBoxList.Add(this.checkBoxPro8);
            CheckBoxList.Add(this.checkBoxPro9);
            CheckBoxList.Add(this.checkBoxPro10);
            CheckBoxList.Add(this.checkBoxPro11);
            CheckBoxList.Add(this.checkBoxPro12);
            

            this.DateStart.Value = DateTime.Now.AddHours(-2.0f);
            this.DateEnd.Value = DateTime.Now;
            // 设置X轴类型
            this.CharData.XDataType = SeeSharpTools.JY.GUI.StripChartX.XAxisDataType.String;
            // 设置图例
            this.CharData.LegendVisible = false;
            this.CharData.DisplayPoints = 10000000;
            //Y1轴范围
            this.CharData.AxisY.Minimum = 0.0f;
            this.CharData.AxisY.Maximum = 100.0f;
            this.CharData.AxisY.AutoScale = false;

        }

        // 属性
        private Dictionary<string, string> ParamList = new Dictionary<string, string>();
        private ActualDataManage ActualDataManage = new ActualDataManage();
        private List<CheckBoxPro> CheckBoxList = new List<CheckBoxPro>();

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            ParamList = GetParamList();
            string start = this.DateStart.Text;
            string end = this.DateEnd.Text;

            if (ParamList.Count == 0)
            {
                new FormMsgBoxWithoutAck("请勾选需要查询的参数！", "查询出错").Show();
                return;
            }

            Task<OperateResult<DataTable>> task1 = Task.Run(() =>
            {
                return QueryProcess(start, end);
            });

            var task2 = task1.ContinueWith(task =>
            {
                this.Invoke(new Action(() =>
                {
                    if (task.Result.IsSuccess)
                    {
                        UpdateChart(task.Result.Content);
                    }
                    else
                    {
                        new FormMsgBoxWithoutAck("查询失败:" + task.Result.Message, "查询出错").Show();
                    }
                }));
            });
        }

        private void UpdateChart(DataTable dataTable)
        {
            int rowcount = dataTable.Rows.Count;
            int columnCount = ParamList.Count;
            //需要设置Chart
            this.CharData.Clear();
            this.CharData.SeriesCount = columnCount;
            for (int i = 0; i < ParamList.Count; i++)
            {
                this.CharData.Series[i].Name = ParamList.Values.ToList()[i];
                this.CharData.Series[i].Width = SeeSharpTools.JY.GUI.StripChartXSeries.LineWidth.Middle;
            }
            // 解析DataTable
            double[,] YData = new double[columnCount, rowcount];
            string[] XData = new string[rowcount];
            for (int i = 0; i < rowcount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    if (dataTable.Rows[i][j + 1] is DBNull)
                    {
                        YData[j, i] = 0.0f;
                    }
                    else
                    {
                        try
                        {
                            YData[j, i] = Convert.ToDouble(dataTable.Rows[i][j + 1]);
                        }
                        catch (Exception)
                        {
                            YData[j, i] = 0.0f;
                        }
                    }


                }
                XData[i] = Convert.ToDateTime(dataTable.Rows[i][0]).ToString("HH:mm:ss");
            }
            this.CharData.Plot(YData, XData);
        }

        private Dictionary<string, string> GetParamList()
        {
            Dictionary<string, string> paramList = new Dictionary<string, string>();
            foreach (var item in CheckBoxList)
            {
                if (item.Tag != null && item.Tag.ToString().Length > 0)
                {
                    if (item.Checked)
                    {
                        paramList.Add(item.Tag.ToString(), item.Text);
                    }
                }
            }
            return paramList;
        }

        private OperateResult<DataTable> QueryProcess(string start, string end)
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
            DataTable dataTable = ActualDataManage.QueryActualDataByCondition(start, end, ParamList.Keys.ToList());
            if (dataTable != null)
            {
                return OperateResult.CreateSuccessResult(dataTable);
            }
            else
            {
                return OperateResult.CreateFailResult<DataTable>("未查询到有效数据");
            }
        }

        private void BtnQuick_Click(object sender, EventArgs e)
        {
            this.DateStart.Value = DateTime.Now.AddHours(-5.0f);
            this.DateEnd.Value = DateTime.Now;
            this.BtnQuery_Click(null, null);
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV(*.csv)|*.csv|所有文件|*.*";
            saveFileDialog.FileName = "历史趋势CSV" + DateTime.Now.ToString("yyyy-MM-dd_HHmmss");
            saveFileDialog.Title = "历史趋势CSV";
            saveFileDialog.DefaultExt = "csv";
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.CharData.SaveAsCsv(saveFileDialog.FileName);
                if (new FormMsgBoxWithAck("CSV导出成功,是否立即打开?", "打开趋势CSV").ShowDialog() == DialogResult.OK)
                {
                    Process.Start(saveFileDialog.FileName);
                }
            }
        }
         
        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "图片文件(*.jpg)|*.jpg|所有文件|*.*";
            saveFileDialog.FileName = "历史趋势图片" + DateTime.Now.ToString("yyyy-MM-dd_HHmmss");
            saveFileDialog.Title = "历史趋势保存";
            saveFileDialog.DefaultExt = "jpg";
            saveFileDialog.AddExtension = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.CharData.SaveAsImage(saveFileDialog.FileName);
                if (new FormMsgBoxWithAck("图片保存成功,是否立即打开", "打开趋势图片").ShowDialog() == DialogResult.OK)
                {
                    Process.Start(saveFileDialog.FileName);
                }
            }
        }

    }
}



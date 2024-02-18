using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wgd.MTHControlLib;
using wgd.MTHProject.common;

namespace wgd.MTHProject
{
    public partial class FormMonitor : Form
    {
        public FormMonitor()
        {
            InitializeComponent();

            this.ListInfo.Columns[1].Width = this.ListInfo.Width - this.ListInfo.Columns[0].Width - 25;
            SetChart();


            UpdateTimer.Interval = 1000;
            UpdateTimer.Tick += UpdateTimer_Tick;
            UpdateTimer.Start();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if (GlobalProperties.Device.IsConnected)
            {
                foreach (var item in this.panelPromax1.Controls.OfType<THMControl>())
                {
                    UpdateTHMcontrol(item);
                }

                List<double> ydata = new List<double>();
                for (int i = 1; i <= 6; i++)
                {
                    ydata.Add(Convert.ToDouble(GlobalProperties.Device[$"模块{i}温度"]));
                    ydata.Add(Convert.ToDouble(GlobalProperties.Device[$"模块{i}湿度"]));
                }
                this.CharData.PlotSingle(ydata.ToArray());
            }
        }

        private void UpdateTHMcontrol(THMControl item)
        {
            if (GlobalProperties.Device[item.TempVarName] != null)
            {
                item.Temp = GlobalProperties.Device[item.TempVarName].ToString();
            }
            if (GlobalProperties.Device[item.HumidityVarName] != null)
            {
                item.Humidity = GlobalProperties.Device[item.HumidityVarName].ToString();
            }
            if (GlobalProperties.Device[item.StateVarName] != null)
            {
                item.ModuleError = GlobalProperties.Device[item.StateVarName].ToString() == "True";
            }
        }

        private Timer UpdateTimer = new Timer();

        private string NowTime
        {
            get { return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); }
        }

        public void AddLog(int level, string log)
        {
            if (level > 2)
            {
                level = 2;
            }
            if (level < 0)
            {
                level = 0;
            }
            if (this.ListInfo.InvokeRequired)
            {
                this.ListInfo.Invoke(new Action<int, string>(AddLog), level, log);
            }
            else
            {
                ListViewItem item = new ListViewItem(" " + NowTime + ":", level);
                item.SubItems.Add(log);
                this.ListInfo.Items.Add(item);

                this.ListInfo.Items[this.ListInfo.Items.Count - 1].EnsureVisible();
            }
        }

        #region 趋势曲线
        private void SetChart()
        {
            //设置X轴数据类型及格式
            this.CharData.XDataType = SeeSharpTools.JY.GUI.StripChartX.XAxisDataType.TimeStamp;
            this.CharData.TimeStampFormat = "HH:mm:ss";
            //设置图例
            this.CharData.LegendVisible = true;
            //设置显示数据点
            this.CharData.DisplayPoints = 4000;
            //Y轴范围
            this.CharData.AxisY.Minimum = 0.0f;
            this.CharData.AxisY.Maximum = 100.0f;
            this.CharData.AxisY.AutoScale = false;
            //清除曲线
            this.CharData.Series.Clear();
            //设置曲线数量
            this.CharData.SeriesCount = 12;
            //设置曲线
            for (int i = 0; i < 12; i++)
            {
                //设置曲线名称
                this.CharData.Series[i].Name = i % 2 == 0 ? $"{i / 2 + 1}#站点温度" : $"{i / 2 + 1}#站点湿度";
                //设置曲线不可见
                this.CharData.Series[i].Visible = false;
                //设置曲线的粗细
                this.CharData.Series[i].Width = SeeSharpTools.JY.GUI.StripChartXSeries.LineWidth.Middle;
                //设置曲线的Y轴
                this.CharData.Series[i].YPlotAxis = SeeSharpTools.JY.GUI.StripChartXAxis.PlotAxis.Primary;
            }
            this.CheckT1.Checked = true;
            this.CheckH1.Checked = true;

            #endregion
        }

        private void All_Check_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBoxPro checkBox)
            {
                if (checkBox.Tag != null && checkBox.Tag.ToString().Length > 0)
                {
                    int index = Convert.ToInt32(checkBox.Tag.ToString());
                    this.CharData.Series[index].Visible = checkBox.Checked;
                }
            }
        }
    }
}

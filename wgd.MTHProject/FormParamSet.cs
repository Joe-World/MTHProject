using System;
using System.Linq;
using System.Windows.Forms;
using wgd.MTHControlLib;
using wgd.MTHModels;
using wgd.MTHProject.common;
using wgd.Utils;

namespace wgd.MTHProject
{
    public partial class FormParamSet : Form
    {
        public FormParamSet(string devPath)
        {
            InitializeComponent();

            this.DevPath = devPath;

            UpdateTimer.Interval = 1000;
            UpdateTimer.Tick += UpdateTimer_Tick;

            InitData();

            CommonBindEvent();

            this.FormClosed += (sender, e) =>
             {
                 this.UpdateTimer.Stop();
             };
            UpdateTimer.Start();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            Updatedata();
        }

        /// <summary>
        /// 高低限值读取 = CurrentValue
        /// 报警状态读取 = IsAlarm 根据 高/低 的true false
        /// </summary>
        private void Updatedata()
        {
            if (GlobalProperties.Device.IsConnected)
            {
                foreach (var item in this.MainPanel.Controls.OfType<TextSet>())
                {
                    if (item.BindVarName != null && item.BindVarName.ToString().Length > 0)
                    {
                        item.CurrentValue = GlobalProperties.Device[item.BindVarName.ToString()].ToString();
                    }
                    if (item.AlarmVarName != null && item.AlarmVarName.ToString().Length > 0)
                    {
                        item.IsAlarm = GlobalProperties.Device[item.AlarmVarName].ToString() == "True";
                    }
                }
            }
        }

        /// <summary>
        /// 获取启用报警数据- 勾选框
        /// </summary>
        private void GetAlarmParam()
        {
            if (GlobalProperties.Device.IsConnected)
            {
                foreach (var item in this.MainPanel.Controls.OfType<CheckBoxPro>())
                {
                    if (item.Tag != null && item.Tag.ToString().Length > 0)
                    {
                        item.Checked = GlobalProperties.Device[item.Tag.ToString()].ToString() == "1";
                    }
                }
            }
        }


        private string DevPath = string.Empty;
        private Timer UpdateTimer = new Timer();

        /// <summary>
        /// 参数配置界面启动，初始化数据
        /// </summary>
        private void InitData()
        {
            this.TextIp.Text = GlobalProperties.Device.IPAddress;
            this.TextPort.Text = GlobalProperties.Device.Port.ToString();

            Updatedata();
            GetAlarmParam();
        }




        private void BtnGroupConfig_Click(object sender, EventArgs e)
        {
            new FormGroupConfig().ShowDialog();
        }

        private void BtnVariable_Click(object sender, EventArgs e)
        {
            new FormVariableConfig().ShowDialog();
        }

        private void SureBtn_Click(object sender, EventArgs e)
        {
            try
            {
                IniHelper.Write("设备参数", "IP地址", this.TextIp.Text.Trim(), DevPath);
                IniHelper.Write("设备参数", "端口号", this.TextPort.Text.Trim(), DevPath);

                DialogResult res = new FormMsgBoxWithAck("是否立即重连？", "通信设置").ShowDialog();
                if (res == DialogResult.OK)
                {
                    GlobalProperties.Device.IPAddress = this.TextIp.Text.Trim();
                    GlobalProperties.Device.Port = Convert.ToInt32(this.TextPort.Text.Trim());
                    GlobalProperties.Device.IsConnected = false;
                }


                /*new FormMsgBoxWithoutAck("设备信息设置成功！", "设备设置").Show();*/
            }
            catch (Exception ee)
            {
                new FormMsgBoxWithoutAck($"设备信息设置失败:{ee.Message}", "设备设置").Show();
            }
        }

        private void CanelBtn_Click(object sender, EventArgs e)
        {
            InitData();

            /*SureBtn_Click(this.SureBtn, null);*/
        }


        private void CommonBindEvent()
        {
            foreach (var item in this.MainPanel.Controls.OfType<TextSet>())
            {
                if (item.BindVarName != null && item.BindVarName.ToString().Length > 0)
                {
                    item.ControlDoubleClick += All_ControlDoubleClick;
                }
            }
            foreach (var item in this.MainPanel.Controls.OfType<CheckBoxPro>())
            {
                if (item.Tag != null && item.Tag.ToString().Length > 0)
                {
                    item.CheckedChanged += All_CheckedChanged;
                }
            }
        }

        private void All_ControlDoubleClick(object sender, EventArgs e)
        {
            if (sender is TextSet textset)
            {
                if (textset.BindVarName != null && textset.BindVarName.ToString().Length > 0)
                {
                    FormModify frmModify = new FormModify(textset.TitleName, textset.BindVarName, textset.CurrentValue);
                    frmModify.ShowDialog();
                }
            }
        }

        private void All_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBoxPro checkbox)
            {
                if (checkbox.Tag != null && checkbox.Tag.ToString().Length > 0)
                {
                    bool result = GlobalProperties.CommonWrite(checkbox.Tag.ToString(), checkbox.Checked ? "1" : "0");
                    if (result == false)
                    {
                        checkbox.CheckedChanged -= All_CheckedChanged; 
                        checkbox.Checked = !checkbox.Checked;
                        checkbox.CheckedChanged += All_CheckedChanged;
                    }
                }
            }
        }


    }
}


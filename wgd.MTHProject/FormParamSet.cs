using System;
using System.Windows.Forms;
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
            InitData();
        }
        private string DevPath = string.Empty;
        private void InitData()
        {
            this.TextIp.Text = GlobalProperties.Device.IPAddress;
            this.TextPort.Text = GlobalProperties.Device.Port.ToString();
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
                new FormMsgBoxWithoutAck("设备信息设置成功！", "设备设置").Show();
            }
            catch (Exception ee)
            {
                new FormMsgBoxWithoutAck($"设备信息设置失败:{ee.Message}", "设备设置").Show();
            }
        }

        private void CanelBtn_Click(object sender, EventArgs e)
        {
            InitData();

            SureBtn_Click(this.SureBtn, null);
        }
    }
}


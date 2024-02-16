using MiniExcelLibs;
using ModbusTCPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using thinger.DataConvertLib;
using wgd.MTHControlLib;
using wgd.MTHModels;
using wgd.MTHProject.common;
using wgd.Utils;

namespace wgd.MTHProject
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            this.Load += FormMain_Load;
        }

        #region 属性
        /// <summary>
        /// 配置文件路径
        /// </summary>
        private string DevicePath = Application.StartupPath + "\\Config\\Device.int";
        private string GroupPath = Application.StartupPath + "\\Config\\Group.xlsx";
        private string VariablePath = Application.StartupPath + "\\Config\\Var.xlsx";
        // 用于生成 CancellationToken 的类 === 通常用于取消正在进行的异步操作
        private CancellationTokenSource cancelToken;
        #endregion

        #region modbusTcp通信
        private void DeviceCommunication(Device device)
        {
            // 判断异步循环是否取消
            while (!cancelToken.IsCancellationRequested)
            {
                // 判断是否处于连接状态，false需要进行重连
                if (device.IsConnected)
                {
                    //通信读取
                    foreach (var gp in device.GroupList)
                    {
                        byte[] data = null;
                        //返回字节长度
                        int reqLength = 0;
                        if (gp.StoreArea == "输入线圈" || gp.StoreArea == "输出线圈")
                        {
                            switch (gp.StoreArea)
                            {
                                case "输入线圈":
                                    data = GlobalProperties.Modbus.ReadInputColls(gp.Start, gp.Length);
                                    // 根据bool数量除以八算出准确字节
                                    reqLength = ShortLib.GetByteLengthFromBoolLength(gp.Length);
                                    break;
                                case "输出线圈":
                                    data = GlobalProperties.Modbus.ReadOutputColls(gp.Start, gp.Length);
                                    reqLength = ShortLib.GetByteLengthFromBoolLength(gp.Length);
                                    break;
                            }
                            if (data != null && data.Length == reqLength)
                            {
                                //变量解析
                            }
                            else
                            {
                                device.IsConnected = false;
                                break;
                            }
                        }
                        else
                        {
                            switch (gp.StoreArea)
                            {
                                case "输入寄存器":
                                    data = GlobalProperties.Modbus.ReadInputRegister(gp.Start, gp.Length);
                                    // 一个寄存器俩个字节
                                    reqLength = gp.Length * 2;
                                    break;
                                case "输出寄存器":
                                    data = GlobalProperties.Modbus.ReadOutputRegister(gp.Start, gp.Length);
                                    reqLength = gp.Length * 2;
                                    break;


                            }
                            if (data != null && data.Length == reqLength)
                            {
                                //变量解析
                            }
                            else
                            {
                                device.IsConnected = false;
                                break;
                            }
                        }
                    }
                }
                // 重连
                else
                {
                    // 判断是否是第一次进行重连：意味着第一次连接，true则为第二次及以上重连
                    if (device.ReConnect)
                    {
                        GlobalProperties.Modbus?.disConnect();
                        Thread.Sleep(device.ReConnectTime);
                    }
                    //通信连接
                    GlobalProperties.Modbus = new ModbusTCP();
                    device.IsConnected = GlobalProperties.Modbus.Connect(device.IPAddress, device.Port);、
                    // 判断是否
                    if (device.ReConnect)
                    {
                        // 根据设备是否连接成功，输出日志，成功和失败俩个listview等级图标
                        GlobalProperties.AddLog(device.IsConnected ? 0 : 1, device.IsConnected ? "控制器重新连接成功" : "控制器重新连接失败");
                    }
                    else
                    {
                        GlobalProperties.AddLog(device.IsConnected ? 0 : 1, device.IsConnected ? "控制器首次连接成功" : "控制器首次连接失败");
                        device.ReConnect = true;
                    }
                }
            }
        }
        #endregion


        #region 加载设备信息
        private void FormMain_Load(object sender, EventArgs e)
        {
            CommonNaviButton_Click(this.BtnMonitor, null);
            GlobalProperties.Device = LoadDevice(GroupPath, DevicePath, VariablePath);
            if (GlobalProperties.Device != null)
            {
                GlobalProperties.AddLog(0, "登陆窗体");
            }

        }
        private Device LoadDevice(string path)
        {
            try
            {
                return new Device()
                {
                    IPAddress = IniHelper.ReadDefult("设备参数", "IP地址", "127.0.0.0.1", path),
                    Port = Convert.ToInt32(IniHelper.ReadDefult("设备参数", "端口号", "502", path)),
                };
            }
            catch (Exception)
            {
                //日志写入
                return null;
            }
        }
        #endregion


        #region 主界面切换窗体逻辑
        //遍历所有导航栏,小与临界窗体的置后不显示（不关闭）
        private void OpenForm(Panel mainPanel, FormNames formNames)
        {
            int total = mainPanel.Controls.Count;
            int closeCount = 0;
            bool isFind = false;

            for (int i = 0; i < total; i++)
            {
                Control ct = mainPanel.Controls[i - closeCount];
                if (ct is Form frm)
                {
                    //当前是我们需要的窗体
                    if (frm.Text == formNames.ToString())
                    {
                        frm.BringToFront();//窗体置前
                        isFind = true;
                        break;
                    }
                    //如果当前窗体Form不是我们需要的窗体,然后判断是否为固定窗体,如果不是，则关闭，如果是，则不做处理
                    /*else if ((FormNames)Enum.Parse(typeof(FormNames), frm.Text, true) >= FormNames.临界窗体)
                    {
                        frm.Close();
                        closeCount++;
                    }*/
                }
            }

            if (isFind == false)
            {
                Form frm = null;
                switch (formNames)
                {
                    case FormNames.集中监控:
                        frm = new FormMonitor();
                        GlobalProperties.AddLog = ((FormMonitor)frm).AddLog;
                        break;
                    case FormNames.配方管理:
                        frm = new FormRecipe();
                        break;
                    case FormNames.报警追溯:
                        frm = new FormAlarm();
                        break;
                    case FormNames.参数设置:
                        frm = new FormParamSet(DevicePath);
                        break;
                    case FormNames.历史趋势:
                        frm = new FormHistory();
                        break;
                    case FormNames.用户管理:
                        frm = new FormUserManage();
                        break;
                    default:
                        break;
                }
                //设置窗体样式，并且添加窗体到mainPanel中

                if (frm != null)
                {
                    //设置非顶层窗体
                    frm.TopLevel = false;

                    //去除边框
                    frm.FormBorderStyle = FormBorderStyle.None;

                    //填充
                    frm.Dock = DockStyle.Fill;
                    //设置父容器为控件容器
                    frm.Parent = mainPanel;

                    //置前
                    frm.BringToFront();

                    //显示
                    frm.Show();

                    // 优化删除其他窗体处理
                    for (int i = 0; i < total; i++)
                    {
                        Control ct = mainPanel.Controls[i];
                        if (ct is Form form)
                        {
                            if (form.Text != FormNames.集中监控.ToString() && form.Text != formNames.ToString())
                            {
                                form.Close();
                            }
                        }
                    }
                }
            }
        }
        //设置标题
        private void SetTitle(Label label, FormNames formNames)
        {
            label.Text = formNames.ToString();
        }

        //设置窗体选中
        private void SetNaviButtonSelected(Panel topPanel, NaviButton naviButton)
        {
            foreach (var item in topPanel.Controls.OfType<NaviButton>())
            {
                item.IsSelected = false;
            }
            naviButton.IsSelected = true;
        }


        private void CommonNaviButton_Click(object sender, EventArgs e)
        {
            if (sender is NaviButton navi)
            {
                if (Enum.IsDefined(typeof(FormNames), navi.TitleName))
                {
                    //拿到导航按钮对应的窗体枚举值
                    FormNames formNames = (FormNames)Enum.Parse(typeof(FormNames), navi.TitleName, true);
                    //窗体切换
                    OpenForm(this.MainPanel, formNames);
                    //设置Title
                    SetTitle(this.LblTitle, formNames);
                    //设置选中
                    SetNaviButtonSelected(this.TopPanel, navi);

                }
            }
        }
        #endregion

        #region 减少闪烁（事件）
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = 0x02000000;
                return cp;
            }
        }
        #endregion


        #region 通过窗体MouseDown、MouseMove、MouseUp事件实现窗体移动
        Point point; //鼠标按下时的点
        bool isMoving = false;//标识是否拖动

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;//按下的点
            isMoving = true;//启动拖动
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && isMoving)
            {
                Point pNew = new Point(e.Location.X - point.X, e.Location.Y - point.Y);
                //Location = new Point(Location.X + pNew.X, Location.Y + pNew.Y);
                Location += new Size(pNew);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;//停止
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            FormMsgBoxWithAck msgForm = new FormMsgBoxWithAck("确认退出系统？", "系统提示");
            msgForm.MsgBtnClick += (Object s, EventArgPro ee) =>
            {
                if (ee.IsOk)
                {
                    this.Close();
                }
                /*else
                {

                }*/
            };
            msgForm.ShowDialog();

        }

        /// <summary>
        /// 添加设备信息
        /// </summary>
        /// <param name="groupPath"></param>
        /// <param name="devicePath"></param>
        /// <param name="variablePath"></param>
        /// <returns></returns>
        private Device LoadDevice(string groupPath, string devicePath, string variablePath)
        {
            if (!File.Exists(groupPath))
            {
                GlobalProperties.AddLog(1, "通信组文件不存在");
                return null;
            }
            List<Group> GpList = LoadGroup(groupPath, variablePath);
            if (GpList != null && GpList.Count > 0)
            {
                try
                {
                    return new Device()
                    {
                        IPAddress = IniHelper.ReadDefult("设备参数", "IP地址", "", devicePath),
                        Port = Convert.ToInt32(IniHelper.ReadDefult("设备参数", "端口号", "502", devicePath)),
                        GroupList = GpList,
                    };
                }
                catch (Exception ex)
                {
                    GlobalProperties.AddLog(1, "通信组加载失败:" + ex.Message);
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 通信组及通信变量解析
        /// </summary>
        /// <param name="groupPath"></param>
        /// <param name="variablePath"></param>
        /// <returns></returns>
        private List<Group> LoadGroup(string groupPath, string variablePath)
        {
            //判断文件是否存在
            if (!File.Exists(groupPath))
            {
                GlobalProperties.AddLog(1, "通信组文件不存在");
                return null;
            }
            if (!File.Exists(variablePath))
            {
                GlobalProperties.AddLog(1, "通信变量文件不存在");
                return null;
            }
            //解析通信组
            List<Group> GpList = null;
            try
            {
                GpList = MiniExcel.Query<Group>(groupPath).ToList();
            }
            catch (Exception ex)
            {
                GlobalProperties.AddLog(1, "通信组加载失败:" + ex.Message);
                return null;
            }
            //解析变量组,把variable添加到每个group中
            List<Variable> VarList = null;
            try
            {
                VarList = MiniExcel.Query<Variable>(variablePath).ToList();
            }
            catch (Exception ex)
            {
                GlobalProperties.AddLog(1, "通信变量加载失败:" + ex.Message);
                return null;
            }
            if (VarList != null && GpList != null)
            {
                foreach (var group in GpList)
                {
                    group.VarList = VarList.FindAll(c => c.GroupName == group.GroupName).ToList();
                }
                return GpList;
            }
            else
            {
                return null;
            }
        }
    }
}
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

        private void FormMain_Load(object sender, EventArgs e)
        {
            CommonNaviButton_Click(this.BtnMonitor, null);
            GlobalProperties.AddLog(0, "登陆窗体");
            GlobalProperties.AddLog(1, "测试-1");
            GlobalProperties.AddLog(2, "测试-2");

            GlobalProperties.Device = LoadDevice(DevPath);
        }

        #region 加载设备信息
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
        /// <summary>
        /// 项目配置文件路径
        /// </summary>
        private string DevPath = Application.StartupPath + "\\Config\\Device.int";

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
                        frm = new FormParamSet(DevPath);
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
    }
}

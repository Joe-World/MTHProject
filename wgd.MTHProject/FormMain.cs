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

namespace wgd.MTHProject
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

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
                        break;
                    case FormNames.配方管理:
                        frm = new FormRecipe();
                        break;
                    case FormNames.报警追溯:
                        frm = new FormAlarm();
                        break;
                    case FormNames.参数设置:
                        frm = new FormParamSet();
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
                            if(form.Text != FormNames.集中监控.ToString() && form.Text != formNames.ToString())
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
    }
}

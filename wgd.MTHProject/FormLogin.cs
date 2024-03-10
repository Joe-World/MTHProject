using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wgd.MTHBLL;
using wgd.MTHModels;
using wgd.MTHProject.common;

namespace wgd.MTHProject
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private SysAmdinManage sysAmdinManage = new SysAmdinManage();


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // 验证数据
            if (this.TextAdmin.Text.Trim().Length == 0)
            {
                new FormMsgBoxWithoutAck("请填写登录用户名!", "登录提示").ShowDialog();
                this.TextAdmin.Focus();
                return;
            }

            if (this.TextPwd.Text.Trim().Length == 0)
            {
                new FormMsgBoxWithoutAck("请填写登录用户密码!", "登录提示").ShowDialog();
                this.TextPwd.Focus();
                return;
            }
            //封装对象
            SysAdmin sysAdmin = new SysAdmin()
            {
                LoginName = this.TextAdmin.Text.Trim(),
                LoginPwd = this.TextPwd.Text.Trim()
            };
            sysAdmin = sysAmdinManage.AdminLogin(sysAdmin);
            if (sysAdmin == null)
            {
                new FormMsgBoxWithoutAck("用户名或密码不正确!", "登录提示").ShowDialog();
                this.TextAdmin.Focus();
                return;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                //存储登录用户信息
                GlobalProperties.CurrentAdmin = sysAdmin;
            }

        }

        #region 无边框拖动
        //通过窗体MouseDown、MouseMove、MouseUp事件实现窗体移动
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

        private void TextPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BtnLogin_Click(null, null);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

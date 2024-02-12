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

namespace wgd.MTHProject
{
    public partial class FormMsgBoxWithoutAck : Form
    {
        public FormMsgBoxWithoutAck(string content, string title)
        {
            InitializeComponent();

            this.TopMost = true;
            this.LbLContent.Text = content;
            this.LblTitle.Text = title;
        }

        public delegate void MsgHandler(Object sender, EventArgPro e);
        public event MsgHandler MsgBtnClick;
        private void BtnSure_Click(object sender, EventArgs e)
        {
            MsgBtnClick?.Invoke(sender, new EventArgPro() { IsOk = true });
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 通过窗体MouseDown、MouseMove、MouseUp事件实现窗体移动
        Point point; //鼠标按下时的点
        bool isMoving = false;//标识是否拖动

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;//按下的点
            isMoving = true;//启动拖动
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && isMoving)
            {
                Point pNew = new Point(e.Location.X - point.X, e.Location.Y - point.Y);
                //Location = new Point(Location.X + pNew.X, Location.Y + pNew.Y);
                Location += new Size(pNew);
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;//停止
        }
        #endregion


    }
}

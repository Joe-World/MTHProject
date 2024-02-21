using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wgd.MTHProject.common;

namespace wgd.MTHProject
{
    public partial class FormModify : Form
    {
        public FormModify(string titleName, string bindVarName, string currentValue)
        {
            InitializeComponent();
            this.LabTitle.Text = titleName;
            this.BindVarName = bindVarName;
            this.LabCurVal.Text = currentValue;
            this.TextSetVal.Focus();
        }

        private string BindVarName;

        private void BtnSure_Click(object sender, EventArgs e)
        {
            var result = GlobalProperties.CommonWrite(this.BindVarName, this.TextSetVal.Text.Trim());
            if (result)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                new FormMsgBoxWithoutAck("参数修改失败，请检查参数!", "参数修改").Show();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextSetVal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.BtnSure_Click(null, null);
            }
        }
    }
}

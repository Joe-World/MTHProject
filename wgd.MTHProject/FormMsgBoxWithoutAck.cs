﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        private void BtnSure_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 无边框拖动
        private Point mPoint;

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }
        #endregion

        
    }
}

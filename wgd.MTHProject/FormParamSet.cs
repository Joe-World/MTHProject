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
    public partial class FormParamSet : Form
    {
        public FormParamSet()
        {
            InitializeComponent();
        }

        private void BtnGroupConfig_Click(object sender, EventArgs e)
        {
            new FormGroupConfig().ShowDialog();
        }
    }
}

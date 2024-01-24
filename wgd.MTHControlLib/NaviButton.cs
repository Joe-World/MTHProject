﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wgd.MTHControlLib
{
    [DefaultEvent("Click")]
    public partial class NaviButton : UserControl
    {
        public NaviButton()
        {
            InitializeComponent();

            //设置控件样式
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private bool isSelected = false;

        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者显示导航是否选中")]
        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                this.BackgroundImage = isSelected ? Properties.Resources.selected_btn : Properties.Resources.unselected_btn;
            }
        }



        private String titleName = "导航按钮";
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者显示导航文本内容")]
        public String TitleName
        {
            get { return titleName; }
            set
            {
                this.titleName = value;
                this.LabTitle.Text = titleName;
            }
        }

        
        // 传递事件，lab-navi
        public new EventHandler Click;
        private void LabTitle_Click(object sender, EventArgs e)
        {
            this.Click?.Invoke(this, e);
        }
    }
}

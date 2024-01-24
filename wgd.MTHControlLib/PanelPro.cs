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
    public partial class PanelPro : Panel
    {
        public PanelPro()
        {
            InitializeComponent();

            //设置控件样式
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        //上方间隙
        private int topGap = 1;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者显示上面间隔")]
        public int TopGap
        {
            get { return topGap; }
            set { topGap = value; this.Invalidate(); }
        }

        //下方间隙
        private int bottomGap = 1;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者显示下面间隔")]
        public int BottomGap
        {
            get { return bottomGap; }
            set { bottomGap = value; this.Invalidate(); }
        }

        //左边间隙
        private int leftGap = 1;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者显示左面间隔")]
        public int LeftGap
        {
            get { return leftGap; }
            set { leftGap = value; this.Invalidate(); }
        }

        //右方间隙
        private int rightGap = 1;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者显示右面间隔")]
        public int RrightGap
        {
            get { return rightGap; }
            set { rightGap = value; this.Invalidate(); }
        }

        //边框宽度间隙
        private int borderWidth = 1;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者显示右面间隔")]
        public int BorderWidth
        {
            get { return borderWidth; }
            set { borderWidth = value; this.Invalidate(); }
        }

        //边框颜色
        private Color borderColor = Color.FromArgb(35, 255, 253);
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者显示右面间隔")]
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; this.Invalidate(); }
        }

        //绘制
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //画布
            Graphics graphics = e.Graphics;
            //笔
            Pen pen = new Pen(borderColor, borderWidth);

            //矩形参数
            float x = leftGap + borderWidth * 0.5f;
            float y = topGap + borderWidth * 0.5f;
            float width = this.Width - leftGap - rightGap - borderWidth;
            float height = this.Height - topGap - bottomGap - borderWidth;

            //绘制矩形
            graphics.DrawRectangle(pen, x, y, width, height);
        }

    }
}

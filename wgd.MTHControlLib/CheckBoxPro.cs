using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wgd.MTHControlLib
{
    public partial class CheckBoxPro : CheckBox
    {
        public CheckBoxPro()
        {
            InitializeComponent();

            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;

            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private StringFormat format = new StringFormat();

        private int checkBoxWidth = 20;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者获取选中框高度/宽度")]
        public int CheckBoxWidth
        {
            get { return checkBoxWidth; }
            set
            {
                checkBoxWidth = value;
                this.Invalidate();
            }
        }


        private Color boxBackColor = Color.White;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者获取选中框背景的颜色")]
        public Color BoxBackColor
        {
            get { return boxBackColor; }
            set
            {
                boxBackColor = value;
                this.Invalidate();
            }
        }

        private Color selectedColor = Color.FromArgb(3, 25, 66);
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者获取选中颜色")]
        public Color SelectedColor
        {
            get { return selectedColor; }
            set
            {
                selectedColor = value;
                this.Invalidate();
            }
        }



        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            // 确保窗体的背景被正确绘制，然后再添加或覆盖其他的绘制内容
            base.OnPaintBackground(pevent);

            Graphics graphics = pevent.Graphics;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            Rectangle boxTangle = new Rectangle(3, (this.Height - checkBoxWidth) / 2, checkBoxWidth, checkBoxWidth);
            Rectangle textTangle = new Rectangle(boxTangle.Right + 3, 0, Width - boxTangle.Right - 6, this.Height);


            SolidBrush solid = new SolidBrush(boxBackColor);
            graphics.FillRectangle(solid, boxTangle);
            Pen pen = new Pen(Color.LightGray);
            graphics.DrawRectangle(pen, boxTangle);
            if (this.CheckState == CheckState.Checked)
            {
                // 画勾选
                DrawSelected(graphics,boxTangle,SelectedColor);
            }

            // 绘制文本
            graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), textTangle,this.format);
        }

        // 画勾选
        private void DrawSelected(Graphics graphics, Rectangle rectangle, Color color)
        {
            // 构建点数组
            PointF[] pointFs = new PointF[3];

            pointFs[0] = new PointF(rectangle.X + rectangle.Width / 4.5f, rectangle.Y + rectangle.Height / 2.5f);
            pointFs[1] = new PointF(rectangle.X + rectangle.Width / 2.5f, rectangle.Bottom - rectangle.Height / 3.0f);
            pointFs[2] = new PointF(rectangle.Right + rectangle.Width / 4.0f, rectangle.Y + rectangle.Height / 4.5f);
            // 画笔
            Pen pen = new Pen(color, 2.0f);
            // 画
            graphics.DrawLines(pen, pointFs);
        }
    }
}

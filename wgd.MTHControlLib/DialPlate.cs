using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wgd.MTHControlLib
{
    public partial class DialPlate : UserControl
    {
        public DialPlate()
        {
            InitializeComponent();
            //设置控件样式
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
        }
        private StringFormat stringFormat = new StringFormat();

        #region 外环设计
        private Color alarmColor = Color.FromArgb(36, 184, 196);
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者获取报警颜色")]
        public Color AlarmColor
        {
            get { return alarmColor; }
            set
            {
                alarmColor = value;
                this.Invalidate();//重绘
            }
        }

        private Color ringColor = Color.FromArgb(187, 187, 187);
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者获取圆环整体颜色")]
        public Color RingColor
        {
            get { return ringColor; }
            set
            {
                ringColor = value;
                this.Invalidate();//重绘
            }
        }

        private float alarmAngle = 120.0f;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者获取报警角度")]
        public float AlarmAngle
        {
            get { return alarmAngle; }
            set
            {
                alarmAngle = value;
                this.Invalidate();//重绘
            }
        }


        private int outThickness = 8;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者获取外环宽度")]
        public int OutThinkness
        {
            get { return outThickness; }
            set
            {
                outThickness = value;
                this.Invalidate();//重绘
            }
        }
        #endregion

        #region 内环设计
        //温度环
        private float tempScale = 0.6f;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者获取温度环比例,默认低于1.0f")]
        public float TempScale
        {
            get { return tempScale; }
            set
            {
                if (value > 1.0f) return;
                tempScale = value;
                this.Invalidate();//重绘
            }
        }


        private Color tempColor = Color.FromArgb(36, 184, 196);
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者获取温度环颜色")]
        public Color TempColor
        {
            get { return tempColor; }
            set
            {
                tempColor = value;
                this.Invalidate();//重绘

            }
        }

        //湿度环
        private float humidityScale = 0.35f;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者获取湿度环比例,默认低于1.0f")]
        public float HumidityScale
        {
            get { return humidityScale; }
            set
            {
                if (value > 1.0f) return;
                humidityScale = value;
                this.Invalidate();//重绘
            }
        }


        private Color humidityColor = Color.FromArgb(36, 184, 196);
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者获取湿度环颜色")]
        public Color HumidityColor
        {
            get { return humidityColor; }
            set
            {
                humidityColor = value;
                this.Invalidate();//重绘

            }
        }

        //湿度宽度
        private int inThickness = 16;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者获取内环宽度")]
        public int InThinkness
        {
            get { return inThickness; }
            set
            {
                inThickness = value;
                this.Invalidate();//重绘
            }
        }
        #endregion

        #region 刻度设计
        private float textScale = 0.85f;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者获取刻度环比例,默认低于1.0f")]
        public float TextScale
        {
            get { return textScale; }
            set
            {
                if (value > 1.0f) return;
                textScale = value;
                this.Invalidate();//重绘
            }
        }

        private float rangeMin = 0.0f;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者获取量程低限,默认低于1.0f")]
        public float RangeMin
        {
            get { return rangeMin; }
            set
            {
                if (value > rangeMax) return;
                rangeMin = value;
                this.Invalidate();//重绘
            }
        }

        private float rangeMax = 90.0f;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者获取量程高限")]
        public float RangeMax
        {
            get { return rangeMax; }
            set
            {
                if (value < rangeMin) return;
                rangeMax = value;
                this.Invalidate();//重绘
            }
        }
        #endregion

        #region 实时显示
        private float temp = 10.0f;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者获取温度实时值")]
        public float Temp
        {
            get { return temp; }
            set
            {
                if (value < rangeMin)
                {
                    value = rangeMin;
                }
                if (value > rangeMax)
                {
                    value = rangeMax;
                }
                temp = value;
                this.Invalidate();//重绘
            }
        }

        private float humidity = 10.0f;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者获取湿度实时值")]
        public float Humidity
        {
            get { return humidity; }
            set
            {
                if (value < rangeMin)
                {
                    value = rangeMin;
                }
                if (value > rangeMax)
                {
                    value = rangeMax;
                }
                humidity = value;
                this.Invalidate();//重绘
            }
        }
        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //获取画布
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            //异常情况处理
            if (this.Width <= 20 || this.Height <= 20) return;
            if (this.Height < this.Width / 2) return;

            //画外环
            Pen pen = new Pen(alarmColor, outThickness);
            graphics.DrawArc(pen, new RectangleF(10, 10, this.Width - 20, this.Width - 20), 180, alarmAngle);

            pen = new Pen(ringColor, outThickness);
            graphics.DrawArc(pen, new RectangleF(10, 10, this.Width - 20, this.Width - 20), 180 + alarmAngle, 180 - alarmAngle);

            //转移坐标系
            graphics.TranslateTransform(this.Width * 0.5f, this.Width * 0.5f);

            //旋转坐标系
            graphics.RotateTransform(-90);

            SolidBrush solidBrush;

            for (int i = 0; i < 7; i++)
            {
                if (30 * i <= alarmAngle)
                {
                    solidBrush = new SolidBrush(alarmColor);
                }
                else
                {
                    solidBrush = new SolidBrush(ringColor);
                }

                float x = -3.0f;
                float width = 6.0f;
                float height = outThickness + 4;
                float y = (this.Width * 0.5f - 10 + height * 0.5f) * (-1.0f);

                graphics.FillRectangle(solidBrush, new RectangleF(x, y, width, height));

                graphics.RotateTransform(30);
            }

            //坐标系旋转回去
            graphics.RotateTransform(-210);
            graphics.RotateTransform(90);

            //绘制刻度
            float rangeAvg = ((rangeMax - rangeMin) % 6 == 0) ? Convert.ToSingle((rangeMax - rangeMin) / 6) : Convert.ToSingle
               (((rangeMax - rangeMin) / 6).ToString("f1"));

            for (int i = 0; i < 7; i++)
            {
                float angle = -180f + i * 30.0f;

                float pointX = Convert.ToSingle(this.Width * textScale * 0.5f * Math.Cos(angle * Math.PI / 180.0f));
                float pointY = Convert.ToSingle(this.Width * textScale * 0.5f * Math.Sin(angle * Math.PI / 180.0f));

                string text = (rangeMin + rangeAvg * i).ToString();

                SizeF size = graphics.MeasureString(text, this.Font);

                RectangleF rectangle = new RectangleF(pointX - size.Width * 0.5f, pointY, size.Width, size.Height);

                graphics.DrawString(text, this.Font, new SolidBrush(this.ForeColor), rectangle, stringFormat);
            }

            //绘制实际温度环
            pen = new Pen(tempColor, InThinkness);
            //真实温度与量程低限的差，根据比例显示度数
            float sweepAngle = (temp - rangeMin) / (rangeMax - rangeMin) * 180.0f;

            float xx = this.Width * tempScale * 0.5f * (-1.0f);
            float yy = this.Width * tempScale * 0.5f * (-1.0f);

            graphics.DrawArc(pen, new RectangleF(xx, yy, this.Width * tempScale, this.Width * tempScale), -180.0f, sweepAngle);

            //绘制湿度温度环
            pen = new Pen(humidityColor, InThinkness);
            sweepAngle = (humidity - rangeMin) / (rangeMax - rangeMin) * 180.0f;

            xx = this.Width * humidityScale * 0.5f * (-1.0f);
            yy = this.Width * humidityScale * 0.5f * (-1.0f);

            graphics.DrawArc(pen, new RectangleF(xx, yy, this.Width * humidityScale, this.Width * humidityScale), -180.0f, sweepAngle);

        }


    }
}



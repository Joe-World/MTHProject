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
    public partial class THMControl : UserControl
    {
        public THMControl()
        {
            InitializeComponent();

            //设置控件样式
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private string title = "1#站点";

        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者显示标题")]
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                this.LblTitle.Text = title;
            }
        }

        private string temp = "0.0";

        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者显示温度值")]
        public string Temp
        {
            get { return temp; }
            set
            {
                if (temp != value)
                {
                    temp = value;
                    this.LblTemp.Text = temp;
                    if (float.TryParse(temp, out float val))
                    {
                        this.dialPlate.Temp = val;
                    }
                    else
                    {
                        this.dialPlate.Temp = 0.0f;
                    }
                }
            }
        }


        private string humidity = "0.0";

        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者显示湿度值")]
        public string Humidity
        {
            get { return humidity; }
            set
            {
                if (humidity != value)
                {
                    humidity = value;
                    this.LblHumidity.Text = humidity;
                    if (float.TryParse(humidity, out float val))
                    {
                        this.dialPlate.Humidity = val;
                    }
                    else
                    {
                        this.dialPlate.Humidity = 0.0f;
                    }
                }
            }
        }


        private bool moduleError = false;

        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者显示标题背景报警颜色")]
        public bool ModuleError
        {
            get { return moduleError; }
            set
            {
                moduleError = value;
                this.LblTitle.BackColor = moduleError ? Color.Red : Color.FromArgb(36, 183, 198);
            }
        }

        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者显示温度绑定变量名称")]
        public string TempVarName { get; set; } = string.Empty;

        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者显示湿度绑定变量名称")]
        public string HumidityVarName { get; set; } = string.Empty;

        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或者显示状态绑定变量名称")]
        public string StateVarName { get; set; } = string.Empty;
    }
}

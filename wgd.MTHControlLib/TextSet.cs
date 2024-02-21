using System;
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
    [DefaultEvent("ControlDoubleClick")]
    public partial class TextSet : UserControl
    {
        public TextSet()
        {
            InitializeComponent();

            //设置控件样式
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private string titleName = "1#站点温度高限";
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或显示标题名称")]
        public string TitleName
        {
            get { return titleName; }
            set
            {
                titleName = value;
                this.LabTitle.Text = titleName;
            }
        }

        private string bindVarName = "模块1温度高限";
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或显示绑定变量名称")]
        public string BindVarName
        {
            get { return bindVarName; }
            set
            {
                bindVarName = value;
            }
        }

        private string currentValue = "0.0";
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或显示当前数值")]
        public string CurrentValue
        {
            get { return currentValue; }
            set
            {
                if (value != currentValue)
                {
                    currentValue = value;
                    this.LabVal.Text = currentValue;
                }

            }
        }

        private string unit = "°C";
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或显示单位名称")]
        public string Unit
        {
            get { return unit; }
            set
            {
                unit = value;
                this.LabUnit.Text = unit;
            }
        }

        private string alarmVarName = "模块1温度高";
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或显示报警绑定变量名称")]
        public string AlarmVarName
        {
            get
            { return alarmVarName; }
            set
            {
                alarmVarName = value;
            }

        }

        private bool isAlarm;
        /// <summary>
        /// Led-value为true开红色，反之绿色
        /// </summary>
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或显示当前报警状态")]
        public bool IsAlarm
        {
            get { return isAlarm; }
            set
            {
                if (isAlarm != value)
                {
                    isAlarm = value;
                    this.Led0.Value = isAlarm;
                }
            }
        }

        public event EventHandler ControlDoubleClick;
        [Browsable(true)]
        [Category("自定义事件")]
        [Description("设置控件双击事件")]
        private void Ibl_DoubleClick(object sender, EventArgs e)
        {
            ControlDoubleClick?.Invoke(this, e);
        }

    }
}

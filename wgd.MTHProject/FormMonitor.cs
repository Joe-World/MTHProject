using System;
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
    public partial class FormMonitor : Form
    {
        public FormMonitor()
        {
            InitializeComponent();
        }

        private string NowTime
        {
            get { return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); }
        }

        public void AddLog(int level, string log)
        {
            if (level > 2)
            {
                level = 2;
            }
            if (level < 0)
            {
                level = 0;
            }
            if (this.ListInfo.InvokeRequired)
            {
                this.ListInfo.Invoke(new Action<int, string>(AddLog), level, log);
            }
            else
            {
                ListViewItem item = new ListViewItem(" " + NowTime+":", level);
                item.SubItems.Add(log);
                this.ListInfo.Items.Add(item);

                this.ListInfo.Items[this.ListInfo.Items.Count - 1].EnsureVisible();
            }
        }
    }
}

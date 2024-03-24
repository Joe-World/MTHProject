using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wgd.MTHBLL;
using wgd.MTHModels;

namespace wgd.MTHProject
{
    public partial class FormUserManage : Form
    {
        public FormUserManage()
        {
            InitializeComponent();

            UpdateData();
        }

        private SysAmdinManage sysAdminManage = new SysAmdinManage();
        private List<SysAdmin> sysAdmins = new List<SysAdmin>();

        private void UpdateData()
        {
            sysAdmins = sysAdminManage.QuerySysAdmins();
            if (sysAdmins.Count > 0)
            {
                this.DgvData.DataSource = null;
                this.DgvData.DataSource = sysAdmins;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //数据验证
            if (this.TextUsername.Text.Length == 0)
            {
                new FormMsgBoxWithoutAck("用户名不能为空!", "添加用户").Show();
                return;
            }

            if (this.TextPwd.Text.Length == 0)
            {
                new FormMsgBoxWithoutAck("用户密码不能为空!", "添加用户").Show();
                return;
            }
            if (this.TextSurepwd.Text.Length == 0)
            {
                new FormMsgBoxWithoutAck("确认密码不能为空!", "添加用户").Show();
                return;
            }
            if (this.TextPwd.Text.Trim() != this.TextSurepwd.Text.Trim())
            {
                new FormMsgBoxWithoutAck("两次输入密码不一致!", "添加用户").Show();
                return;
            }
            if (sysAdmins.Where(c => c.LoginName == this.TextUsername.Text.Trim()).ToList().Count > 0)
            {
                new FormMsgBoxWithoutAck("该用户名已经存在!", "添加用户").Show();
                return;
            }

            //添加用户
            SysAdmin sysAdmin = new SysAdmin()
            {
                LoginName = this.TextUsername.Text.Trim(),
                LoginPwd = this.TextPwd.Text.Trim(),
                ParamSet = this.CheckParam.Checked,
                Recipe = this.CheckRecipe.Checked,
                HistoryLog = this.CheckAlarm.Checked,
                HistoryTrend = this.CheckHistory.Checked,
                UserManage = this.CheckUser.Checked,
            };
            if (sysAdminManage.AddSysAdmin(sysAdmin))
            {
                UpdateData();
            }
            else
            {
                new FormMsgBoxWithoutAck("添加用户失败,请检查!", "添加用户").Show();
            }

        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {
            //数据验证
            if (this.TextUsername.Text.Length == 0)
            {
                new FormMsgBoxWithoutAck("用户名不能为空!", "修改用户").Show();
                return;
            }

            if (this.TextPwd.Text.Length == 0)
            {
                new FormMsgBoxWithoutAck("用户密码不能为空!", "修改用户").Show();
                return;
            }
            if (this.TextSurepwd.Text.Length == 0)
            {
                new FormMsgBoxWithoutAck("确认密码不能为空!", "修改用户").Show();
                return;
            }
            if (this.TextPwd.Text.Trim() != this.TextSurepwd.Text.Trim())
            {
                new FormMsgBoxWithoutAck("两次输入密码不一致!", "修改用户").Show();
                return;
            }

            // 判断是否修改用户名称
            if (sysAdmins[this.DgvData.SelectedRows[0].Index].LoginName != this.TextUsername.Text.Trim())
            {
                if (sysAdmins.Where(c => c.LoginName == this.TextUsername.Text.Trim()).ToList().Count > 0)
                {
                    new FormMsgBoxWithoutAck("该用户名已经存在!", "修改用户").Show();
                    return;
                }
            }
            SysAdmin sysAdmin = new SysAdmin()
            {
                LoginId = sysAdmins[this.DgvData.SelectedRows[0].Index].LoginId,
                LoginName = this.TextUsername.Text.Trim(),
                LoginPwd = this.TextPwd.Text.Trim(),
                ParamSet = this.CheckParam.Checked,
                Recipe = this.CheckRecipe.Checked,
                HistoryLog = this.CheckAlarm.Checked,
                HistoryTrend = this.CheckHistory.Checked,
                UserManage = this.CheckUser.Checked,
            };

            if (sysAdminManage.ModifysysAdmin(sysAdmin))
            {
                UpdateData();
            }
            else
            {
                new FormMsgBoxWithoutAck("修改用户失败,请检查!", "修改用户").Show();
            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (sysAdminManage.DeleteSysAdmin(sysAdmins[this.DgvData.SelectedRows[0].Index].LoginId))
            {
                UpdateData();
            }
            else
            {
                new FormMsgBoxWithoutAck("删除用户失败,请检查!", "删除用户").Show();
            }
        }

        private void EmptyBtn_Click(object sender, EventArgs e)
        {
            this.TextUsername.Clear();
            this.TextPwd.Clear();
            this.TextSurepwd.Clear();

            SetChecked(false);
        }

        private void SetChecked(bool value)
        {
            this.CheckParam.Checked = value;
            this.CheckRecipe.Checked = value;
            this.CheckAlarm.Checked = value;
            this.CheckHistory.Checked = value;
            this.CheckUser.Checked = value;
        }

        private void BtnAllSelect_Click(object sender, EventArgs e)
        {
            SetChecked(!this.CheckParam.Checked);
        }

        /// <summary>
        /// 行绘制 生成行号，选中单元格效果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvData_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, new SolidBrush(Color.White), headerBounds, centerFormat);
        }

        private void DgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Updatelnfo(sysAdmins[e.RowIndex]);
            }
        }
        private void Updatelnfo(SysAdmin sysAdmin)
        {
            if (sysAdmin != null) { }
            this.TextUsername.Text = sysAdmin.LoginName;
            this.TextPwd.Text = sysAdmin.LoginPwd;
            this.TextSurepwd.Text = sysAdmin.LoginPwd;
            this.CheckParam.Checked = sysAdmin.ParamSet;
            this.CheckRecipe.Checked = sysAdmin.Recipe;
            this.CheckAlarm.Checked = sysAdmin.HistoryLog;
            this.CheckHistory.Checked = sysAdmin.HistoryTrend;
            this.CheckUser.Checked = sysAdmin.UserManage;
        }
    }
}


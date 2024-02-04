
namespace wgd.MTHControlLib
{
    partial class NaviButton
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.LabTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabTitle
            // 
            this.LabTitle.BackColor = System.Drawing.Color.Transparent;
            this.LabTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabTitle.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold);
            this.LabTitle.ForeColor = System.Drawing.Color.White;
            this.LabTitle.Location = new System.Drawing.Point(0, 0);
            this.LabTitle.Name = "LabTitle";
            this.LabTitle.Size = new System.Drawing.Size(121, 61);
            this.LabTitle.TabIndex = 0;
            this.LabTitle.Text = "导航按钮";
            this.LabTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabTitle.Click += new System.EventHandler(this.LabTitle_Click);
            // 
            // NaviButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::wgd.MTHControlLib.Properties.Resources.unselected_btn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.LabTitle);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NaviButton";
            this.Size = new System.Drawing.Size(121, 61);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label LabTitle;
    }
}

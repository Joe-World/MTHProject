
namespace wgd.MTHControlLib
{
    partial class TextSet
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
            this.Led = new System.Windows.Forms.TableLayoutPanel();
            this.LabUnit = new System.Windows.Forms.Label();
            this.LabVal = new System.Windows.Forms.Label();
            this.LabTitle = new System.Windows.Forms.Label();
            this.Led0 = new SeeSharpTools.JY.GUI.LED();
            this.Led.SuspendLayout();
            this.SuspendLayout();
            // 
            // Led
            // 
            this.Led.ColumnCount = 4;
            this.Led.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.375F));
            this.Led.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.75F));
            this.Led.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.Led.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.875F));
            this.Led.Controls.Add(this.LabUnit, 2, 0);
            this.Led.Controls.Add(this.LabVal, 1, 0);
            this.Led.Controls.Add(this.LabTitle, 0, 0);
            this.Led.Controls.Add(this.Led0, 3, 0);
            this.Led.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Led.Location = new System.Drawing.Point(0, 0);
            this.Led.Name = "Led";
            this.Led.RowCount = 1;
            this.Led.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Led.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.Led.Size = new System.Drawing.Size(320, 40);
            this.Led.TabIndex = 0;
            this.Led.DoubleClick += new System.EventHandler(this.Ibl_DoubleClick);
            // 
            // LabUnit
            // 
            this.LabUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabUnit.Location = new System.Drawing.Point(237, 0);
            this.LabUnit.Name = "LabUnit";
            this.LabUnit.Size = new System.Drawing.Size(42, 40);
            this.LabUnit.TabIndex = 3;
            this.LabUnit.Text = "℃";
            this.LabUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabVal
            // 
            this.LabVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabVal.Location = new System.Drawing.Point(161, 0);
            this.LabVal.Name = "LabVal";
            this.LabVal.Size = new System.Drawing.Size(70, 40);
            this.LabVal.TabIndex = 2;
            this.LabVal.Text = "0.0";
            this.LabVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabVal.DoubleClick += new System.EventHandler(this.Ibl_DoubleClick);
            // 
            // LabTitle
            // 
            this.LabTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabTitle.Location = new System.Drawing.Point(3, 0);
            this.LabTitle.Name = "LabTitle";
            this.LabTitle.Size = new System.Drawing.Size(152, 40);
            this.LabTitle.TabIndex = 1;
            this.LabTitle.Text = "1#站点温度高限";
            this.LabTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabTitle.DoubleClick += new System.EventHandler(this.Ibl_DoubleClick);
            // 
            // Led0
            // 
            this.Led0.BlinkColor = System.Drawing.Color.Lime;
            this.Led0.BlinkInterval = 1000;
            this.Led0.BlinkOn = false;
            this.Led0.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Led0.Interacton = SeeSharpTools.JY.GUI.LED.InteractionStyle.Indicator;
            this.Led0.Location = new System.Drawing.Point(290, 8);
            this.Led0.Margin = new System.Windows.Forms.Padding(8, 8, 4, 5);
            this.Led0.Name = "Led0";
            this.Led0.OffColor = System.Drawing.Color.Red;
            this.Led0.OnColor = System.Drawing.Color.Lime;
            this.Led0.Size = new System.Drawing.Size(26, 27);
            this.Led0.Style = SeeSharpTools.JY.GUI.LED.LedStyle.Circular;
            this.Led0.TabIndex = 0;
            this.Led0.Value = false;
            // 
            // TextSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(104)))));
            this.Controls.Add(this.Led);
            this.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TextSet";
            this.Size = new System.Drawing.Size(320, 40);
            this.Led.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Led;
        private System.Windows.Forms.Label LabUnit;
        private System.Windows.Forms.Label LabVal;
        private System.Windows.Forms.Label LabTitle;
        private SeeSharpTools.JY.GUI.LED Led0;
    }
}

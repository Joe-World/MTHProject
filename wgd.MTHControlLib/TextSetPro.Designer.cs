
namespace wgd.MTHControlLib
{
    partial class TextSetPro
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
            this.LabTitle = new System.Windows.Forms.Label();
            this.NumVal = new System.Windows.Forms.NumericUpDown();
            this.Led.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumVal)).BeginInit();
            this.SuspendLayout();
            // 
            // Led
            // 
            this.Led.ColumnCount = 3;
            this.Led.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.66667F));
            this.Led.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.33333F));
            this.Led.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.33333F));
            this.Led.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Led.Controls.Add(this.LabUnit, 2, 0);
            this.Led.Controls.Add(this.LabTitle, 0, 0);
            this.Led.Controls.Add(this.NumVal, 1, 0);
            this.Led.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Led.Location = new System.Drawing.Point(0, 0);
            this.Led.Name = "Led";
            this.Led.RowCount = 1;
            this.Led.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Led.Size = new System.Drawing.Size(300, 40);
            this.Led.TabIndex = 0;
            
            // 
            // LabUnit
            // 
            this.LabUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabUnit.Location = new System.Drawing.Point(241, 0);
            this.LabUnit.Name = "LabUnit";
            this.LabUnit.Size = new System.Drawing.Size(56, 40);
            this.LabUnit.TabIndex = 3;
            this.LabUnit.Text = "℃";
            this.LabUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabTitle
            // 
            this.LabTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabTitle.Location = new System.Drawing.Point(3, 0);
            this.LabTitle.Name = "LabTitle";
            this.LabTitle.Size = new System.Drawing.Size(151, 40);
            this.LabTitle.TabIndex = 1;
            this.LabTitle.Text = "1#站点温度高限";
            this.LabTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // NumVal
            // 
            this.NumVal.DecimalPlaces = 1;
            this.NumVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumVal.Location = new System.Drawing.Point(160, 6);
            this.NumVal.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.NumVal.Name = "NumVal";
            this.NumVal.Size = new System.Drawing.Size(75, 28);
            this.NumVal.TabIndex = 4;
            // 
            // TextSetPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(104)))));
            this.Controls.Add(this.Led);
            this.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TextSetPro";
            this.Size = new System.Drawing.Size(300, 40);
            this.Led.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumVal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Led;
        private System.Windows.Forms.Label LabUnit;
        private System.Windows.Forms.Label LabTitle;
        private System.Windows.Forms.NumericUpDown NumVal;
    }
}

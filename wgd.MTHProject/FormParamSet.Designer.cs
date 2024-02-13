
namespace wgd.MTHProject
{
    partial class FormParamSet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParamSet));
            this.MainPanel = new wgd.MTHControlLib.PanelPromax();
            this.BtnVariable = new System.Windows.Forms.Button();
            this.BtnGroupConfig = new System.Windows.Forms.Button();
            this.CanelBtn = new System.Windows.Forms.Button();
            this.SureBtn = new System.Windows.Forms.Button();
            this.TextPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextIp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.naviButton1 = new wgd.MTHControlLib.NaviButton();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.BackgroundImage = global::wgd.MTHProject.Properties.Resources.mainpanel_bg;
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.Controls.Add(this.BtnVariable);
            this.MainPanel.Controls.Add(this.BtnGroupConfig);
            this.MainPanel.Controls.Add(this.CanelBtn);
            this.MainPanel.Controls.Add(this.SureBtn);
            this.MainPanel.Controls.Add(this.TextPort);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.TextIp);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.naviButton1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1394, 724);
            this.MainPanel.TabIndex = 0;
            // 
            // BtnVariable
            // 
            this.BtnVariable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(27)))), ((int)(((byte)(78)))));
            this.BtnVariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVariable.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.BtnVariable.ForeColor = System.Drawing.Color.White;
            this.BtnVariable.Location = new System.Drawing.Point(1267, 30);
            this.BtnVariable.Name = "BtnVariable";
            this.BtnVariable.Size = new System.Drawing.Size(113, 36);
            this.BtnVariable.TabIndex = 8;
            this.BtnVariable.Text = "变量配置";
            this.BtnVariable.UseVisualStyleBackColor = false;
            this.BtnVariable.Click += new System.EventHandler(this.BtnVariable_Click);
            // 
            // BtnGroupConfig
            // 
            this.BtnGroupConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(27)))), ((int)(((byte)(78)))));
            this.BtnGroupConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGroupConfig.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.BtnGroupConfig.ForeColor = System.Drawing.Color.White;
            this.BtnGroupConfig.Location = new System.Drawing.Point(1112, 30);
            this.BtnGroupConfig.Name = "BtnGroupConfig";
            this.BtnGroupConfig.Size = new System.Drawing.Size(113, 36);
            this.BtnGroupConfig.TabIndex = 7;
            this.BtnGroupConfig.Text = "通信组配置";
            this.BtnGroupConfig.UseVisualStyleBackColor = false;
            this.BtnGroupConfig.Click += new System.EventHandler(this.BtnGroupConfig_Click);
            // 
            // CanelBtn
            // 
            this.CanelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(27)))), ((int)(((byte)(78)))));
            this.CanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CanelBtn.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.CanelBtn.ForeColor = System.Drawing.Color.White;
            this.CanelBtn.Location = new System.Drawing.Point(957, 30);
            this.CanelBtn.Name = "CanelBtn";
            this.CanelBtn.Size = new System.Drawing.Size(113, 36);
            this.CanelBtn.TabIndex = 6;
            this.CanelBtn.Text = "取消设置";
            this.CanelBtn.UseVisualStyleBackColor = false;
            this.CanelBtn.Click += new System.EventHandler(this.CanelBtn_Click);
            // 
            // SureBtn
            // 
            this.SureBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(27)))), ((int)(((byte)(78)))));
            this.SureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SureBtn.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.SureBtn.ForeColor = System.Drawing.Color.White;
            this.SureBtn.Location = new System.Drawing.Point(802, 30);
            this.SureBtn.Name = "SureBtn";
            this.SureBtn.Size = new System.Drawing.Size(113, 36);
            this.SureBtn.TabIndex = 5;
            this.SureBtn.Text = "确认设置";
            this.SureBtn.UseVisualStyleBackColor = false;
            this.SureBtn.Click += new System.EventHandler(this.SureBtn_Click);
            // 
            // TextPort
            // 
            this.TextPort.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.TextPort.Location = new System.Drawing.Point(628, 34);
            this.TextPort.Name = "TextPort";
            this.TextPort.Size = new System.Drawing.Size(145, 29);
            this.TextPort.TabIndex = 4;
            this.TextPort.Text = "8080";
            this.TextPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(495, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "端口号设置";
            // 
            // TextIp
            // 
            this.TextIp.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.TextIp.Location = new System.Drawing.Point(304, 34);
            this.TextIp.Name = "TextIp";
            this.TextIp.Size = new System.Drawing.Size(145, 29);
            this.TextIp.TabIndex = 2;
            this.TextIp.Text = "127.0.0.1";
            this.TextIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(171, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP地址配置";
            // 
            // naviButton1
            // 
            this.naviButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("naviButton1.BackgroundImage")));
            this.naviButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.naviButton1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.naviButton1.IsSelected = false;
            this.naviButton1.Location = new System.Drawing.Point(39, 32);
            this.naviButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.naviButton1.Name = "naviButton1";
            this.naviButton1.Size = new System.Drawing.Size(99, 32);
            this.naviButton1.TabIndex = 0;
            this.naviButton1.TitleName = "通信配置";
            // 
            // FormParamSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 724);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormParamSet";
            this.Text = "参数设置";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MTHControlLib.PanelPromax MainPanel;
        private MTHControlLib.NaviButton naviButton1;
        private System.Windows.Forms.Button BtnVariable;
        private System.Windows.Forms.Button BtnGroupConfig;
        private System.Windows.Forms.Button CanelBtn;
        private System.Windows.Forms.Button SureBtn;
        private System.Windows.Forms.TextBox TextPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextIp;
        private System.Windows.Forms.Label label1;
    }
}
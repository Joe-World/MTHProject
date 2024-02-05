
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
            this.button4 = new System.Windows.Forms.Button();
            this.BtnGroupConfig = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.MainPanel.Controls.Add(this.button4);
            this.MainPanel.Controls.Add(this.BtnGroupConfig);
            this.MainPanel.Controls.Add(this.button2);
            this.MainPanel.Controls.Add(this.button1);
            this.MainPanel.Controls.Add(this.textBox2);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.textBox1);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.naviButton1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1394, 724);
            this.MainPanel.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(27)))), ((int)(((byte)(78)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1267, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 36);
            this.button4.TabIndex = 8;
            this.button4.Text = "变量配置";
            this.button4.UseVisualStyleBackColor = false;
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(27)))), ((int)(((byte)(78)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(957, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "取消设置";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(27)))), ((int)(((byte)(78)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(802, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "确认设置";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.textBox2.Location = new System.Drawing.Point(628, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 29);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "8080";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.textBox1.Location = new System.Drawing.Point(304, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 29);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "127.0.0.1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BtnGroupConfig;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
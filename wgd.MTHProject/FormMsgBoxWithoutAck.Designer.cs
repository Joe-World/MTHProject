
namespace wgd.MTHProject
{
    partial class FormMsgBoxWithoutAck
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LbLContent = new System.Windows.Forms.Label();
            this.BtnSure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblTitle.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(12, 19);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(78, 23);
            this.LblTitle.TabIndex = 3;
            this.LblTitle.Text = "退出系统";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold);
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(402, 11);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(41, 36);
            this.BtnClose.TabIndex = 8;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LbLContent
            // 
            this.LbLContent.BackColor = System.Drawing.Color.Transparent;
            this.LbLContent.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.LbLContent.ForeColor = System.Drawing.Color.White;
            this.LbLContent.Location = new System.Drawing.Point(4, 99);
            this.LbLContent.Name = "LbLContent";
            this.LbLContent.Size = new System.Drawing.Size(439, 47);
            this.LbLContent.TabIndex = 3;
            this.LbLContent.Text = "是否确定退出系统？";
            this.LbLContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSure
            // 
            this.BtnSure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(27)))), ((int)(((byte)(78)))));
            this.BtnSure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSure.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.BtnSure.ForeColor = System.Drawing.Color.White;
            this.BtnSure.Location = new System.Drawing.Point(111, 180);
            this.BtnSure.Name = "BtnSure";
            this.BtnSure.Size = new System.Drawing.Size(216, 36);
            this.BtnSure.TabIndex = 14;
            this.BtnSure.Text = "确定";
            this.BtnSure.UseVisualStyleBackColor = false;
            this.BtnSure.Click += new System.EventHandler(this.BtnSure_Click);
            // 
            // FormMsgBoxWithoutAck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::wgd.MTHProject.Properties.Resources.msgbox_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(446, 270);
            this.Controls.Add(this.BtnSure);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.LbLContent);
            this.Controls.Add(this.LblTitle);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMsgBoxWithoutAck";
            this.Text = "FormMsgBoxWith";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LbLContent;
        private System.Windows.Forms.Button BtnSure;
    }
}
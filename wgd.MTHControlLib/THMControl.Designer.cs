
namespace wgd.MTHControlLib
{
    partial class THMControl
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
            this.dialPlate = new wgd.MTHControlLib.DialPlate();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblTemp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblHumidity = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dialPlate
            // 
            this.dialPlate.AlarmAngle = 120F;
            this.dialPlate.AlarmColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.dialPlate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.dialPlate.ForeColor = System.Drawing.Color.White;
            this.dialPlate.Humidity = 0F;
            this.dialPlate.HumidityColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.dialPlate.HumidityScale = 0.35F;
            this.dialPlate.InThinkness = 16;
            this.dialPlate.Location = new System.Drawing.Point(61, 27);
            this.dialPlate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dialPlate.Name = "dialPlate";
            this.dialPlate.OutThinkness = 8;
            this.dialPlate.RangeMax = 90F;
            this.dialPlate.RangeMin = 0F;
            this.dialPlate.RingColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.dialPlate.Size = new System.Drawing.Size(273, 163);
            this.dialPlate.TabIndex = 0;
            this.dialPlate.Temp = 0F;
            this.dialPlate.TempColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.dialPlate.TempScale = 0.6F;
            this.dialPlate.TextScale = 0.85F;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // LblTitle
            // 
            this.LblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.LblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(79, 35);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "1#站点";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "温度:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTemp
            // 
            this.LblTemp.BackColor = System.Drawing.Color.Transparent;
            this.LblTemp.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.LblTemp.Location = new System.Drawing.Point(75, 190);
            this.LblTemp.Name = "LblTemp";
            this.LblTemp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblTemp.Size = new System.Drawing.Size(67, 28);
            this.LblTemp.TabIndex = 4;
            this.LblTemp.Text = "0.0";
            this.LblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.label5.Location = new System.Drawing.Point(153, 194);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(26, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "℃";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.label6.Location = new System.Drawing.Point(340, 194);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(25, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "%";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblHumidity
            // 
            this.LblHumidity.BackColor = System.Drawing.Color.Transparent;
            this.LblHumidity.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblHumidity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.LblHumidity.Location = new System.Drawing.Point(261, 190);
            this.LblHumidity.Name = "LblHumidity";
            this.LblHumidity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblHumidity.Size = new System.Drawing.Size(67, 28);
            this.LblHumidity.TabIndex = 7;
            this.LblHumidity.Text = "0.0";
            this.LblHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(206, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 22);
            this.label8.TabIndex = 6;
            this.label8.Text = "湿度:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // THMControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LblHumidity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblTemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dialPlate);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "THMControl";
            this.Size = new System.Drawing.Size(387, 236);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DialPlate dialPlate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblTemp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblHumidity;
        private System.Windows.Forms.Label label8;
    }
}

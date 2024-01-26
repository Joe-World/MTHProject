
namespace wgd.MTHProject
{
    partial class FormRecipe
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
            this.button1 = new System.Windows.Forms.Button();
            this.dialPlate1 = new wgd.MTHControlLib.DialPlate();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 30F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(838, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(380, 181);
            this.button1.TabIndex = 0;
            this.button1.Text = "配方";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dialPlate1
            // 
            this.dialPlate1.AlarmAngle = 120F;
            this.dialPlate1.AlarmColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.dialPlate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.dialPlate1.Humidity = 10F;
            this.dialPlate1.HumidityColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.dialPlate1.HumidityScale = 0.35F;
            this.dialPlate1.InThinkness = 16;
            this.dialPlate1.Location = new System.Drawing.Point(174, 136);
            this.dialPlate1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dialPlate1.Name = "dialPlate1";
            this.dialPlate1.OutThinkness = 8;
            this.dialPlate1.RangeMax = 90F;
            this.dialPlate1.RangeMin = 0F;
            this.dialPlate1.RingColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.dialPlate1.Size = new System.Drawing.Size(341, 188);
            this.dialPlate1.TabIndex = 1;
            this.dialPlate1.Temp = 20F;
            this.dialPlate1.TempColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.dialPlate1.TempScale = 0.6F;
            this.dialPlate1.TextScale = 0.85F;
            // 
            // FormRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 724);
            this.Controls.Add(this.dialPlate1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormRecipe";
            this.Text = "配方管理";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private MTHControlLib.DialPlate dialPlate1;
    }
}
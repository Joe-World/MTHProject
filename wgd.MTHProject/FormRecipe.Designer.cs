
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
            this.thmControl1 = new wgd.MTHControlLib.THMControl();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 30F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(494, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(380, 181);
            this.button1.TabIndex = 0;
            this.button1.Text = "配方";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // thmControl1
            // 
            this.thmControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(28)))), ((int)(((byte)(68)))));
            this.thmControl1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.thmControl1.Humidity = "45.6";
            this.thmControl1.Location = new System.Drawing.Point(94, 132);
            this.thmControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thmControl1.ModuleError = false;
            this.thmControl1.Name = "thmControl1";
            this.thmControl1.Size = new System.Drawing.Size(387, 236);
            this.thmControl1.TabIndex = 1;
            this.thmControl1.Temp = "水电费";
            this.thmControl1.Title = "2#站点";
            // 
            // FormRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 724);
            this.Controls.Add(this.thmControl1);
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
        private MTHControlLib.THMControl thmControl1;
    }
}
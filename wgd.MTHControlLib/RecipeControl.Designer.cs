
namespace wgd.MTHControlLib
{
    partial class RecipeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeControl));
            this.checkBoxPro2 = new wgd.MTHControlLib.CheckBoxPro();
            this.checkBoxPro1 = new wgd.MTHControlLib.CheckBoxPro();
            this.textSetPro4 = new wgd.MTHControlLib.TextSetPro();
            this.textSetPro3 = new wgd.MTHControlLib.TextSetPro();
            this.textSetPro2 = new wgd.MTHControlLib.TextSetPro();
            this.textSetPro1 = new wgd.MTHControlLib.TextSetPro();
            this.TitleBtn = new wgd.MTHControlLib.NaviButton();
            this.SuspendLayout();
            // 
            // checkBoxPro2
            // 
            this.checkBoxPro2.BoxBackColor = System.Drawing.Color.White;
            this.checkBoxPro2.CheckBoxWidth = 20;
            this.checkBoxPro2.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.checkBoxPro2.ForeColor = System.Drawing.Color.White;
            this.checkBoxPro2.Location = new System.Drawing.Point(174, 295);
            this.checkBoxPro2.Name = "checkBoxPro2";
            this.checkBoxPro2.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxPro2.Size = new System.Drawing.Size(132, 37);
            this.checkBoxPro2.TabIndex = 2;
            this.checkBoxPro2.Text = "湿度报警启用";
            this.checkBoxPro2.UseVisualStyleBackColor = true;
            // 
            // checkBoxPro1
            // 
            this.checkBoxPro1.BoxBackColor = System.Drawing.Color.White;
            this.checkBoxPro1.CheckBoxWidth = 20;
            this.checkBoxPro1.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.checkBoxPro1.ForeColor = System.Drawing.Color.White;
            this.checkBoxPro1.Location = new System.Drawing.Point(23, 295);
            this.checkBoxPro1.Name = "checkBoxPro1";
            this.checkBoxPro1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.checkBoxPro1.Size = new System.Drawing.Size(132, 37);
            this.checkBoxPro1.TabIndex = 2;
            this.checkBoxPro1.Text = "温度报警启用";
            this.checkBoxPro1.UseVisualStyleBackColor = true;
            // 
            // textSetPro4
            // 
            this.textSetPro4.BackColor = System.Drawing.Color.Transparent;
            this.textSetPro4.CurrentValue = 0F;
            this.textSetPro4.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.textSetPro4.ForeColor = System.Drawing.Color.White;
            this.textSetPro4.Location = new System.Drawing.Point(19, 247);
            this.textSetPro4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSetPro4.Name = "textSetPro4";
            this.textSetPro4.Size = new System.Drawing.Size(300, 40);
            this.textSetPro4.TabIndex = 1;
            this.textSetPro4.TitleName = "1#站点湿度低限";
            this.textSetPro4.Unit = "%";
            // 
            // textSetPro3
            // 
            this.textSetPro3.BackColor = System.Drawing.Color.Transparent;
            this.textSetPro3.CurrentValue = 0F;
            this.textSetPro3.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.textSetPro3.ForeColor = System.Drawing.Color.White;
            this.textSetPro3.Location = new System.Drawing.Point(19, 188);
            this.textSetPro3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSetPro3.Name = "textSetPro3";
            this.textSetPro3.Size = new System.Drawing.Size(300, 40);
            this.textSetPro3.TabIndex = 1;
            this.textSetPro3.TitleName = "1#站点湿度高限";
            this.textSetPro3.Unit = "%";
            // 
            // textSetPro2
            // 
            this.textSetPro2.BackColor = System.Drawing.Color.Transparent;
            this.textSetPro2.CurrentValue = 0F;
            this.textSetPro2.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.textSetPro2.ForeColor = System.Drawing.Color.White;
            this.textSetPro2.Location = new System.Drawing.Point(19, 129);
            this.textSetPro2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSetPro2.Name = "textSetPro2";
            this.textSetPro2.Size = new System.Drawing.Size(300, 40);
            this.textSetPro2.TabIndex = 1;
            this.textSetPro2.TitleName = "1#站点温度低限";
            this.textSetPro2.Unit = "°C";
            // 
            // textSetPro1
            // 
            this.textSetPro1.BackColor = System.Drawing.Color.Transparent;
            this.textSetPro1.CurrentValue = 0F;
            this.textSetPro1.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.textSetPro1.ForeColor = System.Drawing.Color.White;
            this.textSetPro1.Location = new System.Drawing.Point(19, 70);
            this.textSetPro1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSetPro1.Name = "textSetPro1";
            this.textSetPro1.Size = new System.Drawing.Size(300, 40);
            this.textSetPro1.TabIndex = 1;
            this.textSetPro1.TitleName = "1#站点温度高限";
            this.textSetPro1.Unit = "°C";
            // 
            // TitleBtn
            // 
            this.TitleBtn.BackColor = System.Drawing.Color.Transparent;
            this.TitleBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TitleBtn.BackgroundImage")));
            this.TitleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TitleBtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TitleBtn.IsSelected = false;
            this.TitleBtn.Location = new System.Drawing.Point(19, 22);
            this.TitleBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TitleBtn.Name = "TitleBtn";
            this.TitleBtn.Size = new System.Drawing.Size(92, 29);
            this.TitleBtn.TabIndex = 0;
            this.TitleBtn.TitleName = "1#站点";
            // 
            // RecipeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(39)))), ((int)(((byte)(104)))));
            this.Controls.Add(this.checkBoxPro2);
            this.Controls.Add(this.checkBoxPro1);
            this.Controls.Add(this.textSetPro4);
            this.Controls.Add(this.textSetPro3);
            this.Controls.Add(this.textSetPro2);
            this.Controls.Add(this.textSetPro1);
            this.Controls.Add(this.TitleBtn);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RecipeControl";
            this.Size = new System.Drawing.Size(327, 346);
            this.ResumeLayout(false);

        }

        #endregion

        private NaviButton TitleBtn;
        private TextSetPro textSetPro1;
        private TextSetPro textSetPro2;
        private TextSetPro textSetPro3;
        private TextSetPro textSetPro4;
        private CheckBoxPro checkBoxPro1;
        private CheckBoxPro checkBoxPro2;
    }
}

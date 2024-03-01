
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            wgd.MTHModels.RecipeParam recipeParam7 = new wgd.MTHModels.RecipeParam();
            wgd.MTHModels.RecipeParam recipeParam8 = new wgd.MTHModels.RecipeParam();
            wgd.MTHModels.RecipeParam recipeParam9 = new wgd.MTHModels.RecipeParam();
            wgd.MTHModels.RecipeParam recipeParam10 = new wgd.MTHModels.RecipeParam();
            wgd.MTHModels.RecipeParam recipeParam11 = new wgd.MTHModels.RecipeParam();
            wgd.MTHModels.RecipeParam recipeParam12 = new wgd.MTHModels.RecipeParam();
            this.panelPromax1 = new wgd.MTHControlLib.PanelPromax();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TextERecipe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipeControl6 = new wgd.MTHControlLib.RecipeControl();
            this.recipeControl3 = new wgd.MTHControlLib.RecipeControl();
            this.recipeControl5 = new wgd.MTHControlLib.RecipeControl();
            this.recipeControl4 = new wgd.MTHControlLib.RecipeControl();
            this.recipeControl2 = new wgd.MTHControlLib.RecipeControl();
            this.recipeControl1 = new wgd.MTHControlLib.RecipeControl();
            this.panelPromax1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPromax1
            // 
            this.panelPromax1.BackgroundImage = global::wgd.MTHProject.Properties.Resources.mainpanel_bg;
            this.panelPromax1.Controls.Add(this.splitContainer1);
            this.panelPromax1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPromax1.Location = new System.Drawing.Point(0, 0);
            this.panelPromax1.Name = "panelPromax1";
            this.panelPromax1.Size = new System.Drawing.Size(1394, 724);
            this.panelPromax1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.BtnAdd);
            this.splitContainer1.Panel1.Controls.Add(this.TextERecipe);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.DgvData);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.recipeControl6);
            this.splitContainer1.Panel2.Controls.Add(this.recipeControl3);
            this.splitContainer1.Panel2.Controls.Add(this.recipeControl5);
            this.splitContainer1.Panel2.Controls.Add(this.recipeControl4);
            this.splitContainer1.Panel2.Controls.Add(this.recipeControl2);
            this.splitContainer1.Panel2.Controls.Add(this.recipeControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1394, 724);
            this.splitContainer1.SplitterDistance = 284;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(27)))), ((int)(((byte)(78)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(147, 660);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 36);
            this.button3.TabIndex = 14;
            this.button3.Text = "应用配方";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(27)))), ((int)(((byte)(78)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(147, 604);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "修改配方";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(27)))), ((int)(((byte)(78)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(41, 660);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 36);
            this.button2.TabIndex = 14;
            this.button2.Text = "删除配方";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(27)))), ((int)(((byte)(78)))));
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(41, 604);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(90, 36);
            this.BtnAdd.TabIndex = 14;
            this.BtnAdd.Text = "添加配方";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TextERecipe
            // 
            this.TextERecipe.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.TextERecipe.Location = new System.Drawing.Point(141, 548);
            this.TextERecipe.Name = "TextERecipe";
            this.TextERecipe.Size = new System.Drawing.Size(95, 29);
            this.TextERecipe.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 551);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "配方管理：";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(141, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "THPR";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前配方：";
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.AllowUserToResizeColumns = false;
            this.DgvData.AllowUserToResizeRows = false;
            this.DgvData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.DgvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvData.ColumnHeadersHeight = 35;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupName,
            this.Start});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvData.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvData.EnableHeadersVisualStyles = false;
            this.DgvData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgvData.Location = new System.Drawing.Point(21, 25);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvData.RowHeadersVisible = false;
            this.DgvData.RowHeadersWidth = 55;
            this.DgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvData.RowTemplate.Height = 40;
            this.DgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvData.Size = new System.Drawing.Size(244, 439);
            this.DgvData.TabIndex = 11;
            // 
            // GroupName
            // 
            this.GroupName.DataPropertyName = "GroupName";
            this.GroupName.HeaderText = "序号";
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            this.GroupName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Start
            // 
            this.Start.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Start.DataPropertyName = "Start";
            this.Start.HeaderText = "配方名称";
            this.Start.Name = "Start";
            this.Start.ReadOnly = true;
            this.Start.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // recipeControl6
            // 
            this.recipeControl6.BackColor = System.Drawing.Color.Transparent;
            this.recipeControl6.DevName = "6#站点";
            this.recipeControl6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recipeControl6.Location = new System.Drawing.Point(763, 364);
            this.recipeControl6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recipeControl6.Name = "recipeControl6";
            recipeParam7.HumidityAlarmEnable = false;
            recipeParam7.HumidityHigh = 0F;
            recipeParam7.HumidityLow = 0F;
            recipeParam7.TempAlarmEnable = false;
            recipeParam7.TempHigh = 0F;
            recipeParam7.TempLow = 0F;
            this.recipeControl6.RecipeParam = recipeParam7;
            this.recipeControl6.Size = new System.Drawing.Size(327, 346);
            this.recipeControl6.TabIndex = 0;
            // 
            // recipeControl3
            // 
            this.recipeControl3.BackColor = System.Drawing.Color.Transparent;
            this.recipeControl3.DevName = "3#站点";
            this.recipeControl3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recipeControl3.Location = new System.Drawing.Point(763, 9);
            this.recipeControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recipeControl3.Name = "recipeControl3";
            recipeParam8.HumidityAlarmEnable = false;
            recipeParam8.HumidityHigh = 0F;
            recipeParam8.HumidityLow = 0F;
            recipeParam8.TempAlarmEnable = false;
            recipeParam8.TempHigh = 0F;
            recipeParam8.TempLow = 0F;
            this.recipeControl3.RecipeParam = recipeParam8;
            this.recipeControl3.Size = new System.Drawing.Size(327, 346);
            this.recipeControl3.TabIndex = 0;
            // 
            // recipeControl5
            // 
            this.recipeControl5.BackColor = System.Drawing.Color.Transparent;
            this.recipeControl5.DevName = "5#站点";
            this.recipeControl5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recipeControl5.Location = new System.Drawing.Point(391, 364);
            this.recipeControl5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recipeControl5.Name = "recipeControl5";
            recipeParam9.HumidityAlarmEnable = false;
            recipeParam9.HumidityHigh = 0F;
            recipeParam9.HumidityLow = 0F;
            recipeParam9.TempAlarmEnable = false;
            recipeParam9.TempHigh = 0F;
            recipeParam9.TempLow = 0F;
            this.recipeControl5.RecipeParam = recipeParam9;
            this.recipeControl5.Size = new System.Drawing.Size(327, 346);
            this.recipeControl5.TabIndex = 0;
            // 
            // recipeControl4
            // 
            this.recipeControl4.BackColor = System.Drawing.Color.Transparent;
            this.recipeControl4.DevName = "4#站点";
            this.recipeControl4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recipeControl4.Location = new System.Drawing.Point(19, 364);
            this.recipeControl4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recipeControl4.Name = "recipeControl4";
            recipeParam10.HumidityAlarmEnable = false;
            recipeParam10.HumidityHigh = 0F;
            recipeParam10.HumidityLow = 0F;
            recipeParam10.TempAlarmEnable = false;
            recipeParam10.TempHigh = 0F;
            recipeParam10.TempLow = 0F;
            this.recipeControl4.RecipeParam = recipeParam10;
            this.recipeControl4.Size = new System.Drawing.Size(327, 346);
            this.recipeControl4.TabIndex = 0;
            // 
            // recipeControl2
            // 
            this.recipeControl2.BackColor = System.Drawing.Color.Transparent;
            this.recipeControl2.DevName = "2#站点";
            this.recipeControl2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recipeControl2.Location = new System.Drawing.Point(391, 9);
            this.recipeControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recipeControl2.Name = "recipeControl2";
            recipeParam11.HumidityAlarmEnable = false;
            recipeParam11.HumidityHigh = 0F;
            recipeParam11.HumidityLow = 0F;
            recipeParam11.TempAlarmEnable = false;
            recipeParam11.TempHigh = 0F;
            recipeParam11.TempLow = 0F;
            this.recipeControl2.RecipeParam = recipeParam11;
            this.recipeControl2.Size = new System.Drawing.Size(327, 346);
            this.recipeControl2.TabIndex = 0;
            // 
            // recipeControl1
            // 
            this.recipeControl1.BackColor = System.Drawing.Color.Transparent;
            this.recipeControl1.DevName = "1#站点";
            this.recipeControl1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recipeControl1.Location = new System.Drawing.Point(19, 9);
            this.recipeControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recipeControl1.Name = "recipeControl1";
            recipeParam12.HumidityAlarmEnable = false;
            recipeParam12.HumidityHigh = 0F;
            recipeParam12.HumidityLow = 0F;
            recipeParam12.TempAlarmEnable = false;
            recipeParam12.TempHigh = 0F;
            recipeParam12.TempLow = 0F;
            this.recipeControl1.RecipeParam = recipeParam12;
            this.recipeControl1.Size = new System.Drawing.Size(327, 346);
            this.recipeControl1.TabIndex = 0;
            // 
            // FormRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 724);
            this.Controls.Add(this.panelPromax1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormRecipe";
            this.Text = "配方管理";
            this.panelPromax1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MTHControlLib.PanelPromax panelPromax1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.TextBox TextERecipe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnAdd;
        private MTHControlLib.RecipeControl recipeControl6;
        private MTHControlLib.RecipeControl recipeControl3;
        private MTHControlLib.RecipeControl recipeControl5;
        private MTHControlLib.RecipeControl recipeControl4;
        private MTHControlLib.RecipeControl recipeControl2;
        private MTHControlLib.RecipeControl recipeControl1;
    }
}
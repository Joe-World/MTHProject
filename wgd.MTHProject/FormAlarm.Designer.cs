
namespace wgd.MTHProject
{
    partial class FormAlarm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbAlarmType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DateStart = new System.Windows.Forms.DateTimePicker();
            this.BtnQuery = new System.Windows.Forms.Button();
            this.DateEnd = new System.Windows.Forms.DateTimePicker();
            this.BtnExport = new System.Windows.Forms.Button();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.InsertTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlarmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VarName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "报警类型";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CmbAlarmType
            // 
            this.CmbAlarmType.FormattingEnabled = true;
            this.CmbAlarmType.Location = new System.Drawing.Point(134, 30);
            this.CmbAlarmType.Name = "CmbAlarmType";
            this.CmbAlarmType.Size = new System.Drawing.Size(121, 28);
            this.CmbAlarmType.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(323, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "开始时间";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.CausesValidation = false;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(677, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "结束时间";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateStart
            // 
            this.DateStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.DateStart.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.DateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateStart.Location = new System.Drawing.Point(413, 30);
            this.DateStart.Name = "DateStart";
            this.DateStart.Size = new System.Drawing.Size(200, 29);
            this.DateStart.TabIndex = 7;
            // 
            // BtnQuery
            // 
            this.BtnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(27)))), ((int)(((byte)(78)))));
            this.BtnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuery.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.BtnQuery.ForeColor = System.Drawing.Color.White;
            this.BtnQuery.Location = new System.Drawing.Point(1016, 25);
            this.BtnQuery.Name = "BtnQuery";
            this.BtnQuery.Size = new System.Drawing.Size(148, 40);
            this.BtnQuery.TabIndex = 15;
            this.BtnQuery.Text = "时 间 查 询";
            this.BtnQuery.UseVisualStyleBackColor = false;
            this.BtnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // DateEnd
            // 
            this.DateEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.DateEnd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.DateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateEnd.Location = new System.Drawing.Point(767, 30);
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Size = new System.Drawing.Size(200, 29);
            this.DateEnd.TabIndex = 7;
            // 
            // BtnExport
            // 
            this.BtnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(27)))), ((int)(((byte)(78)))));
            this.BtnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExport.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.BtnExport.ForeColor = System.Drawing.Color.White;
            this.BtnExport.Location = new System.Drawing.Point(1207, 26);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(148, 40);
            this.BtnExport.TabIndex = 15;
            this.BtnExport.Text = "导 出 Excel";
            this.BtnExport.UseVisualStyleBackColor = false;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvData.ColumnHeadersHeight = 40;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InsertTime,
            this.AlarmType,
            this.Note,
            this.Operator,
            this.VarName});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvData.DefaultCellStyle = dataGridViewCellStyle8;
            this.DgvData.EnableHeadersVisualStyles = false;
            this.DgvData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgvData.Location = new System.Drawing.Point(24, 96);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DgvData.RowHeadersWidth = 55;
            this.DgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvData.RowTemplate.Height = 40;
            this.DgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvData.Size = new System.Drawing.Size(1345, 600);
            this.DgvData.TabIndex = 16;
            this.DgvData.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvData_RowPostPaint);
            // 
            // InsertTime
            // 
            this.InsertTime.DataPropertyName = "InsertTime";
            this.InsertTime.HeaderText = "日期时间";
            this.InsertTime.Name = "InsertTime";
            this.InsertTime.ReadOnly = true;
            this.InsertTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.InsertTime.Width = 200;
            // 
            // AlarmType
            // 
            this.AlarmType.DataPropertyName = "AlarmType";
            this.AlarmType.HeaderText = "报警类型";
            this.AlarmType.Name = "AlarmType";
            this.AlarmType.ReadOnly = true;
            this.AlarmType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AlarmType.Width = 150;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "日志报警信息";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Width = 500;
            // 
            // Operator
            // 
            this.Operator.DataPropertyName = "Operator";
            this.Operator.HeaderText = "操作员";
            this.Operator.Name = "Operator";
            this.Operator.ReadOnly = true;
            this.Operator.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Operator.Width = 250;
            // 
            // VarName
            // 
            this.VarName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VarName.DataPropertyName = "VarName";
            this.VarName.HeaderText = "变量名称";
            this.VarName.Name = "VarName";
            this.VarName.ReadOnly = true;
            this.VarName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FormAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::wgd.MTHProject.Properties.Resources.mainpanel_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1394, 724);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.BtnQuery);
            this.Controls.Add(this.DateEnd);
            this.Controls.Add(this.DateStart);
            this.Controls.Add(this.CmbAlarmType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAlarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "报警追溯";
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbAlarmType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DateStart;
        private System.Windows.Forms.Button BtnQuery;
        private System.Windows.Forms.DateTimePicker DateEnd;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn InsertTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlarmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operator;
        private System.Windows.Forms.DataGridViewTextBoxColumn VarName;
    }
}
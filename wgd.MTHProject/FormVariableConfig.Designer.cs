
namespace wgd.MTHProject
{
    partial class FormVariableConfig
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NumStart = new System.Windows.Forms.NumericUpDown();
            this.NumScale = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.NumLength = new System.Windows.Forms.NumericUpDown();
            this.NumOffset = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.VarName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OffsetOrLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Offset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosAlarm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NegAlarm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TextRemark = new System.Windows.Forms.TextBox();
            this.TextVarName = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ModifyBtn = new System.Windows.Forms.Button();
            this.CmbGroupName = new System.Windows.Forms.ComboBox();
            this.CmbDataType = new System.Windows.Forms.ComboBox();
            this.panelPro1 = new wgd.MTHControlLib.PanelPro();
            this.CheckNegAlarm = new wgd.MTHControlLib.CheckBoxPro();
            this.CheckPosAlarm = new wgd.MTHControlLib.CheckBoxPro();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.panelPro1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 59);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(29)))), ((int)(((byte)(84)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(957, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "变量配置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "通信组名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(294, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "变量名称";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(598, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "起始索引";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(598, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 23);
            this.label11.TabIndex = 6;
            this.label11.Text = "线性系数";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1107, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "长度";
            // 
            // NumStart
            // 
            this.NumStart.Location = new System.Drawing.Point(682, 81);
            this.NumStart.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NumStart.Name = "NumStart";
            this.NumStart.Size = new System.Drawing.Size(77, 29);
            this.NumStart.TabIndex = 7;
            // 
            // NumScale
            // 
            this.NumScale.DecimalPlaces = 1;
            this.NumScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumScale.Location = new System.Drawing.Point(682, 130);
            this.NumScale.Name = "NumScale";
            this.NumScale.Size = new System.Drawing.Size(77, 29);
            this.NumScale.TabIndex = 7;
            this.NumScale.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(792, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "位偏移/长度";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(819, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 23);
            this.label12.TabIndex = 8;
            this.label12.Text = "偏移量";
            // 
            // NumLength
            // 
            this.NumLength.Location = new System.Drawing.Point(916, 81);
            this.NumLength.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NumLength.Name = "NumLength";
            this.NumLength.Size = new System.Drawing.Size(70, 29);
            this.NumLength.TabIndex = 7;
            this.NumLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumOffset
            // 
            this.NumOffset.DecimalPlaces = 1;
            this.NumOffset.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumOffset.Location = new System.Drawing.Point(916, 130);
            this.NumOffset.Name = "NumOffset";
            this.NumOffset.Size = new System.Drawing.Size(70, 29);
            this.NumOffset.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1129, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 23);
            this.label10.TabIndex = 8;
            this.label10.Text = "位偏移/长度";
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
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvData.ColumnHeadersHeight = 40;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VarName,
            this.Start,
            this.OffsetOrLength,
            this.DataType,
            this.Scale,
            this.Offset,
            this.PosAlarm,
            this.NegAlarm,
            this.GroupName,
            this.Remark});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvData.DefaultCellStyle = dataGridViewCellStyle8;
            this.DgvData.EnableHeadersVisualStyles = false;
            this.DgvData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgvData.Location = new System.Drawing.Point(25, 230);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(40)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DgvData.RowHeadersWidth = 45;
            this.DgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvData.RowTemplate.Height = 40;
            this.DgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvData.Size = new System.Drawing.Size(961, 424);
            this.DgvData.TabIndex = 10;
            this.DgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellClick);
            this.DgvData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvData_CellFormatting);
            this.DgvData.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvData_RowPostPaint);
            // 
            // VarName
            // 
            this.VarName.DataPropertyName = "VarName";
            this.VarName.HeaderText = "变量名称";
            this.VarName.Name = "VarName";
            this.VarName.ReadOnly = true;
            this.VarName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.VarName.Width = 130;
            // 
            // Start
            // 
            this.Start.DataPropertyName = "Start";
            this.Start.HeaderText = "起始索引";
            this.Start.Name = "Start";
            this.Start.ReadOnly = true;
            this.Start.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Start.Width = 90;
            // 
            // OffsetOrLength
            // 
            this.OffsetOrLength.DataPropertyName = "OffsetOrLength";
            this.OffsetOrLength.HeaderText = "位偏移/长度";
            this.OffsetOrLength.Name = "OffsetOrLength";
            this.OffsetOrLength.ReadOnly = true;
            this.OffsetOrLength.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OffsetOrLength.Width = 110;
            // 
            // DataType
            // 
            this.DataType.DataPropertyName = "DataType";
            this.DataType.HeaderText = "数据类型";
            this.DataType.Name = "DataType";
            this.DataType.ReadOnly = true;
            this.DataType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DataType.Width = 80;
            // 
            // Scale
            // 
            this.Scale.DataPropertyName = "Scale";
            this.Scale.HeaderText = "线性系数";
            this.Scale.Name = "Scale";
            this.Scale.ReadOnly = true;
            this.Scale.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Scale.Width = 80;
            // 
            // Offset
            // 
            this.Offset.DataPropertyName = "Offset";
            this.Offset.HeaderText = "偏移量";
            this.Offset.Name = "Offset";
            this.Offset.ReadOnly = true;
            this.Offset.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Offset.Width = 80;
            // 
            // PosAlarm
            // 
            this.PosAlarm.DataPropertyName = "PosAlarm";
            this.PosAlarm.HeaderText = "上升沿";
            this.PosAlarm.Name = "PosAlarm";
            this.PosAlarm.ReadOnly = true;
            this.PosAlarm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PosAlarm.Width = 80;
            // 
            // NegAlarm
            // 
            this.NegAlarm.DataPropertyName = "NegAlarm";
            this.NegAlarm.HeaderText = "下降沿";
            this.NegAlarm.Name = "NegAlarm";
            this.NegAlarm.ReadOnly = true;
            this.NegAlarm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NegAlarm.Width = 80;
            // 
            // GroupName
            // 
            this.GroupName.DataPropertyName = "GroupName";
            this.GroupName.HeaderText = "通信组";
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            this.GroupName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Remark
            // 
            this.Remark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "备注说明";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            this.Remark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "数据类型";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(21, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "备注说明";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "备注说明";
            // 
            // TextRemark
            // 
            this.TextRemark.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.TextRemark.Location = new System.Drawing.Point(129, 179);
            this.TextRemark.Name = "TextRemark";
            this.TextRemark.Size = new System.Drawing.Size(432, 29);
            this.TextRemark.TabIndex = 12;
            this.TextRemark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextVarName
            // 
            this.TextVarName.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.TextVarName.Location = new System.Drawing.Point(378, 81);
            this.TextVarName.Name = "TextVarName";
            this.TextVarName.Size = new System.Drawing.Size(183, 29);
            this.TextVarName.TabIndex = 12;
            this.TextVarName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(27)))), ((int)(((byte)(78)))));
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(588, 175);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(113, 36);
            this.BtnAdd.TabIndex = 13;
            this.BtnAdd.Text = "新增变量";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(27)))), ((int)(((byte)(78)))));
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(730, 175);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(113, 36);
            this.DeleteBtn.TabIndex = 14;
            this.DeleteBtn.Text = "删除变量";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ModifyBtn
            // 
            this.ModifyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(27)))), ((int)(((byte)(78)))));
            this.ModifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifyBtn.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.ModifyBtn.ForeColor = System.Drawing.Color.White;
            this.ModifyBtn.Location = new System.Drawing.Point(872, 175);
            this.ModifyBtn.Name = "ModifyBtn";
            this.ModifyBtn.Size = new System.Drawing.Size(113, 36);
            this.ModifyBtn.TabIndex = 15;
            this.ModifyBtn.Text = "修改变量";
            this.ModifyBtn.UseVisualStyleBackColor = false;
            this.ModifyBtn.Click += new System.EventHandler(this.ModifyBtn_Click);
            // 
            // CmbGroupName
            // 
            this.CmbGroupName.FormattingEnabled = true;
            this.CmbGroupName.Location = new System.Drawing.Point(129, 81);
            this.CmbGroupName.Name = "CmbGroupName";
            this.CmbGroupName.Size = new System.Drawing.Size(132, 29);
            this.CmbGroupName.TabIndex = 16;
            // 
            // CmbDataType
            // 
            this.CmbDataType.FormattingEnabled = true;
            this.CmbDataType.Location = new System.Drawing.Point(129, 131);
            this.CmbDataType.Name = "CmbDataType";
            this.CmbDataType.Size = new System.Drawing.Size(132, 29);
            this.CmbDataType.TabIndex = 16;
            // 
            // panelPro1
            // 
            this.panelPro1.BackColor = System.Drawing.Color.Transparent;
            this.panelPro1.BackgroundImage = global::wgd.MTHProject.Properties.Resources.mainpanel_bg;
            this.panelPro1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPro1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(79)))), ((int)(((byte)(150)))));
            this.panelPro1.BorderWidth = 1;
            this.panelPro1.BottomGap = 1;
            this.panelPro1.Controls.Add(this.CheckNegAlarm);
            this.panelPro1.Controls.Add(this.CheckPosAlarm);
            this.panelPro1.Controls.Add(this.CmbDataType);
            this.panelPro1.Controls.Add(this.CmbGroupName);
            this.panelPro1.Controls.Add(this.ModifyBtn);
            this.panelPro1.Controls.Add(this.DeleteBtn);
            this.panelPro1.Controls.Add(this.BtnAdd);
            this.panelPro1.Controls.Add(this.TextVarName);
            this.panelPro1.Controls.Add(this.TextRemark);
            this.panelPro1.Controls.Add(this.label8);
            this.panelPro1.Controls.Add(this.label9);
            this.panelPro1.Controls.Add(this.label6);
            this.panelPro1.Controls.Add(this.DgvData);
            this.panelPro1.Controls.Add(this.label10);
            this.panelPro1.Controls.Add(this.NumOffset);
            this.panelPro1.Controls.Add(this.NumLength);
            this.panelPro1.Controls.Add(this.label12);
            this.panelPro1.Controls.Add(this.label5);
            this.panelPro1.Controls.Add(this.NumScale);
            this.panelPro1.Controls.Add(this.NumStart);
            this.panelPro1.Controls.Add(this.label7);
            this.panelPro1.Controls.Add(this.label11);
            this.panelPro1.Controls.Add(this.label4);
            this.panelPro1.Controls.Add(this.label3);
            this.panelPro1.Controls.Add(this.label2);
            this.panelPro1.Controls.Add(this.panel1);
            this.panelPro1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPro1.LeftGap = 1;
            this.panelPro1.Location = new System.Drawing.Point(0, 0);
            this.panelPro1.Name = "panelPro1";
            this.panelPro1.RrightGap = 1;
            this.panelPro1.Size = new System.Drawing.Size(1010, 666);
            this.panelPro1.TabIndex = 0;
            this.panelPro1.TopGap = 1;
            // 
            // CheckNegAlarm
            // 
            this.CheckNegAlarm.BoxBackColor = System.Drawing.Color.White;
            this.CheckNegAlarm.CheckBoxWidth = 20;
            this.CheckNegAlarm.ForeColor = System.Drawing.Color.White;
            this.CheckNegAlarm.Location = new System.Drawing.Point(434, 130);
            this.CheckNegAlarm.Name = "CheckNegAlarm";
            this.CheckNegAlarm.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.CheckNegAlarm.Size = new System.Drawing.Size(127, 27);
            this.CheckNegAlarm.TabIndex = 17;
            this.CheckNegAlarm.Text = "下升沿报警";
            this.CheckNegAlarm.UseVisualStyleBackColor = true;
            // 
            // CheckPosAlarm
            // 
            this.CheckPosAlarm.BoxBackColor = System.Drawing.Color.White;
            this.CheckPosAlarm.CheckBoxWidth = 20;
            this.CheckPosAlarm.ForeColor = System.Drawing.Color.White;
            this.CheckPosAlarm.Location = new System.Drawing.Point(298, 132);
            this.CheckPosAlarm.Name = "CheckPosAlarm";
            this.CheckPosAlarm.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.CheckPosAlarm.Size = new System.Drawing.Size(127, 27);
            this.CheckPosAlarm.TabIndex = 17;
            this.CheckPosAlarm.Text = "上升沿报警";
            this.CheckPosAlarm.UseVisualStyleBackColor = true;
            // 
            // FormVariableConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 666);
            this.Controls.Add(this.panelPro1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormVariableConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGroupConfig";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.panelPro1.ResumeLayout(false);
            this.panelPro1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NumStart;
        private System.Windows.Forms.NumericUpDown NumScale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown NumLength;
        private System.Windows.Forms.NumericUpDown NumOffset;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextRemark;
        private System.Windows.Forms.TextBox TextVarName;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ModifyBtn;
        private System.Windows.Forms.ComboBox CmbGroupName;
        private System.Windows.Forms.ComboBox CmbDataType;
        private MTHControlLib.PanelPro panelPro1;
        private MTHControlLib.CheckBoxPro CheckNegAlarm;
        private MTHControlLib.CheckBoxPro CheckPosAlarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn VarName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn OffsetOrLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataType;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Scale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Offset;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosAlarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn NegAlarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
    }
}
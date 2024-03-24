
namespace wgd.MTHProject
{
    partial class FormUserManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserManage));
            this.TextUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextSurepwd = new System.Windows.Forms.TextBox();
            this.BtnAllSelect = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.ModifyBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EmptyBtn = new System.Windows.Forms.Button();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.LoginName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginPwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParamSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryLog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryTrend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserManage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckHistory = new wgd.MTHControlLib.CheckBoxPro();
            this.CheckRecipe = new wgd.MTHControlLib.CheckBoxPro();
            this.CheckUser = new wgd.MTHControlLib.CheckBoxPro();
            this.CheckAlarm = new wgd.MTHControlLib.CheckBoxPro();
            this.CheckParam = new wgd.MTHControlLib.CheckBoxPro();
            this.naviButton3 = new wgd.MTHControlLib.NaviButton();
            this.naviButton2 = new wgd.MTHControlLib.NaviButton();
            this.naviButton1 = new wgd.MTHControlLib.NaviButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // TextUsername
            // 
            this.TextUsername.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.TextUsername.Location = new System.Drawing.Point(134, 85);
            this.TextUsername.Name = "TextUsername";
            this.TextUsername.Size = new System.Drawing.Size(152, 29);
            this.TextUsername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "用户名称:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户密码:";
            // 
            // TextPwd
            // 
            this.TextPwd.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.TextPwd.Location = new System.Drawing.Point(134, 138);
            this.TextPwd.Name = "TextPwd";
            this.TextPwd.PasswordChar = '*';
            this.TextPwd.Size = new System.Drawing.Size(152, 29);
            this.TextPwd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码:";
            // 
            // TextSurepwd
            // 
            this.TextSurepwd.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.TextSurepwd.Location = new System.Drawing.Point(134, 193);
            this.TextSurepwd.Name = "TextSurepwd";
            this.TextSurepwd.PasswordChar = '*';
            this.TextSurepwd.Size = new System.Drawing.Size(152, 29);
            this.TextSurepwd.TabIndex = 1;
            // 
            // BtnAllSelect
            // 
            this.BtnAllSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(27)))), ((int)(((byte)(78)))));
            this.BtnAllSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAllSelect.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.BtnAllSelect.ForeColor = System.Drawing.Color.White;
            this.BtnAllSelect.Location = new System.Drawing.Point(178, 416);
            this.BtnAllSelect.Name = "BtnAllSelect";
            this.BtnAllSelect.Size = new System.Drawing.Size(104, 33);
            this.BtnAllSelect.TabIndex = 26;
            this.BtnAllSelect.Text = "全 选";
            this.BtnAllSelect.UseVisualStyleBackColor = false;
            this.BtnAllSelect.Click += new System.EventHandler(this.BtnAllSelect_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(27)))), ((int)(((byte)(78)))));
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(38, 565);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(108, 40);
            this.BtnAdd.TabIndex = 27;
            this.BtnAdd.Text = "添加用户";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // ModifyBtn
            // 
            this.ModifyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(27)))), ((int)(((byte)(78)))));
            this.ModifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifyBtn.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.ModifyBtn.ForeColor = System.Drawing.Color.White;
            this.ModifyBtn.Location = new System.Drawing.Point(174, 565);
            this.ModifyBtn.Name = "ModifyBtn";
            this.ModifyBtn.Size = new System.Drawing.Size(108, 40);
            this.ModifyBtn.TabIndex = 27;
            this.ModifyBtn.Text = "修改用户";
            this.ModifyBtn.UseVisualStyleBackColor = false;
            this.ModifyBtn.Click += new System.EventHandler(this.ModifyBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(27)))), ((int)(((byte)(78)))));
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(38, 634);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(108, 40);
            this.DeleteBtn.TabIndex = 27;
            this.DeleteBtn.Text = "删除用户";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EmptyBtn
            // 
            this.EmptyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(27)))), ((int)(((byte)(78)))));
            this.EmptyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmptyBtn.Font = new System.Drawing.Font("微软雅黑", 12.5F);
            this.EmptyBtn.ForeColor = System.Drawing.Color.White;
            this.EmptyBtn.Location = new System.Drawing.Point(174, 634);
            this.EmptyBtn.Name = "EmptyBtn";
            this.EmptyBtn.Size = new System.Drawing.Size(108, 40);
            this.EmptyBtn.TabIndex = 27;
            this.EmptyBtn.Text = "清空信息";
            this.EmptyBtn.UseVisualStyleBackColor = false;
            this.EmptyBtn.Click += new System.EventHandler(this.EmptyBtn_Click);
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
            this.LoginName,
            this.LoginPwd,
            this.ParamSet,
            this.Recipe,
            this.HistoryLog,
            this.HistoryTrend,
            this.UserManage,
            this.LoginId});
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
            this.DgvData.Location = new System.Drawing.Point(337, 22);
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
            this.DgvData.Size = new System.Drawing.Size(1030, 678);
            this.DgvData.TabIndex = 28;
            this.DgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellClick);
            this.DgvData.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvData_RowPostPaint);
            // 
            // LoginName
            // 
            this.LoginName.DataPropertyName = "LoginName";
            this.LoginName.HeaderText = "用户名";
            this.LoginName.Name = "LoginName";
            this.LoginName.ReadOnly = true;
            this.LoginName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LoginName.Width = 170;
            // 
            // LoginPwd
            // 
            this.LoginPwd.DataPropertyName = "LoginPwd";
            this.LoginPwd.HeaderText = "用户密码";
            this.LoginPwd.Name = "LoginPwd";
            this.LoginPwd.ReadOnly = true;
            this.LoginPwd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LoginPwd.Width = 130;
            // 
            // ParamSet
            // 
            this.ParamSet.DataPropertyName = "ParamSet";
            this.ParamSet.HeaderText = "参数设置";
            this.ParamSet.Name = "ParamSet";
            this.ParamSet.ReadOnly = true;
            this.ParamSet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ParamSet.Width = 130;
            // 
            // Recipe
            // 
            this.Recipe.DataPropertyName = "Recipe";
            this.Recipe.HeaderText = "配方管理";
            this.Recipe.Name = "Recipe";
            this.Recipe.ReadOnly = true;
            this.Recipe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Recipe.Width = 130;
            // 
            // HistoryLog
            // 
            this.HistoryLog.DataPropertyName = "HistoryLog";
            this.HistoryLog.HeaderText = "报警追溯";
            this.HistoryLog.Name = "HistoryLog";
            this.HistoryLog.ReadOnly = true;
            this.HistoryLog.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.HistoryLog.Width = 130;
            // 
            // HistoryTrend
            // 
            this.HistoryTrend.DataPropertyName = "HistoryTrend";
            this.HistoryTrend.HeaderText = "历史趋势";
            this.HistoryTrend.Name = "HistoryTrend";
            this.HistoryTrend.ReadOnly = true;
            this.HistoryTrend.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.HistoryTrend.Width = 130;
            // 
            // UserManage
            // 
            this.UserManage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserManage.DataPropertyName = "UserManage";
            this.UserManage.HeaderText = "用户管理";
            this.UserManage.Name = "UserManage";
            this.UserManage.ReadOnly = true;
            this.UserManage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LoginId
            // 
            this.LoginId.DataPropertyName = "LoginId";
            this.LoginId.HeaderText = "用户Id";
            this.LoginId.Name = "LoginId";
            this.LoginId.ReadOnly = true;
            this.LoginId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LoginId.Visible = false;
            this.LoginId.Width = 50;
            // 
            // CheckHistory
            // 
            this.CheckHistory.BackColor = System.Drawing.Color.Transparent;
            this.CheckHistory.BoxBackColor = System.Drawing.Color.White;
            this.CheckHistory.CheckBoxWidth = 20;
            this.CheckHistory.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckHistory.ForeColor = System.Drawing.Color.White;
            this.CheckHistory.Location = new System.Drawing.Point(178, 367);
            this.CheckHistory.Name = "CheckHistory";
            this.CheckHistory.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.CheckHistory.Size = new System.Drawing.Size(108, 33);
            this.CheckHistory.TabIndex = 25;
            this.CheckHistory.Tag = "Station2Temp";
            this.CheckHistory.Text = "历史曲线";
            this.CheckHistory.UseVisualStyleBackColor = false;
            // 
            // CheckRecipe
            // 
            this.CheckRecipe.BackColor = System.Drawing.Color.Transparent;
            this.CheckRecipe.BoxBackColor = System.Drawing.Color.White;
            this.CheckRecipe.CheckBoxWidth = 20;
            this.CheckRecipe.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckRecipe.ForeColor = System.Drawing.Color.White;
            this.CheckRecipe.Location = new System.Drawing.Point(178, 319);
            this.CheckRecipe.Name = "CheckRecipe";
            this.CheckRecipe.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.CheckRecipe.Size = new System.Drawing.Size(108, 33);
            this.CheckRecipe.TabIndex = 25;
            this.CheckRecipe.Tag = "Station2Temp";
            this.CheckRecipe.Text = "配方管理";
            this.CheckRecipe.UseVisualStyleBackColor = false;
            // 
            // CheckUser
            // 
            this.CheckUser.BackColor = System.Drawing.Color.Transparent;
            this.CheckUser.BoxBackColor = System.Drawing.Color.White;
            this.CheckUser.CheckBoxWidth = 20;
            this.CheckUser.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckUser.ForeColor = System.Drawing.Color.White;
            this.CheckUser.Location = new System.Drawing.Point(38, 416);
            this.CheckUser.Name = "CheckUser";
            this.CheckUser.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.CheckUser.Size = new System.Drawing.Size(108, 33);
            this.CheckUser.TabIndex = 25;
            this.CheckUser.Tag = "Station2Temp";
            this.CheckUser.Text = "用户管理";
            this.CheckUser.UseVisualStyleBackColor = false;
            // 
            // CheckAlarm
            // 
            this.CheckAlarm.BackColor = System.Drawing.Color.Transparent;
            this.CheckAlarm.BoxBackColor = System.Drawing.Color.White;
            this.CheckAlarm.CheckBoxWidth = 20;
            this.CheckAlarm.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckAlarm.ForeColor = System.Drawing.Color.White;
            this.CheckAlarm.Location = new System.Drawing.Point(38, 367);
            this.CheckAlarm.Name = "CheckAlarm";
            this.CheckAlarm.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.CheckAlarm.Size = new System.Drawing.Size(108, 33);
            this.CheckAlarm.TabIndex = 25;
            this.CheckAlarm.Tag = "Station2Temp";
            this.CheckAlarm.Text = "报警追溯";
            this.CheckAlarm.UseVisualStyleBackColor = false;
            // 
            // CheckParam
            // 
            this.CheckParam.BackColor = System.Drawing.Color.Transparent;
            this.CheckParam.BoxBackColor = System.Drawing.Color.White;
            this.CheckParam.CheckBoxWidth = 20;
            this.CheckParam.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CheckParam.ForeColor = System.Drawing.Color.White;
            this.CheckParam.Location = new System.Drawing.Point(38, 319);
            this.CheckParam.Name = "CheckParam";
            this.CheckParam.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(25)))), ((int)(((byte)(66)))));
            this.CheckParam.Size = new System.Drawing.Size(108, 33);
            this.CheckParam.TabIndex = 25;
            this.CheckParam.Tag = "Station2Temp";
            this.CheckParam.Text = "参数设置";
            this.CheckParam.UseVisualStyleBackColor = false;
            // 
            // naviButton3
            // 
            this.naviButton3.BackColor = System.Drawing.Color.Transparent;
            this.naviButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("naviButton3.BackgroundImage")));
            this.naviButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.naviButton3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.naviButton3.IsSelected = false;
            this.naviButton3.Location = new System.Drawing.Point(38, 497);
            this.naviButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.naviButton3.Name = "naviButton3";
            this.naviButton3.Size = new System.Drawing.Size(91, 30);
            this.naviButton3.TabIndex = 0;
            this.naviButton3.TitleName = "用户操作";
            // 
            // naviButton2
            // 
            this.naviButton2.BackColor = System.Drawing.Color.Transparent;
            this.naviButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("naviButton2.BackgroundImage")));
            this.naviButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.naviButton2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.naviButton2.IsSelected = false;
            this.naviButton2.Location = new System.Drawing.Point(38, 260);
            this.naviButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.naviButton2.Name = "naviButton2";
            this.naviButton2.Size = new System.Drawing.Size(91, 30);
            this.naviButton2.TabIndex = 0;
            this.naviButton2.TitleName = "权限配置";
            // 
            // naviButton1
            // 
            this.naviButton1.BackColor = System.Drawing.Color.Transparent;
            this.naviButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("naviButton1.BackgroundImage")));
            this.naviButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.naviButton1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.naviButton1.IsSelected = false;
            this.naviButton1.Location = new System.Drawing.Point(38, 30);
            this.naviButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.naviButton1.Name = "naviButton1";
            this.naviButton1.Size = new System.Drawing.Size(91, 30);
            this.naviButton1.TabIndex = 0;
            this.naviButton1.TitleName = "用户信息";
            // 
            // FormUserManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::wgd.MTHProject.Properties.Resources.mainpanel_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1394, 724);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.EmptyBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ModifyBtn);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnAllSelect);
            this.Controls.Add(this.CheckHistory);
            this.Controls.Add(this.CheckRecipe);
            this.Controls.Add(this.CheckUser);
            this.Controls.Add(this.CheckAlarm);
            this.Controls.Add(this.CheckParam);
            this.Controls.Add(this.TextSurepwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextPwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.naviButton3);
            this.Controls.Add(this.naviButton2);
            this.Controls.Add(this.naviButton1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormUserManage";
            this.Text = "用户管理";
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MTHControlLib.NaviButton naviButton1;
        private System.Windows.Forms.TextBox TextUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextSurepwd;
        private MTHControlLib.NaviButton naviButton2;
        private MTHControlLib.CheckBoxPro CheckParam;
        private MTHControlLib.CheckBoxPro CheckRecipe;
        private MTHControlLib.CheckBoxPro CheckHistory;
        private MTHControlLib.CheckBoxPro CheckUser;
        private System.Windows.Forms.Button BtnAllSelect;
        private MTHControlLib.NaviButton naviButton3;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button ModifyBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EmptyBtn;
        private System.Windows.Forms.DataGridView DgvData;
        private MTHControlLib.CheckBoxPro CheckAlarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginPwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParamSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryTrend;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserManage;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginId;
    }
}
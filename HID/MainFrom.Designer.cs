namespace HID
{
    partial class MainFrom
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
            this.components = new System.ComponentModel.Container();
            this.tbc_Fun = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_SetBoard = new System.Windows.Forms.Button();
            this.gbx_basic = new System.Windows.Forms.GroupBox();
            this.tbxIcNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxCarNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_ReSet = new System.Windows.Forms.Button();
            this.btn_set_bl = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.gbx_SetCount = new System.Windows.Forms.GroupBox();
            this.rdbtn_SetCountN = new System.Windows.Forms.RadioButton();
            this.rdbtn_SetCountY = new System.Windows.Forms.RadioButton();
            this.tbxCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbx_SetDay = new System.Windows.Forms.GroupBox();
            this.rdbtn_SetDayN = new System.Windows.Forms.RadioButton();
            this.rdbtn_SetDayY = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_EndDay = new System.Windows.Forms.DateTimePicker();
            this.dtp_StartDay = new System.Windows.Forms.DateTimePicker();
            this.gbx_SetWeekDay = new System.Windows.Forms.GroupBox();
            this.cbx_Sun = new System.Windows.Forms.CheckBox();
            this.cbx_Sat = new System.Windows.Forms.CheckBox();
            this.cbx_Fri = new System.Windows.Forms.CheckBox();
            this.cbx_Thu = new System.Windows.Forms.CheckBox();
            this.cbx_Wed = new System.Windows.Forms.CheckBox();
            this.cbx_Tue = new System.Windows.Forms.CheckBox();
            this.cbx_Mon = new System.Windows.Forms.CheckBox();
            this.rdbtn_SetWeekDayN = new System.Windows.Forms.RadioButton();
            this.rdbtn_SetWeekDayY = new System.Windows.Forms.RadioButton();
            this.gbx_SetTime = new System.Windows.Forms.GroupBox();
            this.rdbtn_SetTimeN = new System.Windows.Forms.RadioButton();
            this.rdbtn_SetTimeY = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_TimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dtp_TimeStart = new System.Windows.Forms.DateTimePicker();
            this.btn_SetDataTime = new System.Windows.Forms.Button();
            this.btn_count = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.btn_oldIC_clear = new System.Windows.Forms.Button();
            this.btn_newICw = new System.Windows.Forms.Button();
            this.btn_write = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_import = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_clr = new System.Windows.Forms.Button();
            this.dgv_IcData = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgv_mb_data = new System.Windows.Forms.DataGridView();
            this.sts = new System.Windows.Forms.StatusStrip();
            this.sts_lable = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbc_Fun.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbx_basic.SuspendLayout();
            this.gbx_SetCount.SuspendLayout();
            this.gbx_SetDay.SuspendLayout();
            this.gbx_SetWeekDay.SuspendLayout();
            this.gbx_SetTime.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IcData)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mb_data)).BeginInit();
            this.sts.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_Fun
            // 
            this.tbc_Fun.Controls.Add(this.tabPage1);
            this.tbc_Fun.Controls.Add(this.tabPage2);
            this.tbc_Fun.Controls.Add(this.tabPage3);
            this.tbc_Fun.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbc_Fun.ItemSize = new System.Drawing.Size(160, 48);
            this.tbc_Fun.Location = new System.Drawing.Point(0, 0);
            this.tbc_Fun.Name = "tbc_Fun";
            this.tbc_Fun.SelectedIndex = 0;
            this.tbc_Fun.Size = new System.Drawing.Size(843, 586);
            this.tbc_Fun.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbc_Fun.TabIndex = 0;
            this.tbc_Fun.SelectedIndexChanged += new System.EventHandler(this.tbc_Fun_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.btn_SetBoard);
            this.tabPage1.Controls.Add(this.gbx_basic);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.btn_ReSet);
            this.tabPage1.Controls.Add(this.btn_set_bl);
            this.tabPage1.Controls.Add(this.btn_read);
            this.tabPage1.Controls.Add(this.gbx_SetCount);
            this.tabPage1.Controls.Add(this.gbx_SetDay);
            this.tabPage1.Controls.Add(this.gbx_SetWeekDay);
            this.tabPage1.Controls.Add(this.gbx_SetTime);
            this.tabPage1.Controls.Add(this.btn_SetDataTime);
            this.tabPage1.Controls.Add(this.btn_count);
            this.tabPage1.Controls.Add(this.btn_check);
            this.tabPage1.Controls.Add(this.btn_oldIC_clear);
            this.tabPage1.Controls.Add(this.btn_newICw);
            this.tabPage1.Controls.Add(this.btn_write);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 52);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(835, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "发卡";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 64;
            this.label9.Text = "按钮有效时间：";
            this.label9.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 291);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(87, 21);
            this.textBox2.TabIndex = 65;
            this.textBox2.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(29, 353);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(447, 20);
            this.comboBox1.TabIndex = 61;
            this.comboBox1.Visible = false;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_SetBoard
            // 
            this.btn_SetBoard.Location = new System.Drawing.Point(671, 468);
            this.btn_SetBoard.Name = "btn_SetBoard";
            this.btn_SetBoard.Size = new System.Drawing.Size(109, 41);
            this.btn_SetBoard.TabIndex = 59;
            this.btn_SetBoard.Text = "读主板ID";
            this.btn_SetBoard.UseVisualStyleBackColor = true;
            this.btn_SetBoard.Click += new System.EventHandler(this.btn_SetBoard_Click);
            // 
            // gbx_basic
            // 
            this.gbx_basic.Controls.Add(this.tbxIcNum);
            this.gbx_basic.Controls.Add(this.label8);
            this.gbx_basic.Controls.Add(this.tbxCarNum);
            this.gbx_basic.Controls.Add(this.label7);
            this.gbx_basic.Controls.Add(this.tbxName);
            this.gbx_basic.Controls.Add(this.label6);
            this.gbx_basic.Location = new System.Drawing.Point(20, 35);
            this.gbx_basic.Name = "gbx_basic";
            this.gbx_basic.Size = new System.Drawing.Size(199, 170);
            this.gbx_basic.TabIndex = 58;
            this.gbx_basic.TabStop = false;
            this.gbx_basic.Text = "基本信息";
            // 
            // tbxIcNum
            // 
            this.tbxIcNum.Location = new System.Drawing.Point(94, 99);
            this.tbxIcNum.Name = "tbxIcNum";
            this.tbxIcNum.Size = new System.Drawing.Size(87, 21);
            this.tbxIcNum.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 62;
            this.label8.Text = "卡号：";
            // 
            // tbxCarNum
            // 
            this.tbxCarNum.Location = new System.Drawing.Point(94, 65);
            this.tbxCarNum.Name = "tbxCarNum";
            this.tbxCarNum.Size = new System.Drawing.Size(87, 21);
            this.tbxCarNum.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 60;
            this.label7.Text = "电梯系统号：";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(94, 26);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(87, 21);
            this.tbxName.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 59;
            this.label6.Text = "业主姓名：";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(591, 210);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(178, 146);
            this.textBox1.TabIndex = 42;
            this.textBox1.Visible = false;
            // 
            // btn_ReSet
            // 
            this.btn_ReSet.Location = new System.Drawing.Point(519, 468);
            this.btn_ReSet.Name = "btn_ReSet";
            this.btn_ReSet.Size = new System.Drawing.Size(107, 41);
            this.btn_ReSet.TabIndex = 57;
            this.btn_ReSet.Text = "恢复出厂设置卡";
            this.btn_ReSet.UseVisualStyleBackColor = true;
            this.btn_ReSet.Click += new System.EventHandler(this.btn_ReSet_Click);
            // 
            // btn_set_bl
            // 
            this.btn_set_bl.Location = new System.Drawing.Point(368, 468);
            this.btn_set_bl.Name = "btn_set_bl";
            this.btn_set_bl.Size = new System.Drawing.Size(108, 41);
            this.btn_set_bl.TabIndex = 56;
            this.btn_set_bl.Text = "并联使用设置卡";
            this.btn_set_bl.UseVisualStyleBackColor = true;
            this.btn_set_bl.Click += new System.EventHandler(this.btn_set_bl_Click);
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(65, 468);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(107, 41);
            this.btn_read.TabIndex = 55;
            this.btn_read.Text = "读卡";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // gbx_SetCount
            // 
            this.gbx_SetCount.Controls.Add(this.rdbtn_SetCountN);
            this.gbx_SetCount.Controls.Add(this.rdbtn_SetCountY);
            this.gbx_SetCount.Controls.Add(this.tbxCount);
            this.gbx_SetCount.Controls.Add(this.label1);
            this.gbx_SetCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbx_SetCount.Location = new System.Drawing.Point(237, 42);
            this.gbx_SetCount.Name = "gbx_SetCount";
            this.gbx_SetCount.Size = new System.Drawing.Size(263, 53);
            this.gbx_SetCount.TabIndex = 54;
            this.gbx_SetCount.TabStop = false;
            this.gbx_SetCount.Text = "是否限定次数";
            // 
            // rdbtn_SetCountN
            // 
            this.rdbtn_SetCountN.AutoSize = true;
            this.rdbtn_SetCountN.Location = new System.Drawing.Point(60, 23);
            this.rdbtn_SetCountN.Name = "rdbtn_SetCountN";
            this.rdbtn_SetCountN.Size = new System.Drawing.Size(35, 16);
            this.rdbtn_SetCountN.TabIndex = 30;
            this.rdbtn_SetCountN.TabStop = true;
            this.rdbtn_SetCountN.Text = "否";
            this.rdbtn_SetCountN.UseVisualStyleBackColor = true;
            this.rdbtn_SetCountN.CheckedChanged += new System.EventHandler(this.rdbtn_SetCountN_CheckedChanged);
            // 
            // rdbtn_SetCountY
            // 
            this.rdbtn_SetCountY.AutoSize = true;
            this.rdbtn_SetCountY.Location = new System.Drawing.Point(13, 23);
            this.rdbtn_SetCountY.Name = "rdbtn_SetCountY";
            this.rdbtn_SetCountY.Size = new System.Drawing.Size(35, 16);
            this.rdbtn_SetCountY.TabIndex = 29;
            this.rdbtn_SetCountY.TabStop = true;
            this.rdbtn_SetCountY.Text = "是";
            this.rdbtn_SetCountY.UseVisualStyleBackColor = true;
            this.rdbtn_SetCountY.CheckedChanged += new System.EventHandler(this.rdbtn_SetCountY_CheckedChanged);
            // 
            // tbxCount
            // 
            this.tbxCount.Location = new System.Drawing.Point(207, 22);
            this.tbxCount.Name = "tbxCount";
            this.tbxCount.Size = new System.Drawing.Size(43, 21);
            this.tbxCount.TabIndex = 28;
            this.tbxCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "限定刷卡次数：";
            // 
            // gbx_SetDay
            // 
            this.gbx_SetDay.Controls.Add(this.rdbtn_SetDayN);
            this.gbx_SetDay.Controls.Add(this.rdbtn_SetDayY);
            this.gbx_SetDay.Controls.Add(this.label4);
            this.gbx_SetDay.Controls.Add(this.label2);
            this.gbx_SetDay.Controls.Add(this.dtp_EndDay);
            this.gbx_SetDay.Controls.Add(this.dtp_StartDay);
            this.gbx_SetDay.Location = new System.Drawing.Point(528, 113);
            this.gbx_SetDay.Name = "gbx_SetDay";
            this.gbx_SetDay.Size = new System.Drawing.Size(285, 92);
            this.gbx_SetDay.TabIndex = 53;
            this.gbx_SetDay.TabStop = false;
            this.gbx_SetDay.Text = "是否限定期限";
            // 
            // rdbtn_SetDayN
            // 
            this.rdbtn_SetDayN.AutoSize = true;
            this.rdbtn_SetDayN.Location = new System.Drawing.Point(13, 59);
            this.rdbtn_SetDayN.Name = "rdbtn_SetDayN";
            this.rdbtn_SetDayN.Size = new System.Drawing.Size(35, 16);
            this.rdbtn_SetDayN.TabIndex = 1;
            this.rdbtn_SetDayN.TabStop = true;
            this.rdbtn_SetDayN.Text = "否";
            this.rdbtn_SetDayN.UseVisualStyleBackColor = true;
            this.rdbtn_SetDayN.CheckedChanged += new System.EventHandler(this.rdbtn_SetDayN_CheckedChanged);
            // 
            // rdbtn_SetDayY
            // 
            this.rdbtn_SetDayY.AutoSize = true;
            this.rdbtn_SetDayY.Location = new System.Drawing.Point(13, 25);
            this.rdbtn_SetDayY.Name = "rdbtn_SetDayY";
            this.rdbtn_SetDayY.Size = new System.Drawing.Size(35, 16);
            this.rdbtn_SetDayY.TabIndex = 0;
            this.rdbtn_SetDayY.TabStop = true;
            this.rdbtn_SetDayY.Text = "是";
            this.rdbtn_SetDayY.UseVisualStyleBackColor = true;
            this.rdbtn_SetDayY.CheckedChanged += new System.EventHandler(this.rdbtn_SetDayY_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "有效期结束时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "有效期起始时间";
            // 
            // dtp_EndDay
            // 
            this.dtp_EndDay.Location = new System.Drawing.Point(161, 56);
            this.dtp_EndDay.Name = "dtp_EndDay";
            this.dtp_EndDay.Size = new System.Drawing.Size(118, 21);
            this.dtp_EndDay.TabIndex = 3;
            // 
            // dtp_StartDay
            // 
            this.dtp_StartDay.CustomFormat = "yyyy-MM-dd";
            this.dtp_StartDay.Location = new System.Drawing.Point(161, 23);
            this.dtp_StartDay.Name = "dtp_StartDay";
            this.dtp_StartDay.Size = new System.Drawing.Size(118, 21);
            this.dtp_StartDay.TabIndex = 2;
            // 
            // gbx_SetWeekDay
            // 
            this.gbx_SetWeekDay.Controls.Add(this.cbx_Sun);
            this.gbx_SetWeekDay.Controls.Add(this.cbx_Sat);
            this.gbx_SetWeekDay.Controls.Add(this.cbx_Fri);
            this.gbx_SetWeekDay.Controls.Add(this.cbx_Thu);
            this.gbx_SetWeekDay.Controls.Add(this.cbx_Wed);
            this.gbx_SetWeekDay.Controls.Add(this.cbx_Tue);
            this.gbx_SetWeekDay.Controls.Add(this.cbx_Mon);
            this.gbx_SetWeekDay.Controls.Add(this.rdbtn_SetWeekDayN);
            this.gbx_SetWeekDay.Controls.Add(this.rdbtn_SetWeekDayY);
            this.gbx_SetWeekDay.Location = new System.Drawing.Point(237, 113);
            this.gbx_SetWeekDay.Name = "gbx_SetWeekDay";
            this.gbx_SetWeekDay.Size = new System.Drawing.Size(263, 92);
            this.gbx_SetWeekDay.TabIndex = 52;
            this.gbx_SetWeekDay.TabStop = false;
            this.gbx_SetWeekDay.Text = "是否限定日期";
            // 
            // cbx_Sun
            // 
            this.cbx_Sun.AutoSize = true;
            this.cbx_Sun.Location = new System.Drawing.Point(60, 69);
            this.cbx_Sun.Name = "cbx_Sun";
            this.cbx_Sun.Size = new System.Drawing.Size(60, 16);
            this.cbx_Sun.TabIndex = 8;
            this.cbx_Sun.Text = "星期日";
            this.cbx_Sun.UseVisualStyleBackColor = true;
            // 
            // cbx_Sat
            // 
            this.cbx_Sat.AutoSize = true;
            this.cbx_Sat.Location = new System.Drawing.Point(192, 47);
            this.cbx_Sat.Name = "cbx_Sat";
            this.cbx_Sat.Size = new System.Drawing.Size(60, 16);
            this.cbx_Sat.TabIndex = 7;
            this.cbx_Sat.Text = "星期六";
            this.cbx_Sat.UseVisualStyleBackColor = true;
            // 
            // cbx_Fri
            // 
            this.cbx_Fri.AutoSize = true;
            this.cbx_Fri.Location = new System.Drawing.Point(126, 47);
            this.cbx_Fri.Name = "cbx_Fri";
            this.cbx_Fri.Size = new System.Drawing.Size(60, 16);
            this.cbx_Fri.TabIndex = 6;
            this.cbx_Fri.Text = "星期五";
            this.cbx_Fri.UseVisualStyleBackColor = true;
            // 
            // cbx_Thu
            // 
            this.cbx_Thu.AutoSize = true;
            this.cbx_Thu.Location = new System.Drawing.Point(60, 47);
            this.cbx_Thu.Name = "cbx_Thu";
            this.cbx_Thu.Size = new System.Drawing.Size(60, 16);
            this.cbx_Thu.TabIndex = 5;
            this.cbx_Thu.Text = "星期四";
            this.cbx_Thu.UseVisualStyleBackColor = true;
            // 
            // cbx_Wed
            // 
            this.cbx_Wed.AutoSize = true;
            this.cbx_Wed.Location = new System.Drawing.Point(192, 23);
            this.cbx_Wed.Name = "cbx_Wed";
            this.cbx_Wed.Size = new System.Drawing.Size(60, 16);
            this.cbx_Wed.TabIndex = 4;
            this.cbx_Wed.Text = "星期三";
            this.cbx_Wed.UseVisualStyleBackColor = true;
            // 
            // cbx_Tue
            // 
            this.cbx_Tue.AutoSize = true;
            this.cbx_Tue.Location = new System.Drawing.Point(126, 23);
            this.cbx_Tue.Name = "cbx_Tue";
            this.cbx_Tue.Size = new System.Drawing.Size(60, 16);
            this.cbx_Tue.TabIndex = 3;
            this.cbx_Tue.Text = "星期二";
            this.cbx_Tue.UseVisualStyleBackColor = true;
            // 
            // cbx_Mon
            // 
            this.cbx_Mon.AutoSize = true;
            this.cbx_Mon.Location = new System.Drawing.Point(60, 23);
            this.cbx_Mon.Name = "cbx_Mon";
            this.cbx_Mon.Size = new System.Drawing.Size(60, 16);
            this.cbx_Mon.TabIndex = 2;
            this.cbx_Mon.Text = "星期一";
            this.cbx_Mon.UseVisualStyleBackColor = true;
            // 
            // rdbtn_SetWeekDayN
            // 
            this.rdbtn_SetWeekDayN.AutoSize = true;
            this.rdbtn_SetWeekDayN.Location = new System.Drawing.Point(12, 46);
            this.rdbtn_SetWeekDayN.Name = "rdbtn_SetWeekDayN";
            this.rdbtn_SetWeekDayN.Size = new System.Drawing.Size(35, 16);
            this.rdbtn_SetWeekDayN.TabIndex = 1;
            this.rdbtn_SetWeekDayN.TabStop = true;
            this.rdbtn_SetWeekDayN.Text = "否";
            this.rdbtn_SetWeekDayN.UseVisualStyleBackColor = true;
            this.rdbtn_SetWeekDayN.CheckedChanged += new System.EventHandler(this.rdbtn_SetWeekDayN_CheckedChanged);
            // 
            // rdbtn_SetWeekDayY
            // 
            this.rdbtn_SetWeekDayY.AutoSize = true;
            this.rdbtn_SetWeekDayY.Location = new System.Drawing.Point(12, 21);
            this.rdbtn_SetWeekDayY.Name = "rdbtn_SetWeekDayY";
            this.rdbtn_SetWeekDayY.Size = new System.Drawing.Size(35, 16);
            this.rdbtn_SetWeekDayY.TabIndex = 0;
            this.rdbtn_SetWeekDayY.TabStop = true;
            this.rdbtn_SetWeekDayY.Text = "是";
            this.rdbtn_SetWeekDayY.UseVisualStyleBackColor = true;
            this.rdbtn_SetWeekDayY.CheckedChanged += new System.EventHandler(this.rdbtn_SetWeekDayY_CheckedChanged);
            // 
            // gbx_SetTime
            // 
            this.gbx_SetTime.Controls.Add(this.rdbtn_SetTimeN);
            this.gbx_SetTime.Controls.Add(this.rdbtn_SetTimeY);
            this.gbx_SetTime.Controls.Add(this.label5);
            this.gbx_SetTime.Controls.Add(this.dtp_TimeEnd);
            this.gbx_SetTime.Controls.Add(this.dtp_TimeStart);
            this.gbx_SetTime.Location = new System.Drawing.Point(528, 42);
            this.gbx_SetTime.Name = "gbx_SetTime";
            this.gbx_SetTime.Size = new System.Drawing.Size(285, 53);
            this.gbx_SetTime.TabIndex = 51;
            this.gbx_SetTime.TabStop = false;
            this.gbx_SetTime.Text = "是否限定时段";
            // 
            // rdbtn_SetTimeN
            // 
            this.rdbtn_SetTimeN.AutoSize = true;
            this.rdbtn_SetTimeN.Location = new System.Drawing.Point(63, 23);
            this.rdbtn_SetTimeN.Name = "rdbtn_SetTimeN";
            this.rdbtn_SetTimeN.Size = new System.Drawing.Size(35, 16);
            this.rdbtn_SetTimeN.TabIndex = 1;
            this.rdbtn_SetTimeN.TabStop = true;
            this.rdbtn_SetTimeN.Text = "否";
            this.rdbtn_SetTimeN.UseVisualStyleBackColor = true;
            this.rdbtn_SetTimeN.CheckedChanged += new System.EventHandler(this.rdbtn_SetTimeN_CheckedChanged);
            // 
            // rdbtn_SetTimeY
            // 
            this.rdbtn_SetTimeY.AutoSize = true;
            this.rdbtn_SetTimeY.Location = new System.Drawing.Point(13, 23);
            this.rdbtn_SetTimeY.Name = "rdbtn_SetTimeY";
            this.rdbtn_SetTimeY.Size = new System.Drawing.Size(35, 16);
            this.rdbtn_SetTimeY.TabIndex = 0;
            this.rdbtn_SetTimeY.TabStop = true;
            this.rdbtn_SetTimeY.Text = "是";
            this.rdbtn_SetTimeY.UseVisualStyleBackColor = true;
            this.rdbtn_SetTimeY.CheckedChanged += new System.EventHandler(this.rdbtn_SetTimeY_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 33;
            this.label5.Text = "至";
            // 
            // dtp_TimeEnd
            // 
            this.dtp_TimeEnd.CustomFormat = "HH:mm";
            this.dtp_TimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_TimeEnd.Location = new System.Drawing.Point(207, 20);
            this.dtp_TimeEnd.Name = "dtp_TimeEnd";
            this.dtp_TimeEnd.ShowUpDown = true;
            this.dtp_TimeEnd.Size = new System.Drawing.Size(60, 21);
            this.dtp_TimeEnd.TabIndex = 32;
            // 
            // dtp_TimeStart
            // 
            this.dtp_TimeStart.CustomFormat = "HH:mm";
            this.dtp_TimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_TimeStart.Location = new System.Drawing.Point(118, 20);
            this.dtp_TimeStart.Name = "dtp_TimeStart";
            this.dtp_TimeStart.ShowUpDown = true;
            this.dtp_TimeStart.Size = new System.Drawing.Size(60, 21);
            this.dtp_TimeStart.TabIndex = 31;
            // 
            // btn_SetDataTime
            // 
            this.btn_SetDataTime.Location = new System.Drawing.Point(223, 468);
            this.btn_SetDataTime.Name = "btn_SetDataTime";
            this.btn_SetDataTime.Size = new System.Drawing.Size(109, 41);
            this.btn_SetDataTime.TabIndex = 50;
            this.btn_SetDataTime.Text = "设置当前时间";
            this.btn_SetDataTime.UseVisualStyleBackColor = true;
            this.btn_SetDataTime.Click += new System.EventHandler(this.btn_SetDataTime_Click);
            // 
            // btn_count
            // 
            this.btn_count.Location = new System.Drawing.Point(519, 406);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(107, 41);
            this.btn_count.TabIndex = 49;
            this.btn_count.Text = "设置管理员卡";
            this.btn_count.UseVisualStyleBackColor = true;
            this.btn_count.Click += new System.EventHandler(this.btn_count_Click);
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(65, 406);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(107, 41);
            this.btn_check.TabIndex = 48;
            this.btn_check.Text = "连接设备";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // btn_oldIC_clear
            // 
            this.btn_oldIC_clear.Enabled = false;
            this.btn_oldIC_clear.Location = new System.Drawing.Point(314, 267);
            this.btn_oldIC_clear.Name = "btn_oldIC_clear";
            this.btn_oldIC_clear.Size = new System.Drawing.Size(109, 41);
            this.btn_oldIC_clear.TabIndex = 47;
            this.btn_oldIC_clear.Text = "擦除卡片数据";
            this.btn_oldIC_clear.UseVisualStyleBackColor = true;
            this.btn_oldIC_clear.Visible = false;
            this.btn_oldIC_clear.Click += new System.EventHandler(this.btn_oldIC_clear_Click);
            // 
            // btn_newICw
            // 
            this.btn_newICw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_newICw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_newICw.Location = new System.Drawing.Point(671, 406);
            this.btn_newICw.Name = "btn_newICw";
            this.btn_newICw.Size = new System.Drawing.Size(109, 41);
            this.btn_newICw.TabIndex = 46;
            this.btn_newICw.Text = "空白卡加密";
            this.btn_newICw.UseVisualStyleBackColor = true;
            this.btn_newICw.Click += new System.EventHandler(this.btn_newICw_Click);
            // 
            // btn_write
            // 
            this.btn_write.Location = new System.Drawing.Point(223, 406);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(253, 41);
            this.btn_write.TabIndex = 45;
            this.btn_write.Text = "写卡";
            this.btn_write.UseVisualStyleBackColor = true;
            this.btn_write.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 44;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.btn_import);
            this.tabPage2.Controls.Add(this.btn_export);
            this.tabPage2.Controls.Add(this.btn_clr);
            this.tabPage2.Controls.Add(this.dgv_IcData);
            this.tabPage2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage2.Location = new System.Drawing.Point(4, 52);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(835, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "已发卡数据";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(25, 13);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(216, 21);
            this.textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(564, 13);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(69, 21);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(258, 6);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(94, 33);
            this.btn_import.TabIndex = 3;
            this.btn_import.Text = "导入数据库";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(358, 6);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(100, 33);
            this.btn_export.TabIndex = 2;
            this.btn_export.Text = "导出数据库";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_clr
            // 
            this.btn_clr.Location = new System.Drawing.Point(464, 6);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(94, 33);
            this.btn_clr.TabIndex = 1;
            this.btn_clr.Text = "清空数据库";
            this.btn_clr.UseVisualStyleBackColor = true;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // dgv_IcData
            // 
            this.dgv_IcData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_IcData.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_IcData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_IcData.Location = new System.Drawing.Point(25, 58);
            this.dgv_IcData.Name = "dgv_IcData";
            this.dgv_IcData.RowTemplate.Height = 23;
            this.dgv_IcData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_IcData.Size = new System.Drawing.Size(784, 466);
            this.dgv_IcData.TabIndex = 0;
            this.dgv_IcData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_IcData_CellContentDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgv_mb_data);
            this.tabPage3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage3.Location = new System.Drawing.Point(4, 52);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(835, 530);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "主板统计";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgv_mb_data
            // 
            this.dgv_mb_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mb_data.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_mb_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mb_data.Location = new System.Drawing.Point(23, 58);
            this.dgv_mb_data.Name = "dgv_mb_data";
            this.dgv_mb_data.RowTemplate.Height = 23;
            this.dgv_mb_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_mb_data.Size = new System.Drawing.Size(787, 466);
            this.dgv_mb_data.TabIndex = 1;
            this.dgv_mb_data.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mb_data_CellContentDoubleClick);
            // 
            // sts
            // 
            this.sts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sts_lable});
            this.sts.Location = new System.Drawing.Point(0, 591);
            this.sts.Name = "sts";
            this.sts.Size = new System.Drawing.Size(843, 22);
            this.sts.TabIndex = 41;
            this.sts.Text = "statusStrip1";
            // 
            // sts_lable
            // 
            this.sts_lable.Name = "sts_lable";
            this.sts_lable.Size = new System.Drawing.Size(118, 17);
            this.sts_lable.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 613);
            this.Controls.Add(this.sts);
            this.Controls.Add(this.tbc_Fun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainFrom";
            this.Text = "佛山恒新电子有限公司 IC卡系统软件 V2.31";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFrom_FormClosed);
            this.tbc_Fun.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbx_basic.ResumeLayout(false);
            this.gbx_basic.PerformLayout();
            this.gbx_SetCount.ResumeLayout(false);
            this.gbx_SetCount.PerformLayout();
            this.gbx_SetDay.ResumeLayout(false);
            this.gbx_SetDay.PerformLayout();
            this.gbx_SetWeekDay.ResumeLayout(false);
            this.gbx_SetWeekDay.PerformLayout();
            this.gbx_SetTime.ResumeLayout(false);
            this.gbx_SetTime.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IcData)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mb_data)).EndInit();
            this.sts.ResumeLayout(false);
            this.sts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_ReSet;
        private System.Windows.Forms.Button btn_set_bl;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.GroupBox gbx_SetCount;
        private System.Windows.Forms.RadioButton rdbtn_SetCountN;
        private System.Windows.Forms.RadioButton rdbtn_SetCountY;
        private System.Windows.Forms.TextBox tbxCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbx_SetDay;
        private System.Windows.Forms.RadioButton rdbtn_SetDayN;
        private System.Windows.Forms.RadioButton rdbtn_SetDayY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_EndDay;
        private System.Windows.Forms.DateTimePicker dtp_StartDay;
        private System.Windows.Forms.GroupBox gbx_SetWeekDay;
        private System.Windows.Forms.CheckBox cbx_Sun;
        private System.Windows.Forms.CheckBox cbx_Sat;
        private System.Windows.Forms.CheckBox cbx_Fri;
        private System.Windows.Forms.CheckBox cbx_Thu;
        private System.Windows.Forms.CheckBox cbx_Wed;
        private System.Windows.Forms.CheckBox cbx_Tue;
        private System.Windows.Forms.CheckBox cbx_Mon;
        private System.Windows.Forms.RadioButton rdbtn_SetWeekDayN;
        private System.Windows.Forms.RadioButton rdbtn_SetWeekDayY;
        private System.Windows.Forms.GroupBox gbx_SetTime;
        private System.Windows.Forms.RadioButton rdbtn_SetTimeN;
        private System.Windows.Forms.RadioButton rdbtn_SetTimeY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_TimeEnd;
        private System.Windows.Forms.DateTimePicker dtp_TimeStart;
        private System.Windows.Forms.Button btn_SetDataTime;
        private System.Windows.Forms.Button btn_count;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button btn_oldIC_clear;
        private System.Windows.Forms.Button btn_newICw;
        private System.Windows.Forms.Button btn_write;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip sts;
        private System.Windows.Forms.ToolStripStatusLabel sts_lable;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gbx_basic;
        private System.Windows.Forms.TextBox tbxIcNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxCarNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TabControl tbc_Fun;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.DataGridView dgv_IcData;
        private System.Windows.Forms.Button btn_SetBoard;
        private System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.DataGridView dgv_mb_data;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_clr;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}
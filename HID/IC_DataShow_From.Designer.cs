namespace HID
{
    partial class IC_DataShow_From
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
            this.btn_deleteRecord = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.gbx_data = new System.Windows.Forms.GroupBox();
            this.label_FloorData = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_SetTime = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_SetDay = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_SetWeekDay = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_SetCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_Car_Num = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_Car_ID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_IC_Num = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_IC_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SetBlack = new System.Windows.Forms.Button();
            this.btn_reuse = new System.Windows.Forms.Button();
            this.gbx_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_deleteRecord
            // 
            this.btn_deleteRecord.Location = new System.Drawing.Point(436, 26);
            this.btn_deleteRecord.Name = "btn_deleteRecord";
            this.btn_deleteRecord.Size = new System.Drawing.Size(89, 30);
            this.btn_deleteRecord.TabIndex = 0;
            this.btn_deleteRecord.Text = "删除卡记录";
            this.btn_deleteRecord.UseVisualStyleBackColor = true;
            this.btn_deleteRecord.Click += new System.EventHandler(this.btn_deleteRecord_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(587, 26);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(89, 29);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "退出";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // gbx_data
            // 
            this.gbx_data.Controls.Add(this.label_FloorData);
            this.gbx_data.Controls.Add(this.label12);
            this.gbx_data.Controls.Add(this.label_SetTime);
            this.gbx_data.Controls.Add(this.label11);
            this.gbx_data.Controls.Add(this.label_SetDay);
            this.gbx_data.Controls.Add(this.label10);
            this.gbx_data.Controls.Add(this.label_SetWeekDay);
            this.gbx_data.Controls.Add(this.label9);
            this.gbx_data.Controls.Add(this.label_SetCount);
            this.gbx_data.Controls.Add(this.label8);
            this.gbx_data.Controls.Add(this.label_Car_Num);
            this.gbx_data.Controls.Add(this.label6);
            this.gbx_data.Controls.Add(this.label_Car_ID);
            this.gbx_data.Controls.Add(this.label4);
            this.gbx_data.Controls.Add(this.label_IC_Num);
            this.gbx_data.Controls.Add(this.label2);
            this.gbx_data.Controls.Add(this.label_IC_ID);
            this.gbx_data.Controls.Add(this.label1);
            this.gbx_data.Location = new System.Drawing.Point(12, 89);
            this.gbx_data.Name = "gbx_data";
            this.gbx_data.Size = new System.Drawing.Size(690, 213);
            this.gbx_data.TabIndex = 2;
            this.gbx_data.TabStop = false;
            this.gbx_data.Text = "IC卡 详细信息";
            // 
            // label_FloorData
            // 
            this.label_FloorData.AutoSize = true;
            this.label_FloorData.ForeColor = System.Drawing.Color.Blue;
            this.label_FloorData.Location = new System.Drawing.Point(128, 165);
            this.label_FloorData.Name = "label_FloorData";
            this.label_FloorData.Size = new System.Drawing.Size(23, 12);
            this.label_FloorData.TabIndex = 19;
            this.label_FloorData.Text = "112";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 18;
            this.label12.Text = "可用楼层：";
            // 
            // label_SetTime
            // 
            this.label_SetTime.AutoSize = true;
            this.label_SetTime.ForeColor = System.Drawing.Color.Blue;
            this.label_SetTime.Location = new System.Drawing.Point(451, 133);
            this.label_SetTime.Name = "label_SetTime";
            this.label_SetTime.Size = new System.Drawing.Size(0, 12);
            this.label_SetTime.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(341, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 12);
            this.label11.TabIndex = 16;
            this.label11.Text = "是否限定时段：";
            // 
            // label_SetDay
            // 
            this.label_SetDay.AutoSize = true;
            this.label_SetDay.ForeColor = System.Drawing.Color.Blue;
            this.label_SetDay.Location = new System.Drawing.Point(451, 104);
            this.label_SetDay.Name = "label_SetDay";
            this.label_SetDay.Size = new System.Drawing.Size(0, 12);
            this.label_SetDay.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(341, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 14;
            this.label10.Text = "是否限定日期：";
            // 
            // label_SetWeekDay
            // 
            this.label_SetWeekDay.AutoSize = true;
            this.label_SetWeekDay.ForeColor = System.Drawing.Color.Blue;
            this.label_SetWeekDay.Location = new System.Drawing.Point(451, 70);
            this.label_SetWeekDay.Name = "label_SetWeekDay";
            this.label_SetWeekDay.Size = new System.Drawing.Size(0, 12);
            this.label_SetWeekDay.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(341, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "是否限定期限：";
            // 
            // label_SetCount
            // 
            this.label_SetCount.AutoSize = true;
            this.label_SetCount.ForeColor = System.Drawing.Color.Blue;
            this.label_SetCount.Location = new System.Drawing.Point(451, 37);
            this.label_SetCount.Name = "label_SetCount";
            this.label_SetCount.Size = new System.Drawing.Size(0, 12);
            this.label_SetCount.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "是否限定次数：";
            // 
            // label_Car_Num
            // 
            this.label_Car_Num.AutoSize = true;
            this.label_Car_Num.ForeColor = System.Drawing.Color.Blue;
            this.label_Car_Num.Location = new System.Drawing.Point(106, 133);
            this.label_Car_Num.Name = "label_Car_Num";
            this.label_Car_Num.Size = new System.Drawing.Size(0, 12);
            this.label_Car_Num.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "电梯 号：";
            // 
            // label_Car_ID
            // 
            this.label_Car_ID.AutoSize = true;
            this.label_Car_ID.ForeColor = System.Drawing.Color.Blue;
            this.label_Car_ID.Location = new System.Drawing.Point(106, 104);
            this.label_Car_ID.Name = "label_Car_ID";
            this.label_Car_ID.Size = new System.Drawing.Size(0, 12);
            this.label_Car_ID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "电梯 ID：";
            // 
            // label_IC_Num
            // 
            this.label_IC_Num.AutoSize = true;
            this.label_IC_Num.ForeColor = System.Drawing.Color.Blue;
            this.label_IC_Num.Location = new System.Drawing.Point(106, 70);
            this.label_IC_Num.Name = "label_IC_Num";
            this.label_IC_Num.Size = new System.Drawing.Size(0, 12);
            this.label_IC_Num.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "卡   号：";
            // 
            // label_IC_ID
            // 
            this.label_IC_ID.AutoSize = true;
            this.label_IC_ID.ForeColor = System.Drawing.Color.Blue;
            this.label_IC_ID.Location = new System.Drawing.Point(106, 37);
            this.label_IC_ID.Name = "label_IC_ID";
            this.label_IC_ID.Size = new System.Drawing.Size(0, 12);
            this.label_IC_ID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IC卡 ID：";
            // 
            // btn_SetBlack
            // 
            this.btn_SetBlack.Location = new System.Drawing.Point(63, 25);
            this.btn_SetBlack.Name = "btn_SetBlack";
            this.btn_SetBlack.Size = new System.Drawing.Size(108, 29);
            this.btn_SetBlack.TabIndex = 3;
            this.btn_SetBlack.Text = "设置为黑名单";
            this.btn_SetBlack.UseVisualStyleBackColor = true;
            this.btn_SetBlack.Click += new System.EventHandler(this.btn_SetBlack_Click);
            // 
            // btn_reuse
            // 
            this.btn_reuse.Location = new System.Drawing.Point(242, 24);
            this.btn_reuse.Name = "btn_reuse";
            this.btn_reuse.Size = new System.Drawing.Size(133, 30);
            this.btn_reuse.TabIndex = 4;
            this.btn_reuse.Text = "黑名单卡 复原";
            this.btn_reuse.UseVisualStyleBackColor = true;
            this.btn_reuse.Click += new System.EventHandler(this.btn_reuse_Click);
            // 
            // IC_DataShow_From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 348);
            this.Controls.Add(this.btn_reuse);
            this.Controls.Add(this.btn_SetBlack);
            this.Controls.Add(this.gbx_data);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_deleteRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "IC_DataShow_From";
            this.Text = "IC卡 详细信息";
            this.Load += new System.EventHandler(this.IC_DataShow_From_Load);
            this.gbx_data.ResumeLayout(false);
            this.gbx_data.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_deleteRecord;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.GroupBox gbx_data;
        private System.Windows.Forms.Label label_IC_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_SetDay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_SetWeekDay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_SetCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_Car_Num;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_Car_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_IC_Num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_SetTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_FloorData;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_SetBlack;
        private System.Windows.Forms.Button btn_reuse;
    }
}
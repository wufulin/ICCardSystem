namespace HID
{
    partial class FrmMBoardID
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
            this.btn_add_mbid = new System.Windows.Forms.Button();
            this.lbe_mb_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_mb_num = new System.Windows.Forms.TextBox();
            this.tbx_Company = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_add_mbid
            // 
            this.btn_add_mbid.Location = new System.Drawing.Point(93, 156);
            this.btn_add_mbid.Name = "btn_add_mbid";
            this.btn_add_mbid.Size = new System.Drawing.Size(88, 23);
            this.btn_add_mbid.TabIndex = 0;
            this.btn_add_mbid.Text = "加入数据库";
            this.btn_add_mbid.UseVisualStyleBackColor = true;
            this.btn_add_mbid.Click += new System.EventHandler(this.btn_add_mbid_Click);
            // 
            // lbe_mb_id
            // 
            this.lbe_mb_id.AutoSize = true;
            this.lbe_mb_id.Location = new System.Drawing.Point(103, 39);
            this.lbe_mb_id.Name = "lbe_mb_id";
            this.lbe_mb_id.Size = new System.Drawing.Size(0, 12);
            this.lbe_mb_id.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "主板ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "主板号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "备注:";
            // 
            // tbx_mb_num
            // 
            this.tbx_mb_num.Location = new System.Drawing.Point(105, 65);
            this.tbx_mb_num.Name = "tbx_mb_num";
            this.tbx_mb_num.Size = new System.Drawing.Size(144, 21);
            this.tbx_mb_num.TabIndex = 8;
            // 
            // tbx_Company
            // 
            this.tbx_Company.Location = new System.Drawing.Point(105, 102);
            this.tbx_Company.Name = "tbx_Company";
            this.tbx_Company.Size = new System.Drawing.Size(144, 21);
            this.tbx_Company.TabIndex = 9;
            // 
            // FrmMBoard_ID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(292, 216);
            this.Controls.Add(this.tbx_Company);
            this.Controls.Add(this.tbx_mb_num);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbe_mb_id);
            this.Controls.Add(this.btn_add_mbid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMBoardID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "主板信息采集";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_mbid;
        private System.Windows.Forms.Label lbe_mb_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_mb_num;
        private System.Windows.Forms.TextBox tbx_Company;
    }
}
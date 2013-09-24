namespace HID
{
    partial class FrmSelectMBoardID
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
            this.dgv_mb = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mb)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_mb
            // 
            this.dgv_mb.AllowUserToAddRows = false;
            this.dgv_mb.AllowUserToDeleteRows = false;
            this.dgv_mb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_mb.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_mb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mb.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_mb.Location = new System.Drawing.Point(48, 53);
            this.dgv_mb.Name = "dgv_mb";
            this.dgv_mb.ReadOnly = true;
            this.dgv_mb.RowTemplate.Height = 23;
            this.dgv_mb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_mb.Size = new System.Drawing.Size(372, 209);
            this.dgv_mb.TabIndex = 2;
            this.dgv_mb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mb_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "11";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "取消选择";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "你所选择的电梯为：";
            // 
            // FrmSelectMBoardID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(481, 278);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_mb);
            this.Name = "FrmSelectMBoardID";
            this.Text = "FrmSelectMBoardID";
            this.Load += new System.EventHandler(this.FrmSelectMBoardID_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_mb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}
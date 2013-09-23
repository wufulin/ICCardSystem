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
            this.dgv_mb.Location = new System.Drawing.Point(46, 44);
            this.dgv_mb.Name = "dgv_mb";
            this.dgv_mb.ReadOnly = true;
            this.dgv_mb.RowTemplate.Height = 23;
            this.dgv_mb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_mb.Size = new System.Drawing.Size(372, 222);
            this.dgv_mb.TabIndex = 2;
            this.dgv_mb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mb_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "lbe_mb_id.Text = MBoard_ID;";
            // 
            // FrmSelectMBoardID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(481, 278);
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
    }
}
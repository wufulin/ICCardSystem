using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HID.BaseClass;
using HID.Model;

namespace HID
{
    
    public partial class FrmSelectMBoardID : Form
    {
        public static MainFrom form1 = null;
        public FrmSelectMBoardID(MainFrom parent)
        {
            InitializeComponent();
            form1 = parent;
        }

        private void FrmSelectMBoardID_Load(object sender, EventArgs e)
        {
            DataSet ds_board = DBHelper.getDs("select * from tb_MainBoard", "tb_mb");
            dgv_mb.DataSource = ds_board.Tables[0];
        }

        private void dgv_mb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = dgv_mb.SelectedRows[0].Cells["MainBoard_ID"].Value.ToString();
            form1.Text = label1.Text;
        }
    }
}

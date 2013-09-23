using System;
using System.Data;
using System.Windows.Forms;
using HID.BaseClass;

namespace HID
{
    
    public partial class FrmSelectMBoardID : Form
    {
        private MainFrom parent = null;

        public FrmSelectMBoardID(MainFrom parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void FrmSelectMBoardID_Load(object sender, EventArgs e)
        {
            DataSet ds_board = DBHelper.getDs("select * from tb_MainBoard", "tb_mb");
            dgv_mb.DataSource = ds_board.Tables[0];
        }

        private void dgv_mb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = dgv_mb.SelectedRows[0].Cells["MainBoard_ID"].Value.ToString();
            parent.LiftSystemNumber = label1.Text;
        }
    }
}

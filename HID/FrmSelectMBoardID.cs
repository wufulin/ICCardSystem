using System;
using System.Data;
using System.Windows.Forms;
using HID.BaseClass;
using HID.Model;

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
            parent.bmsg = dgv_mb.SelectedRows[0].Cells["单位名称"].Value.ToString();
            parent.LiftSystemNumber = parent.bmsg;

            MainBoard mb_temp = new MainBoard();
            mb_temp.Id = dgv_mb.SelectedRows[0].Cells["MainBoard_ID"].Value.ToString();
            mb_temp.Number=dgv_mb.SelectedRows[0].Cells["MainBoard_Num"].Value.ToString();
            mb_temp.CompanyName=dgv_mb.SelectedRows[0].Cells["单位名称"].Value.ToString();
            label1.Text = mb_temp.Number;
            parent.mainboard = mb_temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.LiftSystemNumber = "";
            parent.mainboard = null;
            label1.Text = "没有选择电梯。";
        }
    }
}

using System;
using System.Windows.Forms;
using HID.BaseClass;
using HID.Model;

namespace HID
{
    public partial class FrmMBoardID : Form
    {
        private string _MBoard_ID;

        public FrmMBoardID()
        {
            InitializeComponent();
            lbe_mb_id.Text = @"852741963";
            tbx_mb_num.Text = MBoard_ID;
        }

        public string MBoard_ID
        {
            get { return _MBoard_ID; }
            set { _MBoard_ID = value; }
        }

        private void btn_add_mbid_Click(object sender, EventArgs e)
        {
            DBOperation bf = new DBOperation();
            MainBoard mb_data = new MainBoard(this.MBoard_ID, tbx_mb_num.Text, tbx_Company.Text);

            if (bf.Find_MainBoard_Data(mb_data) == 1)
            {
                bf.Updata_MainBoard_Data(mb_data);
                //textBox1.Text += "\r\n access_db have data\r\n!";
                //if (bf.Updata_IcData(ic_data) == 1)
                //    textBox1.Text += "\r\n access_db have up data ok\r\n!";
                //else
                //    textBox1.Text += "\r\n access_db updata error\r\n!";
            }
            else
            {
                if (bf.Add_MainBoard_Data(mb_data) == 1)
                {
                    MessageBox.Show("add main board id ok!");
                }
                else
                {
                    MessageBox.Show("add main board id error !");
                }
            }

        }
    }
}

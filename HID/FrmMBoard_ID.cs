using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using HID.BaseClass;
using HID;

namespace HID
{
    public partial class FrmMBoard_ID : Form
    {
        public FrmMBoard_ID()
        {
            InitializeComponent();
            lbe_mb_id.Text = "852741963";
            tbx_mb_num.Text = MBoard_ID;
        }

        private string _MBoard_ID;

        public string MBoard_ID
        {
            get { return _MBoard_ID; }
            set { _MBoard_ID = value; }
        }

        private void btn_add_mbid_Click(object sender, EventArgs e)
        {
            DBOperation bf = new DBOperation();
            s_MainBoard_Data mb_data = new s_MainBoard_Data();
            mb_data.MainBoard_ID = this.MBoard_ID;
            mb_data.MainBoard_Num = tbx_mb_num.Text;
            mb_data.Company_Name = tbx_Company.Text;


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

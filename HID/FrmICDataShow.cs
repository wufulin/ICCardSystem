using System;
using System.Data;
using System.Windows.Forms;
using System.Globalization;
using HID.BaseClass;
using HID.Model;

namespace HID
{
    public partial class FrmICDataShow : Form
    {
        public static MainFrom form1 =null;
        public FrmICDataShow(MainFrom parent)
        {
            InitializeComponent();
            form1 = parent;

            //label_block8.Text = form1.dgv_IcData.SelectedRows[0].Cells["Block_8"].Value.ToString();
            label_IC_Num.Text = form1.dgv_IcData.SelectedRows[0].Cells["卡号"].Value.ToString();
            label_Car_ID.Text = form1.dgv_IcData.SelectedRows[0].Cells["电梯ID"].Value.ToString();

            string b8_0 = form1.dgv_IcData.SelectedRows[0].Cells["Block_8"].Value.ToString().Substring(0, 2);
            string b8_6 = form1.dgv_IcData.SelectedRows[0].Cells["Block_8"].Value.ToString().Substring(18,2) ;
            string b8_7 = form1.dgv_IcData.SelectedRows[0].Cells["Block_8"].Value.ToString().Substring(21, 2);
            if (((byte)Int32.Parse(b8_0, NumberStyles.HexNumber) & 0x01) == 1)
            //if (((byte)Convert.ToInt32(b8_0) & 0x01) ==1)
            {
                //int t_val=(int.Parse(b8_6) * 256 + int.Parse(b8_7)); 
                //int t_val = Convert.ToInt32(form1.dgv_IcData.SelectedRows[0].Cells["Block_8"].Value.ToString().Substring(18, 2)) ;
                //int t_val = Convert.ToInt32(form1.dgv_IcData.SelectedRows[0].Cells["Block_8"].Value.ToString().Substring(18, 2));
                label_SetCount.Text = Int32.Parse(b8_7 + b8_6, NumberStyles.HexNumber).ToString();
                //label_SetCount.Text = b8_6 + b8_7;
            }
            else
            {
                label_SetCount.Text = "无次数限制";
            }

            string b9_4 = form1.dgv_IcData.SelectedRows[0].Cells["Block_9"].Value.ToString().Substring(12, 2);
            //if (((byte)Convert.ToInt32(b8_0) & 0x04) ==4)
            if (((byte)Int32.Parse(b8_0, NumberStyles.HexNumber) & 0x04) == 4)
            {
                int i;
                byte b_9_4 = (byte)Int32.Parse(b9_4, NumberStyles.HexNumber);
                for(i=0;i<7;i++)
                {
                    //label_SetWeekDay.Text += b_9_4.ToString("X2");
                    if ((b_9_4 >> i & 0x01) == 0x01)
                    {
                        if(i==0)
                            label_SetWeekDay.Text+="星期一 ";
                        else if(i==1)
                            label_SetWeekDay.Text+="星期二 ";
                        else if(i==2)
                            label_SetWeekDay.Text+="星期三 ";
                        else if(i==3)
                            label_SetWeekDay.Text+="星期四 ";
                        else if(i==4)
                            label_SetWeekDay.Text+="星期五 ";
                        else if(i==5)
                            label_SetWeekDay.Text+="星期六 ";
                        else if(i==6)
                            label_SetWeekDay.Text+="星期日 ";
                    }
                }

                //label_SetWeekDay.Text ="无星期限制";
            }
            else
            {
                label_SetWeekDay.Text = "无日期限制！";
            }

            string b9_5 = form1.dgv_IcData.SelectedRows[0].Cells["Block_9"].Value.ToString().Substring(15, 2);
            string b9_6 = form1.dgv_IcData.SelectedRows[0].Cells["Block_9"].Value.ToString().Substring(18, 2);
            string b9_7 = form1.dgv_IcData.SelectedRows[0].Cells["Block_9"].Value.ToString().Substring(21, 2);
            string b9_8 = form1.dgv_IcData.SelectedRows[0].Cells["Block_9"].Value.ToString().Substring(24, 2);
            string b9_9 = form1.dgv_IcData.SelectedRows[0].Cells["Block_9"].Value.ToString().Substring(27, 2);
            string b9_10 = form1.dgv_IcData.SelectedRows[0].Cells["Block_9"].Value.ToString().Substring(30, 2);

            //if (((byte)Convert.ToInt32(b8_0) & 0x08) ==8)
            if (((byte)Int32.Parse(b8_0, NumberStyles.HexNumber) & 0x08) == 8)
            {
                label_SetDay.Text = "20" + Int32.Parse(b9_5, NumberStyles.HexNumber).ToString() + "年" + 
                                            Int32.Parse(b9_6, NumberStyles.HexNumber).ToString() + "月" + 
                                            Int32.Parse(b9_7, NumberStyles.HexNumber).ToString() + "日    " +
                                    "20" +  Int32.Parse(b9_8, NumberStyles.HexNumber).ToString() + "年" + 
                                            Int32.Parse(b9_9, NumberStyles.HexNumber).ToString() + "月" +
                                            Int32.Parse(b9_10, NumberStyles.HexNumber).ToString() + "日";
            }
            else
            {
                label_SetDay.Text="不限定日期";
            }

            string b9_0 = form1.dgv_IcData.SelectedRows[0].Cells["Block_9"].Value.ToString().Substring(0, 2);
            string b9_1 = form1.dgv_IcData.SelectedRows[0].Cells["Block_9"].Value.ToString().Substring(3, 2);
            string b9_2 = form1.dgv_IcData.SelectedRows[0].Cells["Block_9"].Value.ToString().Substring(6, 2);
            string b9_3 = form1.dgv_IcData.SelectedRows[0].Cells["Block_9"].Value.ToString().Substring(9, 2);
            if (((byte)Int32.Parse(b8_0, NumberStyles.HexNumber) & 0x02) == 2)
            {
                label_SetTime.Text = Int32.Parse(b9_0, NumberStyles.HexNumber).ToString() + "时" +
                                    Int32.Parse(b9_1, NumberStyles.HexNumber).ToString() + "分   到    " +
                                    Int32.Parse(b9_2, NumberStyles.HexNumber).ToString() + "时" +
                                    Int32.Parse(b9_3, NumberStyles.HexNumber).ToString() + "分";
            }
            else
            {
                label_SetTime.Text = "不限定时间";
            }
            
            string b8_8 = form1.dgv_IcData.SelectedRows[0].Cells["Block_8"].Value.ToString().Substring(24, 2);
            string b8_9 = form1.dgv_IcData.SelectedRows[0].Cells["Block_8"].Value.ToString().Substring(27, 2);
            //label_SetTime.Text = b8_8 + " " + b8_9;
            byte _b8_8 = (byte)Int32.Parse(b8_8, NumberStyles.HexNumber);
            byte _b8_9 = (byte)Int32.Parse(b8_9, NumberStyles.HexNumber);

            //label_SetTime.Text += "----" + _b8_8.ToString("X2") + "----" + _b8_9.ToString("X2");
            label_FloorData.Text = "";

            if(_b8_8>=0 || _b8_9>=0 )
            {
                int i;
                for (i = 0; i < 8; i++)
                {
                    if (((_b8_8 >> i) & 0x01) == 0x01)
                    {
                        if(i==0)
                            label_FloorData.Text += "1 ";
                        else if(i==1)
                            label_FloorData.Text += "2 ";
                        else if (i == 2)
                            label_FloorData.Text += "3 ";
                        else if (i == 3)
                            label_FloorData.Text += "4 ";
                        else if (i == 4)
                            label_FloorData.Text += "5 ";
                        else if (i == 5)
                            label_FloorData.Text += "6 ";
                        else if (i == 6)
                            label_FloorData.Text += "7 ";
                        else if (i == 7)
                            label_FloorData.Text += "8 ";
                    }
                }
                for (i = 0; i < 8; i++)
                {
                    if (((byte)_b8_9 >> i & 0x01) == 0x01)
                    {
                        if (i == 0)
                            label_FloorData.Text += "9 ";
                        else if (i == 1)
                            label_FloorData.Text += "10 ";
                        else if (i == 2)
                            label_FloorData.Text += "11 ";
                        else if (i == 3)
                            label_FloorData.Text += "12 ";
                        else if (i == 4)
                            label_FloorData.Text += "13 ";
                        else if (i == 5)
                            label_FloorData.Text += "14 ";
                        else if (i == 6)
                            label_FloorData.Text += "15 ";
                        else if (i == 7)
                            label_FloorData.Text += "16 ";
                    }
                }
            }
            else
            {
                label_FloorData.Text = "没有可用的楼层！";
            }
            
            
        }

        private string _strIC_ID;

        private void btn_deleteRecord_Click(object sender, EventArgs e)
        {
            DBOperation bf = new DBOperation();
            cIC_Card_Data ic_data = new cIC_Card_Data();
            ic_data.IC_ID = this.IC_ID;

            DataBase data = new DataBase();//创建DataBase类的对象
            DataSet ds = data.getDs("select * from tb_ICCard_Data", "tb_Data");

            form1.dgv_IcData.DataSource = ds.Tables[0];
           

            if (bf.Delete_IcData(ic_data) == 1)
                MessageBox.Show("delete ok");
            else
                MessageBox.Show("delete error");
        }

        public string IC_ID
        {
            get { return _strIC_ID; }
            set { _strIC_ID = value; }
        }

        private void IC_DataShow_From_Load(object sender, EventArgs e)
        {
            label_IC_ID.Text = this.IC_ID.Substring(0,11);
            //label_IC_Num.Text = BitConverter.ToString(Encoding.Default.GetBytes(this.IC_ID.Substring(0, 3)));
            //label_IC_Num.Text = Convert.ToInt32(this.IC_ID.Substring(0, 3)).ToString("X") + " " +
            //                    Convert.ToInt32(this.IC_ID.Substring(3, 3)).ToString("X") + " " +
            //                    Convert.ToInt32(this.IC_ID.Substring(6, 3)).ToString("X") + " " +
            //                    //Convert.ToInt32(this.IC_ID.Substring(9, 3)).ToString("X") + " " +
            //                    Convert.ToInt32(this.IC_ID.Substring(9, 3)).ToString("X");
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_SetBlack_Click(object sender, EventArgs e)
        {
            int index_bit, num;

            if (form1.myHidDevice.opened == false)
            {
                MessageBox.Show("请先 连接设备！");
            }
            else
            {
                for (index_bit = 0; index_bit < 64; index_bit++)
                    form1.WriteBuffer[index_bit] = 0;

                form1.WriteBuffer[1] = 0xAE;
                form1.WriteBuffer[2] = 4;       //  直接传数据写扇区
                form1.WriteBuffer[32+3]=0xcf;   //  设置黑名单功能
                form1.WriteBuffer[33 + 3] = Convert.ToByte(this.IC_ID.Substring(0, 2), 16);
                form1.WriteBuffer[34 + 3] = Convert.ToByte(this.IC_ID.Substring(3, 2), 16);
                form1.WriteBuffer[35 + 3] = Convert.ToByte(this.IC_ID.Substring(6, 2), 16);
                form1.WriteBuffer[36 + 3] = Convert.ToByte(this.IC_ID.Substring(9, 2), 16);

                if (form1.myHidDevice.Write(form1.WriteBuffer) == false)
                    MessageBox.Show("Write Failed");
                else
                {
                    MessageBox.Show("Write OK");
                }

            }
        }

        private void btn_reuse_Click(object sender, EventArgs e)
        {
            int index_bit, num;

            if (form1.myHidDevice.opened == false)
            {
                MessageBox.Show("请先 连接设备！");
            }
            else
            {
                for (index_bit = 0; index_bit < 64; index_bit++)
                    form1.WriteBuffer[index_bit] = 0;

                form1.WriteBuffer[1] = 0xAE;
                form1.WriteBuffer[2] = 4;       //  直接传数据写扇区
                form1.WriteBuffer[32 + 3] = 0xce;   //  设置黑名单功能
                form1.WriteBuffer[33 + 3] = Convert.ToByte(this.IC_ID.Substring(0, 2), 16);
                form1.WriteBuffer[34 + 3] = Convert.ToByte(this.IC_ID.Substring(3, 2), 16);
                form1.WriteBuffer[35 + 3] = Convert.ToByte(this.IC_ID.Substring(6, 2), 16);
                form1.WriteBuffer[36 + 3] = Convert.ToByte(this.IC_ID.Substring(9, 2), 16);

                if (form1.myHidDevice.Write(form1.WriteBuffer) == false)
                    MessageBox.Show("Write Failed");
                else
                {
                    MessageBox.Show("Write OK");
                }
            }
        }
    }
}

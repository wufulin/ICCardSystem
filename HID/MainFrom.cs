using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using HID.BaseClass;
using HID.Model;

namespace HID
{
    public partial class MainFrom : Form
    {
        public byte[] ReadBuffer = new byte[64];
        public byte[] WriteBuffer = new byte[65];
        public CheckBox[] cbx_lc;
        //public string strIC_ID;

        int bytesWritten,hid_index;
        bool my_hid_opened = false;

        public HidDriver myHidDevice = new HidDriver();

        public HidAttribute[] hid =  HidDriver.GetHidDevice();

        DBOperation bf = new DBOperation();

        public MainFrom()
        {
            InitializeComponent();

            cbx_lc = new CheckBox[16];

            #region   
            int i;
            for (i = 0; i < 8; i++)
            {
                cbx_lc[i] = new CheckBox();

                cbx_lc[i].Appearance = System.Windows.Forms.Appearance.Button;
                cbx_lc[i].Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                this.cbx_lc[i].Location = new System.Drawing.Point(90 + i * 85, 215);
                cbx_lc[i].Name = "cbx_lc";
                cbx_lc[i].BackColor = Color.PaleTurquoise;
                cbx_lc[i].Size = new System.Drawing.Size(50, 50);
                cbx_lc[i].TabIndex = 5 + i;
                cbx_lc[i].Text = Convert.ToString(i + 1); ;
                cbx_lc[i].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                cbx_lc[i].UseVisualStyleBackColor = true;
                cbx_lc[i].CheckedChanged += new System.EventHandler(this.cbx_lc_CheckedChanged);
                this.tabPage1.Controls.Add(this.cbx_lc[i]); //在窗体上呈现控件
            }

            for (i = 8; i < 16; i++)
            {
                cbx_lc[i] = new CheckBox();
                cbx_lc[i].Appearance = System.Windows.Forms.Appearance.Button;
                cbx_lc[i].Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                cbx_lc[i].Location = new System.Drawing.Point(90 + (i - 8) * 85, 285);
                cbx_lc[i].Name = "cbx_lc";
                cbx_lc[i].BackColor = Color.PaleTurquoise;
                cbx_lc[i].Size = new System.Drawing.Size(50, 50);
                cbx_lc[i].TabIndex = 5 + i;
                cbx_lc[i].Text = Convert.ToString(i + 1); ;
                cbx_lc[i].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                cbx_lc[i].UseVisualStyleBackColor = true;
                cbx_lc[i].CheckedChanged += new System.EventHandler(this.cbx_lc_CheckedChanged);
                this.tabPage1.Controls.Add(cbx_lc[i]); //在窗体上呈现控件
            }
            for (i = 0; i < 16; i++)
                cbx_lc[i].BackColor = Color.PaleTurquoise;

            sts_lable.Text = DateTime.Now.ToString();

            this.tabPage1.Controls.Add(textBox1); //在窗体上呈现控件

            tbxCount.Text = "10";
            rdbtn_SetTimeY.Checked = false;
            rdbtn_SetTimeN.Checked = true;
            rdbtn_SetWeekDayY.Checked = false;
            rdbtn_SetWeekDayN.Checked = true;
            rdbtn_SetDayY.Checked = false;
            rdbtn_SetDayN.Checked = true;
            rdbtn_SetCountY.Checked = false;
            rdbtn_SetCountN.Checked = true;

            //textBox3.Text = Application.StartupPath;

            #endregion

        }

        void OnDataRecieved(object sender, DataReceivedArgs e)
        {
            //uint t = e.Packet[1];
            //t = t * 256 + e.Packet[2];
            //t = t * 256 + e.Packet[3];
            //t = t * 256 + e.Packet[4];
            //textBox1.Text = textBox1.Text + e.Packet[0] + e.Packet[1] + e.Packet[2] + e.Packet[3] + e.Packet[4] + e.Packet[5] + e.Packet[6] + "\r\n\r\n";

            byte[] rbuf = new byte[100];
            int i,num;
            //textBox1.Text += Encoding.ASCII.GetString(e.Packet.Length);
            //textBox1.Text += e.Packet.Length.ToString();
            for (i = 0; i < e.Packet.Length; i++)
                rbuf[i] = e.Packet[i];
            //rbuf[i] = (byte)(i + 97);
            //rbuf[0] = 97;
            //e.Packet[0] = 33;
            e.Packet[0] = 32;

            string str = BitConverter.ToString(e.Packet);
            //textBox1.Text  = str;


            //string str_id = e.Packet[51].ToString("D3") + " " +
            //                e.Packet[52].ToString("D3") + " " +
            //                e.Packet[53].ToString("D3") + " " +
            //                e.Packet[54].ToString("D3") + " " +
            //                e.Packet[55].ToString("D3");

            string str_id = e.Packet[51].ToString("X2") + " "+
                            e.Packet[52].ToString("X2") + " " +
                            e.Packet[53].ToString("X2") + " " +
                            e.Packet[54].ToString("X2");
                            //e.Packet[55].ToString("X");

            if (e.Packet[1] == 0xBE)        //  写卡回应
            {
                //BaseInfo bf = new BaseInfo();
                cIC_Card_Data ic_data = new cIC_Card_Data();
                ic_data.IC_ID = str_id;
                //ic_data.IC_Fun = "";
                //ic_data.Floor_Data = "";
                //ic_data.IC_FunA = "";
                ////ic_data.Add_ID = "";

                if (tbxIcNum.Text!="")
                {
                    if (!int.TryParse((tbxIcNum.Text), out num))
                    {
                        MessageBox.Show("请输入卡号！");
                    }
                    else
                    {
                        ic_data.ic_num = num;
                    }
                }

                ic_data.持卡人 = tbxName.Text;
                ic_data.电梯ID = tbxCarNum.Text;
                

                for (i = 0; i < 16; i++)
                {
                   ic_data.Block_8[i]=e.Packet[3+i];
                   ic_data.Block_9[i] = e.Packet[19 + i];
                   ic_data.Block_10[i] = e.Packet[35 + i];
                }

                if (bf.Find_IcData(ic_data) == 1)
                {
                    textBox1.Text += "\r\n access_db have data\r\n!";
                    if(bf.Updata_IcData(ic_data)==1)
                        textBox1.Text += "\r\n access_db have up data ok\r\n!";
                    else
                        textBox1.Text += "\r\n access_db updata error\r\n!";
                }
                else
                {
                    if (bf.Add_IcData(ic_data) == 1)
                    {
                        textBox1.Text += "\r\n access_db add data ok\r\n!";
                    }
                    else
                        textBox1.Text += "\r\n access_db add data error\r\n!";
                    //bf.Add_IcData(ic_data);
                }

                //if (bf.Add_IcData(ic_data) == 1)
                //{
                //    //MessageBox.Show("add access_db ok!");
                //    textBox1.Text += "add access_db ok!";
                //}
                //else
                //    MessageBox.Show("add access_db error!");
            }
            else if (e.Packet[1] == 0xB5)
            {
                //BaseInfo bf = new BaseInfo();
                cIC_Card_Data ic_data = new cIC_Card_Data();
                ic_data.IC_ID = str_id;
                ic_data.电梯ID = str_id;
                //ic_data.IC_Fun = "";
                //ic_data.Floor_Data = "";
                //ic_data.IC_FunA = "";
                ////ic_data.Add_ID = "";

                if (tbxIcNum.Text != "")
                {
                    if (!int.TryParse((tbxIcNum.Text), out num))
                    {
                        MessageBox.Show("请输入卡号！");
                    }
                    else
                    {
                        ic_data.ic_num = num;
                    }
                }

                ic_data.持卡人 = tbxName.Text;
                ic_data.电梯ID = tbxCarNum.Text;

                for (i = 0; i < 16; i++)
                {
                    ic_data.Block_8[i] = e.Packet[3 + i];
                    ic_data.Block_9[i] = e.Packet[19 + i];
                    ic_data.Block_10[i] = e.Packet[35 + i];
                }

                if (bf.Find_IcData(ic_data) == 1)
                {
                    textBox1.Text += "\r\n access_db have data\r\n!";
                    if (bf.Updata_IcData(ic_data) == 1)
                        textBox1.Text += "\r\n access_db have up data ok\r\n!";
                    else
                        textBox1.Text += "\r\n access_db updata error\r\n!";
                }
                else
                {
                    bf.Add_IcData(ic_data);
                }
            }
            else if (e.Packet[1] == 0xBC)   //	采集 主板 ID
            {
                //e.Packet[3 + 0];
                FrmMBoardID frm_Mboard = new FrmMBoardID();
                //frm_Mboard.MBoard_ID = e.Packet[3 + 0].ToString("X2");
                //frm_Mboard.MBoard_ID = str.Substring(2,12);
                
                frm_Mboard.MBoard_ID = BitConverter.ToString(e.Packet,3,12);
                frm_Mboard.Show();
            }
       
            //if ((e.Packet[1] % 2) == 1)
            //    MessageBox.Show("卡号：" + str_id + "\r\n\r\n" +
            //                    "还剩次数：" + (e.Packet[7] + e.Packet[8] * 256).ToString() + "\r\n\r\n" +
            //                    "已刷卡的次数：" + (e.Packet[31] + e.Packet[32] * 256).ToString());
            //else
            //    MessageBox.Show("卡号：" + str_id + "\r\n\r\n" +
            //                    "刷卡无次数限制！" + "\r\n\r\n" +
            //                    "已刷卡的次数：" + (e.Packet[31] + e.Packet[32] * 256).ToString());

            //}
            //else
            //{
            //    MessageBox.Show("卡号：" + str_id );
            //}
            //textBox1.Text += Encoding.ASCII.GetString(e.Packet)+"\r\n";
            //textBox1.Text += e.Packet[1].ToString("X2") + e.Packet[2].ToString("X2");

            //textBox1.Text += Encoding.Unicode.GetString(e.Packet) + "\r\n";
            //textBox1.Text += Encoding.UTF7.GetString(e.Packet) + "\r\n";
            //textBox1.Text += Encoding.UTF8.GetString(e.Packet) + "\r\n";
            //textBox1.Text += Encoding.UTF32.GetString(e.Packet) + "\r\n";
            //textBox1.Text += Encoding.BigEndianUnicode.GetString(e.Packet) + "\r\n";

            //textBox1.Text += Encoding.Default.GetString(e.Packet) + "\r\n";

        }

        private void cbx_lc_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked == true)
            {
                ((CheckBox)sender).BackColor = Color.Orchid;
            }
            else
            {
                ((CheckBox)sender).BackColor = Color.PaleTurquoise;
            }
        }

        private void rdbtn_SetTimeY_CheckedChanged(object sender, EventArgs e)
        {
            dtp_TimeStart.Enabled = true;
            dtp_TimeEnd.Enabled = true;
            label2.Enabled = true;
        }

        private void rdbtn_SetTimeN_CheckedChanged(object sender, EventArgs e)
        {
            dtp_TimeStart.Enabled = false;
            dtp_TimeEnd.Enabled = false;
            //label2.Enabled = false;
        }

        private void rdbtn_SetWeekDayY_CheckedChanged(object sender, EventArgs e)
        {
            cbx_Mon.Enabled = true;
            cbx_Tue.Enabled = true;
            cbx_Wed.Enabled = true;
            cbx_Thu.Enabled = true;
            cbx_Fri.Enabled = true;
            cbx_Sat.Enabled = true;
            cbx_Sun.Enabled = true;
        }

        private void rdbtn_SetWeekDayN_CheckedChanged(object sender, EventArgs e)
        {
            cbx_Mon.Enabled = false;
            cbx_Tue.Enabled = false;
            cbx_Wed.Enabled = false;
            cbx_Thu.Enabled = false;
            cbx_Fri.Enabled = false;
            cbx_Sat.Enabled = false;
            cbx_Sun.Enabled = false;
        }

        private void rdbtn_SetDayY_CheckedChanged(object sender, EventArgs e)
        {
            dtp_StartDay.Enabled = true;
            dtp_EndDay.Enabled = true;
        }

        private void rdbtn_SetDayN_CheckedChanged(object sender, EventArgs e)
        {
            dtp_StartDay.Enabled = false;
            dtp_EndDay.Enabled = false;
        }

        private void rdbtn_SetCountY_CheckedChanged(object sender, EventArgs e)
        {
            this.tbxCount.Enabled = true;
        }

        private void rdbtn_SetCountN_CheckedChanged(object sender, EventArgs e)
        {
            this.tbxCount.Enabled = false;
        }

        private void btn_write_Click(object sender, EventArgs e)
        {
            int index_bit, num;
            Int32 set_data = 0;

            if (myHidDevice.opened == false)
            {
                MessageBox.Show("请先 连接设备！");
            }
            else
            {
                for (index_bit = 0; index_bit < 64; index_bit++)
                    WriteBuffer[index_bit] = 0;

                for (index_bit = 0; index_bit < 16; index_bit++)
                {
                    if (cbx_lc[index_bit].Checked == true)
                    {
                        //WriteBuffer[]
                        set_data = set_data | (1 << index_bit);
                    }
                    else
                    {
                        set_data = set_data & ~(1 << index_bit);
                    }
                }

                //*********************************************************************
                #region   旧的写卡模式
                //WriteBuffer[0] = 0;     // report id;

                //WriteBuffer[1] = 0xAE;
                //WriteBuffer[2] = 1;

                //WriteBuffer[3] = 0;

                //WriteBuffer[4] = (byte)set_data;
                //WriteBuffer[5] = (byte)(set_data >> 8);
                //WriteBuffer[6] = (byte)(set_data >> 16);
                //WriteBuffer[7] = (byte)(set_data >> 24);
                //WriteBuffer[8] = (byte)0;
                //WriteBuffer[9] = (byte)0;
                //WriteBuffer[10] = (byte)0;
                //WriteBuffer[11] = (byte)0;

                //if (rdbtn_SetCountY.Checked)
                //{
                //    if (!int.TryParse((tbxCount.Text), out num))
                //    {
                //        MessageBox.Show("请输入数字！");
                //    }
                //    else
                //    {
                //        WriteBuffer[12] = (byte)(num / 256);
                //        WriteBuffer[13] = (byte)(num % 256);

                //        WriteBuffer[3] |= 0x01;
                //    }
                //}

                //if (rdbtn_SetTimeY.Checked)
                //{
                //    // Start Hour
                //    WriteBuffer[14] = (byte)dtp_TimeStart.Value.Hour;
                //    // Start Minute
                //    WriteBuffer[15] = (byte)dtp_TimeStart.Value.Minute;
                //    // End Hour
                //    WriteBuffer[16] = (byte)dtp_TimeEnd.Value.Hour;
                //    // End Minute
                //    WriteBuffer[17] = (byte)dtp_TimeEnd.Value.Minute;

                //    WriteBuffer[3] |= 0x02;
                //}

                //if (rdbtn_SetWeekDayY.Checked)
                //{
                //    int temp;
                //    temp = (cbx_Mon.Checked ? 1 : 0) +
                //                     (cbx_Tue.Checked ? 2 : 0) +
                //                     (cbx_Wed.Checked ? 4 : 0) +
                //                     (cbx_Thu.Checked ? 8 : 0) +
                //                     (cbx_Fri.Checked ? 16 : 0) +
                //                     (cbx_Sat.Checked ? 32 : 0) +
                //                     (cbx_Sun.Checked ? 64 : 0);

                //    WriteBuffer[18] = (byte)temp;

                //    WriteBuffer[3] |= 0x04;
                //}

                //if (rdbtn_SetDayY.Checked)
                //{
                //    // Start Year
                //    WriteBuffer[19] = (byte)dtp_StartDay.Value.Year;
                //    // Start Moon
                //    WriteBuffer[20] = (byte)dtp_StartDay.Value.Month;
                //    // Start Day
                //    WriteBuffer[21] = (byte)dtp_StartDay.Value.Day;
                //    // End Year
                //    WriteBuffer[22] = (byte)dtp_EndDay.Value.Year;
                //    // End Moon
                //    WriteBuffer[23] = (byte)dtp_EndDay.Value.Month;
                //    // End Day
                //    WriteBuffer[24] = (byte)dtp_EndDay.Value.Day;

                //    WriteBuffer[3] |= 0x08;
                //}
                #endregion
                //*********************************************************************
                #region 直接写卡模式
                WriteBuffer[0] = 0;     // report id;

                WriteBuffer[1] = 0xAE;
                WriteBuffer[2] = 4;     // 直接传数据写扇区

                WriteBuffer[0+3] = 0;     // 功能号  Block_8[0]

                WriteBuffer[8+3] = (byte)set_data;              // 楼层数据  Block_8[8] 
                WriteBuffer[9+3] = (byte)(set_data >> 8);       // 楼层数据  Block_8[9]
                WriteBuffer[10 + 3] = (byte)(set_data >> 16);   // 楼层数据  Block_8[10]
                WriteBuffer[11 + 3] = (byte)(set_data >> 24);   // 楼层数据  Block_8[11]
                WriteBuffer[12+3] = (byte)0;
                WriteBuffer[13+3] = (byte)0;
                WriteBuffer[14+3] = (byte)0;
                WriteBuffer[15+3] = (byte)0;

                if (rdbtn_SetCountY.Checked)
                {
                    if (!int.TryParse((tbxCount.Text), out num))
                    {
                        MessageBox.Show("请输入数字！");
                    }
                    else
                    {
                        WriteBuffer[7 + 3] = (byte)(num / 256);   // 限定次数  Block_8[7]
                        WriteBuffer[6 + 3] = (byte)(num % 256);   // 限定次数  Block_8[6]

                        WriteBuffer[0 + 3] |= 0x01;
                    }
                }

                if (rdbtn_SetTimeY.Checked)
                {
                    // Start Hour
                    WriteBuffer[16 + 3] = (byte)dtp_TimeStart.Value.Hour;       // Start Hour  Block_9[0]
                    // Start Minute
                    WriteBuffer[17 + 3] = (byte)dtp_TimeStart.Value.Minute;     // Start Minute Block_9[1]
                    // End Hour
                    WriteBuffer[18 + 3] = (byte)dtp_TimeEnd.Value.Hour;         // End Hour Block_9[2]
                    // End Minute
                    WriteBuffer[19 + 3] = (byte)dtp_TimeEnd.Value.Minute;       // End Minute Block_9[3]

                    WriteBuffer[3] |= 0x02;
                }

                if (rdbtn_SetWeekDayY.Checked)
                {
                    int temp;
                    temp = (cbx_Mon.Checked ? 1 : 0) +
                                     (cbx_Tue.Checked ? 2 : 0) +
                                     (cbx_Wed.Checked ? 4 : 0) +
                                     (cbx_Thu.Checked ? 8 : 0) +
                                     (cbx_Fri.Checked ? 16 : 0) +
                                     (cbx_Sat.Checked ? 32 : 0) +
                                     (cbx_Sun.Checked ? 64 : 0);

                    WriteBuffer[20 + 3] = (byte)temp;         // WeekDay Block_9[4]

                    WriteBuffer[3] |= 0x04;
                    //textBox2.Text += "**-" + temp.ToString();
                }

                if (rdbtn_SetDayY.Checked)
                {
                    //textBox2.Text += "--" + dtp_StartDay.Value.Year.ToString();
                    // Start Year   Block_9[5]
                    WriteBuffer[21 + 3] = (byte)(dtp_StartDay.Value.Year%2000);   //  ???????????
                    // Start Moon   Block_9[6]
                    WriteBuffer[22+3] = (byte)dtp_StartDay.Value.Month;
                    // Start Day    Block_9[7]
                    WriteBuffer[23+3] = (byte)dtp_StartDay.Value.Day;
                    // End Year     Block_9[8]
                    WriteBuffer[24+3] = (byte)(dtp_EndDay.Value.Year%2000);
                    // End Moon     Block_9[9]
                    WriteBuffer[25+3] = (byte)dtp_EndDay.Value.Month;
                    // End Day      Block_9[10]
                    WriteBuffer[26+3] = (byte)dtp_EndDay.Value.Day;

                    WriteBuffer[3] |= 0x08;
                }

                //  判断是否 把主板ID号直接写到卡里...
                if (comboBox1.SelectedIndex == -1)
                {
                    WriteBuffer[32 + 3] = 0;    //   Block_10[0]
                    WriteBuffer[33 + 3] = 0;    //   Block_10[1]
                }
                else
                {
                    //Int32 mbid = ConvertToInt32(comboBox1.Text);
                    // //BitConverter.GetBytes(mbid);
                    //tbxIcNum.Text = BitConverter.ToString(BitConverter.GetBytes(mbid));
                    byte[] buf_byte=Encoding.Default.GetBytes(comboBox1.Text.ToString());

                    WriteBuffer[32 + 3] = 1;    //   Block_10[0]

                    //WriteBuffer[33 + 3] = (byte)(Convert.ToUInt32(comboBox1.Text.Substring(0, 2)));    //   Block_10[1]
                    WriteBuffer[33 + 3] = (byte)Int32.Parse(comboBox1.Text.Substring(12, 2), NumberStyles.HexNumber);    //   Block_10[1]
                    WriteBuffer[34 + 3] = (byte)Int32.Parse(comboBox1.Text.Substring(15, 2), NumberStyles.HexNumber);    //   Block_10[2]
                    WriteBuffer[35 + 3] = (byte)Int32.Parse(comboBox1.Text.Substring(18, 2), NumberStyles.HexNumber);    //   Block_10[3]
                    WriteBuffer[36 + 3] = (byte)Int32.Parse(comboBox1.Text.Substring(21, 2), NumberStyles.HexNumber);    //   Block_10[4]

                    WriteBuffer[37 + 3] = (byte)Int32.Parse(comboBox1.Text.Substring(24, 2), NumberStyles.HexNumber);    //   Block_10[5]
                    WriteBuffer[38 + 3] = (byte)Int32.Parse(comboBox1.Text.Substring(27, 2), NumberStyles.HexNumber);    //   Block_10[6]
                    WriteBuffer[39 + 3] = (byte)Int32.Parse(comboBox1.Text.Substring(30, 2), NumberStyles.HexNumber);    //   Block_10[7]
                    WriteBuffer[40 + 3] = (byte)Int32.Parse(comboBox1.Text.Substring(33, 2), NumberStyles.HexNumber);    //   Block_10[8]

                    WriteBuffer[41 + 3] = (byte)Int32.Parse(comboBox1.Text.Substring(0, 2), NumberStyles.HexNumber);    //   Block_10[9]
                    WriteBuffer[42 + 3] = (byte)Int32.Parse(comboBox1.Text.Substring(3, 2), NumberStyles.HexNumber);    //   Block_10[10]
                    WriteBuffer[43 + 3] = (byte)Int32.Parse(comboBox1.Text.Substring(6, 2), NumberStyles.HexNumber);    //   Block_10[11]
                    WriteBuffer[44 + 3] = (byte)Int32.Parse(comboBox1.Text.Substring(9, 2), NumberStyles.HexNumber);    //   Block_10[12]

                    //tbxIcNum.Text = Encoding.Default.GetString(buf_byte);
                    //tbxIcNum.Text = buf_byte[0].ToString("X2");
                    //tbxIcNum.Text =BitConverter.ToString(buf_byte);
                    tbxIcNum.Text = comboBox1.Text.Substring(0, 2);
                    tbxCarNum.Text = (Int32.Parse(comboBox1.Text.Substring(0, 2), NumberStyles.HexNumber)).ToString("X2");
                }
                #endregion
                //*********************************************************************

                if (myHidDevice.Write(WriteBuffer) == false)
                    MessageBox.Show("Write Failed");
                else
                {
                    //byte[] buf_byte = Encoding.Default.GetBytes(comboBox1.Text.ToString());
                    //tbxIcNum.Text = Encoding.Default.GetString(buf_byte);
                    MessageBox.Show("Write OK");
                }
            }
        }

        private double ConvertToInt(string p)
        {
            throw new NotImplementedException();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            try
            {
                myHidDevice = new HidDriver();
                hid = HidDriver.GetHidDevice();
                for (int i = 0; i < hid.Length; i++)
                {
                    if (hid[i].venderID == 0x0483 && hid[i].productID == 0x5750)
                    {
                        myHidDevice.OpenDevice(hid[i].venderID, hid[i].productID, hid[i].serial);
                        myHidDevice.DataReceivedHandle += new EventHandler<DataReceivedArgs>(OnDataRecieved);
                        //MessageBox.Show(@"***找到设备！");
                        my_hid_opened = true;
                        hid_index = i;
                        break;
                    }

                }
                if (my_hid_opened == true)
                    MessageBox.Show(@"找到设备！");
                else
                    MessageBox.Show(@"没有找到设备！");


            }
            catch (Exception ex)
            {
                MessageBox.Show(@"未找到设备！");
            }
        }

        private void btn_oldIC_clear_Click(object sender, EventArgs e)
        {
            int i;
            if (myHidDevice.opened == false)
            {
                MessageBox.Show("请先 连接设备！");
            }
            else
            {
                for (i = 0; i < 16; i++)
                {
                    WriteBuffer[i] = 0;
                }

                WriteBuffer[0] = 0x00;
                WriteBuffer[1] = 0xAE;
                WriteBuffer[2] = 0x00;

                if (myHidDevice.Write(WriteBuffer) == false)
                    MessageBox.Show("Write Failed");
                else
                    MessageBox.Show("Write OK");
            }
        }

        private void btn_count_Click(object sender, EventArgs e)
        {
            int index_bit, temp_count;
            Int32 set_data = 0;

            if (myHidDevice.opened == false)
            {
                MessageBox.Show("请先 连接设备！");
            }
            else
            {
                WriteBuffer[0] = 0x00;
                WriteBuffer[1] = 0xAE;
                WriteBuffer[2] = 6;

                for (index_bit = 0; index_bit < 16; index_bit++)
                {
                    if (cbx_lc[index_bit].Checked == true)
                    {
                        //WriteBuffer[]
                        set_data = set_data | (1 << index_bit);
                    }
                    else
                    {
                        set_data = set_data & ~(1 << index_bit);
                    }
                }

                WriteBuffer[3] = (byte)set_data;
                WriteBuffer[4] = (byte)(set_data >> 8);
                WriteBuffer[5] = (byte)(set_data >> 16);
                WriteBuffer[6] = (byte)(set_data >> 24);

                //WriteBuffer[6] = 0;
                //WriteBuffer[7] = 5;

                if (myHidDevice.Write(WriteBuffer) == false)
                    MessageBox.Show("Write Failed");
                else
                    MessageBox.Show("Write OK");
            }
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            int index_bit, num;
            Int32 set_data = 0;

            if (myHidDevice.opened == false)
            {
                MessageBox.Show("请先 连接设备！");
            }
            else
            {
                for (index_bit = 0; index_bit < 64; index_bit++)
                    WriteBuffer[index_bit] = 0;

                for (index_bit = 0; index_bit < 16; index_bit++)
                {
                    if (cbx_lc[index_bit].Checked == true)
                    {
                        //WriteBuffer[]
                        set_data = set_data | (1 << index_bit);
                    }
                    else
                    {
                        set_data = set_data & ~(1 << index_bit);
                    }
                }


                WriteBuffer[0] = 0;     // report id;

                WriteBuffer[1] = 0xA5;

                if (myHidDevice.Write(WriteBuffer) == false)
                    MessageBox.Show("Write Failed");
                //else
                //MessageBox.Show("Write OK");
            }
        }

        private void btn_SetDataTime_Click(object sender, EventArgs e)
        {
            int i;
            if (myHidDevice.opened == false)
            {
                MessageBox.Show("请先 连接设备！");
            }
            else
            {
                for (i = 0; i < 16; i++)
                {
                    WriteBuffer[i] = 0;
                }

                WriteBuffer[0] = 0x0;
                WriteBuffer[1] = 0xAB;      //  设置主板时间
                //WriteBuffer[1] = 0xAC;      //  读取主板ID
                WriteBuffer[2] = 7;

                // Year
                WriteBuffer[3] = (byte)(int.Parse(DateTime.Now.Year.ToString()) % 100);
                // Month
                WriteBuffer[4] = (byte)(int.Parse(DateTime.Now.Month.ToString()));
                // Day
                WriteBuffer[5] = (byte)(int.Parse(DateTime.Now.Day.ToString()));
                // Hour
                WriteBuffer[6] = (byte)(int.Parse(DateTime.Now.Hour.ToString()));
                // Minute
                WriteBuffer[7] = (byte)(int.Parse(DateTime.Now.Minute.ToString()));
                // Second
                WriteBuffer[8] = (byte)(int.Parse(DateTime.Now.Second.ToString()));

                if (myHidDevice.Write(WriteBuffer) == false)
                    MessageBox.Show("Write Failed");
                else
                    MessageBox.Show("Write OK");
            }
        }

        private void btn_set_bl_Click(object sender, EventArgs e)
        {
            int index_bit, temp_count;
            Int32 set_data = 0;

            if (myHidDevice.opened == false)
            {
                MessageBox.Show("请先 连接设备！");
            }
            else
            {
                WriteBuffer[0] = 0x00;
                WriteBuffer[1] = 0xAE;
                WriteBuffer[2] = 2;

                WriteBuffer[3] = (byte)set_data;
                WriteBuffer[4] = (byte)(set_data >> 8);
                WriteBuffer[5] = (byte)(set_data >> 16);
                WriteBuffer[6] = (byte)(set_data >> 24);

                //WriteBuffer[6] = 0;
                //WriteBuffer[7] = 5;

                if (myHidDevice.Write(WriteBuffer) == false)
                    MessageBox.Show("Write Failed");
                else
                    MessageBox.Show("Write OK");
            }
        }

        private void btn_ReSet_Click(object sender, EventArgs e)
        {
            int index_bit, temp_count;
            Int32 set_data = 0;

            if (myHidDevice.opened == false)
            {
                MessageBox.Show("请先 连接设备！");
            }
            else
            {
                WriteBuffer[0] = 0x00;
                WriteBuffer[1] = 0xAE;
                WriteBuffer[2] = 3;

                WriteBuffer[3] = (byte)set_data;
                WriteBuffer[4] = (byte)(set_data >> 8);
                WriteBuffer[5] = (byte)(set_data >> 16);
                WriteBuffer[6] = (byte)(set_data >> 24);

                //WriteBuffer[6] = 0;
                //WriteBuffer[7] = 5;

                if (myHidDevice.Write(WriteBuffer) == false)
                    MessageBox.Show("Write Failed");
                else
                    MessageBox.Show("Write OK");
            }
        }

        private void btn_newICw_Click(object sender, EventArgs e)
        {
            int i;
            if (myHidDevice.opened == false)
            {
                MessageBox.Show("请先 连接设备！");
            }
            else
            {
                for (i = 0; i < 16; i++)
                {
                    WriteBuffer[i] = 0;
                }

                WriteBuffer[0] = 0x00;
                WriteBuffer[1] = 0xAE;
                WriteBuffer[2] = 0x05;

                if (myHidDevice.Write(WriteBuffer) == false)
                    MessageBox.Show("Write Failed");
                else
                    MessageBox.Show("Write OK");
            }
        }

        private void tbc_Fun_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                switch (tbc_Fun.SelectedIndex)
                {
                    case 0:
                        //MessageBox.Show("选择了标签1");
                        break;
                    case 1:
                        //MessageBox.Show("选择了标签2");
                        DataSet ds = DBHelper.getDs("select * from tb_ICCard_Data", "tb_Data");

                        dgv_IcData.DataSource = ds.Tables[0];
                        dgv_IcData.Columns[1].Visible = false;
                        dgv_IcData.Columns[2].Visible = false;
                        dgv_IcData.Columns[4].Visible = false;
                        dgv_IcData.Columns[5].Visible = false;
                        dgv_IcData.Columns[6].Visible = false;
                        break;
                    case 2:
                        DataSet ds2 = DBHelper.getDs("select * from tb_MainBoard", "tb_mb");
                        dgv_mb_data.DataSource = ds2.Tables[0];
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //sts_lable.Text = DateTime.Now.ToString();
            //if (hid[hid_index].venderID == 0x0483 && hid[hid_index].productID == 0x5750)
            //{
            //    sts_lable.Text += "  " + hid[hid_index].venderID.ToString() + " " + hid[hid_index].productID.ToString();
            //}
        }

        ///  <summary>
        ///   Overrides WndProc to enable checking for and handling WM_DEVICECHANGE messages.
        ///  </summary>
        ///  
        ///  <param name="m"> a Windows Message </param>

        protected override void WndProc(ref Message m)
        {
            try
            {
                //  The OnDeviceChange routine processes WM_DEVICECHANGE messages.

                if (m.Msg == 0X219)
                {
                    try
                    {
                        if ((m.WParam.ToInt32() == 0X8000))
                        {
                            //  If WParam contains DBT_DEVICEARRIVAL, a device has been attached.

                            textBox1.Text+=("A device has been attached.");

                            //  Find out if it's the device we're communicating with.

                            //if (MyDeviceManagement.DeviceNameMatch(m, myDevicePathName))
                            //{
                            //    lstResults.Items.Add("My device attached.");
                            //    USB_Status.Text = "USB Status: Attached (VID: " + txtVendorID.Text + " PID: " + txtProductID.Text + ")";
                            //}

                        }
                        else if ((m.WParam.ToInt32() == 0X8004))
                        {

                            //  If WParam contains DBT_DEVICEREMOVAL, a device has been removed.

                            textBox1.Text += ("A device has been removed.");

                            //  Find out if it's the device we're communicating with.

                            //if (MyDeviceManagement.DeviceNameMatch(m, myDevicePathName))
                            //{

                            //    lstResults.Items.Add("My device removed.");
                            //    USB_Status.Text = "USB Status: Detached";
                            //    //  Set MyDeviceDetected False so on the next data-transfer attempt,
                            //    //  FindTheHid() will be called to look for the device 
                            //    //  and get a new handle.

                            //    FrmMy.myDeviceDetected = false;
                            //}
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        
                        throw;
                    } 
                }

                //  Let the base form process the message.

                base.WndProc(ref m);
            }
            catch (Exception ex)
            {
                //DisplayException(this.Name, ex);
                throw;
            }
        }

        //  读取主板ID
        private void btn_SetBoard_Click(object sender, EventArgs e)
        {
            int i;
            if (myHidDevice.opened == false)
            {
                MessageBox.Show("请先 连接设备！");
            }
            else
            {
                for (i = 0; i < 16; i++)
                {
                    WriteBuffer[i] = 0;
                }

                WriteBuffer[0] = 0x0;
                WriteBuffer[1] = 0xAC;      //  读取主板ID
                WriteBuffer[2] = 7;


                if (myHidDevice.Write(WriteBuffer) == false)
                    MessageBox.Show("Write Failed");
                else
                    MessageBox.Show("Write OK");
            }
        }

        private void dgv_mb_data_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            DataBase data2 = new DataBase();//创建DataBase类的对象
            DataSet ds2 = data2.getDs("select * from tb_MainBoard", "tb_mb");

            comboBox1.DataSource = ds2.Tables[0];

            comboBox1.DisplayMember =  "MainBoard_ID";
            comboBox1.ValueMember = "MainBoard_ID";
            comboBox1.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBox1.Text != "")
            //{
            //    //Int32 mbid = ConvertToInt32(comboBox1.Text);
            //    //BitConverter.GetBytes(mbid);
            //    tbxIcNum.Text = BitConverter.ToString(BitConverter.GetBytes(mbid));
            //}
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = ("Excel 文件(*.xls)|*.xls");//指定文件后缀名为Excel 文件。
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    string filename = saveFile.FileName;

                    if (System.IO.File.Exists(filename))
                    {
                        System.IO.File.Delete(filename);//如果文件存在删除文件
                    }

                    int index = filename.LastIndexOf("//");//获取最后一个/的索引  
                    filename = filename.Substring(index + 1);//获取excel名称(新建表的路径相对于SaveFileDialog的路径)  
                    //select * into 建立 新的表[[Excel 8.0;database= excel名].[sheet名] 
                    //如果是新建sheet表不能加$,如果向sheet里插入数据要加$.sheet最多存储65535条数据
                    string sql = "select top 65535 *  into   [Excel 8.0;database=" 
                        + filename + "].[Sheet1] from tb_ICCard_Data where 卡号 ="
                        +Convert.ToInt32(textBox3.Text);
               
                    int flag = DBHelper.executeCommand(sql);
                    if (flag>0)
                    {
                        MessageBox.Show("导出数据成功", "导出数据", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                    DataSet ds = DBHelper.getDs("select * from tb_ICCard_Data", "tb_Data");

                    dgv_IcData.DataSource = ds.Tables[0];
                    dgv_IcData.Columns[1].Visible = false;
                    dgv_IcData.Columns[2].Visible = false;
                    dgv_IcData.Columns[4].Visible = false;
                    dgv_IcData.Columns[5].Visible = false;
                    dgv_IcData.Columns[6].Visible = false;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();//打开文件对话框。   
                openFile.Filter = ("Excel 文件(*.xls)|*.xls");//后缀名。   
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    string filename = openFile.FileName;
                    //int index = filename.LastIndexOf("//");//截取文件的名字   
                    //filename = filename.Substring(index + 1);

                    //将excel导入access   
                    //distinct :删除excel重复的行.   
                    //[excel名].[sheet名] 已有的excel的表要加$   
                    //where not in : 插入不重复的记录。   

                    string sql = "insert into tb_ICCard_Data(IC_ID) select distinct * from [Excel 8.0;database=" +
                                filename + "].[Sheet1] where IC_ID not in (select distinct IC_ID from tb_ICCard_Data) ";
                    int flag = DBHelper.executeCommand(sql);

                    if (flag>0)
                    {
                        MessageBox.Show("导入数据成功", "导入数据", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataSet ds = DBHelper.getDs("select * from tb_ICCard_Data", "tb_Data");

                        dgv_IcData.DataSource = ds.Tables[0];
                        dgv_IcData.Columns[1].Visible = false;
                        dgv_IcData.Columns[2].Visible = false;
                        dgv_IcData.Columns[4].Visible = false;
                        dgv_IcData.Columns[5].Visible = false;
                        dgv_IcData.Columns[6].Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("导入数据失败", "导入数据", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //db.Close();
            }  
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete from tb_ICCard_Data";
                int flag = DBHelper.executeCommand(sql);
                MessageBox.Show("删除数据库数据成功", "删除数据库数据", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataSet ds = DBHelper.getDs("select * from tb_ICCard_Data", "tb_Data");

                dgv_IcData.DataSource = ds.Tables[0];
                dgv_IcData.Columns[1].Visible = false;
                dgv_IcData.Columns[2].Visible = false;
                dgv_IcData.Columns[4].Visible = false;
                dgv_IcData.Columns[5].Visible = false;
                dgv_IcData.Columns[6].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = DBHelper.getDs("select * from tb_ICCard_Data where 卡号 ="+ Convert.ToInt32(textBox3.Text), "tb_Data");
            DataTable dt = ds.Tables[0];
            DataView dv = new DataView(dt);
            dgv_IcData.DataSource = dv;
        }

        /// <summary>
        /// 关闭窗体事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFrom_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 关闭窗体时，关闭数据库连接
            DBHelper.closeCon();
        }

        private void dgv_IcData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //MessageBox.Show(dgv_IcData.SelectedRows[0].Cells["IC_ID"].Value.ToString());
            //strIC_ID = dgv_IcData.SelectedRows[0].Cells["IC_ID"].Value.ToString();
            FrmICDataShow FrmData = new FrmICDataShow(this);
            string tstr = dgv_IcData.SelectedRows[0].Cells["IC_ID"].Value.ToString();
            //FrmData.IC_ID = Convert.ToInt32(tstr.Substring(0, 3)).ToString("X") + " " +
            //                Convert.ToInt32(tstr.Substring(3, 3)).ToString("X") + " " +
            //                Convert.ToInt32(tstr.Substring(6, 3)).ToString("X") + " " +
            //                Convert.ToInt32(tstr.Substring(9, 3)).ToString("X") ;
            //FrmData.IC_ID = tstr.Substring(0, 2) + " " +
            //                tstr.Substring(2, 2) + " " +
            //                tstr.Substring(4, 2) + " " +
            //                tstr.Substring(6, 2);
            FrmData.IC_ID = tstr;
            FrmData.Show();
        }

        private void dgv_mb_data_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void tbxCarNum_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FrmSelectMBoardID FrmSMBoardID = new FrmSelectMBoardID(this);
            FrmSMBoardID.Show();
        }

        private void dgv_IcData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gbx_basic_Enter(object sender, EventArgs e)
        {

        }

        //public string IC_ID
        //{
        //    get { return strIC_ID; }
        //    set { strIC_ID = value; }
        //}


        public string text { get; set; }
    }
}

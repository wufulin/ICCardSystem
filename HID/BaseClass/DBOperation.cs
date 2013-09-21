using System;
//引用类库
using System.Data;
using System.Data.OleDb;

namespace HID.BaseClass
{
    class DBOperation
    {
        private OleDbConnection oledCon;

        #region 添加--IC_Data
        public int Add_IcData(cIC_Card_Data icData)
        {
            int intFalg = 0;
            try
            {
                oledCon = DBHelper.getCon();
                oledCon.Open();
                string strAdd = "insert into tb_ICCard_Data (IC_ID,写卡时间,Block_8,Block_9,Block_10,卡号,持卡人,电梯ID)";
                //string strAdd = "insert into tb_ICCard_Data (IC_ID,写卡时间,Block_8,Block_9,Block_10)";
                strAdd += "values('" + icData.IC_ID + "','" + DateTime.Now.ToString() + "','" + 
                    BitConverter.ToString(icData.Block_8) + "','" + 
                    BitConverter.ToString(icData.Block_9)+"','" +
                    BitConverter.ToString(icData.Block_10) + "','" +
                    icData.ic_num+"','" +
                    icData.持卡人+"','" +
                    icData.电梯ID+"')" 
                    ;
                //strAdd += "values('" + icData.IC_ID + "','" + icData.IC_Fun + "',";
                //strAdd += "'" + icData.Floor_Data + "','" + icData.IC_FunA + "','" + icData.Add_ID + "')";
                OleDbCommand oledCmd = new OleDbCommand(strAdd, oledCon);
                if (oledCmd.ExecuteNonQuery() != 0)
                {
                    intFalg = 1;//添加成功
                }
                return intFalg;
            }
            catch (Exception ee)
            {
                return intFalg;
            }
        }
        #endregion

        #region 更新--IC_Data
        public int Updata_IcData(cIC_Card_Data icData)
        {
            int intFalg = 0;
            try
            {
                oledCon = DBHelper.getCon();
                oledCon.Open();
                string strAdd = "update tb_ICCard_Data ";
                strAdd +=   "set 写卡时间='" + DateTime.Now.ToString()+"'," +
                            "Block_8='" + BitConverter.ToString(icData.Block_8) + "'," +
                            "Block_9='" + BitConverter.ToString(icData.Block_9) + "'," +
                            "Block_10='" + BitConverter.ToString(icData.Block_10) + "'," +
                            "卡号='" + icData.ic_num + "'," +
                            "持卡人='" + icData.持卡人 + "'," +
                            "电梯ID='" + icData.电梯ID + "'" +
                            "where IC_ID='"+ icData.IC_ID+"'" ;
 
                OleDbCommand oledCmd = new OleDbCommand(strAdd, oledCon);
                if (oledCmd.ExecuteNonQuery() != 0)
                {
                    intFalg = 1;//添加成功
                }
                return intFalg;
            }
            catch (Exception ee)
            {
                return intFalg;
            }
        }
        #endregion

        #region 查找数据--IC_Data
        public int Find_IcData(cIC_Card_Data icData)
        {
            int intFalg = 0;
            try
            {
                string strcmd = "select * from tb_ICCard_Data where IC_ID='" + icData.IC_ID+"'" ;

                DataSet ds = DBHelper.getDs(strcmd, "tb_Data");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    intFalg = 1;

                }
                return intFalg;
            }
            catch (Exception ee)
            {
                return intFalg;
            }
        }
        #endregion

        #region 删除数据--IC_Data
        public int Delete_IcData(cIC_Card_Data icData)
        {
            int intFalg = 0;
            try
            {
                oledCon = DBHelper.getCon();
                oledCon.Open();
                string strcmd = "delete from tb_ICCard_Data where IC_ID='" + icData.IC_ID+"'" ;

                OleDbCommand oledCmd = new OleDbCommand(strcmd, oledCon);
                if (oledCmd.ExecuteNonQuery() != 0)
                {
                    intFalg = 1;//添加成功
                }
                return intFalg;
            }
            catch (Exception ee)
            {
                return intFalg;
            }
        }
        #endregion

        #region 添加--MainBoard_Data
        public int Add_MainBoard_Data(s_MainBoard_Data mbData)
        {
            int intFalg = 0;
            try
            {
                oledCon = DBHelper.getCon();
                oledCon.Open();
                string strAdd = "insert into tb_MainBoard (MainBoard_ID,MainBoard_Num,单位名称)";
                strAdd += "values('" + mbData.MainBoard_ID + "','" + mbData.MainBoard_Num + "','" +
                    mbData.Company_Name + "')";

                OleDbCommand oledCmd = new OleDbCommand(strAdd, oledCon);
                if (oledCmd.ExecuteNonQuery() != 0)
                {
                    intFalg = 1;//添加成功
                }
                return intFalg;
            }
            catch (Exception ee)
            {
                return intFalg;
            }
        }
        #endregion

        #region 更新--MainBoard_Data
        public int Updata_MainBoard_Data(s_MainBoard_Data mbData)
        {
            int intFalg = 0;
            try
            {
                oledCon = DBHelper.getCon();
                oledCon.Open();
                string strAdd = "update tb_MainBoard ";
                strAdd += "set MainBoard_Num='" + mbData.MainBoard_Num + "'" + "set 单位名称='" + mbData.Company_Name + "'" + "where MainBoard_ID='" + mbData.MainBoard_ID + "'";

                OleDbCommand oledCmd = new OleDbCommand(strAdd, oledCon);
                if (oledCmd.ExecuteNonQuery() != 0)
                {
                    intFalg = 1;//添加成功
                }
                return intFalg;
            }
            catch (Exception ee)
            {
                return intFalg;
            }
        }
        #endregion

        #region 查找数据--MainBoard_Data
        public int Find_MainBoard_Data(s_MainBoard_Data mbData)
        {
            int intFalg = 0;
            try
            {
                //oledCon = data.getCon();
                //oledCon.Open();
                string strcmd = "select * from tb_MainBoard where MainBoard_ID='" + mbData.MainBoard_ID + "'";

                DataBase data = new DataBase();//创建DataBase类的对象
                DataSet ds = data.getDs(strcmd, "tb_MB");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    intFalg = 1;

                }
                return intFalg;
            }
            catch (Exception ee)
            {
                return intFalg;
            }
        }
        #endregion

        #region 删除数据--MainBoard_Data
        public int Delete_MainBoard_Data(s_MainBoard_Data mbData)
        {
            int intFalg = 0;
            try
            {
                oledCon = DBHelper.getCon();
                oledCon.Open();
                string strcmd = "delete from tb_MainBoard where MainBoard_ID='" + mbData.MainBoard_ID + "'";

                OleDbCommand oledCmd = new OleDbCommand(strcmd, oledCon);
                if (oledCmd.ExecuteNonQuery() != 0)
                {
                    intFalg = 1;//成功
                }
                return intFalg;
            }
            catch (Exception ee)
            {
                return intFalg;
            }
        }
        #endregion
    }

    #region 定义 IC_Card_Data 数据结构
    public class cIC_Card_Data
    {
        private string ic_id = "";
        private string ic_fun = "";
        private string floor_data = "";
        private string ic_funa = "";
        private int _ic_num ;
        private string _持卡人 = "";
        private string _电梯ID = "";
        private byte[] block_8=new byte[16];
        private byte[] block_9 = new byte[16];
        private byte[] block_10 = new byte[16];
        //private byte[] block_9;
        //private byte[] block_10;

        public string 持卡人
        {
            get { return _持卡人; }
            set { _持卡人 = value; }
        }

        public string 电梯ID
        {
            get { return _电梯ID; }
            set { _电梯ID = value; }
        }

        public string IC_ID
        {
            get { return ic_id; }
            set { ic_id = value; }
        }
        /// <summary>
        /// 单位全称
        /// </summary>
        public string IC_Fun
        {
            get { return ic_fun; }
            set { ic_fun = value; }
        }
        /// <summary>
        /// 单位税号
        /// </summary>
        public string Floor_Data
        {
            get { return floor_data; }
            set { floor_data = value; }
        }
        /// <summary>
        /// 联系人
        /// </summary>
        public string IC_FunA
        {
            get { return ic_funa; }
            set { ic_funa = value; }
        }
        /// <summary>
        /// 联系电话
        /// </summary>
        public int ic_num
        {
            get { return _ic_num; }
            set { _ic_num = value; }
        }

        public byte[] Block_8
        {
            get { return block_8; }
            set { block_8 = value; }
        }

        public byte[] Block_9
        {
            get { return block_9; }
            set { block_9 = value; }
        }

        public byte[] Block_10
        {
            get { return block_10; }
            set { block_10 = value; }
        }
   
    }
    #endregion
   
    #region 定义 MainBoard_Data
    public class s_MainBoard_Data
    {
        private string _MainBoard_ID = "";
        private string _MainBoard_Num = "";
        private string _Company_Name = "";

        public string MainBoard_ID
        {
            get { return _MainBoard_ID; }
            set { _MainBoard_ID = value; }
        }

        public string MainBoard_Num
        {
            get { return _MainBoard_Num; }
            set { _MainBoard_Num = value; }
        }

        public string Company_Name
        {
            get { return _Company_Name; }
            set { _Company_Name = value; }
        }
    }
    #endregion
    
}
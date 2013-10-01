using System;
//引用类库
using System.Data;
using System.Data.OleDb;
using HID.Model;

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

                string strAdd = "insert into tb_ICCard_Data (IC_ID,写卡时间,Block_8,Block_9,Block_10,卡号,电梯ID,持卡人)";  //
                strAdd += " values('" + icData.IC_ID + "','" + DateTime.Now.ToString() + "','" +
                    BitConverter.ToString(icData.Block_8) + "','" +
                    BitConverter.ToString(icData.Block_9) + "','" +
                    BitConverter.ToString(icData.Block_10) + "','" +
                    icData.ic_num + "','" +
                    icData.电梯ID + "','" +
                    icData.持卡人 + "')";

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
                string strAdd = "update tb_ICCard_Data ";
                strAdd +=   "set 写卡时间='" + DateTime.Now.ToString()+"'," +
                            "Block_8='" + BitConverter.ToString(icData.Block_8) + "'," +
                            "Block_9='" + BitConverter.ToString(icData.Block_9) + "'," +
                            "Block_10='" + BitConverter.ToString(icData.Block_10) + "'," +
                            "卡号='" + icData.ic_num + "'," +
                            "电梯ID='" + icData. 电梯ID+ "'," +
                            "持卡人='" + icData.持卡人 + "'" +
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
        public int Add_MainBoard_Data(MainBoard mbData)
        {
            int intFalg = 0;
            try
            {
                oledCon = DBHelper.getCon();
                string strAdd = "insert into tb_MainBoard (MainBoard_ID,MainBoard_Num,单位名称)";
                strAdd += "values('" + mbData.Id + "','" + mbData.Number + "','" +
                    mbData.CompanyName + "')";

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
        public int Updata_MainBoard_Data(MainBoard mbData)
        {
            int intFalg = 0;
            try
            {
                oledCon = DBHelper.getCon();
                string strAdd = "update tb_MainBoard ";
                strAdd += "set MainBoard_Num='" + mbData.Number+ "'" + "set 单位名称='" + 
                    mbData.CompanyName + "'" + "where MainBoard_ID='" + mbData.Id + "'";

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
        public int Find_MainBoard_Data(MainBoard mbData)
        {
            int intFalg = 0;
            try
            {
                //oledCon = data.getCon();
                string strcmd = "select * from tb_MainBoard where MainBoard_ID='" + mbData.Id + "'";

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
        public int Delete_MainBoard_Data(MainBoard mbData)
        {
            int intFalg = 0;
            try
            {
                oledCon = DBHelper.getCon();
                string strcmd = "delete from tb_MainBoard where MainBoard_ID='" + mbData.Id + "'";

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
}
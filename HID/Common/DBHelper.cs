using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace HID.BaseClass
{
    /// <summary>
    /// 数据库帮助类
    /// </summary>
    class DBHelper
    {
        private static OleDbConnection oledbcon; // Access数据库连接单例

        /// <summary>
        /// 通过类方法，获取数据库连接
        /// </summary>
        /// <returns></returns>
        public static OleDbConnection getCon()
        {
            string strDPath = Application.StartupPath;
            string strDataSource = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
                + strDPath + "\\DataBase\\db_Login.mdb;" + "Jet OLEDB:Database Password=xzy;";
 
            if (oledbcon == null)
            {
                oledbcon = new OleDbConnection(strDataSource);
            }

            if (oledbcon.State != ConnectionState.Open)
            {
                oledbcon.Open();
            }

            return oledbcon;
        }

        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public static void closeCon()
        {
            if (oledbcon !=null && oledbcon.State != ConnectionState.Closed)
            {
                oledbcon.Close();
            }
        }

        /// <summary>
        /// 执行增、删、改命令
        /// </summary>
        /// <param name="strCon">sql命令</param>
        /// <returns>执行结果，1代表成功，0代表失败</returns>
        public static int executeCommand(string strCon)
        {
            int intFalg = 0;
            try
            {
                getCon();
                OleDbCommand oledbCom = new OleDbCommand(strCon, getCon());
                if (oledbCom.ExecuteNonQuery() != 0)
                {
                    intFalg = 1; //执行增、删、改成功
                }
                oledbCom.Connection.Close();
                return intFalg;
            }
            catch (Exception e)
            {
                return intFalg;
            }
        }

        /// <summary>
        /// 根据sql命令，获取数据集
        /// </summary>
        /// <param name="strCom">sql命令</param>
        /// <param name="tbname">表名</param>
        /// <returns>查询数据集</returns>
        public static DataSet getDs(string strCom, string tbname)
        {
            OleDbDataAdapter oledbda = new OleDbDataAdapter(strCom,getCon());
            DataSet ds = new DataSet();
            oledbda.Fill(ds, tbname);
            return ds;
        }
    }
}
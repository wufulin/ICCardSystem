using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using HID.CommonClass;

namespace HID
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        //DataCon datacon = new DataCon();
        DataOperate dataoperate = new DataOperate();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                errorProvider_Name.SetError(txtName, "用户名不能为空!");
                //MessageBox.Show("用户名不能为空!");
            }
            else
            {
                errorProvider_Name.Clear();
                string strSql = "select * from tb_admin where name='" + txtName.Text + "' and pwd='" + txtPwd.Text + "'";
                DataSet ds = dataoperate.getDs(strSql, "tb_admin");
                //if (ds.Tables[0].Rows.Count > 0)

                //if(txtName.Text=="xzy" && txtPwd.Text=="13590672871" )

                string strDPath = Application.StartupPath;
                string strDataSource = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
                    + strDPath.Substring(0, strDPath.LastIndexOf("\\")).Substring(0, strDPath.Substring(0, strDPath.LastIndexOf("\\")).LastIndexOf("\\")) + "\\DataBase\\db_Login.mdb";

                //OleDbConnection oledbCon = new OleDbConnection(strDataSource);

                //oledbCon.Open();

                //string strSql = "select * from tb_admin where name='" + txtName.Text + "' and pwd='" + txtPwd.Text + "'";

                //OleDbDataAdapter da = new OleDbDataAdapter(strSql, oledbCon);

                //DataSet ds = new DataSet();
                //da.Fill(ds, "tb_admin");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.Hide();
                    //Form frmmain = new Form1();
                    Form frmmain = new MainFrom();
                    frmmain.Show();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnEixt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

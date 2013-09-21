using System;
using System.Data;
using System.Windows.Forms;
using HID.BaseClass;

namespace HID
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

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
                DataSet ds = DBHelper.getDs(strSql, "tb_admin");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.Close();
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

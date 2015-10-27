using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication6
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select Name from StaffAccount where Name='" + txtUserName + "'";
            string connstr = ConfigurationManager.ConnectionStrings["WindowsFormsApplication6.Properties.Settings.staffConnectionString1"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstr);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                lblUserMsg.Text = "用户名已存在,请重新输入!";
            }
            else if (txtUserName.Text.Trim() == "")
            {
                lblUserMsg.Text = "用户名不能为空!";
            }

            else if (txtPassword.Text.Trim() == "")
            {
                lblPwd.Text = "密码不能为空!";
                lblPwd.Text = "";
            }
            else if (txtPwdConfirm.Text.Trim() == "")
            {
                lblPswConfirm.Text = "验证密码不能为空!";
                lblUserMsg.Text = "";
                lblPwd.Text = "";
            }
            else if (txtPassword.Text.Trim() != txtPwdConfirm.Text.Trim())
            {
                lblPwd.Text = "2次密码必须一样!";
                lblPswConfirm.Text = "请重新输入!";
            }
            else if (txtName.Text.Trim() == "" | txtAge.Text.Trim() == "" | cmboxSex.Text == "" | cmboxOffice.Text == "")
            {
                lblBaseInfo.Text = "基本信息不完整！";
            }
            else 
            {
                lblUserMsg.Text = "";
                lblPwd.Text = "";
                lblPswConfirm.Text = "";
                lblBaseInfo.Text = "";
                string uType = "";
                if (rbtAdmin.Checked)
                    uType = "Administrator";
                else if (rbtNormalUser.Checked)
                    uType = "NormalUser";
                else
                    uType = "NormalUser";
                conn.Close();
                string sqlInsert = "insert into StaffAccount(Name,Password,UserType) values(@UserName,@UserPwd,@UserType)";
                string sqlInsertInfo = "insert into StaffInfo(Name,Sex,Age,Office) values(@Name,@Sex,@Age,@Office)";
                SqlParameter[] param = {
                                        new SqlParameter("@UserName",txtUserName.Text),
                                        new SqlParameter("@UserPwd",txtPassword.Text),
                                        new SqlParameter("@UserType",uType)
                                    };
                SqlParameter[] paramInfo = {
                                        new SqlParameter("@Name",txtName.Text),
                                        new SqlParameter("@Age",txtAge.Text),
                                        new SqlParameter("@Sex",cmboxSex.Text),
                                        new SqlParameter("@Office",cmboxOffice.Text)
                };
                SqlConnection connInsert = new SqlConnection(connstr);
                SqlCommand cmdInsertInfo = new SqlCommand(sqlInsertInfo, connInsert);
                SqlCommand cmdInsert = new SqlCommand(sqlInsert, connInsert);             
                connInsert.Open();
                cmdInsertInfo.Parameters.AddRange(paramInfo);
                cmdInsert.Parameters.AddRange(param);
                int m = cmdInsertInfo.ExecuteNonQuery();
                int n = cmdInsert.ExecuteNonQuery();
                
                if (n == 0||m==0)
                {
                    MessageBox.Show("注册失败!,请重新输入");
                    return;
                }
                else
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Close();
                    MessageBox.Show("注册成功!");
                }
                connInsert.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

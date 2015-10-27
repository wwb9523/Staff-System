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
    public partial class PasswordChange : Form
    {
        public PasswordChange()
        {
            InitializeComponent();
        }

        private void PasswordChange_Load(object sender, EventArgs e)
        {
            string currentUser = Form1.UserName;
            txtName.Text = currentUser;
        }

        private void Change_Click(object sender, EventArgs e)
        {
            string connstr = ConfigurationManager.ConnectionStrings["WindowsFormsApplication6.Properties.Settings.staffConnectionString1"].ConnectionString;
            SqlConnection conn = new SqlConnection(connstr);
            string sql = "select Password from StaffAccount where Name ='" + txtName.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                string oldPwd = sdr.GetString(0).Trim();
                 if (oldPwd == txtOldPwd.Text)
                {
                    if (txtNewPassword.Text.Trim() == "" || txtNewPwdAgain.Text.Trim() == "")
                    {
                    MessageBox.Show("新密码确认不能为空!");
                    return;
                    }
                    else if (txtNewPassword.Text.Trim() != txtNewPwdAgain.Text.Trim())
                    {
                        MessageBox.Show("2次输入的新密码不一样,请重新输入!");
                        txtNewPassword.Text = "";
                        txtNewPwdAgain.Text = "";
                        return;
                    }
                    else
                    {
                        sdr.Close();
                        string sqlUpdate = "update StaffAccount set Password ='" + txtNewPwdAgain.Text +
                        "' where Name ='" + txtName.Text + "'";
                        SqlCommand cmdUp = new SqlCommand(sqlUpdate, conn);
                        if (cmdUp.ExecuteNonQuery() == 0)
                        {
                            MessageBox.Show("未知错误!");
                            return;
                        }
                        else
                        {
                            MainForm mainForm = new MainForm();
                            mainForm.Show();
                            this.Close();
                            MessageBox.Show("恭喜你!密码修改成功!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("旧密码错误或者不能为空");
                    txtOldPwd.Text = "";
                    txtNewPassword.Text = "";
                    txtNewPwdAgain.Text = "";
                    return;
                }
            }
            else
            {
                MessageBox.Show("用户名不存在,请重新输入!");
                txtName.Text = "";
                txtOldPwd.Text = "";
                txtNewPassword.Text = "";
                txtNewPwdAgain.Text = "";
                return;             
            }
            conn.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

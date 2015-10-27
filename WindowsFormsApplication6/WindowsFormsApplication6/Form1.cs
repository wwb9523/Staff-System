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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string UserName;
        public static string UserType;
        public static int ID;
        string connstr = ConfigurationManager.ConnectionStrings["WindowsFormsApplication6.Properties.Settings.staffConnectionString1"].ConnectionString;
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connstr))
            {
                string sql = "select Password,UserType,ID from StaffAccount where Name='" + textBox1.Text + "'";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();//打开连接
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string pwd = reader.GetString(0).Trim();
                            string utype = reader.GetString(1);
                            int id = reader.GetInt32(2);
                            if (pwd == textBox2.Text)
                            {
                                UserName = textBox1.Text;
                                UserType = utype;
                                ID = id;
                                MessageBox.Show("系统登录成功,正在跳转主页面...");
                                MainForm mainForm = new MainForm();
                                mainForm.Show();
                                this.Hide();
                            }
                            else {
                                MessageBox.Show("密码错误!请再次输入!");
                                textBox2.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("用户名不存在,请重新出入!");
                            textBox1.Text = "";
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            Application.Exit();
        }
    }
}

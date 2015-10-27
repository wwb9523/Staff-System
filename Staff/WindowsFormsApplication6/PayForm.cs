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
    public partial class PayForm : Form
    {
        public PayForm()
        {
            InitializeComponent();
        }

        private static int id = Form1.ID;
        private void PayForm_Load(object sender, EventArgs e)
        {
            if (Form1.UserType.Trim() == "Administrator")
            {
                // TODO: 这行代码将数据加载到表“staffDataSet.Pay”中。您可以根据需要移动或删除它。
                this.payTableAdapter.Fill(this.staffDataSet.Pay);
            }
            else
            {
                string sql = "select*from Pay where ID=" + id + "";
                string connstr = ConfigurationManager.ConnectionStrings["WindowsFormsApplication6.Properties.Settings.staffConnectionString1"].ConnectionString;
                SqlConnection conn = new SqlConnection(connstr);
                SqlCommand cmd = new SqlCommand(sql, conn);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void PayForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

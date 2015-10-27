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
    public partial class ShowPayForm : Form
    {
        public ShowPayForm()
        {
            InitializeComponent();
        }
        private static int id = Form1.ID;
        private void ShowPayForm_Load(object sender, EventArgs e)
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
                comboBox1.Enabled = false;
                btnOk.Enabled = false;
            }
            display();
        }
        private string SelectValue="";
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            SelectValue = comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (SelectValue == "")
            {
                sql = "select*from Pay";
            }
            else
            {
                string connstr = ConfigurationManager.ConnectionStrings["WindowsFormsApplication6.Properties.Settings.staffConnectionString1"].ConnectionString;
                SqlConnection conn = new SqlConnection(connstr);
                sql = "select * from Pay where Pay.ID in(select ID from StaffInfo where StaffInfo.Office='" + SelectValue + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            display();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void display()
        {
            int totalMoney = 0;
            int totalMan = 0;
            int Id;
            List<int> listID = new List<int>();
            int count = dataGridView1.Rows.Count;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                count--;                           
                if (count > 0)
                {
                    Id = Convert.ToInt32(row.Cells[0].Value.ToString());
                    if (!listID.Contains(Id))
                    {
                        listID.Add(Id);
                        totalMan++;
                    }
                    totalMoney += Convert.ToInt32(row.Cells[6].Value.ToString());
                }
            }
            TotalMan.Text = totalMan.ToString();
            TotalMoney.Text = totalMoney.ToString();
        }
    }
}

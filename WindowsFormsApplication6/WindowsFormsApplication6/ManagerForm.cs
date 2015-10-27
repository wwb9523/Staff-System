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
    public partial class ManagerForm : Form
    {

        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“staffDataSet.StaffInfo”中。您可以根据需要移动或删除它。
            this.staffInfoTableAdapter.Fill(this.staffDataSet.StaffInfo);
            // TODO: 这行代码将数据加载到表“staffDataSet.Pay”中。您可以根据需要移动或删除它。
            this.payTableAdapter.Fill(this.staffDataSet.Pay);

        }
      
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "delete from StaffAccount where 1=1";
            if (dgvManager.CurrentRow.Selected)
            {
                sql = sql + "and ID=" + Convert.ToInt32(dgvManager.CurrentRow.Cells[0].Value.ToString());
            }
            int n = 0;
            string connStr = ConfigurationManager.ConnectionStrings["WindowsFormsApplication6.Properties.Settings.staffConnectionString1"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            n = cmd.ExecuteNonQuery();
            if (n == 0)
            {
                MessageBox.Show("不存在的ID!");
                return;

            }
            else if (n > 0)
            {
                MessageBox.Show("删除成功!");
            }
            conn.Close();
            this.staffInfoTableAdapter.Fill(this.staffDataSet.StaffInfo);
            this.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float basePay;
            float wealPay;
            float rewardPay;
            float unInsurance;
            float housingFund;
            try {
                basePay = (float)Convert.ToDouble(txtBasePay.Text.Trim());
                wealPay = (float)Convert.ToDouble(txtWealPay.Text.Trim());
                rewardPay = (float)Convert.ToDouble(txtRewardPay.Text.Trim());
                unInsurance = (float)Convert.ToDouble(txtUnInsurance.Text.Trim());
                housingFund = (float)Convert.ToDouble(txtHousingFund.Text.Trim());
            }
            catch
            {
                txtBasePay.Text = "";
                MessageBox.Show("工资不是数字，警告！！");
                return;
            }
            if (dgvManager.CurrentRow.Selected)
            {
                int id = Convert.ToInt32(dgvManager.CurrentRow.Cells[0].Value.ToString());
                string today = DateTime.Now.ToLocalTime().ToString();
                SqlParameter[] param =
                {
                    new SqlParameter("@basePay",basePay),
                    new SqlParameter("@wealPay",wealPay),
                    new SqlParameter("@rewardPay",rewardPay),
                    new SqlParameter("@unInsurance",unInsurance),
                    new SqlParameter("@housingFund",housingFund),
                    new SqlParameter("@date",today),
                    new SqlParameter("@id",id)
                };
                string sql = "insert into Pay(BasePay,WealPay,RewardPay,UnInsurance,HousingFund,Date,ID) values(@basePay,@wealPay,@rewardPay,@unInsurance,@housingFund,@date,@id)";
                string connstr = ConfigurationManager.ConnectionStrings["WindowsFormsApplication6.Properties.Settings.staffConnectionString1"].ConnectionString;
                SqlConnection conn = new SqlConnection(connstr);
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.AddRange(param);
                int n = 0;
                n = cmd.ExecuteNonQuery();
                if (n == 0)
                {
                    MessageBox.Show("添加失败!");
                    return;
                }
                else if (n > 0)
                {
                    MessageBox.Show("添加成功!");
                }
                conn.Close();
            }
        }

    }
}

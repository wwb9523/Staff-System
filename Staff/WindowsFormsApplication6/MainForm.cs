using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ManagerForm managerForm = new ManagerForm();
            managerForm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            PasswordChange PwdChange = new PasswordChange();
            PwdChange.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string uType = Form1.UserType;
            if (uType.Trim() == "Administrator")
            {
                lblIdentify.Text = "管理员";
            }
            else
            {
                lblIdentify.Text = "普通用户";
                tsbManage.Enabled = false;
                tsbRegistration.Enabled = false;
            }
            lblIdentify.Parent = pictureBox2;
            lblWelcome.Parent = pictureBox2;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ShowPayForm ShowpayForm = new ShowPayForm();
            ShowpayForm.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

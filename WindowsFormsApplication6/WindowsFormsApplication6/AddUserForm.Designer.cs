namespace WindowsFormsApplication6
{
    partial class AddUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPwdConfirm = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblUserMsg = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblPswConfirm = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.cmboxSex = new System.Windows.Forms.ComboBox();
            this.cmboxOffice = new System.Windows.Forms.ComboBox();
            this.lblBaseInfo = new System.Windows.Forms.Label();
            this.rbtNormalUser = new System.Windows.Forms.RadioButton();
            this.rbtAdmin = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码确认";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(106, 44);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(142, 21);
            this.txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(106, 81);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(142, 21);
            this.txtPassword.TabIndex = 2;
            // 
            // txtPwdConfirm
            // 
            this.txtPwdConfirm.Location = new System.Drawing.Point(106, 115);
            this.txtPwdConfirm.Name = "txtPwdConfirm";
            this.txtPwdConfirm.PasswordChar = '*';
            this.txtPwdConfirm.Size = new System.Drawing.Size(142, 21);
            this.txtPwdConfirm.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "注册";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(165, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblUserMsg
            // 
            this.lblUserMsg.AutoSize = true;
            this.lblUserMsg.ForeColor = System.Drawing.Color.Red;
            this.lblUserMsg.Location = new System.Drawing.Point(254, 47);
            this.lblUserMsg.Name = "lblUserMsg";
            this.lblUserMsg.Size = new System.Drawing.Size(0, 12);
            this.lblUserMsg.TabIndex = 8;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.ForeColor = System.Drawing.Color.Red;
            this.lblPwd.Location = new System.Drawing.Point(256, 84);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(0, 12);
            this.lblPwd.TabIndex = 9;
            // 
            // lblPswConfirm
            // 
            this.lblPswConfirm.AutoSize = true;
            this.lblPswConfirm.ForeColor = System.Drawing.Color.Red;
            this.lblPswConfirm.Location = new System.Drawing.Point(256, 118);
            this.lblPswConfirm.Name = "lblPswConfirm";
            this.lblPswConfirm.Size = new System.Drawing.Size(0, 12);
            this.lblPswConfirm.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "姓名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "年龄";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "性别";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "科室";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 173);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 21);
            this.txtName.TabIndex = 4;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(104, 201);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(142, 21);
            this.txtAge.TabIndex = 5;
            // 
            // cmboxSex
            // 
            this.cmboxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxSex.FormattingEnabled = true;
            this.cmboxSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmboxSex.Location = new System.Drawing.Point(106, 227);
            this.cmboxSex.Name = "cmboxSex";
            this.cmboxSex.Size = new System.Drawing.Size(121, 20);
            this.cmboxSex.TabIndex = 6;
            // 
            // cmboxOffice
            // 
            this.cmboxOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxOffice.FormattingEnabled = true;
            this.cmboxOffice.Items.AddRange(new object[] {
            "经理室",
            "财务科",
            "技术科",
            "销售科"});
            this.cmboxOffice.Location = new System.Drawing.Point(106, 258);
            this.cmboxOffice.Name = "cmboxOffice";
            this.cmboxOffice.Size = new System.Drawing.Size(121, 20);
            this.cmboxOffice.TabIndex = 7;
            // 
            // lblBaseInfo
            // 
            this.lblBaseInfo.AutoSize = true;
            this.lblBaseInfo.ForeColor = System.Drawing.Color.Red;
            this.lblBaseInfo.Location = new System.Drawing.Point(254, 176);
            this.lblBaseInfo.Name = "lblBaseInfo";
            this.lblBaseInfo.Size = new System.Drawing.Size(0, 12);
            this.lblBaseInfo.TabIndex = 19;
            // 
            // rbtNormalUser
            // 
            this.rbtNormalUser.AutoSize = true;
            this.rbtNormalUser.Location = new System.Drawing.Point(41, 302);
            this.rbtNormalUser.Name = "rbtNormalUser";
            this.rbtNormalUser.Size = new System.Drawing.Size(71, 16);
            this.rbtNormalUser.TabIndex = 8;
            this.rbtNormalUser.TabStop = true;
            this.rbtNormalUser.Text = "普通用户";
            this.rbtNormalUser.UseVisualStyleBackColor = true;
            // 
            // rbtAdmin
            // 
            this.rbtAdmin.AutoSize = true;
            this.rbtAdmin.Location = new System.Drawing.Point(180, 305);
            this.rbtAdmin.Name = "rbtAdmin";
            this.rbtAdmin.Size = new System.Drawing.Size(59, 16);
            this.rbtAdmin.TabIndex = 9;
            this.rbtAdmin.TabStop = true;
            this.rbtAdmin.Text = "管理员";
            this.rbtAdmin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(41, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 142);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "个人基本信息";
            // 
            // groupBox2
            // 
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(36, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 125);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用户信息";
            // 
            // AddUserForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(293, 398);
            this.Controls.Add(this.rbtAdmin);
            this.Controls.Add(this.rbtNormalUser);
            this.Controls.Add(this.lblBaseInfo);
            this.Controls.Add(this.cmboxOffice);
            this.Controls.Add(this.cmboxSex);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPswConfirm);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblUserMsg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPwdConfirm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPwdConfirm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblUserMsg;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblPswConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ComboBox cmboxSex;
        private System.Windows.Forms.ComboBox cmboxOffice;
        private System.Windows.Forms.Label lblBaseInfo;
        private System.Windows.Forms.RadioButton rbtNormalUser;
        private System.Windows.Forms.RadioButton rbtAdmin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
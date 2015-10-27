using WindowsFormsApplication6.staffDataSetTableAdapters;

namespace WindowsFormsApplication6
{
    partial class ManagerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.dgvManager = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffDataSet = new WindowsFormsApplication6.staffDataSet();
            this.payBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payTableAdapter = new WindowsFormsApplication6.staffDataSetTableAdapters.PayTableAdapter();
            this.staffInfoTableAdapter = new WindowsFormsApplication6.staffDataSetTableAdapters.StaffInfoTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBasePay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtWealPay = new System.Windows.Forms.TextBox();
            this.txtRewardPay = new System.Windows.Forms.TextBox();
            this.txtUnInsurance = new System.Windows.Forms.TextBox();
            this.txtHousingFund = new System.Windows.Forms.TextBox();
            this.staffDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManager
            // 
            this.dgvManager.AutoGenerateColumns = false;
            this.dgvManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nameDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.officeDataGridViewTextBoxColumn});
            this.dgvManager.DataSource = this.staffInfoBindingSource;
            this.dgvManager.Location = new System.Drawing.Point(85, 12);
            this.dgvManager.Name = "dgvManager";
            this.dgvManager.ReadOnly = true;
            this.dgvManager.RowTemplate.Height = 23;
            this.dgvManager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManager.Size = new System.Drawing.Size(544, 203);
            this.dgvManager.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // officeDataGridViewTextBoxColumn
            // 
            this.officeDataGridViewTextBoxColumn.DataPropertyName = "Office";
            this.officeDataGridViewTextBoxColumn.HeaderText = "Office";
            this.officeDataGridViewTextBoxColumn.Name = "officeDataGridViewTextBoxColumn";
            this.officeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffInfoBindingSource
            // 
            this.staffInfoBindingSource.DataMember = "StaffInfo";
            this.staffInfoBindingSource.DataSource = this.staffDataSetBindingSource;
            // 
            // staffDataSetBindingSource
            // 
            this.staffDataSetBindingSource.DataSource = this.staffDataSet;
            this.staffDataSetBindingSource.Position = 0;
            // 
            // staffDataSet
            // 
            this.staffDataSet.DataSetName = "staffDataSet";
            this.staffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // payBindingSource
            // 
            this.payBindingSource.DataMember = "Pay";
            this.payBindingSource.DataSource = this.staffDataSetBindingSource;
            // 
            // payTableAdapter
            // 
            this.payTableAdapter.ClearBeforeFill = true;
            // 
            // staffInfoTableAdapter
            // 
            this.staffInfoTableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(156, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除记录";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(6, 97);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 13;
            this.Back.Text = "返回主界面";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.Back);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(370, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 126);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能按钮";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "退出系统";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = " 发放工资";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBasePay
            // 
            this.txtBasePay.Location = new System.Drawing.Point(169, 243);
            this.txtBasePay.Name = "txtBasePay";
            this.txtBasePay.Size = new System.Drawing.Size(100, 21);
            this.txtBasePay.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "基本工资";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "福利补贴";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "奖励工资";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "失业保险";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "住房公积金";
            // 
            // txtWealPay
            // 
            this.txtWealPay.Location = new System.Drawing.Point(169, 273);
            this.txtWealPay.Name = "txtWealPay";
            this.txtWealPay.Size = new System.Drawing.Size(100, 21);
            this.txtWealPay.TabIndex = 17;
            // 
            // txtRewardPay
            // 
            this.txtRewardPay.Location = new System.Drawing.Point(169, 307);
            this.txtRewardPay.Name = "txtRewardPay";
            this.txtRewardPay.Size = new System.Drawing.Size(100, 21);
            this.txtRewardPay.TabIndex = 18;
            // 
            // txtUnInsurance
            // 
            this.txtUnInsurance.Location = new System.Drawing.Point(169, 342);
            this.txtUnInsurance.Name = "txtUnInsurance";
            this.txtUnInsurance.Size = new System.Drawing.Size(100, 21);
            this.txtUnInsurance.TabIndex = 19;
            // 
            // txtHousingFund
            // 
            this.txtHousingFund.Location = new System.Drawing.Point(169, 375);
            this.txtHousingFund.Name = "txtHousingFund";
            this.txtHousingFund.Size = new System.Drawing.Size(100, 21);
            this.txtHousingFund.TabIndex = 20;
            // 
            // staffDataSetBindingSource1
            // 
            this.staffDataSetBindingSource1.DataSource = this.staffDataSet;
            this.staffDataSetBindingSource1.Position = 0;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(645, 430);
            this.Controls.Add(this.txtHousingFund);
            this.Controls.Add(this.txtUnInsurance);
            this.Controls.Add(this.txtRewardPay);
            this.Controls.Add(this.txtWealPay);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBasePay);
            this.Controls.Add(this.dgvManager);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManager;
        private System.Windows.Forms.BindingSource staffDataSetBindingSource;
        private staffDataSet staffDataSet;
        private System.Windows.Forms.BindingSource payBindingSource;
        private staffDataSetTableAdapters.PayTableAdapter payTableAdapter;
        private System.Windows.Forms.BindingSource staffInfoBindingSource;
        private staffDataSetTableAdapters.StaffInfoTableAdapter staffInfoTableAdapter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBasePay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtWealPay;
        private System.Windows.Forms.TextBox txtRewardPay;
        private System.Windows.Forms.TextBox txtUnInsurance;
        private System.Windows.Forms.TextBox txtHousingFund;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource staffDataSetBindingSource1;
    }
}
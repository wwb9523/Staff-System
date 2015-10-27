using WindowsFormsApplication6.staffDataSetTableAdapters;

namespace WindowsFormsApplication6
{
    partial class ShowPayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowPayForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basePayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wealPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rewardPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unInsuranceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.housingFundDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.staffDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffDataSet = new WindowsFormsApplication6.staffDataSet();
            this.payBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payTableAdapter = new WindowsFormsApplication6.staffDataSetTableAdapters.PayTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalMan = new System.Windows.Forms.TextBox();
            this.TotalMoney = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.basePayDataGridViewTextBoxColumn,
            this.wealPayDataGridViewTextBoxColumn,
            this.rewardPayDataGridViewTextBoxColumn,
            this.unInsuranceDataGridViewTextBoxColumn,
            this.housingFundDataGridViewTextBoxColumn,
            this.finalPayDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.payBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(843, 301);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "编号";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // basePayDataGridViewTextBoxColumn
            // 
            this.basePayDataGridViewTextBoxColumn.DataPropertyName = "BasePay";
            this.basePayDataGridViewTextBoxColumn.HeaderText = "基本工资";
            this.basePayDataGridViewTextBoxColumn.Name = "basePayDataGridViewTextBoxColumn";
            this.basePayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wealPayDataGridViewTextBoxColumn
            // 
            this.wealPayDataGridViewTextBoxColumn.DataPropertyName = "WealPay";
            this.wealPayDataGridViewTextBoxColumn.HeaderText = "福利补贴";
            this.wealPayDataGridViewTextBoxColumn.Name = "wealPayDataGridViewTextBoxColumn";
            this.wealPayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rewardPayDataGridViewTextBoxColumn
            // 
            this.rewardPayDataGridViewTextBoxColumn.DataPropertyName = "RewardPay";
            this.rewardPayDataGridViewTextBoxColumn.HeaderText = "奖励工资";
            this.rewardPayDataGridViewTextBoxColumn.Name = "rewardPayDataGridViewTextBoxColumn";
            this.rewardPayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unInsuranceDataGridViewTextBoxColumn
            // 
            this.unInsuranceDataGridViewTextBoxColumn.DataPropertyName = "UnInsurance";
            this.unInsuranceDataGridViewTextBoxColumn.HeaderText = "失业保险";
            this.unInsuranceDataGridViewTextBoxColumn.Name = "unInsuranceDataGridViewTextBoxColumn";
            this.unInsuranceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // housingFundDataGridViewTextBoxColumn
            // 
            this.housingFundDataGridViewTextBoxColumn.DataPropertyName = "HousingFund";
            this.housingFundDataGridViewTextBoxColumn.HeaderText = "住房公积金";
            this.housingFundDataGridViewTextBoxColumn.Name = "housingFundDataGridViewTextBoxColumn";
            this.housingFundDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finalPayDataGridViewTextBoxColumn
            // 
            this.finalPayDataGridViewTextBoxColumn.DataPropertyName = "FinalPay";
            this.finalPayDataGridViewTextBoxColumn.HeaderText = "最终工资";
            this.finalPayDataGridViewTextBoxColumn.Name = "finalPayDataGridViewTextBoxColumn";
            this.finalPayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "日期";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payBindingSource1
            // 
            this.payBindingSource1.DataMember = "Pay";
            this.payBindingSource1.DataSource = this.staffDataSetBindingSource;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "经理室",
            "财务科",
            "技术科",
            "销售科"});
            this.comboBox1.Location = new System.Drawing.Point(218, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "分类搜索";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(356, 33);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "总人数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(613, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "总金额";
            // 
            // TotalMan
            // 
            this.TotalMan.Location = new System.Drawing.Point(57, 384);
            this.TotalMan.Name = "TotalMan";
            this.TotalMan.ReadOnly = true;
            this.TotalMan.Size = new System.Drawing.Size(100, 21);
            this.TotalMan.TabIndex = 6;
            // 
            // TotalMoney
            // 
            this.TotalMoney.Location = new System.Drawing.Point(660, 384);
            this.TotalMoney.Name = "TotalMoney";
            this.TotalMoney.ReadOnly = true;
            this.TotalMoney.Size = new System.Drawing.Size(100, 21);
            this.TotalMoney.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(516, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ShowPayForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(872, 427);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TotalMoney);
            this.Controls.Add(this.TotalMan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowPayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ShowPayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource staffDataSetBindingSource;
       // private staffDataSet staffDataSet;
        private System.Windows.Forms.BindingSource payBindingSource;
      //  private staffDataSetTableAdapters.PayTableAdapter payTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TotalMan;
        private System.Windows.Forms.TextBox TotalMoney;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource payBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basePayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wealPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rewardPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unInsuranceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn housingFundDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private staffDataSet staffDataSet;

        public PayTableAdapter payTableAdapter { get; private set; }
    }
}
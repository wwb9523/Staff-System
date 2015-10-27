using WindowsFormsApplication6.staffDataSetTableAdapters;

namespace WindowsFormsApplication6
{
    partial class PayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basePayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wealPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rewardPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unInsuranceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.housingFundDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffDataSet = new WindowsFormsApplication6.staffDataSet();
            this.payTableAdapter = new WindowsFormsApplication6.staffDataSetTableAdapters.PayTableAdapter();
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.basePayDataGridViewTextBoxColumn,
            this.wealPayDataGridViewTextBoxColumn,
            this.rewardPayDataGridViewTextBoxColumn,
            this.unInsuranceDataGridViewTextBoxColumn,
            this.housingFundDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.finalPayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.payBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(844, 254);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // basePayDataGridViewTextBoxColumn
            // 
            this.basePayDataGridViewTextBoxColumn.DataPropertyName = "BasePay";
            this.basePayDataGridViewTextBoxColumn.HeaderText = "基本工资";
            this.basePayDataGridViewTextBoxColumn.Name = "basePayDataGridViewTextBoxColumn";
            // 
            // wealPayDataGridViewTextBoxColumn
            // 
            this.wealPayDataGridViewTextBoxColumn.DataPropertyName = "WealPay";
            this.wealPayDataGridViewTextBoxColumn.HeaderText = "福利补贴";
            this.wealPayDataGridViewTextBoxColumn.Name = "wealPayDataGridViewTextBoxColumn";
            // 
            // rewardPayDataGridViewTextBoxColumn
            // 
            this.rewardPayDataGridViewTextBoxColumn.DataPropertyName = "RewardPay";
            this.rewardPayDataGridViewTextBoxColumn.HeaderText = "奖励工资";
            this.rewardPayDataGridViewTextBoxColumn.Name = "rewardPayDataGridViewTextBoxColumn";
            // 
            // unInsuranceDataGridViewTextBoxColumn
            // 
            this.unInsuranceDataGridViewTextBoxColumn.DataPropertyName = "UnInsurance";
            this.unInsuranceDataGridViewTextBoxColumn.HeaderText = "失业保险";
            this.unInsuranceDataGridViewTextBoxColumn.Name = "unInsuranceDataGridViewTextBoxColumn";
            // 
            // housingFundDataGridViewTextBoxColumn
            // 
            this.housingFundDataGridViewTextBoxColumn.DataPropertyName = "HousingFund";
            this.housingFundDataGridViewTextBoxColumn.HeaderText = "住房公积金";
            this.housingFundDataGridViewTextBoxColumn.Name = "housingFundDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "时间";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // finalPayDataGridViewTextBoxColumn
            // 
            this.finalPayDataGridViewTextBoxColumn.DataPropertyName = "FinalPay";
            this.finalPayDataGridViewTextBoxColumn.HeaderText = "实得工资";
            this.finalPayDataGridViewTextBoxColumn.Name = "finalPayDataGridViewTextBoxColumn";
            this.finalPayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payBindingSource
            // 
            this.payBindingSource.DataMember = "Pay";
            this.payBindingSource.DataSource = this.staffDataSetBindingSource;
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
            // payTableAdapter
            // 
            this.payTableAdapter.ClearBeforeFill = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(613, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 34);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "返回主界面";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(746, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "退出系统";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(842, 305);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource staffDataSetBindingSource;
        private staffDataSet staffDataSet;
        private System.Windows.Forms.BindingSource payBindingSource;
        private staffDataSetTableAdapters.PayTableAdapter payTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basePayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wealPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rewardPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unInsuranceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn housingFundDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
    }
}
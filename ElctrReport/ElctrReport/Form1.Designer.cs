namespace ElctrReport
{
    partial class Form1
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDegreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobStageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.graduateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeofGraduateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstjobDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingYearsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeOfworkingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNFOEMPDataSet = new ElctrReport.INFOEMPDataSet();
            this.table_1TableAdapter = new ElctrReport.INFOEMPDataSetTableAdapters.Table_1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNFOEMPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(516, 344);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // DGV
            // 
            this.DGV.AutoGenerateColumns = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.jobDataGridViewTextBoxColumn,
            this.jobDegreeDataGridViewTextBoxColumn,
            this.jobStageDataGridViewTextBoxColumn,
            this.graduateDataGridViewTextBoxColumn,
            this.placeofGraduateDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.firstjobDateDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.workingYearsDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.placeOfworkingDataGridViewTextBoxColumn,
            this.levelesDataGridViewTextBoxColumn});
            this.DGV.DataSource = this.table1BindingSource;
            this.DGV.Location = new System.Drawing.Point(12, 12);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(599, 326);
            this.DGV.TabIndex = 1;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "Full_Name";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Full_Name";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // jobDataGridViewTextBoxColumn
            // 
            this.jobDataGridViewTextBoxColumn.DataPropertyName = "Job";
            this.jobDataGridViewTextBoxColumn.HeaderText = "Job";
            this.jobDataGridViewTextBoxColumn.Name = "jobDataGridViewTextBoxColumn";
            // 
            // jobDegreeDataGridViewTextBoxColumn
            // 
            this.jobDegreeDataGridViewTextBoxColumn.DataPropertyName = "Job_Degree";
            this.jobDegreeDataGridViewTextBoxColumn.HeaderText = "Job_Degree";
            this.jobDegreeDataGridViewTextBoxColumn.Name = "jobDegreeDataGridViewTextBoxColumn";
            // 
            // jobStageDataGridViewTextBoxColumn
            // 
            this.jobStageDataGridViewTextBoxColumn.DataPropertyName = "Job_Stage";
            this.jobStageDataGridViewTextBoxColumn.HeaderText = "Job_Stage";
            this.jobStageDataGridViewTextBoxColumn.Name = "jobStageDataGridViewTextBoxColumn";
            // 
            // graduateDataGridViewTextBoxColumn
            // 
            this.graduateDataGridViewTextBoxColumn.DataPropertyName = "Graduate";
            this.graduateDataGridViewTextBoxColumn.HeaderText = "Graduate";
            this.graduateDataGridViewTextBoxColumn.Name = "graduateDataGridViewTextBoxColumn";
            // 
            // placeofGraduateDataGridViewTextBoxColumn
            // 
            this.placeofGraduateDataGridViewTextBoxColumn.DataPropertyName = "Place_of_Graduate";
            this.placeofGraduateDataGridViewTextBoxColumn.HeaderText = "Place_of_Graduate";
            this.placeofGraduateDataGridViewTextBoxColumn.Name = "placeofGraduateDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // firstjobDateDataGridViewTextBoxColumn
            // 
            this.firstjobDateDataGridViewTextBoxColumn.DataPropertyName = "First_job_Date";
            this.firstjobDateDataGridViewTextBoxColumn.HeaderText = "First_job_Date";
            this.firstjobDateDataGridViewTextBoxColumn.Name = "firstjobDateDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            // 
            // workingYearsDataGridViewTextBoxColumn
            // 
            this.workingYearsDataGridViewTextBoxColumn.DataPropertyName = "Working_Years";
            this.workingYearsDataGridViewTextBoxColumn.HeaderText = "Working_Years";
            this.workingYearsDataGridViewTextBoxColumn.Name = "workingYearsDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // placeOfworkingDataGridViewTextBoxColumn
            // 
            this.placeOfworkingDataGridViewTextBoxColumn.DataPropertyName = "Place_Of_working";
            this.placeOfworkingDataGridViewTextBoxColumn.HeaderText = "Place_Of_working";
            this.placeOfworkingDataGridViewTextBoxColumn.Name = "placeOfworkingDataGridViewTextBoxColumn";
            // 
            // levelesDataGridViewTextBoxColumn
            // 
            this.levelesDataGridViewTextBoxColumn.DataPropertyName = "leveles";
            this.levelesDataGridViewTextBoxColumn.HeaderText = "leveles";
            this.levelesDataGridViewTextBoxColumn.Name = "levelesDataGridViewTextBoxColumn";
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table_1";
            this.table1BindingSource.DataSource = this.iNFOEMPDataSet;
            // 
            // iNFOEMPDataSet
            // 
            this.iNFOEMPDataSet.DataSetName = "INFOEMPDataSet";
            this.iNFOEMPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_1TableAdapter
            // 
            this.table_1TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 377);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.btnPrint);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNFOEMPDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView DGV;
        private INFOEMPDataSet iNFOEMPDataSet;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private INFOEMPDataSetTableAdapters.Table_1TableAdapter table_1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDegreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobStageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn graduateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeofGraduateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstjobDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingYearsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeOfworkingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelesDataGridViewTextBoxColumn;
    }
}


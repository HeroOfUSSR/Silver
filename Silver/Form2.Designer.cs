namespace Silver
{
    partial class Form2
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silverDataSet = new Silver.silverDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.arhivBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameMonthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arhivTableAdapter = new Silver.silverDataSetTableAdapters.arhivTableAdapter();
            this.nameMonthTableAdapter = new Silver.silverDataSetTableAdapters.NameMonthTableAdapter();
            this.dataTable1TableAdapter = new Silver.silverDataSetTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silverDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arhivBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameMonthBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.silverDataSet;
            // 
            // silverDataSet
            // 
            this.silverDataSet.DataSetName = "silverDataSet";
            this.silverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "silverDataSet_DataTable1";
            reportDataSource1.Value = this.dataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Silver.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(728, 471);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer2.ForeColor = System.Drawing.SystemColors.ControlText;
            reportDataSource2.Name = "silverDataSet_DataTable1";
            reportDataSource2.Value = this.dataTable1BindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Silver.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(728, 471);
            this.reportViewer2.TabIndex = 1;
            // 
            // arhivBindingSource
            // 
            this.arhivBindingSource.DataMember = "arhiv";
            this.arhivBindingSource.DataSource = this.silverDataSet;
            // 
            // nameMonthBindingSource
            // 
            this.nameMonthBindingSource.DataMember = "NameMonth";
            this.nameMonthBindingSource.DataSource = this.silverDataSet;
            // 
            // arhivTableAdapter
            // 
            this.arhivTableAdapter.ClearBeforeFill = true;
            // 
            // nameMonthTableAdapter
            // 
            this.nameMonthTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 471);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silverDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arhivBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameMonthBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private silverDataSet silverDataSet;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource arhivBindingSource;
        //      private Silver.silverDataSetTableAdapters.SilverTableAdapter SilverTableAdapter;
        private Silver.silverDataSetTableAdapters.arhivTableAdapter arhivTableAdapter;
        private System.Windows.Forms.BindingSource nameMonthBindingSource;
        private Silver.silverDataSetTableAdapters.NameMonthTableAdapter nameMonthTableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private Silver.silverDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
    }
}
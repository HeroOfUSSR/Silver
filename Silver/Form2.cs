using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Silver
{
    public partial class Form2 : Form
    {
        public int MakRepNum;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'silverDataSet.DataTable1' table. You can move, or remove it, as needed.
            switch (MakRepNum)
            {
                case 1:
                    this.dataTable1TableAdapter.Fill(this.silverDataSet.DataTable1);
                    this.reportViewer1.Visible = true;
                    this.reportViewer2.Visible = false;
                    this.reportViewer1.RefreshReport();
                    break;
                case 2:
                    this.dataTable1TableAdapter.Fill(silverDataSet.DataTable1);
                    this.reportViewer2.Visible = true;
                    this.reportViewer1.Visible = false;
                    this.reportViewer2.RefreshReport();
                    break;
                default:
                    break;
            }
        }
    }
}
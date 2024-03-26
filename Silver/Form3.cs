using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Silver
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'silverDataSet.dat' table. You can move, or remove it, as needed.
            this.datTableAdapter.Fill(this.silverDataSet.dat);
            textBox1.Text = (string)this.silverDataSet.dat.Rows[0]["mnth"].ToString();
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            this.silverDataSet.dat.Rows[0]["mnth"] = textBox1.Text;
            this.datTableAdapter.Update(this.silverDataSet.dat);
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Silver
{
    public partial class Form4 : Form
    {
        public int lbl;
        public string nchek;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (lbl == 1)
            {
          //      label1.Text = "�� ������������� ������ �������� ����?";
            }
            else
            {
                label1.Text = "������� ����� ����";
                button1.Text = "�����";
                textBox1.Visible = true;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
        //    if (lbl == 0)
                nchek = textBox1.Text;
        }
    }
}
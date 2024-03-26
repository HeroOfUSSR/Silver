using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Silver
{
    public partial class Form1 : Form
    {
        int currow;
        DataGridViewPrinter MyDataGridViewPrinter;

        public Form1()
        {
            InitializeComponent();
        }

        private void ïðîñìîòðToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //           Form3 mnth = new Form3();
            //          if (mnth.ShowDialog() == DialogResult.OK)
            //         {
            ïîèñêToolStripMenuItem.Visible = true;
            dataGridView2.Visible = false;
            panel1.Visible = false;
            dataGridView1.Visible = true;
            this.arhivTableAdapter.Fill(this.silverDataSet.arhiv);
            //        dataGridView1.CurrentRow.Index = 0;
            //           }
        }

        private void ââîäToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            panel1.Visible = true;
            textBox2.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool NormY = false;
            Form3 dial = new Form3();
            dial.label1.Visible = false;
            dial.label2.Visible = false;
            dial.textBox1.Visible = false;
            dial.button1.Text = "Ñîõðàíèòü";
            if (dial.ShowDialog() == DialogResult.OK)
            {
                if (!equval())
                {
                    this.normTableAdapter1.FillBy(this.silverDataSet.norm);
                    for (int i = 0; i < silverDataSet.norm.Rows.Count; i++)
                    {
                        if ((string)this.silverDataSet.norm.Rows[i]["dni"].ToString() == textBox6.Text.Substring(0, 3))
                        {
                            if ((string)this.silverDataSet.norm.Rows[i]["dn"].ToString() == textBox6.Text.Substring(3))
                            {
                                if ((string)this.silverDataSet.norm.Rows[i]["vidSilv1"].ToString() == textBox9.Text)
                                {
                                    NormY = true;
                                }
                            }
                        }
                    }
                    if (NormY == true)
                    {
                        this.arhivTableAdapter.Insert(textBox2.Text, Convert.ToInt32(textBox4.Text), textBox5.Text, textBox6.Text.Substring(0, 3), textBox6.Text.Substring(3), textBox7.Text, textBox8.Text, textBox9.Text, textBox3.Text, textBox11.Text, textBox10.Text);
                        this.arhivTableAdapter.Fill(this.silverDataSet.arhiv);
                        //          textBox2.Text = "";
                        textBox3.Text = "";
                        //         textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                        textBox8.Text = "";
                        //        textBox9.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Íåò â íîðìàõ");
                    }
                }
                else
                {
                    MessageBox.Show("Òàêàÿ êàðòà åñòü â áàçå");
                }
            }
            textBox2.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'silverDataSet.arhiv' table. You can move, or remove it, as needed.

        }

        private void arhivBindingSource_CurrentChanged(object sender, EventArgs e)
        {
   /*         try
            {
                currow = dataGridView1.CurrentRow.Index;
            }
            catch
            {
            }
            if (!equval1())//povtor == false)
            {
                this.arhivTableAdapter.Update(this.silverDataSet.arhiv);
            }
            else
            {
                MessageBox.Show("Òàêàÿ êàðòà åñòü â áàçå");
                this.arhivTableAdapter.Fill(this.silverDataSet.arhiv);
                dataGridView1.Rows[0].Selected = false;
                dataGridView1.Rows[currow].Cells[1].Selected = true;
            }*/
        }

        private void êîððåêòèðîâêàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.arhivTableAdapter.FillBy(this.silverDataSet.arhiv);
            panel1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView1.Visible = true;
        }

        private bool equval()
        {
            int i;
            for (i = 0; i < silverDataSet.arhiv.Rows.Count; i++)
            {
                if ((string)this.silverDataSet.arhiv.Rows[i]["mnth"].ToString() == textBox2.Text)
                {
                 //   if ((string)this.silverDataSet.arhiv.Rows[i]["cex"].ToString() == textBox4.Text)
                    if (Convert.ToInt32(this.silverDataSet.arhiv.Rows[i]["cex"]) == Convert.ToInt32(textBox4.Text))//this.silverDataSet.arhiv.Rows[currow]["cex"]))
                    {
                        if ((string)this.silverDataSet.arhiv.Rows[i]["zakaz"].ToString() == textBox5.Text)
                        {
                            if ((string)this.silverDataSet.arhiv.Rows[i]["dni"].ToString() == textBox6.Text.Substring(0, 3))
                            {
                                if ((string)this.silverDataSet.arhiv.Rows[i]["dn"].ToString() == textBox6.Text.Substring(3))
                                {
                                    if ((string)this.silverDataSet.arhiv.Rows[i]["kol"].ToString() == textBox7.Text)
                                    {
                                        if ((string)this.silverDataSet.arhiv.Rows[i]["norm"].ToString() == textBox8.Text)
                                        {
                                            if ((string)this.silverDataSet.arhiv.Rows[i]["vid"].ToString() == textBox9.Text)
                                            {
                                                if ((string)this.silverDataSet.arhiv.Rows[i]["chek"].ToString() == textBox3.Text)
                                                {
                                                    if ((string)this.silverDataSet.arhiv.Rows[i]["pl"].ToString() == textBox11.Text)
                                                    {
                                                        return true;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }

        private void êîððÍîðìÑåððàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ïîèñêToolStripMenuItem.Visible = false;
            panel1.Visible = false;
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            this.normTableAdapter1.FillBy(this.silverDataSet.norm);
        }

        private void ïîÇÀÊÀÇÀÌToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form3 mnth = new Form3();
            if (mnth.ShowDialog() == DialogResult.OK)
            {
                Form2 ReportForm = new Form2();
                ReportForm.MakRepNum = 1;
                ReportForm.Show();
            }
        }

        private void ïîÖÅÕÓToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 mnth = new Form3();
            if (mnth.ShowDialog() == DialogResult.OK)
            {
                Form2 ReportForm = new Form2();
                ReportForm.MakRepNum = 2;
                ReportForm.Show();
            }
        }

        private bool equval1()
        {
            int i;
            for (i = 0; i < silverDataSet.arhiv.Rows.Count; i++)
            {
                if ((string)this.silverDataSet.arhiv.Rows[i]["mnth"].ToString() == (string)this.silverDataSet.arhiv.Rows[currow]["mnth"].ToString())
                {
  //                  if ((string)this.silverDataSet.arhiv.Rows[i]["cex"].ToString() == (string)this.silverDataSet.arhiv.Rows[currow]["cex"].ToString())
                    if (Convert.ToInt32(this.silverDataSet.arhiv.Rows[i]["cex"]) == Convert.ToInt32(this.silverDataSet.arhiv.Rows[currow]["cex"]))
                    {
                        if ((string)this.silverDataSet.arhiv.Rows[i]["zakaz"].ToString() == (string)this.silverDataSet.arhiv.Rows[currow]["zakaz"].ToString())
                        {
                            if ((string)this.silverDataSet.arhiv.Rows[i]["dni"].ToString() == (string)this.silverDataSet.arhiv.Rows[currow]["dni"].ToString())
                            {
                                if ((string)this.silverDataSet.arhiv.Rows[i]["dn"].ToString() == (string)this.silverDataSet.arhiv.Rows[currow]["dn"].ToString())
                                {
                                    if ((string)this.silverDataSet.arhiv.Rows[i]["kol"].ToString() == (string)this.silverDataSet.arhiv.Rows[currow]["kol"].ToString())
                                    {
                                        if ((string)this.silverDataSet.arhiv.Rows[i]["norm"].ToString() == (string)this.silverDataSet.arhiv.Rows[currow]["norm"].ToString())
                                        {
                                            if ((string)this.silverDataSet.arhiv.Rows[i]["vid"].ToString() == (string)this.silverDataSet.arhiv.Rows[currow]["vid"].ToString())
                                            {
                                                if ((string)this.silverDataSet.arhiv.Rows[i]["chek"].ToString() == (string)this.silverDataSet.arhiv.Rows[currow]["chek"].ToString())
                                                {
                                                    if ((string)this.silverDataSet.arhiv.Rows[i]["pl"].ToString() == textBox11.Text)
                                                    {
                                                        if (i != currow)
                                                            return true;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }

        private void Ìàêåò1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 mes = new Form4();
            mes.lbl = 1;
            if (mes.ShowDialog() == DialogResult.OK)
            {
                this.arhivTableAdapter.DeleteQuery();
                this.arhivTableAdapter.Fill(this.silverDataSet.arhiv);
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                currow = dataGridView1.CurrentRow.Index;
            }
            catch
            {
            }
            try
            {
                if (!equval1())
                {
                    this.arhivTableAdapter.Update(this.silverDataSet.arhiv);
                }
                else
                {
                    MessageBox.Show("Òàêàÿ êàðòà åñòü â áàçå");
                    this.arhivTableAdapter.Fill(this.silverDataSet.arhiv);
                    dataGridView1.Rows[0].Selected = false;
                    dataGridView1.Rows[currow].Cells[1].Selected = true;
                }
            }
            catch
            {
            }
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.arhivTableAdapter.Update(this.silverDataSet.arhiv);
            this.arhivTableAdapter.Fill(this.silverDataSet.arhiv);

        }

        private void ââîäToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            this.arhivTableAdapter.Fill(this.silverDataSet.arhiv);
            panel1.Visible = true;
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox11.Text = "";
            textBox2.Focus();

        }

        private void ïðåäâàðèòåëüíûéÏðîñìîòðToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyPrintDocument.DocumentName = "Îò÷åò";
            MyPrintDocument.PrinterSettings = MyPrintDialog.PrinterSettings;
            MyPrintDocument.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            MyPrintDocument.DefaultPageSettings.Margins = new Margins(30, 30, 30, 30);
            MyDataGridViewPrinter = new DataGridViewPrinter(dataGridView1, MyPrintDocument, true, false,
                MyPrintDocument.DocumentName, new Font("Tahoma", 8, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true, true);//Selection);
            MyPrintPreviewDialog.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            bool more = MyDataGridViewPrinter.DrawDataGridView(e.Graphics);
            if (more == true)
                e.HasMorePages = true;
        }

        private void ïå÷àòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool print = SetupThePrinting();
            if (print) MessageBox.Show("Äîêóìåíò óñïåøíî íàïå÷àòàí!");
        }
        private bool SetupThePrinting()
        {
            if (MyPrintDialog.ShowDialog() != DialogResult.OK)
                return false;

            MyPrintDocument.DocumentName = "Îò÷åò";
            MyPrintDocument.PrinterSettings = MyPrintDialog.PrinterSettings;
            MyPrintDocument.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            MyPrintDocument.DefaultPageSettings.Margins = new Margins(30, 30, 30, 30);
            bool Selection = false;
            if (MyPrintDocument.PrinterSettings.PrintRange == System.Drawing.Printing.PrintRange.Selection)
                Selection = true;

            MyDataGridViewPrinter = new DataGridViewPrinter(dataGridView1, MyPrintDocument, true, false,
                MyPrintDocument.DocumentName, new Font("Tahoma", 8, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true, Selection);
            MyPrintDocument.Print();
            return true;
        }

        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.normTableAdapter1.Update(this.silverDataSet.norm);
        }

        private void dataGridView2_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.normTableAdapter1.Update(this.silverDataSet.norm);
        }

        private void ïîèñêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 mes = new Form4();
            mes.lbl=0;
            if (mes.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < silverDataSet.arhiv.Count; i++)
                {
                    if (mes.nchek == silverDataSet.arhiv.Rows[i]["chek"].ToString())
                    {
                        dataGridView1.CurrentRow.Selected = false;
                        dataGridView1.Rows[i].Selected = true;
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                        return;
                    }
                }
            }

        }
    }
}
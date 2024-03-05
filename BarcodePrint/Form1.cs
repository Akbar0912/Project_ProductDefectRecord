using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BarcodePrint
{
    public partial class Form1 : Form
    {
        public string InspectorName;
        public Form1()
        {
            InitializeComponent();

            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBoxSerial.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
            e.Graphics.DrawString(textBoxModel.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
            e.Graphics.DrawString(textBoxDefect.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
            e.Graphics.DrawString(textBoxInspec.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
        }

        private void print_Click(object sender, EventArgs e)
        {
           

            Form2 frm2 = new Form2();
            frm2.Serial = textBoxSerial.Text;
            frm2.Model = textBoxModel.Text;
            frm2.Defect = textBoxDefect.Text;
            frm2.Inspec = textBoxInspec.Text;
            frm2.ShowDialog();
        }

        public Form1 (string inspectorname) : this () 
        {
            this.InspectorName = inspectorname;
            textBoxInspec.Text = InspectorName;
        }

        private void textBoxInpec_TextChanged(object sender, EventArgs e)
        {
            textBoxInspec.ForeColor = System.Drawing.SystemColors.WindowText;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDefect_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true;

        }

        private void textBoxSerial_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdButton12_Click(object sender, EventArgs e)
        {

        }

        private void rdButton17_Click(object sender, EventArgs e)
        {

        }
    }
}

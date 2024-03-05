using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodePrint
{
    public partial class Form2 : Form
    {
        public string Date, Serial, Model, Defect, Inspec;
        public Form2()
        {
            InitializeComponent();
            Date = DateTime.Now.ToString("F");
        }

        private void Print(Panel pn1 )
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrint = pn1;
            getprintarea(pn1);
            /*printPreviewDialog1.Document = printDocument1;*/
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.DefaultPageSettings.Landscape = true;
            /* printPreviewDialog1.ShowDialog();*/
            printDocument1.Print();
        }

        private Bitmap memoryimg;

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg,(pagearea.Width / 2) - (pagearea.Height / 2), this.panelPrint.Location.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Print(this.panelPrint);
            button1.Visible = true;
        }

        private void textBoxSerial_TextChanged(object sender, EventArgs e)
        {

        }

        private void getprintarea(Panel pn1 )
        {
            button1.Visible = false;
            memoryimg = new Bitmap(pn1.Width, pn1.Height);
            pn1.DrawToBitmap(memoryimg, new Rectangle(0,0, pn1.Width, pn1.Height));
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "Print");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            date.Text = Date;
            textBoxSerial.Text = Serial;
            textBoxModel.Text = Model;
            textBoxDefect.Text = Defect;
            textBoxInspec.Text = Inspec;
        }
    }
}

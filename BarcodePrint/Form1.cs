﻿using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using BarcodePrint.Component;
using System.Configuration;
using System.IO.Ports;

namespace BarcodePrint
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LSBUDBConnection"].ConnectionString);

        private RdButton[] rdButtons; // Declare an array of RdButton
        public string InspectorName;

        public Form1()
        {
            InitializeComponent();  
            CreateButtons();

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

        public Form1(string inspectorname) : this()
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

        private void CreateButtons()
        {
            try
            {
                using (conn)
                {
                    conn.Open();

                    // Fetch Defect Names from the database
                    string query = "SELECT id, PartId, DefectName FROM Defect_Names";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Assuming you have a column named "DefectName" in the result
                                string defectName = reader["DefectName"].ToString();

                                // Create a new instance of RdButton (replace with your actual class)
                                RdButton rdButton = new RdButton();

                                // Set button properties
                                rdButton.Height = 56;
                                rdButton.Width = 219;
                                rdButton.BackColor = Color.White;
                                rdButton.ForeColor = Color.Black;
                                rdButton.BorderColor = Color.Black;
                                rdButton.BorderSize = 1;
                                rdButton.Text = defectName;
                                rdButton.Name = $"RdButton_{defectName}";
                                rdButton.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

                                // To center the text both horizontally and vertically within the button
                                rdButton.TextAlign = ContentAlignment.MiddleCenter;

                                // If you're facing issues with text not being centered properly, especially with special characters or different font styles,
                                // you might also consider setting the UseCompatibleTextRendering property to true for the button. This can help with the rendering of text.
                                rdButton.UseCompatibleTextRendering = true;

                                // Add a Button Click Event handler
                                rdButton.Click += new EventHandler(Button_Click);

                                // Add the button to the FlowLayoutPanel
                                flowLayoutPanel1.Controls.Add(rdButton); // assuming flowLayoutPanel1 is the name of your FlowLayoutPanel
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            // Handle button click event
            //RdButton clickedButton = (RdButton)sender;
            //MessageBox.Show($"Dynamic button {clickedButton.Name} is clicked");

            Form formBackground = new Form();
            try
            {
                using (popUp uu = new popUp())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = 70d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();
                }
            }
            catch (Exception)
            { }
        }

        private void rdButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdButton4_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Serial = textBoxSerial.Text;
            frm2.Model = textBoxModel.Text;
            frm2.Defect = textBoxDefect.Text;
            frm2.Inspec = textBoxInspec.Text;
            frm2.ShowDialog();

            /*PrintDocument pd = new PrintDocument();

            pd.PrintPage += printDocument1_PrintPage;

            pd.PrintPage += (s, ev) => PrintInformation(ev);

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = pd;
            printPreviewDialog.ShowDialog();*/

            /*PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }*/
        }

        public void textBoxSerial_KeyPress(object sender, KeyPressEventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LSBUDBConnection"].ConnectionString);
            if (e.KeyChar == 13)
            {
                try
                {
                    conn.Open();

                    string query = "SELECT @ModelNumber FROM global_model_code gmc JOIN defect_results dr ON gmc.ModelNumber = dr.ModelNumber WHERE dr.ModelNumber = '123';";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ModelNumber", textBoxSerial.Text);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string model;

                                model = reader["ModelNumber"].ToString();
                               /* code = reader["code"].ToString();*/

                                textBoxModel.Text = model;
                            }
                            else
                            {
                                MessageBox.Show("Not Found");
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public void BaseAButtonClick(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LSBUDBConnection"].ConnectionString);
            try
            {
                conn.Open();

                string query = "SELECT gmc.ModelNumber FROM Global_Model_Code AS gmc JOIN Defect_Result AS dr ON gmc.ModelNumber= dr.SerialNumber WHERE dr.SerialNumber = '123'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ModelNumber", textBoxSerial.Text);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string model;

                            model = reader["ModelNumber"].ToString();
                            /* code = reader["code"].ToString();*/

                            textBoxModel.Text = model;
                        }
                        else
                        {
                            MessageBox.Show("Not Found");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void rdButton3_Click(object sender, EventArgs e)
        {
            textBoxModel.Clear();
            textBoxSerial.Clear();
            textBoxDefect.Clear();
        }

        private void rdButton2_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();
        }

        private void textBoxSerial_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void rdButton14_Click(object sender, EventArgs e)
        {

        }
    }
}

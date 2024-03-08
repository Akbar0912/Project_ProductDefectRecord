using BarcodePrint.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodePrint
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            CreateDynamicButtons();
        }

        private void CreateDynamicButtons()
        {
            // Define the number of rows and columns for the button grid
            int rows = 3;
            int columns = 4;

            // Loop through rows and columns to create buttons
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    // Create a new instance of RdButton (replace with your actual class)
                    RdButton rdButton = new RdButton();

                    // Set button properties
                    rdButton.Height = 40;
                    rdButton.Width = 100;
                    rdButton.BackColor = Color.Red;
                    rdButton.ForeColor = Color.Blue;
                    rdButton.Text = $"Button {row + 1}-{col + 1}";
                    rdButton.Name = $"RdButton_{row}_{col}";
                    rdButton.Font = new Font("Georgia", 12);

                    // Add a Button Click Event handler
                    rdButton.Click += new EventHandler(Button_Click);

                    // Add the button to the FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(rdButton); // assuming flowLayoutPanel1 is the name of your FlowLayoutPanel
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            // Handle button click event
            RdButton clickedButton = (RdButton)sender;
            MessageBox.Show($"Dynamic button {clickedButton.Name} is clicked");
        }
    }
}

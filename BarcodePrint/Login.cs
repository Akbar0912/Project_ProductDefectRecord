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
using System.Configuration;

namespace BarcodePrint
{
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LSBUDBConnection"].ConnectionString);
        public Login()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                conn.Open();
                string query = "SELECT COUNT (*) FROM Users WHERE Nik = @Nik AND Password = @Password;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nik", Number_Id.Text);
                cmd.Parameters.AddWithValue("@Password", password.Text);
                int count = (int)cmd.ExecuteScalar();


                if (count > 0)
                {
                    //mengirim nama ke form berbeda
                    string getInspector = "SELECT Name FROM Users WHERE Nik = @Nik";
                    SqlCommand getCmd = new SqlCommand(getInspector, conn);
                    getCmd.Parameters.AddWithValue("@Nik", Number_Id.Text);
                    string inspectorName = getCmd.ExecuteScalar().ToString();
                    conn.Close();

                    this.Hide();
                    Form1 Home = new Form1(inspectorName);
                    Home.ShowDialog();
                    /*MessageBox.Show("Login Success", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
                } else
                {
                    MessageBox.Show("Your Id not found, please enter correctly.");
                    conn.Close();
                }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;


namespace NIBM_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        MySqlConnection con = Connection.connectionDB();

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            

            string username = txtUName.Text;
            string password = txtPassword.Text;
            try
            {
                if (username == "" && password == "")
                {
                    MessageBox.Show("Username & Password Is Empty!!!", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    string query_select = "SELECT * FROM login WHERE username = '" + username + "' AND Password = '" + password + "' ";
                    MySqlCommand cmnd = new MySqlCommand(query_select, con);
                    MySqlDataReader row = cmnd.ExecuteReader();

                    if (row.HasRows)
                    {
                        Home home = new Home();
                        this.Hide();
                        home.Show();
                        ;

                    }
                    else
                    {
                        MessageBox.Show("Invalid login credentials, Please check Username & Password and try again!", "Invalid Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PasswordTb_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup Sign = new Signup();
            this.Hide();
            Sign.Show();
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnMClose_Click(object sender, EventArgs e)
        {

        }

        private void btnL_FormClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtUName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

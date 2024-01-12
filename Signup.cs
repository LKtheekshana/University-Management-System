using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIBM_Management_System
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        MySqlConnection con = Connection.connectionDB();
        private void bunifuTextBox1_Enter(object sender, EventArgs e)
        {
            bunifuColorTransition1.Start();
            txtPassword.UseSystemPasswordChar = true;
        }

        

        private void Cnfrm_SignupPass_TextChanged(object sender, EventArgs e)
        {
            txtConfirmPass.UseSystemPasswordChar = true;
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text == txtConfirmPass.Text)
                {
                    if (txtUName.Text == "" || txtPassword.Text == "" || txtConfirmPass.Text == "")
                    {
                        MessageBox.Show("Missing Information...", "NIBM Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MySqlConnection con = Connection.connectionDB();
                        string username = txtUName.Text;
                        string password = txtPassword.Text;
                        try
                        {   
                            con.Open();
                            string query_insert = "INSERT INTO login VALUES('" + username + "','" + password + "')";
                            MySqlCommand cmnd = new MySqlCommand(query_insert, con);
                            cmnd.ExecuteNonQuery();
                            con.Close();
                            Console.WriteLine("Record added successfully!", "Registered Employee!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Login login = new Login();
                            this.Hide();
                            login.Show();
                        }
                        catch (Exception Ex)
                        {
                            MessageBox.Show(Ex.Message, "NIBM Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Password Do Not Matched...!!", "NIBM Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NIBM Management System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnS_FormClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

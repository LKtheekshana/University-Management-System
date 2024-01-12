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
using MySql.Data.MySqlClient;

namespace NIBM_Management_System
{
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
            Display();
        }
        MySqlConnection con = Connection.connectionDB();

        private void Display() 
        {

            try
            {
                DataTable data = new DataTable();
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("select * from department", con);
                adapter.Fill(data);
                DeptDGV.DataSource = data;
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void Reset() 
        {
            txtDepId.Text = "";
            txtDepartment.Text = "";
            txtDepFees.Text = "";
            txtDepIntake.Text = "";
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (txtDepartment.Text == "" || txtDepIntake.Text == "" || txtDepFees.Text == "")
            {
                MessageBox.Show("Missing Information...", "NIBM Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("Insert into department(ID,DeptName,Intake,Fees)values(@DID,@DN,@DI,@DF)", con);
                    cmd.Parameters.AddWithValue("@DID", txtDepId.Text);
                    cmd.Parameters.AddWithValue("@DN", txtDepartment.Text);
                    cmd.Parameters.AddWithValue("@DI", txtDepIntake.Text);
                    cmd.Parameters.AddWithValue("@DF", txtDepFees.Text);
                    cmd.ExecuteNonQuery();
                    DialogBox Db = new DialogBox("Department Added");
                    Db.ShowDialog();
                    con.Close();
                    Display();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                    Reset();
            }
        }
        int Key = 0;
        private void DeptDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MySqlConnection con = Connection.connectionDB();
                string query = "SELECT * from department";
                MySqlCommand cmd = new MySqlCommand(@query, con);
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ada.Fill(ds);
                DeptDGV.DataSource = ds;
                if (txtDepartment.Text == "")
                {
                    Key = 0;
                    txtDepId.Text = "";
                    txtDepartment.Text = "";
                    txtDepFees.Text = "";
                    txtDepIntake.Text = "";
                }
                else
                {
                    Key = int.Parse(DeptDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (txtDepId.Text == "" || txtDepartment.Text == "" || txtDepIntake.Text == "" || txtDepFees.Text == "")
            {
                MessageBox.Show("Missing Information...", "NIBM Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("Update department Set ID=@DID ,DeptName=@DN ,Intake=@DI ,Fees=@DF where ID=@DID", con);
                    cmd.Parameters.AddWithValue("@DID", txtDepId.Text);
                    cmd.Parameters.AddWithValue("@DN", txtDepartment.Text);
                    cmd.Parameters.AddWithValue("@DI", txtDepIntake.Text);
                    cmd.Parameters.AddWithValue("@DF", txtDepFees.Text);

                    cmd.ExecuteNonQuery();
                    DialogBox Db = new DialogBox("Department Updated");
                    Db.ShowDialog();
                    con.Close();
                    Display();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                Reset();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Key = Convert.ToInt32(txtDepId.Text);
            if (Key == 0)
            {
                MessageBox.Show("Select The Department...!!", "NIBM Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("Delete from department where ID=@DID", con);
                    cmd.Parameters.AddWithValue("@DID", Key);
                    cmd.ExecuteNonQuery();
                    DialogBox Db = new DialogBox("Department Deleted");
                    Db.ShowDialog();
                    con.Close();
                    Display();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                Reset();
            }
        }

        private void Student_Lbl_Click(object sender, EventArgs e)
        {
            Student Std = new Student();
            this.Hide();
            Std.Show();
        }

        private void Fac_Lbl_Click(object sender, EventArgs e)
        {
            Lecturer Fac = new Lecturer();
            this.Hide();
            Fac.Show();
        }

        private void Course_Lbl_Click(object sender, EventArgs e)
        {
            Courses Course = new Courses();
            this.Hide();
            Course.Show();
        }

        private void Home_Lbl_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void FeeLbl_Click(object sender, EventArgs e)
        {
            Fees Fee = new Fees();
            this.Hide();
            Fee.Show();
        }

        private void Department_Load(object sender, EventArgs e)
        {

        }

        private void Dept_Lbl_Click(object sender, EventArgs e)
        {

        }

        private void txtDepId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnD_FormMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnD_FormClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }
    }
}

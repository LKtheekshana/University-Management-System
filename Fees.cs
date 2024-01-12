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
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
            Display();
            GetStudentId();
        }
        MySqlConnection con = Connection.connectionDB();

        private void GetStudentId()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("Select ID from student", con);
                MySqlDataReader Reader = cmd.ExecuteReader();
                DataTable data = new DataTable();
                data.Columns.Add("ID", typeof(int));
                data.Load(Reader);
                con.Close();
                cmbFStdId.ValueMember = "ID";
                cmbFStdId.DataSource = data;
               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "NIBM Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void GetStudentInfo()
        {
            try
            {
                con.Open();

                string query = "SELECT * FROM student WHERE ID = @SID";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@SID", cmbFStdId.SelectedValue);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable data = new DataTable();
                        adapter.Fill(data);

                        foreach (DataRow dataRow in data.Rows)
                        {
                            txtFStdName.Text = dataRow["Name"].ToString();
                            txtFDept.Text = dataRow["Department"].ToString();
                        }
                    }
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "NIBM Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Display()
        {

            try
            {
                
                DataTable data = new DataTable();
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter("select * from fees", con);
                adapter.Fill(data);
                DgvFees.DataSource = data;
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void Reset()
        {
            txtFStdName.Text = "";
            txtAmount.Text = "";
            txtFDept.Text = "";
            cmbFStdId.SelectedIndex = -1;
            cmbSemester.SelectedIndex = -1;
        }
        
       


        private void cmbFStdId_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetStudentInfo();
        }

        int Key = 0;


        private void PayBtn_Click(object sender, EventArgs e)
        {
            if (txtFStdName.Text == "" || cmbFStdId.SelectedIndex == -1 || txtFDept.Text == "" || txtAmount.Text == "" || cmbSemester.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information...", "NIBM Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("Insert into fees(StId,StName,Amount,StDepartment,Semester)values(@SId,@SN,@Amount,@SDep,@Sem)", con);
                    cmd.Parameters.AddWithValue("@SId", cmbFStdId.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@SN", txtFStdName.Text);
                    cmd.Parameters.AddWithValue("@Amount", txtAmount.Text);
                    cmd.Parameters.AddWithValue("@SDep", txtFDept.Text);
                    cmd.Parameters.AddWithValue("@Sem", cmbSemester.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    DialogBox Db = new DialogBox("Fee Paid");
                    Db.ShowDialog();
                    con.Close();
                    Display();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "NIBM Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            Reset();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Key = Convert.ToInt32(cmbFStdId.SelectedValue);

            if (Key == 0)
            {
                MessageBox.Show("Select a Student...!!", "NIBM Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("Delete from fees where StId=@FID", con);
                    cmd.Parameters.AddWithValue("@FID", Key);
                    cmd.ExecuteNonQuery();
                    DialogBox Db = new DialogBox("Data Deleted");
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

        private void FeeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MySqlConnection con = Connection.connectionDB();
                string query = "SELECT * from lecturer";
                MySqlCommand cmd = new MySqlCommand(@query, con);
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ada.Fill(ds);
                DgvFees.DataSource = ds;
                if (txtFStdName.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = int.Parse(DgvFees.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NIBM Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Home_Lbl_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();

        }

        private void Student_Lbl_Click(object sender, EventArgs e)
        {
            Student Std = new Student();
            this.Hide();
            Std.Show();
        }

        private void Dept_Lbl_Click(object sender, EventArgs e)
        {
            Department Dept = new Department();
            this.Hide();
            Dept.Show();

        }

        private void Fac_Lbl_Click(object sender, EventArgs e)
        {
            Lecturer Fac = new Lecturer();
            this.Hide();
            Fac.Show();
        }

        private void Course_Lbl_Click(object sender, EventArgs e)
        {
            Courses courses = new Courses();
            this.Hide();
            courses.Show();
        }

        private void StIdCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtFStdName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fees_Load(object sender, EventArgs e)
        {

        }

        private void btnF_FormMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnF_FormClose_Click(object sender, EventArgs e)
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

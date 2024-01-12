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
    public partial class Lecturer : Form
    {
        public Lecturer()
        {
            InitializeComponent();
            GetDeptId();
            Display();
        }
        MySqlConnection con = Connection.connectionDB();
        private void GetDeptId()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("Select ID from department", con);
                MySqlDataReader Reader = cmd.ExecuteReader();
                DataTable data = new DataTable();
                data.Columns.Add("ID", typeof(int));
                data.Load(Reader);
                cmbLDepId.ValueMember = "ID";
                cmbLDepId.DataSource = data;
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "NIBM Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void GetDeptName()
        {
            try {
                con.Open();

                string query = "SELECT * FROM department WHERE ID = @DID";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@DID", cmbLDepId.SelectedValue);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable data = new DataTable();
                        adapter.Fill(data);

                        foreach (DataRow dataRow in data.Rows)
                        {
                            txtLDeptName.Text = dataRow["DeptName"].ToString();
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
                MySqlDataAdapter adapter = new MySqlDataAdapter("Select * from lecturer", con);
                adapter.Fill(data);
                DgvLec.DataSource = data;
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "NIBM Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Reset()
        {
            txtLId.Text = "";
            txtLName.Text = "";
            txtLExp.Text = "";
            txtLAddr.Text = "";
            txtLDeptName.Text = "";
            txtLSalary.Text = "";
            cmbLQual.SelectedIndex = -1;
            cmbLGender.SelectedIndex = -1;
            cmbLDepId.SelectedIndex = -1;
        }

        private void F_DeptIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetDeptName();
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

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (txtLName.Text == "" || txtLExp.Text == "" || txtLAddr.Text == "" || cmbLQual.SelectedIndex == -1 || txtLDeptName.Text == "" || cmbLGender.SelectedIndex == -1 || cmbLDepId.SelectedIndex == -1 || txtLSalary.Text == "")
            {
                MessageBox.Show("Missing Information...", "NIBM Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("Insert into lecturer(ID,Name,DOB,Gender,Address,Qualification,Experience,DepId,Department,Salary)values(@LId,@LN,@LDOB,@LGen,@LAdd,@LQ,@LE,@LDepId,@LDept,@LSal)", con);
                    cmd.Parameters.AddWithValue("@LID", txtLId.Text);
                    cmd.Parameters.AddWithValue("@LN", txtLName.Text);
                    cmd.Parameters.AddWithValue("@LDOB", dt_DOB.Value.Date);
                    cmd.Parameters.AddWithValue("@LGen", cmbLGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@LAdd", txtLAddr.Text);
                    cmd.Parameters.AddWithValue("@LQ", cmbLQual.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@LE", txtLExp.Text);
                    cmd.Parameters.AddWithValue("@LDepId", cmbLDepId.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@LDept", txtLDeptName.Text);
                    cmd.Parameters.AddWithValue("@LSal", txtLSalary.Text);
                    cmd.ExecuteNonQuery();
                    DialogBox Db = new DialogBox("Lecturer Added");
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
        private void Fac_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MySqlConnection con = Connection.connectionDB();
                string query = "SELECT * from lecturer";
                MySqlCommand cmd = new MySqlCommand(@query, con);
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ada.Fill(ds);
                DgvLec.DataSource = ds;
                if (txtLName.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = int.Parse(DgvLec.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (txtLId.Text == "" || txtLName.Text == "" || txtLExp.Text == "" || txtLAddr.Text == "" || cmbLQual.SelectedIndex == -1 || txtLDeptName.Text == "" || cmbLGender.SelectedIndex == -1 || cmbLDepId.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information...", "NIBM Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("Update lecturer Set ID=@LId,Name=@LN,DOB=@LDOB,Gender=@LGen,Address=@LAdd,Qualification=@LQ,Experience=@LE,DepId=@LDepId,Department=@LDept,Salary=@LSal where ID=@LId", con);
                    cmd.Parameters.AddWithValue("@LId", txtLId.Text);
                    cmd.Parameters.AddWithValue("@LN", txtLName.Text);
                    cmd.Parameters.AddWithValue("@LDOB", dt_DOB.Value.Date);
                    cmd.Parameters.AddWithValue("@LGen", cmbLGender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@LAdd", txtLAddr.Text);
                    cmd.Parameters.AddWithValue("@LQ", cmbLQual.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@LE", txtLExp.Text);
                    cmd.Parameters.AddWithValue("@LDepId", cmbLDepId.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@LDept", txtLDeptName.Text);
                    cmd.Parameters.AddWithValue("@LSal", txtLSalary.Text); ;
                    cmd.ExecuteNonQuery();
                    DialogBox Db = new DialogBox("Lecturer Updated");
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
            Key = Convert.ToInt32(txtLId.Text);
            if (Key == 0)
            {
                MessageBox.Show("Select The Lecturer...!!", "NIBM Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("Delete from lecturer where ID=@LID", con);
                    cmd.Parameters.AddWithValue("@LID", Key);
                    cmd.ExecuteNonQuery();
                    DialogBox Db = new DialogBox("Lecturer Deleted");
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

        private void Home_Lbl_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void Course_Lbl_Click(object sender, EventArgs e)
        {
            Courses Course = new Courses();
            this.Hide();
            Course.Show();
        }

        private void FeeLbl_Click(object sender, EventArgs e)
        {
            Fees Fee = new Fees();
            this.Hide();
            Fee.Show();
        }

        private void ExperienceTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lblLecturer_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Lecturer_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnL_FormClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnL_FormMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

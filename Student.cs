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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
            Display();
            GetDeptId();
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
                cmbSDepId.ValueMember = "ID";
                cmbSDepId.DataSource = data;
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "NIBM Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }   
        }
        private void GetDeptName() 
        {
            try
            {
                con.Open();

                string query = "SELECT * FROM department WHERE ID = @DID";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@DID", cmbSDepId.SelectedValue);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable data = new DataTable();
                        adapter.Fill(data);

                        foreach (DataRow dataRow in data.Rows)
                        {
                            txtSDept.Text = dataRow["DeptName"].ToString();
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
                MySqlDataAdapter adapter = new MySqlDataAdapter("select * from student", con);
                adapter.Fill(data);
                StDGV.DataSource = data;
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "NIBM Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Reset()
        {

            txtStdId.Text = "";
            txtStName.Text = "";
            txtPn.Text = "";
            txtStAddress.Text = "";
            txtSDept.Text = "";
            StGenderCb.SelectedIndex = -1;
            cmbSDepId.SelectedIndex = -1;
            cmbStSem.SelectedIndex = -1;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void St_DeptIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetDeptName();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (txtStName.Text == "" || txtPn.Text == "" || txtStAddress.Text == "" || cmbSDepId.SelectedIndex == -1 || txtSDept.Text == "" || cmbStSem.SelectedIndex == -1 || StGenderCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information...", "NIBM Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("Insert into student(ID, Name, DOB, Gender, Address, DepId, Department, Phone, Semester) values(@SID,@SN,@SDOB,@SGen,@SAdd,@SDeptId,@SDept,@SPh,@Sem)", con);
                    cmd.Parameters.AddWithValue("@SID", txtStdId.Text);
                    cmd.Parameters.AddWithValue("@SN", txtStName.Text);
                    cmd.Parameters.AddWithValue("@SDOB", StDOBdt.Value.Date);
                    cmd.Parameters.AddWithValue("@SGen", StGenderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SAdd", txtStAddress.Text);
                    cmd.Parameters.AddWithValue("@SDeptId", cmbSDepId.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@SDept", txtSDept.Text);
                    cmd.Parameters.AddWithValue("@SPh", txtPn.Text);
                    cmd.Parameters.AddWithValue("@Sem", cmbStSem.SelectedItem.ToString()); ;
                    cmd.ExecuteNonQuery();
                    DialogBox Db = new DialogBox("Student Added");
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
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Key = Convert.ToInt32(txtStdId.Text);
            if (Key == 0)
            {
                MessageBox.Show("Select The Student...!!", "NIBM Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("Delete from student where ID=@SID", con);
                    cmd.Parameters.AddWithValue("@SID", Key);
                    cmd.ExecuteNonQuery();
                    DialogBox Db = new DialogBox("Student Deleted");
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

        private void StDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string query = "SELECT * from employees";
                MySqlCommand cmd = new MySqlCommand(@query, con);
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                ada.Fill(ds);
                if (txtStName.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = int.Parse(StDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (txtStdId.Text == "" || txtStName.Text == "" || txtPn.Text == "" || txtStAddress.Text == "" || cmbSDepId.SelectedIndex == -1 || txtSDept.Text == "" || cmbStSem.SelectedIndex == -1 || StGenderCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information...", "NIBM Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("Update student Set ID=@SID,Name=@SN,DOB=@SDOB,Gender=@SGen,Address=@SAdd,DepId=@SDeptId,Department=@SDept,Phone=@SPh,Semester=@Sem where ID=@SID", con);
                    cmd.Parameters.AddWithValue("@SID", txtStdId.Text);
                    cmd.Parameters.AddWithValue("@SN", txtStName.Text);
                    cmd.Parameters.AddWithValue("@SDOB", StDOBdt.Value.Date);
                    cmd.Parameters.AddWithValue("@SGen", StGenderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SAdd", txtStAddress.Text);
                    cmd.Parameters.AddWithValue("@SDeptId", cmbSDepId.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@SDept", txtSDept.Text);
                    cmd.Parameters.AddWithValue("@SPh", txtPn.Text);
                    cmd.Parameters.AddWithValue("@Sem", cmbStSem.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    DialogBox Db = new DialogBox("Student Updated");
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

        private void Home_Lbl_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void lblStudent_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }
    }
}

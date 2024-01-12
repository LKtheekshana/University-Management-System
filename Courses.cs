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
    public partial class Courses : Form
    {
        public Courses()
        {
            InitializeComponent();
            GetDeptId();
            GetFacId();
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
                cmbCDepId.ValueMember = "ID";
                cmbCDepId.DataSource = data;
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "NIBM Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void GetFacId()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("Select ID from lecturer", con);
                MySqlDataReader Reader = cmd.ExecuteReader();
                DataTable data = new DataTable();
                data.Columns.Add("ID", typeof(int));
                data.Load(Reader);
                cmbCLecId.ValueMember = "ID";
                cmbCLecId.DataSource = data;
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
                    cmd.Parameters.AddWithValue("@DID", cmbCDepId.SelectedValue);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable data = new DataTable();
                        adapter.Fill(data);

                        foreach (DataRow dataRow in data.Rows)
                        {
                            txtCDepName.Text = dataRow["DeptName"].ToString();
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
        private void GetFacName()
        {
            try
            {
                con.Open();

                string query = "SELECT * FROM lecturer WHERE ID = @LID";
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@LID", cmbCLecId.SelectedValue);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable data = new DataTable();
                        adapter.Fill(data);

                        foreach (DataRow dataRow in data.Rows)
                        {
                            txtCLecName.Text = dataRow["Name"].ToString();
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
                MySqlDataAdapter adapter = new MySqlDataAdapter("select * from courses", con);
                adapter.Fill(data);
                DgvCourse.DataSource = data;
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "NIBM Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Reset()
        {
            txtCId.Text = "";
            txtCName.Text = "";
            txtCreditHrs.Text = "";
            cmbCDepId.SelectedIndex = -1;
            txtCDepName.Text = "";
            cmbCLecId.SelectedIndex = -1;
            txtCLecName.Text = "";
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (txtCName.Text == "" || txtCreditHrs.Text == "" || cmbCDepId.SelectedIndex == -1 || txtCDepName.Text == "" || cmbCLecId.SelectedIndex == -1 || txtCLecName.Text == "")
            {
                MessageBox.Show("Missing Information...", "NIBM Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("Insert into courses(ID,Course,CreditHrs,DeptId,DeptName,LecId,LecName)values(@CId,@CN,@CH,@DepId,@DepName,@LecId,@LecName)", con);
                    cmd.Parameters.AddWithValue("@CID", txtCId.Text);
                    cmd.Parameters.AddWithValue("@CN", txtCName.Text);
                    cmd.Parameters.AddWithValue("@CH", txtCreditHrs.Text);
                    cmd.Parameters.AddWithValue("@DepId", cmbCDepId.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@DepName", txtCDepName.Text);
                    cmd.Parameters.AddWithValue("@LecId", cmbCLecId.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@LecName", txtCLecName.Text);
                    cmd.ExecuteNonQuery();
                    DialogBox Db = new DialogBox("Course Added");
                    Db.ShowDialog();
                    con.Close();
                    Display();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "NIBM Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                Reset();
            }
        }

        private void C_DeptIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetDeptName();
        }

        private void C_FacIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetFacName();
        }

        private void Fac_Lbl_Click(object sender, EventArgs e)
        {
            Lecturer Fac = new Lecturer();
            this.Hide();
            Fac.Show();
        }

        private void Dept_Lbl_Click(object sender, EventArgs e)
        {
            Department Dept = new Department();
            this.Hide();
            Dept.Show();
        }

        private void Student_Lbl_Click(object sender, EventArgs e)
        {
            Student Std = new Student();
            this.Hide();
            Std.Show();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (txtCName.Text == "" || txtCreditHrs.Text == "" || cmbCDepId.SelectedIndex == -1 || txtCDepName.Text == "" || cmbCLecId.SelectedIndex == -1 || txtCLecName.Text == "")
            {
                MessageBox.Show("Missing Information...", "NIBM Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("Update courses Set ID=@CId,Course=@CN,CreditHrs=@CH,DeptId=@DepId,DeptName=@Dep,LecId=@LecId,LecName=@LN where ID=@CId", con);
                    cmd.Parameters.AddWithValue("@CId", txtCId.Text);
                    cmd.Parameters.AddWithValue("@CN", txtCName.Text);
                    cmd.Parameters.AddWithValue("@CH", txtCreditHrs.Text);
                    cmd.Parameters.AddWithValue("@DepId", cmbCDepId.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@Dep", txtCDepName.Text);
                    cmd.Parameters.AddWithValue("@LecId", cmbCLecId.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@LN", txtCLecName.Text);
                    cmd.ExecuteNonQuery();
                    DialogBox Db = new DialogBox("Course Updated");
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
        private void Course_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try{
                    MySqlConnection con = Connection.connectionDB();
                    string query = "SELECT * from lecturer";
                    MySqlCommand cmd = new MySqlCommand(@query, con);
                    MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    ada.Fill(ds);
                    DgvCourse.DataSource = ds;
                    if (txtCName.Text == "")
                    {
                        Key = 0;
                    }
                    else
                    {
                        Key = int.Parse(DgvCourse.Rows[e.RowIndex].Cells[0].Value.ToString());
                    }
                }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "NIBM Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Key = Convert.ToInt32(txtCId.Text);
            if (Key == 0)
            {
                MessageBox.Show("Select The Course...!!", "NIBM Management System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("Delete from courses where ID=@CID", con);
                    cmd.Parameters.AddWithValue("@CID", Key);
                    cmd.ExecuteNonQuery();
                    DialogBox Db = new DialogBox("Course Deleted");
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

        private void FeeLbl_Click(object sender, EventArgs e)
        {
            Fees Fee = new Fees();
            this.Hide();
            Fee.Show();
        }
        private void btnC_FormMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnC_FormClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblCourse_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }
    }
}

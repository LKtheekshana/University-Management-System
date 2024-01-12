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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            /*Count_Students();
            Count_Department();
            Count_Faculty();
            Count_Campus();
            SumFinances();
            SumSalary();*/
        }

        MySqlConnection con = Connection.connectionDB();

        private void Student_Lbl_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            this.Hide();
            student.Show();
        }

        private void Dept_Lbl_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            this.Hide();
            department.Show();
        }

        private void Fac_Lbl_Click(object sender, EventArgs e)
        {
            Lecturer lecturer = new Lecturer();
            this.Hide();
            lecturer.Show();
        }

        private void Course_Lbl_Click(object sender, EventArgs e)
        {
            Courses course = new Courses();
            this.Hide();
            course.Show();
        }

        private void FeeLbl_Click(object sender, EventArgs e)
        {
            Fees fees = new Fees(); 
            this.Hide();
            fees.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnMClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
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

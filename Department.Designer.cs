
namespace NIBM_Management_System
{
    partial class Department
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Department));
            this.lblFees = new System.Windows.Forms.Label();
            this.lblCourses = new System.Windows.Forms.Label();
            this.lblDepLecturer = new System.Windows.Forms.Label();
            this.lblDepDepartment = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblDepFees = new System.Windows.Forms.Label();
            this.txtDepFees = new System.Windows.Forms.TextBox();
            this.lblIntake = new System.Windows.Forms.Label();
            this.txtDepIntake = new System.Windows.Forms.TextBox();
            this.btnDepSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDepEdit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DeptDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnDepDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.txtDepId = new System.Windows.Forms.TextBox();
            this.lblDepId = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.btnD_FormClose = new System.Windows.Forms.Button();
            this.btnD_FormMinimize = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DeptDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFees.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(127, 609);
            this.lblFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(60, 26);
            this.lblFees.TabIndex = 22;
            this.lblFees.Text = "Fees";
            this.lblFees.Click += new System.EventHandler(this.FeeLbl_Click);
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCourses.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourses.Location = new System.Drawing.Point(127, 515);
            this.lblCourses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(93, 26);
            this.lblCourses.TabIndex = 21;
            this.lblCourses.Text = "Courses";
            this.lblCourses.Click += new System.EventHandler(this.Course_Lbl_Click);
            // 
            // lblDepLecturer
            // 
            this.lblDepLecturer.AutoSize = true;
            this.lblDepLecturer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDepLecturer.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepLecturer.Location = new System.Drawing.Point(127, 420);
            this.lblDepLecturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepLecturer.Name = "lblDepLecturer";
            this.lblDepLecturer.Size = new System.Drawing.Size(102, 26);
            this.lblDepLecturer.TabIndex = 20;
            this.lblDepLecturer.Text = "Lecturer";
            this.lblDepLecturer.Click += new System.EventHandler(this.Fac_Lbl_Click);
            // 
            // lblDepDepartment
            // 
            this.lblDepDepartment.AutoSize = true;
            this.lblDepDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDepDepartment.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepDepartment.Location = new System.Drawing.Point(127, 245);
            this.lblDepDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepDepartment.Name = "lblDepDepartment";
            this.lblDepDepartment.Size = new System.Drawing.Size(135, 26);
            this.lblDepDepartment.TabIndex = 26;
            this.lblDepDepartment.Text = "Department";
            this.lblDepDepartment.Click += new System.EventHandler(this.Dept_Lbl_Click);
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblStudent.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(127, 329);
            this.lblStudent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(91, 26);
            this.lblStudent.TabIndex = 19;
            this.lblStudent.Text = "Student";
            this.lblStudent.Click += new System.EventHandler(this.Student_Lbl_Click);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHome.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(127, 156);
            this.lblHome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(73, 26);
            this.lblHome.TabIndex = 18;
            this.lblHome.Text = "Home";
            this.lblHome.Click += new System.EventHandler(this.Home_Lbl_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(273, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(9, 809);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Location = new System.Drawing.Point(132, 275);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(127, 4);
            this.panel3.TabIndex = 33;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.Location = new System.Drawing.Point(528, 186);
            this.txtDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(171, 33);
            this.txtDepartment.TabIndex = 34;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.Color.Gray;
            this.lblDepartment.Location = new System.Drawing.Point(524, 156);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(135, 26);
            this.lblDepartment.TabIndex = 26;
            this.lblDepartment.Text = "Department";
            // 
            // lblDepFees
            // 
            this.lblDepFees.AutoSize = true;
            this.lblDepFees.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepFees.ForeColor = System.Drawing.Color.Gray;
            this.lblDepFees.Location = new System.Drawing.Point(1001, 156);
            this.lblDepFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepFees.Name = "lblDepFees";
            this.lblDepFees.Size = new System.Drawing.Size(155, 26);
            this.lblDepFees.TabIndex = 26;
            this.lblDepFees.Text = "Fees Per Year";
            // 
            // txtDepFees
            // 
            this.txtDepFees.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepFees.Location = new System.Drawing.Point(1006, 186);
            this.txtDepFees.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepFees.Name = "txtDepFees";
            this.txtDepFees.Size = new System.Drawing.Size(171, 33);
            this.txtDepFees.TabIndex = 34;
            // 
            // lblIntake
            // 
            this.lblIntake.AutoSize = true;
            this.lblIntake.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntake.ForeColor = System.Drawing.Color.Gray;
            this.lblIntake.Location = new System.Drawing.Point(754, 156);
            this.lblIntake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntake.Name = "lblIntake";
            this.lblIntake.Size = new System.Drawing.Size(80, 26);
            this.lblIntake.TabIndex = 26;
            this.lblIntake.Text = "Intake";
            // 
            // txtDepIntake
            // 
            this.txtDepIntake.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepIntake.Location = new System.Drawing.Point(759, 186);
            this.txtDepIntake.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepIntake.Name = "txtDepIntake";
            this.txtDepIntake.Size = new System.Drawing.Size(171, 33);
            this.txtDepIntake.TabIndex = 34;
            // 
            // btnDepSave
            // 
            this.btnDepSave.ActiveBorderThickness = 1;
            this.btnDepSave.ActiveCornerRadius = 20;
            this.btnDepSave.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(255)))), ((int)(((byte)(245)))));
            this.btnDepSave.ActiveForecolor = System.Drawing.Color.White;
            this.btnDepSave.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.btnDepSave.BackColor = System.Drawing.Color.White;
            this.btnDepSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDepSave.BackgroundImage")));
            this.btnDepSave.ButtonText = "Save";
            this.btnDepSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.btnDepSave.IdleBorderThickness = 1;
            this.btnDepSave.IdleCornerRadius = 20;
            this.btnDepSave.IdleFillColor = System.Drawing.Color.White;
            this.btnDepSave.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.btnDepSave.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.btnDepSave.Location = new System.Drawing.Point(527, 257);
            this.btnDepSave.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnDepSave.Name = "btnDepSave";
            this.btnDepSave.Size = new System.Drawing.Size(172, 49);
            this.btnDepSave.TabIndex = 36;
            this.btnDepSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDepSave.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // btnDepEdit
            // 
            this.btnDepEdit.ActiveBorderThickness = 1;
            this.btnDepEdit.ActiveCornerRadius = 20;
            this.btnDepEdit.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(255)))), ((int)(((byte)(245)))));
            this.btnDepEdit.ActiveForecolor = System.Drawing.Color.White;
            this.btnDepEdit.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.btnDepEdit.BackColor = System.Drawing.Color.White;
            this.btnDepEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDepEdit.BackgroundImage")));
            this.btnDepEdit.ButtonText = "Edit";
            this.btnDepEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.btnDepEdit.IdleBorderThickness = 1;
            this.btnDepEdit.IdleCornerRadius = 20;
            this.btnDepEdit.IdleFillColor = System.Drawing.Color.White;
            this.btnDepEdit.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.btnDepEdit.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.btnDepEdit.Location = new System.Drawing.Point(759, 257);
            this.btnDepEdit.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnDepEdit.Name = "btnDepEdit";
            this.btnDepEdit.Size = new System.Drawing.Size(172, 49);
            this.btnDepEdit.TabIndex = 36;
            this.btnDepEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDepEdit.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeptDGV
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.DeptDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeptDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DeptDGV.ColumnHeadersHeight = 25;
            this.DeptDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DeptDGV.DefaultCellStyle = dataGridViewCellStyle12;
            this.DeptDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DeptDGV.Location = new System.Drawing.Point(335, 366);
            this.DeptDGV.Margin = new System.Windows.Forms.Padding(4);
            this.DeptDGV.Name = "DeptDGV";
            this.DeptDGV.RowHeadersVisible = false;
            this.DeptDGV.RowHeadersWidth = 51;
            this.DeptDGV.Size = new System.Drawing.Size(1041, 399);
            this.DeptDGV.TabIndex = 37;
            this.DeptDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DeptDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DeptDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DeptDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DeptDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DeptDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DeptDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DeptDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.DeptDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DeptDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DeptDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DeptDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.DeptDGV.ThemeStyle.ReadOnly = false;
            this.DeptDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DeptDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DeptDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DeptDGV.ThemeStyle.RowsStyle.Height = 22;
            this.DeptDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DeptDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DeptDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeptDGV_CellContentClick);
            // 
            // btnDepDelete
            // 
            this.btnDepDelete.ActiveBorderThickness = 1;
            this.btnDepDelete.ActiveCornerRadius = 20;
            this.btnDepDelete.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(255)))), ((int)(((byte)(245)))));
            this.btnDepDelete.ActiveForecolor = System.Drawing.Color.White;
            this.btnDepDelete.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.btnDepDelete.BackColor = System.Drawing.Color.White;
            this.btnDepDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDepDelete.BackgroundImage")));
            this.btnDepDelete.ButtonText = "Delete";
            this.btnDepDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.btnDepDelete.IdleBorderThickness = 1;
            this.btnDepDelete.IdleCornerRadius = 20;
            this.btnDepDelete.IdleFillColor = System.Drawing.Color.White;
            this.btnDepDelete.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.btnDepDelete.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(188)))), ((int)(((byte)(249)))));
            this.btnDepDelete.Location = new System.Drawing.Point(1006, 257);
            this.btnDepDelete.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnDepDelete.Name = "btnDepDelete";
            this.btnDepDelete.Size = new System.Drawing.Size(172, 49);
            this.btnDepDelete.TabIndex = 36;
            this.btnDepDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDepDelete.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(335, 338);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1041, 6);
            this.panel2.TabIndex = 33;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // txtDepId
            // 
            this.txtDepId.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepId.Location = new System.Drawing.Point(305, 186);
            this.txtDepId.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepId.Name = "txtDepId";
            this.txtDepId.Size = new System.Drawing.Size(171, 33);
            this.txtDepId.TabIndex = 138;
            this.txtDepId.TextChanged += new System.EventHandler(this.txtDepId_TextChanged);
            // 
            // lblDepId
            // 
            this.lblDepId.AutoSize = true;
            this.lblDepId.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepId.ForeColor = System.Drawing.Color.Gray;
            this.lblDepId.Location = new System.Drawing.Point(300, 156);
            this.lblDepId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepId.Name = "lblDepId";
            this.lblDepId.Size = new System.Drawing.Size(170, 26);
            this.lblDepId.TabIndex = 137;
            this.lblDepId.Text = "Department ID";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(93, 738);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(85, 52);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 158;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(35, 595);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(85, 52);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 157;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(35, 501);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(85, 52);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 156;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(35, 407);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(85, 52);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 155;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(35, 227);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(85, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 154;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(35, 318);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 153;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(35, 145);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(85, 52);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 152;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(637, 12);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(428, 94);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 159;
            this.pictureBox9.TabStop = false;
            // 
            // btnD_FormClose
            // 
            this.btnD_FormClose.BackColor = System.Drawing.Color.White;
            this.btnD_FormClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnD_FormClose.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD_FormClose.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnD_FormClose.Location = new System.Drawing.Point(1384, 13);
            this.btnD_FormClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnD_FormClose.Name = "btnD_FormClose";
            this.btnD_FormClose.Size = new System.Drawing.Size(34, 35);
            this.btnD_FormClose.TabIndex = 186;
            this.btnD_FormClose.Text = "X";
            this.btnD_FormClose.UseVisualStyleBackColor = false;
            this.btnD_FormClose.Click += new System.EventHandler(this.btnD_FormClose_Click);
            // 
            // btnD_FormMinimize
            // 
            this.btnD_FormMinimize.BackColor = System.Drawing.Color.White;
            this.btnD_FormMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnD_FormMinimize.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD_FormMinimize.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnD_FormMinimize.Location = new System.Drawing.Point(1342, 13);
            this.btnD_FormMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnD_FormMinimize.Name = "btnD_FormMinimize";
            this.btnD_FormMinimize.Size = new System.Drawing.Size(34, 35);
            this.btnD_FormMinimize.TabIndex = 185;
            this.btnD_FormMinimize.Text = "-";
            this.btnD_FormMinimize.UseVisualStyleBackColor = false;
            this.btnD_FormMinimize.Click += new System.EventHandler(this.btnD_FormMinimize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 187;
            this.pictureBox1.TabStop = false;
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1427, 802);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnD_FormClose);
            this.Controls.Add(this.btnD_FormMinimize);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtDepId);
            this.Controls.Add(this.lblDepId);
            this.Controls.Add(this.btnDepDelete);
            this.Controls.Add(this.btnDepEdit);
            this.Controls.Add(this.btnDepSave);
            this.Controls.Add(this.DeptDGV);
            this.Controls.Add(this.txtDepIntake);
            this.Controls.Add(this.txtDepFees);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblFees);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.lblDepLecturer);
            this.Controls.Add(this.lblIntake);
            this.Controls.Add(this.lblDepFees);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblDepDepartment);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Department";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Department_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeptDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblCourses;
        private System.Windows.Forms.Label lblDepLecturer;
        private System.Windows.Forms.Label lblDepDepartment;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblHome;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblDepFees;
        private System.Windows.Forms.TextBox txtDepFees;
        private System.Windows.Forms.Label lblIntake;
        private System.Windows.Forms.TextBox txtDepIntake;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDepSave;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDepEdit;
        private Guna.UI2.WinForms.Guna2DataGridView DeptDGV;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDepDelete;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.TextBox txtDepId;
        private System.Windows.Forms.Label lblDepId;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button btnD_FormClose;
        private System.Windows.Forms.Button btnD_FormMinimize;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
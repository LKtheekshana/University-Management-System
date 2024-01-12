
namespace NIBM_Management_System
{
    partial class DialogBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogBox));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.icon = new System.Windows.Forms.PictureBox();
            this.icon_Delay = new System.Windows.Forms.Timer(this.components);
            this.btnOk = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DialogBox_Msg = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // icon
            // 
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(65, -22);
            this.icon.Margin = new System.Windows.Forms.Padding(4);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(377, 233);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // icon_Delay
            // 
            this.icon_Delay.Enabled = true;
            this.icon_Delay.Interval = 5000;
            this.icon_Delay.Tick += new System.EventHandler(this.icon_Delay_Tick);
            // 
            // btnOk
            // 
            this.btnOk.ActiveBorderThickness = 1;
            this.btnOk.ActiveCornerRadius = 20;
            this.btnOk.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(180)))), ((int)(((byte)(63)))));
            this.btnOk.ActiveForecolor = System.Drawing.Color.White;
            this.btnOk.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(180)))), ((int)(((byte)(63)))));
            this.btnOk.BackColor = System.Drawing.Color.White;
            this.btnOk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOk.BackgroundImage")));
            this.btnOk.ButtonText = "OK";
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnOk.IdleBorderThickness = 1;
            this.btnOk.IdleCornerRadius = 25;
            this.btnOk.IdleFillColor = System.Drawing.Color.White;
            this.btnOk.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnOk.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnOk.Location = new System.Drawing.Point(183, 218);
            this.btnOk.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(141, 48);
            this.btnOk.TabIndex = 1;
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOk.Click += new System.EventHandler(this.Ok_Btn_Click);
            // 
            // DialogBox_Msg
            // 
            this.DialogBox_Msg.AllowParentOverrides = false;
            this.DialogBox_Msg.AutoEllipsis = true;
            this.DialogBox_Msg.AutoSize = false;
            this.DialogBox_Msg.CursorType = null;
            this.DialogBox_Msg.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DialogBox_Msg.ForeColor = System.Drawing.Color.Gray;
            this.DialogBox_Msg.Location = new System.Drawing.Point(-21, 174);
            this.DialogBox_Msg.Margin = new System.Windows.Forms.Padding(4);
            this.DialogBox_Msg.Name = "DialogBox_Msg";
            this.DialogBox_Msg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DialogBox_Msg.Size = new System.Drawing.Size(549, 46);
            this.DialogBox_Msg.TabIndex = 2;
            this.DialogBox_Msg.Text = "Success";
            this.DialogBox_Msg.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.DialogBox_Msg.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // DialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(503, 274);
            this.Controls.Add(this.DialogBox_Msg);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DialogBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogBox";
            this.Load += new System.EventHandler(this.DialogBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Timer icon_Delay;
        private Bunifu.Framework.UI.BunifuThinButton2 btnOk;
        private Bunifu.UI.WinForms.BunifuLabel DialogBox_Msg;
    }
}
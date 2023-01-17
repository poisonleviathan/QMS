namespace QMS
{
    partial class Login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_form));
            this.Login_left_panel = new System.Windows.Forms.Panel();
            this.Login_img = new System.Windows.Forms.PictureBox();
            this.Login_right_panel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_userType = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Login_logo_img = new System.Windows.Forms.PictureBox();
            this.Login_exit_btn = new System.Windows.Forms.Button();
            this.txt_select_user = new System.Windows.Forms.ComboBox();
            this.panel_teacher = new System.Windows.Forms.Panel();
            this.lbl_wrong_cred = new System.Windows.Forms.Label();
            this.btn_login = new QMS.roundedbtn();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.Uname_txt = new System.Windows.Forms.TextBox();
            this.Pwd_txt = new System.Windows.Forms.TextBox();
            this.lbl_Uname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Teacher_panel = new System.Windows.Forms.Panel();
            this.studnet_panel = new System.Windows.Forms.Panel();
            this.btn_studentLogin = new QMS.roundedbtn();
            this.btn_studentReg = new QMS.roundedbtn();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.lbl_StNo = new System.Windows.Forms.Label();
            this.txt_StudentNo = new System.Windows.Forms.TextBox();
            this.Login_left_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Login_img)).BeginInit();
            this.Login_right_panel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Login_logo_img)).BeginInit();
            this.Teacher_panel.SuspendLayout();
            this.studnet_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_left_panel
            // 
            this.Login_left_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login_left_panel.BackgroundImage")));
            this.Login_left_panel.Controls.Add(this.panel_teacher);
            this.Login_left_panel.Controls.Add(this.Login_img);
            this.Login_left_panel.Controls.Add(this.Login_logo_img);
            this.Login_left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Login_left_panel.Location = new System.Drawing.Point(0, 0);
            this.Login_left_panel.Name = "Login_left_panel";
            this.Login_left_panel.Size = new System.Drawing.Size(478, 450);
            this.Login_left_panel.TabIndex = 0;
            // 
            // Login_img
            // 
            this.Login_img.BackColor = System.Drawing.Color.Transparent;
            this.Login_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Login_img.Image = ((System.Drawing.Image)(resources.GetObject("Login_img.Image")));
            this.Login_img.InitialImage = null;
            this.Login_img.Location = new System.Drawing.Point(77, 44);
            this.Login_img.Name = "Login_img";
            this.Login_img.Size = new System.Drawing.Size(303, 339);
            this.Login_img.TabIndex = 0;
            this.Login_img.TabStop = false;
            this.Login_img.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login_right_panel
            // 
            this.Login_right_panel.BackColor = System.Drawing.SystemColors.Control;
            this.Login_right_panel.Controls.Add(this.studnet_panel);
            this.Login_right_panel.Controls.Add(this.Teacher_panel);
            this.Login_right_panel.Controls.Add(this.panel3);
            this.Login_right_panel.Controls.Add(this.panel2);
            this.Login_right_panel.Controls.Add(this.Login_exit_btn);
            this.Login_right_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login_right_panel.Location = new System.Drawing.Point(478, 0);
            this.Login_right_panel.Name = "Login_right_panel";
            this.Login_right_panel.Size = new System.Drawing.Size(322, 450);
            this.Login_right_panel.TabIndex = 1;
            this.Login_right_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_userType);
            this.panel3.Location = new System.Drawing.Point(0, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 42);
            this.panel3.TabIndex = 11;
            // 
            // lbl_userType
            // 
            this.lbl_userType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_userType.AutoSize = true;
            this.lbl_userType.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userType.Location = new System.Drawing.Point(87, 11);
            this.lbl_userType.Name = "lbl_userType";
            this.lbl_userType.Size = new System.Drawing.Size(125, 19);
            this.lbl_userType.TabIndex = 9;
            this.lbl_userType.Text = "Select User Type";
            this.lbl_userType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_select_user);
            this.panel2.Location = new System.Drawing.Point(27, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 36);
            this.panel2.TabIndex = 10;
            // 
            // Login_logo_img
            // 
            this.Login_logo_img.BackColor = System.Drawing.Color.White;
            this.Login_logo_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Login_logo_img.Image = ((System.Drawing.Image)(resources.GetObject("Login_logo_img.Image")));
            this.Login_logo_img.Location = new System.Drawing.Point(0, 0);
            this.Login_logo_img.Name = "Login_logo_img";
            this.Login_logo_img.Size = new System.Drawing.Size(61, 95);
            this.Login_logo_img.TabIndex = 0;
            this.Login_logo_img.TabStop = false;
            // 
            // Login_exit_btn
            // 
            this.Login_exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_exit_btn.FlatAppearance.BorderSize = 0;
            this.Login_exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_exit_btn.Font = new System.Drawing.Font("Coolvetica Rg", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_exit_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(2)))), ((int)(((byte)(108)))));
            this.Login_exit_btn.Location = new System.Drawing.Point(282, 0);
            this.Login_exit_btn.Name = "Login_exit_btn";
            this.Login_exit_btn.Size = new System.Drawing.Size(40, 40);
            this.Login_exit_btn.TabIndex = 1;
            this.Login_exit_btn.Text = "X";
            this.Login_exit_btn.UseVisualStyleBackColor = true;
            this.Login_exit_btn.Click += new System.EventHandler(this.btn_lg_close_Click);
            // 
            // txt_select_user
            // 
            this.txt_select_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_select_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_select_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_select_user.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_select_user.FormattingEnabled = true;
            this.txt_select_user.Items.AddRange(new object[] {
            "Teacher",
            "Student"});
            this.txt_select_user.Location = new System.Drawing.Point(0, 0);
            this.txt_select_user.Name = "txt_select_user";
            this.txt_select_user.Size = new System.Drawing.Size(243, 23);
            this.txt_select_user.TabIndex = 0;
            this.txt_select_user.SelectedIndexChanged += new System.EventHandler(this.txt_select_user_SelectedIndexChanged);
            // 
            // panel_teacher
            // 
            this.panel_teacher.Location = new System.Drawing.Point(478, 125);
            this.panel_teacher.Name = "panel_teacher";
            this.panel_teacher.Size = new System.Drawing.Size(322, 325);
            this.panel_teacher.TabIndex = 12;
            // 
            // lbl_wrong_cred
            // 
            this.lbl_wrong_cred.AutoSize = true;
            this.lbl_wrong_cred.Font = new System.Drawing.Font("Roboto", 10F);
            this.lbl_wrong_cred.ForeColor = System.Drawing.Color.Red;
            this.lbl_wrong_cred.Location = new System.Drawing.Point(44, 229);
            this.lbl_wrong_cred.Name = "lbl_wrong_cred";
            this.lbl_wrong_cred.Size = new System.Drawing.Size(211, 17);
            this.lbl_wrong_cred.TabIndex = 28;
            this.lbl_wrong_cred.Text = "Wrong Username \"OR\" Password";
            this.lbl_wrong_cred.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login.BackgroundImage")));
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login.BorderColor = System.Drawing.Color.Transparent;
            this.btn_login.BorderRadius = 13;
            this.btn_login.BorderSize = 0;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(63, 186);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(173, 40);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.TextColor = System.Drawing.Color.White;
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pwd.Location = new System.Drawing.Point(101, 117);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(79, 19);
            this.lbl_pwd.TabIndex = 34;
            this.lbl_pwd.Text = "Password";
            this.lbl_pwd.Click += new System.EventHandler(this.lbl_pwd_Click);
            // 
            // Uname_txt
            // 
            this.Uname_txt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uname_txt.ForeColor = System.Drawing.Color.Indigo;
            this.Uname_txt.Location = new System.Drawing.Point(28, 73);
            this.Uname_txt.Name = "Uname_txt";
            this.Uname_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Uname_txt.Size = new System.Drawing.Size(242, 25);
            this.Uname_txt.TabIndex = 31;
            this.Uname_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Pwd_txt
            // 
            this.Pwd_txt.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pwd_txt.ForeColor = System.Drawing.Color.Indigo;
            this.Pwd_txt.Location = new System.Drawing.Point(28, 139);
            this.Pwd_txt.Name = "Pwd_txt";
            this.Pwd_txt.Size = new System.Drawing.Size(242, 22);
            this.Pwd_txt.TabIndex = 32;
            this.Pwd_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pwd_txt.UseSystemPasswordChar = true;
            // 
            // lbl_Uname
            // 
            this.lbl_Uname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Uname.AutoSize = true;
            this.lbl_Uname.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Uname.Location = new System.Drawing.Point(101, 51);
            this.lbl_Uname.Name = "lbl_Uname";
            this.lbl_Uname.Size = new System.Drawing.Size(80, 19);
            this.lbl_Uname.TabIndex = 30;
            this.lbl_Uname.Text = "Username";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Teacher Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Teacher_panel
            // 
            this.Teacher_panel.Controls.Add(this.btn_login);
            this.Teacher_panel.Controls.Add(this.lbl_wrong_cred);
            this.Teacher_panel.Controls.Add(this.label1);
            this.Teacher_panel.Controls.Add(this.lbl_Uname);
            this.Teacher_panel.Controls.Add(this.Pwd_txt);
            this.Teacher_panel.Controls.Add(this.Uname_txt);
            this.Teacher_panel.Controls.Add(this.lbl_pwd);
            this.Teacher_panel.Location = new System.Drawing.Point(0, 152);
            this.Teacher_panel.Name = "Teacher_panel";
            this.Teacher_panel.Size = new System.Drawing.Size(322, 298);
            this.Teacher_panel.TabIndex = 29;
            // 
            // studnet_panel
            // 
            this.studnet_panel.Controls.Add(this.btn_studentLogin);
            this.studnet_panel.Controls.Add(this.btn_studentReg);
            this.studnet_panel.Controls.Add(this.lbl_Type);
            this.studnet_panel.Controls.Add(this.lbl_StNo);
            this.studnet_panel.Controls.Add(this.txt_StudentNo);
            this.studnet_panel.Location = new System.Drawing.Point(0, 152);
            this.studnet_panel.Name = "studnet_panel";
            this.studnet_panel.Size = new System.Drawing.Size(322, 298);
            this.studnet_panel.TabIndex = 36;
            // 
            // btn_studentLogin
            // 
            this.btn_studentLogin.BackColor = System.Drawing.Color.Transparent;
            this.btn_studentLogin.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_studentLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_studentLogin.BackgroundImage")));
            this.btn_studentLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_studentLogin.BorderColor = System.Drawing.Color.Transparent;
            this.btn_studentLogin.BorderRadius = 13;
            this.btn_studentLogin.BorderSize = 0;
            this.btn_studentLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_studentLogin.FlatAppearance.BorderSize = 0;
            this.btn_studentLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_studentLogin.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_studentLogin.ForeColor = System.Drawing.Color.White;
            this.btn_studentLogin.Location = new System.Drawing.Point(63, 126);
            this.btn_studentLogin.Name = "btn_studentLogin";
            this.btn_studentLogin.Size = new System.Drawing.Size(173, 40);
            this.btn_studentLogin.TabIndex = 34;
            this.btn_studentLogin.Text = "Login";
            this.btn_studentLogin.TextColor = System.Drawing.Color.White;
            this.btn_studentLogin.UseVisualStyleBackColor = false;
            // 
            // btn_studentReg
            // 
            this.btn_studentReg.BackColor = System.Drawing.Color.Transparent;
            this.btn_studentReg.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_studentReg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_studentReg.BackgroundImage")));
            this.btn_studentReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_studentReg.BorderColor = System.Drawing.Color.Transparent;
            this.btn_studentReg.BorderRadius = 13;
            this.btn_studentReg.BorderSize = 0;
            this.btn_studentReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_studentReg.FlatAppearance.BorderSize = 0;
            this.btn_studentReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_studentReg.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_studentReg.ForeColor = System.Drawing.Color.White;
            this.btn_studentReg.Location = new System.Drawing.Point(63, 191);
            this.btn_studentReg.Name = "btn_studentReg";
            this.btn_studentReg.Size = new System.Drawing.Size(173, 40);
            this.btn_studentReg.TabIndex = 0;
            this.btn_studentReg.Text = "Register";
            this.btn_studentReg.TextColor = System.Drawing.Color.White;
            this.btn_studentReg.UseVisualStyleBackColor = false;
            // 
            // lbl_Type
            // 
            this.lbl_Type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Type.Location = new System.Drawing.Point(87, 0);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(108, 19);
            this.lbl_Type.TabIndex = 33;
            this.lbl_Type.Text = "Student Login";
            this.lbl_Type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_StNo
            // 
            this.lbl_StNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_StNo.AutoSize = true;
            this.lbl_StNo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StNo.Location = new System.Drawing.Point(72, 51);
            this.lbl_StNo.Name = "lbl_StNo";
            this.lbl_StNo.Size = new System.Drawing.Size(164, 19);
            this.lbl_StNo.TabIndex = 30;
            this.lbl_StNo.Text = "Student Enroment No.";
            // 
            // txt_StudentNo
            // 
            this.txt_StudentNo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StudentNo.ForeColor = System.Drawing.Color.Indigo;
            this.txt_StudentNo.Location = new System.Drawing.Point(28, 73);
            this.txt_StudentNo.Name = "txt_StudentNo";
            this.txt_StudentNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_StudentNo.Size = new System.Drawing.Size(242, 25);
            this.txt_StudentNo.TabIndex = 31;
            this.txt_StudentNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Login_right_panel);
            this.Controls.Add(this.Login_left_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QMS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Login_left_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Login_img)).EndInit();
            this.Login_right_panel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Login_logo_img)).EndInit();
            this.Teacher_panel.ResumeLayout(false);
            this.Teacher_panel.PerformLayout();
            this.studnet_panel.ResumeLayout(false);
            this.studnet_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Login_left_panel;
        private System.Windows.Forms.Panel Login_right_panel;
        private System.Windows.Forms.PictureBox Login_img;
        private System.Windows.Forms.PictureBox Login_logo_img;
        private System.Windows.Forms.Button Login_exit_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_userType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox txt_select_user;
        private System.Windows.Forms.Panel panel_teacher;
        private System.Windows.Forms.Label lbl_wrong_cred;
        private roundedbtn btn_login;
        private System.Windows.Forms.Panel Teacher_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Uname;
        private System.Windows.Forms.TextBox Pwd_txt;
        private System.Windows.Forms.TextBox Uname_txt;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.Panel studnet_panel;
        private roundedbtn btn_studentLogin;
        private roundedbtn btn_studentReg;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.Label lbl_StNo;
        private System.Windows.Forms.TextBox txt_StudentNo;
    }
}


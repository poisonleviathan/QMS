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
            this.Login_right_panel = new System.Windows.Forms.Panel();
            this.Login_img = new System.Windows.Forms.PictureBox();
            this.Login_logo_img = new System.Windows.Forms.PictureBox();
            this.Login_exit_btn = new System.Windows.Forms.Button();
            this.Login_greet_img = new System.Windows.Forms.PictureBox();
            this.Login_Uname_panel = new System.Windows.Forms.Panel();
            this.lbl_Uname = new System.Windows.Forms.Label();
            this.Uname_txt = new System.Windows.Forms.TextBox();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.Pwd_txt = new System.Windows.Forms.TextBox();
            this.login_pwd_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Login_btn = new System.Windows.Forms.Button();
            this.Login_left_panel.SuspendLayout();
            this.Login_right_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Login_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_logo_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_greet_img)).BeginInit();
            this.Login_Uname_panel.SuspendLayout();
            this.login_pwd_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_left_panel
            // 
            this.Login_left_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login_left_panel.BackgroundImage")));
            this.Login_left_panel.Controls.Add(this.Login_img);
            this.Login_left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Login_left_panel.Location = new System.Drawing.Point(0, 0);
            this.Login_left_panel.Name = "Login_left_panel";
            this.Login_left_panel.Size = new System.Drawing.Size(478, 450);
            this.Login_left_panel.TabIndex = 0;
            // 
            // Login_right_panel
            // 
            this.Login_right_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.Login_right_panel.Controls.Add(this.panel1);
            this.Login_right_panel.Controls.Add(this.login_pwd_panel);
            this.Login_right_panel.Controls.Add(this.lbl_pwd);
            this.Login_right_panel.Controls.Add(this.Login_Uname_panel);
            this.Login_right_panel.Controls.Add(this.lbl_Uname);
            this.Login_right_panel.Controls.Add(this.Login_greet_img);
            this.Login_right_panel.Controls.Add(this.Login_exit_btn);
            this.Login_right_panel.Controls.Add(this.Login_logo_img);
            this.Login_right_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login_right_panel.Location = new System.Drawing.Point(478, 0);
            this.Login_right_panel.Name = "Login_right_panel";
            this.Login_right_panel.Size = new System.Drawing.Size(322, 450);
            this.Login_right_panel.TabIndex = 1;
            this.Login_right_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            // Login_logo_img
            // 
            this.Login_logo_img.BackColor = System.Drawing.Color.Transparent;
            this.Login_logo_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Login_logo_img.Image = ((System.Drawing.Image)(resources.GetObject("Login_logo_img.Image")));
            this.Login_logo_img.Location = new System.Drawing.Point(139, 12);
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
            // Login_greet_img
            // 
            this.Login_greet_img.Image = ((System.Drawing.Image)(resources.GetObject("Login_greet_img.Image")));
            this.Login_greet_img.Location = new System.Drawing.Point(27, 126);
            this.Login_greet_img.Name = "Login_greet_img";
            this.Login_greet_img.Size = new System.Drawing.Size(242, 57);
            this.Login_greet_img.TabIndex = 2;
            this.Login_greet_img.TabStop = false;
            // 
            // Login_Uname_panel
            // 
            this.Login_Uname_panel.BackColor = System.Drawing.Color.Transparent;
            this.Login_Uname_panel.Controls.Add(this.Uname_txt);
            this.Login_Uname_panel.ForeColor = System.Drawing.Color.Indigo;
            this.Login_Uname_panel.Location = new System.Drawing.Point(0, 232);
            this.Login_Uname_panel.Name = "Login_Uname_panel";
            this.Login_Uname_panel.Size = new System.Drawing.Size(322, 35);
            this.Login_Uname_panel.TabIndex = 3;
            this.Login_Uname_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Login_Uname_panel_Paint);
            // 
            // lbl_Uname
            // 
            this.lbl_Uname.AutoSize = true;
            this.lbl_Uname.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Uname.Location = new System.Drawing.Point(24, 213);
            this.lbl_Uname.Name = "lbl_Uname";
            this.lbl_Uname.Size = new System.Drawing.Size(80, 19);
            this.lbl_Uname.TabIndex = 3;
            this.lbl_Uname.Text = "Username";
            // 
            // Uname_txt
            // 
            this.Uname_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Uname_txt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uname_txt.ForeColor = System.Drawing.Color.Indigo;
            this.Uname_txt.Location = new System.Drawing.Point(27, 3);
            this.Uname_txt.Name = "Uname_txt";
            this.Uname_txt.Size = new System.Drawing.Size(242, 25);
            this.Uname_txt.TabIndex = 4;
            this.Uname_txt.TextChanged += new System.EventHandler(this.Uname_txt_TextChanged);
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pwd.Location = new System.Drawing.Point(24, 281);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(79, 19);
            this.lbl_pwd.TabIndex = 4;
            this.lbl_pwd.Text = "Password";
            this.lbl_pwd.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Pwd_txt
            // 
            this.Pwd_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pwd_txt.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pwd_txt.ForeColor = System.Drawing.Color.Indigo;
            this.Pwd_txt.Location = new System.Drawing.Point(27, 3);
            this.Pwd_txt.Name = "Pwd_txt";
            this.Pwd_txt.Size = new System.Drawing.Size(242, 22);
            this.Pwd_txt.TabIndex = 4;
            this.Pwd_txt.UseSystemPasswordChar = true;
            // 
            // login_pwd_panel
            // 
            this.login_pwd_panel.BackColor = System.Drawing.Color.Transparent;
            this.login_pwd_panel.Controls.Add(this.Pwd_txt);
            this.login_pwd_panel.Location = new System.Drawing.Point(0, 303);
            this.login_pwd_panel.Name = "login_pwd_panel";
            this.login_pwd_panel.Size = new System.Drawing.Size(322, 34);
            this.login_pwd_panel.TabIndex = 5;
            this.login_pwd_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.login_pwd_panel_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.Login_btn);
            this.panel1.Location = new System.Drawing.Point(75, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 40);
            this.panel1.TabIndex = 6;
            // 
            // Login_btn
            // 
            this.Login_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login_btn.BackgroundImage")));
            this.Login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Login_btn.FlatAppearance.BorderSize = 0;
            this.Login_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Login_btn.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.ForeColor = System.Drawing.SystemColors.Info;
            this.Login_btn.Location = new System.Drawing.Point(0, 0);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(173, 40);
            this.Login_btn.TabIndex = 0;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = true;
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
            this.Login_right_panel.ResumeLayout(false);
            this.Login_right_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Login_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_logo_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_greet_img)).EndInit();
            this.Login_Uname_panel.ResumeLayout(false);
            this.Login_Uname_panel.PerformLayout();
            this.login_pwd_panel.ResumeLayout(false);
            this.login_pwd_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Login_left_panel;
        private System.Windows.Forms.Panel Login_right_panel;
        private System.Windows.Forms.PictureBox Login_img;
        private System.Windows.Forms.PictureBox Login_logo_img;
        private System.Windows.Forms.Button Login_exit_btn;
        private System.Windows.Forms.Panel Login_Uname_panel;
        private System.Windows.Forms.Label lbl_Uname;
        private System.Windows.Forms.PictureBox Login_greet_img;
        private System.Windows.Forms.TextBox Uname_txt;
        private System.Windows.Forms.Panel login_pwd_panel;
        private System.Windows.Forms.TextBox Pwd_txt;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Login_btn;
    }
}


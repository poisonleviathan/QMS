namespace QMS
{
    partial class StudentReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentReg));
            this.ScreenPanel = new System.Windows.Forms.Panel();
            this.StudentsDGV = new System.Windows.Forms.DataGridView();
            this.lbl_StudentList = new System.Windows.Forms.Label();
            this.btn_reset = new QMS.roundedbtn();
            this.btn_edit = new QMS.roundedbtn();
            this.btn_save = new QMS.roundedbtn();
            this.lbl_DashHeader = new System.Windows.Forms.Label();
            this.addressTb = new System.Windows.Forms.TextBox();
            this.PhoneTb = new System.Windows.Forms.TextBox();
            this.CAgeTb = new System.Windows.Forms.TextBox();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.CNameTb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.roundedbtn6 = new QMS.roundedbtn();
            this.panel12 = new System.Windows.Forms.Panel();
            this.roundedbtn7 = new QMS.roundedbtn();
            this.roundedbtn8 = new QMS.roundedbtn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.roundedbtn1 = new QMS.roundedbtn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.roundedbtn2 = new QMS.roundedbtn();
            this.roundedbtn4 = new QMS.roundedbtn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_dashboard = new QMS.roundedbtn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_quizActive = new QMS.roundedbtn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.roundedbtn3 = new QMS.roundedbtn();
            this.btn_quiz = new QMS.roundedbtn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Login_logo_img = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.roundedbtn5 = new QMS.roundedbtn();
            this.btn_logout = new QMS.roundedbtn();
            this.ScreenPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Login_logo_img)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScreenPanel
            // 
            this.ScreenPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScreenPanel.BackColor = System.Drawing.Color.Transparent;
            this.ScreenPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ScreenPanel.BackgroundImage")));
            this.ScreenPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ScreenPanel.Controls.Add(this.StudentsDGV);
            this.ScreenPanel.Controls.Add(this.lbl_StudentList);
            this.ScreenPanel.Controls.Add(this.btn_reset);
            this.ScreenPanel.Controls.Add(this.btn_edit);
            this.ScreenPanel.Controls.Add(this.btn_save);
            this.ScreenPanel.Controls.Add(this.lbl_DashHeader);
            this.ScreenPanel.Controls.Add(this.addressTb);
            this.ScreenPanel.Controls.Add(this.PhoneTb);
            this.ScreenPanel.Controls.Add(this.CAgeTb);
            this.ScreenPanel.Controls.Add(this.PasswordTb);
            this.ScreenPanel.Controls.Add(this.CNameTb);
            this.ScreenPanel.Location = new System.Drawing.Point(129, 0);
            this.ScreenPanel.Name = "ScreenPanel";
            this.ScreenPanel.Size = new System.Drawing.Size(951, 647);
            this.ScreenPanel.TabIndex = 5;
            this.ScreenPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ScreenPanel_Paint);
            // 
            // StudentsDGV
            // 
            this.StudentsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentsDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.StudentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StudentsDGV.EnableHeadersVisualStyles = false;
            this.StudentsDGV.Location = new System.Drawing.Point(0, 372);
            this.StudentsDGV.Name = "StudentsDGV";
            this.StudentsDGV.RowHeadersVisible = false;
            this.StudentsDGV.Size = new System.Drawing.Size(951, 275);
            this.StudentsDGV.TabIndex = 15;
            this.StudentsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsDGV_CellContentClick_1);
            // 
            // lbl_StudentList
            // 
            this.lbl_StudentList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_StudentList.AutoSize = true;
            this.lbl_StudentList.Font = new System.Drawing.Font("Inter Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StudentList.Location = new System.Drawing.Point(393, 335);
            this.lbl_StudentList.Name = "lbl_StudentList";
            this.lbl_StudentList.Size = new System.Drawing.Size(146, 25);
            this.lbl_StudentList.TabIndex = 14;
            this.lbl_StudentList.Text = "Students LIst";
            this.lbl_StudentList.Click += new System.EventHandler(this.lbl_StudentList_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reset.BackColor = System.Drawing.Color.Navy;
            this.btn_reset.BackgroundColor = System.Drawing.Color.Navy;
            this.btn_reset.BorderColor = System.Drawing.Color.Tomato;
            this.btn_reset.BorderRadius = 18;
            this.btn_reset.BorderSize = 0;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(605, 276);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(99, 34);
            this.btn_reset.TabIndex = 11;
            this.btn_reset.Text = "Reset";
            this.btn_reset.TextColor = System.Drawing.Color.White;
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Navy;
            this.btn_edit.BackgroundColor = System.Drawing.Color.Navy;
            this.btn_edit.BorderColor = System.Drawing.Color.Tomato;
            this.btn_edit.BorderRadius = 18;
            this.btn_edit.BorderSize = 0;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(216, 276);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(99, 34);
            this.btn_edit.TabIndex = 10;
            this.btn_edit.Text = "Edit";
            this.btn_edit.TextColor = System.Drawing.Color.White;
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_save.BackColor = System.Drawing.Color.Navy;
            this.btn_save.BackgroundColor = System.Drawing.Color.Navy;
            this.btn_save.BorderColor = System.Drawing.Color.Tomato;
            this.btn_save.BorderRadius = 18;
            this.btn_save.BorderSize = 0;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(398, 276);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(115, 34);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.TextColor = System.Drawing.Color.White;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_DashHeader
            // 
            this.lbl_DashHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_DashHeader.AutoSize = true;
            this.lbl_DashHeader.Font = new System.Drawing.Font("Inter Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DashHeader.Location = new System.Drawing.Point(355, 27);
            this.lbl_DashHeader.Name = "lbl_DashHeader";
            this.lbl_DashHeader.Size = new System.Drawing.Size(220, 25);
            this.lbl_DashHeader.TabIndex = 8;
            this.lbl_DashHeader.Text = "Student Registration";
            this.lbl_DashHeader.Click += new System.EventHandler(this.lbl_DashHeader_Click);
            // 
            // addressTb
            // 
            this.addressTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTb.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(2)))), ((int)(((byte)(108)))));
            this.addressTb.Location = new System.Drawing.Point(614, 136);
            this.addressTb.Name = "addressTb";
            this.addressTb.Size = new System.Drawing.Size(238, 27);
            this.addressTb.TabIndex = 6;
            this.addressTb.Text = "Address";
            this.addressTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addressTb.TextChanged += new System.EventHandler(this.txt_StAddress_TextChanged);
            this.addressTb.Enter += new System.EventHandler(this.addressTb_Enter);
            this.addressTb.Leave += new System.EventHandler(this.addressTb_Leave);
            // 
            // PhoneTb
            // 
            this.PhoneTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneTb.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(2)))), ((int)(((byte)(108)))));
            this.PhoneTb.Location = new System.Drawing.Point(614, 186);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(238, 27);
            this.PhoneTb.TabIndex = 5;
            this.PhoneTb.Text = "Phone";
            this.PhoneTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PhoneTb.TextChanged += new System.EventHandler(this.txt_StPhone_TextChanged);
            this.PhoneTb.Enter += new System.EventHandler(this.PhoneTb_Enter);
            this.PhoneTb.Leave += new System.EventHandler(this.PhoneTb_Leave);
            // 
            // CAgeTb
            // 
            this.CAgeTb.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAgeTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(2)))), ((int)(((byte)(108)))));
            this.CAgeTb.Location = new System.Drawing.Point(88, 136);
            this.CAgeTb.MaxLength = 3;
            this.CAgeTb.Name = "CAgeTb";
            this.CAgeTb.Size = new System.Drawing.Size(238, 27);
            this.CAgeTb.TabIndex = 4;
            this.CAgeTb.Text = "Age";
            this.CAgeTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CAgeTb.TextChanged += new System.EventHandler(this.txt_StAge_TextChanged);
            this.CAgeTb.Enter += new System.EventHandler(this.CAgeTb_Enter);
            this.CAgeTb.Leave += new System.EventHandler(this.CAgeTb_Leave);
            // 
            // PasswordTb
            // 
            this.PasswordTb.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(2)))), ((int)(((byte)(108)))));
            this.PasswordTb.Location = new System.Drawing.Point(88, 199);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(238, 27);
            this.PasswordTb.TabIndex = 3;
            this.PasswordTb.Text = "Password";
            this.PasswordTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordTb.TextChanged += new System.EventHandler(this.txt_StPassword_TextChanged);
            this.PasswordTb.Enter += new System.EventHandler(this.PasswordTb_Enter);
            this.PasswordTb.Leave += new System.EventHandler(this.PasswordTb_Leave);
            // 
            // CNameTb
            // 
            this.CNameTb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CNameTb.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(2)))), ((int)(((byte)(108)))));
            this.CNameTb.Location = new System.Drawing.Point(346, 83);
            this.CNameTb.Name = "CNameTb";
            this.CNameTb.Size = new System.Drawing.Size(229, 27);
            this.CNameTb.TabIndex = 2;
            this.CNameTb.Text = "Name";
            this.CNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CNameTb.TextChanged += new System.EventHandler(this.txt_StName_TextChanged);
            this.CNameTb.Enter += new System.EventHandler(this.CNameTb_Enter);
            this.CNameTb.Leave += new System.EventHandler(this.CNameTb_Leave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 699);
            this.panel1.TabIndex = 15;
            // 
            // panel11
            // 
            this.panel11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Controls.Add(this.roundedbtn6);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.roundedbtn8);
            this.panel11.Location = new System.Drawing.Point(0, 428);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(127, 82);
            this.panel11.TabIndex = 6;
            // 
            // roundedbtn6
            // 
            this.roundedbtn6.BackColor = System.Drawing.SystemColors.Control;
            this.roundedbtn6.BackgroundColor = System.Drawing.SystemColors.Control;
            this.roundedbtn6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedbtn6.BackgroundImage")));
            this.roundedbtn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundedbtn6.BorderColor = System.Drawing.Color.Tomato;
            this.roundedbtn6.BorderRadius = 16;
            this.roundedbtn6.BorderSize = 0;
            this.roundedbtn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedbtn6.FlatAppearance.BorderSize = 0;
            this.roundedbtn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedbtn6.ForeColor = System.Drawing.Color.White;
            this.roundedbtn6.Location = new System.Drawing.Point(40, 18);
            this.roundedbtn6.Name = "roundedbtn6";
            this.roundedbtn6.Size = new System.Drawing.Size(52, 54);
            this.roundedbtn6.TabIndex = 3;
            this.roundedbtn6.TextColor = System.Drawing.Color.White;
            this.roundedbtn6.UseVisualStyleBackColor = false;
            this.roundedbtn6.Click += new System.EventHandler(this.roundedbtn6_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.roundedbtn7);
            this.panel12.Location = new System.Drawing.Point(0, 78);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(200, 82);
            this.panel12.TabIndex = 2;
            // 
            // roundedbtn7
            // 
            this.roundedbtn7.BackColor = System.Drawing.Color.Transparent;
            this.roundedbtn7.BackgroundColor = System.Drawing.Color.Transparent;
            this.roundedbtn7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedbtn7.BackgroundImage")));
            this.roundedbtn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundedbtn7.BorderColor = System.Drawing.Color.Tomato;
            this.roundedbtn7.BorderRadius = 16;
            this.roundedbtn7.BorderSize = 0;
            this.roundedbtn7.FlatAppearance.BorderSize = 0;
            this.roundedbtn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedbtn7.ForeColor = System.Drawing.Color.White;
            this.roundedbtn7.Location = new System.Drawing.Point(64, 11);
            this.roundedbtn7.Name = "roundedbtn7";
            this.roundedbtn7.Size = new System.Drawing.Size(61, 63);
            this.roundedbtn7.TabIndex = 0;
            this.roundedbtn7.TextColor = System.Drawing.Color.White;
            this.roundedbtn7.UseVisualStyleBackColor = false;
            // 
            // roundedbtn8
            // 
            this.roundedbtn8.BackColor = System.Drawing.Color.Gainsboro;
            this.roundedbtn8.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.roundedbtn8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedbtn8.BackgroundImage")));
            this.roundedbtn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundedbtn8.BorderColor = System.Drawing.Color.Tomato;
            this.roundedbtn8.BorderRadius = 16;
            this.roundedbtn8.BorderSize = 0;
            this.roundedbtn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedbtn8.FlatAppearance.BorderSize = 0;
            this.roundedbtn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedbtn8.ForeColor = System.Drawing.Color.White;
            this.roundedbtn8.Location = new System.Drawing.Point(40, 18);
            this.roundedbtn8.Name = "roundedbtn8";
            this.roundedbtn8.Size = new System.Drawing.Size(52, 54);
            this.roundedbtn8.TabIndex = 0;
            this.roundedbtn8.TextColor = System.Drawing.Color.White;
            this.roundedbtn8.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.roundedbtn1);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.roundedbtn4);
            this.panel6.Location = new System.Drawing.Point(0, 342);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(127, 82);
            this.panel6.TabIndex = 5;
            // 
            // roundedbtn1
            // 
            this.roundedbtn1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundedbtn1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundedbtn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedbtn1.BackgroundImage")));
            this.roundedbtn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundedbtn1.BorderColor = System.Drawing.Color.Tomato;
            this.roundedbtn1.BorderRadius = 16;
            this.roundedbtn1.BorderSize = 0;
            this.roundedbtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedbtn1.FlatAppearance.BorderSize = 0;
            this.roundedbtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedbtn1.ForeColor = System.Drawing.Color.White;
            this.roundedbtn1.Location = new System.Drawing.Point(40, 18);
            this.roundedbtn1.Name = "roundedbtn1";
            this.roundedbtn1.Size = new System.Drawing.Size(52, 54);
            this.roundedbtn1.TabIndex = 3;
            this.roundedbtn1.TextColor = System.Drawing.Color.White;
            this.roundedbtn1.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.roundedbtn2);
            this.panel9.Location = new System.Drawing.Point(0, 78);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 82);
            this.panel9.TabIndex = 2;
            // 
            // roundedbtn2
            // 
            this.roundedbtn2.BackColor = System.Drawing.Color.Transparent;
            this.roundedbtn2.BackgroundColor = System.Drawing.Color.Transparent;
            this.roundedbtn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedbtn2.BackgroundImage")));
            this.roundedbtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundedbtn2.BorderColor = System.Drawing.Color.Tomato;
            this.roundedbtn2.BorderRadius = 16;
            this.roundedbtn2.BorderSize = 0;
            this.roundedbtn2.FlatAppearance.BorderSize = 0;
            this.roundedbtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedbtn2.ForeColor = System.Drawing.Color.White;
            this.roundedbtn2.Location = new System.Drawing.Point(64, 11);
            this.roundedbtn2.Name = "roundedbtn2";
            this.roundedbtn2.Size = new System.Drawing.Size(61, 63);
            this.roundedbtn2.TabIndex = 0;
            this.roundedbtn2.TextColor = System.Drawing.Color.White;
            this.roundedbtn2.UseVisualStyleBackColor = false;
            // 
            // roundedbtn4
            // 
            this.roundedbtn4.BackColor = System.Drawing.Color.Gainsboro;
            this.roundedbtn4.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.roundedbtn4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedbtn4.BackgroundImage")));
            this.roundedbtn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundedbtn4.BorderColor = System.Drawing.Color.Tomato;
            this.roundedbtn4.BorderRadius = 16;
            this.roundedbtn4.BorderSize = 0;
            this.roundedbtn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedbtn4.FlatAppearance.BorderSize = 0;
            this.roundedbtn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedbtn4.ForeColor = System.Drawing.Color.White;
            this.roundedbtn4.Location = new System.Drawing.Point(40, 18);
            this.roundedbtn4.Name = "roundedbtn4";
            this.roundedbtn4.Size = new System.Drawing.Size(52, 54);
            this.roundedbtn4.TabIndex = 0;
            this.roundedbtn4.TextColor = System.Drawing.Color.White;
            this.roundedbtn4.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btn_dashboard);
            this.panel3.Location = new System.Drawing.Point(0, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(127, 82);
            this.panel3.TabIndex = 4;
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.SystemColors.Control;
            this.btn_dashboard.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btn_dashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_dashboard.BackgroundImage")));
            this.btn_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_dashboard.BorderColor = System.Drawing.Color.Tomato;
            this.btn_dashboard.BorderRadius = 16;
            this.btn_dashboard.BorderSize = 0;
            this.btn_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_dashboard.Location = new System.Drawing.Point(40, 19);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(52, 54);
            this.btn_dashboard.TabIndex = 0;
            this.btn_dashboard.TextColor = System.Drawing.Color.White;
            this.btn_dashboard.UseVisualStyleBackColor = false;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click_1);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btn_quizActive);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.btn_quiz);
            this.panel4.Location = new System.Drawing.Point(0, 256);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(127, 82);
            this.panel4.TabIndex = 2;
            // 
            // btn_quizActive
            // 
            this.btn_quizActive.BackColor = System.Drawing.SystemColors.Control;
            this.btn_quizActive.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btn_quizActive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_quizActive.BackgroundImage")));
            this.btn_quizActive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_quizActive.BorderColor = System.Drawing.Color.Tomato;
            this.btn_quizActive.BorderRadius = 16;
            this.btn_quizActive.BorderSize = 0;
            this.btn_quizActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quizActive.FlatAppearance.BorderSize = 0;
            this.btn_quizActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quizActive.ForeColor = System.Drawing.Color.White;
            this.btn_quizActive.Location = new System.Drawing.Point(40, 18);
            this.btn_quizActive.Name = "btn_quizActive";
            this.btn_quizActive.Size = new System.Drawing.Size(52, 54);
            this.btn_quizActive.TabIndex = 3;
            this.btn_quizActive.TextColor = System.Drawing.Color.White;
            this.btn_quizActive.UseVisualStyleBackColor = false;
            this.btn_quizActive.Click += new System.EventHandler(this.btn_quizActive_Click_1);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.roundedbtn3);
            this.panel5.Location = new System.Drawing.Point(0, 78);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 82);
            this.panel5.TabIndex = 2;
            // 
            // roundedbtn3
            // 
            this.roundedbtn3.BackColor = System.Drawing.Color.Transparent;
            this.roundedbtn3.BackgroundColor = System.Drawing.Color.Transparent;
            this.roundedbtn3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedbtn3.BackgroundImage")));
            this.roundedbtn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundedbtn3.BorderColor = System.Drawing.Color.Tomato;
            this.roundedbtn3.BorderRadius = 16;
            this.roundedbtn3.BorderSize = 0;
            this.roundedbtn3.FlatAppearance.BorderSize = 0;
            this.roundedbtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedbtn3.ForeColor = System.Drawing.Color.White;
            this.roundedbtn3.Location = new System.Drawing.Point(64, 11);
            this.roundedbtn3.Name = "roundedbtn3";
            this.roundedbtn3.Size = new System.Drawing.Size(61, 63);
            this.roundedbtn3.TabIndex = 0;
            this.roundedbtn3.TextColor = System.Drawing.Color.White;
            this.roundedbtn3.UseVisualStyleBackColor = false;
            // 
            // btn_quiz
            // 
            this.btn_quiz.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_quiz.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.btn_quiz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_quiz.BackgroundImage")));
            this.btn_quiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_quiz.BorderColor = System.Drawing.Color.Tomato;
            this.btn_quiz.BorderRadius = 16;
            this.btn_quiz.BorderSize = 0;
            this.btn_quiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quiz.FlatAppearance.BorderSize = 0;
            this.btn_quiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quiz.ForeColor = System.Drawing.Color.White;
            this.btn_quiz.Location = new System.Drawing.Point(40, 18);
            this.btn_quiz.Name = "btn_quiz";
            this.btn_quiz.Size = new System.Drawing.Size(52, 54);
            this.btn_quiz.TabIndex = 0;
            this.btn_quiz.TextColor = System.Drawing.Color.White;
            this.btn_quiz.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Login_logo_img);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 100);
            this.panel2.TabIndex = 0;
            // 
            // Login_logo_img
            // 
            this.Login_logo_img.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Login_logo_img.BackColor = System.Drawing.Color.Transparent;
            this.Login_logo_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Login_logo_img.Image = ((System.Drawing.Image)(resources.GetObject("Login_logo_img.Image")));
            this.Login_logo_img.Location = new System.Drawing.Point(40, 27);
            this.Login_logo_img.Name = "Login_logo_img";
            this.Login_logo_img.Size = new System.Drawing.Size(52, 71);
            this.Login_logo_img.TabIndex = 1;
            this.Login_logo_img.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.btn_logout);
            this.panel7.Location = new System.Drawing.Point(0, 514);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(127, 82);
            this.panel7.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.roundedbtn5);
            this.panel8.Location = new System.Drawing.Point(0, 78);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 82);
            this.panel8.TabIndex = 2;
            // 
            // roundedbtn5
            // 
            this.roundedbtn5.BackColor = System.Drawing.Color.Transparent;
            this.roundedbtn5.BackgroundColor = System.Drawing.Color.Transparent;
            this.roundedbtn5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedbtn5.BackgroundImage")));
            this.roundedbtn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundedbtn5.BorderColor = System.Drawing.Color.Tomato;
            this.roundedbtn5.BorderRadius = 16;
            this.roundedbtn5.BorderSize = 0;
            this.roundedbtn5.FlatAppearance.BorderSize = 0;
            this.roundedbtn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedbtn5.ForeColor = System.Drawing.Color.White;
            this.roundedbtn5.Location = new System.Drawing.Point(64, 11);
            this.roundedbtn5.Name = "roundedbtn5";
            this.roundedbtn5.Size = new System.Drawing.Size(61, 63);
            this.roundedbtn5.TabIndex = 0;
            this.roundedbtn5.TextColor = System.Drawing.Color.White;
            this.roundedbtn5.UseVisualStyleBackColor = false;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.SystemColors.Control;
            this.btn_logout.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btn_logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_logout.BackgroundImage")));
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_logout.BorderColor = System.Drawing.Color.Tomato;
            this.btn_logout.BorderRadius = 16;
            this.btn_logout.BorderSize = 0;
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(40, 18);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(52, 54);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.TextColor = System.Drawing.Color.White;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click_1);
            // 
            // StudentReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 646);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ScreenPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentReg";
            this.Text = "StudentReg";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StudentReg_Load);
            this.ScreenPanel.ResumeLayout(false);
            this.ScreenPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Login_logo_img)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ScreenPanel;
        private System.Windows.Forms.Label lbl_StudentList;
        private roundedbtn btn_reset;
        private roundedbtn btn_edit;
        private roundedbtn btn_save;
        private System.Windows.Forms.Label lbl_DashHeader;
        private System.Windows.Forms.TextBox addressTb;
        private System.Windows.Forms.TextBox PhoneTb;
        private System.Windows.Forms.TextBox CAgeTb;
        private System.Windows.Forms.TextBox PasswordTb;
        private System.Windows.Forms.TextBox CNameTb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel11;
        private roundedbtn roundedbtn6;
        private System.Windows.Forms.Panel panel12;
        private roundedbtn roundedbtn7;
        private roundedbtn roundedbtn8;
        private System.Windows.Forms.Panel panel6;
        private roundedbtn roundedbtn1;
        private System.Windows.Forms.Panel panel9;
        private roundedbtn roundedbtn2;
        private roundedbtn roundedbtn4;
        private System.Windows.Forms.Panel panel3;
        private roundedbtn btn_dashboard;
        private System.Windows.Forms.Panel panel4;
        private roundedbtn btn_quizActive;
        private System.Windows.Forms.Panel panel5;
        private roundedbtn roundedbtn3;
        private roundedbtn btn_quiz;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Login_logo_img;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private roundedbtn roundedbtn5;
        private roundedbtn btn_logout;
        private System.Windows.Forms.DataGridView StudentsDGV;
    }
}
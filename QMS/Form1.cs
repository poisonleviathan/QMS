﻿using System;
using System.Windows.Forms;

namespace QMS
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_lg_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Uname_txt_TextChanged(object sender, EventArgs e)
        {


        }

        private void login_pwd_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Uname_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedbtn1_Click(object sender, EventArgs e)
        {
            frm_Dashboard dashboard= new frm_Dashboard();
            dashboard.ShowDialog();
        }
    }
}

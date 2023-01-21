using System;
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
            studnet_panel.Visible = false;
            Teacher_panel.Visible = false;
            lbl_wrong_cred.Visible = false;
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
           
        }

        private void label1_Click_2(object sender, EventArgs e)
        {
           
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Uname_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_reg_Click(object sender, EventArgs e)
        {

        }

        private void lbl_pwd_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_select_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txt_select_user.SelectedIndex == 0) {
                Teacher_panel.Visible = true;
                studnet_panel.Visible = false;

            }
            else if (txt_select_user.SelectedIndex != 0)
            {
                
                studnet_panel.Visible = true;
            }
        }

        private void btn_studentLogin_Click(object sender, EventArgs e)
        {
            if (txt_StudentNo.Text == "3998" && txt_Stpwd.Text == "st123")
            {
                lbl_wrong_cred_st.Visible = false;
                this.Hide();
            }
            else
            {
                lbl_wrong_cred_st.Visible = true;
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (Uname_txt.Text=="admin" && Pwd_txt.Text=="admin123") {
            lbl_wrong_cred.Visible = false;
                this.Hide();
            }
            else
            {
                lbl_wrong_cred.Visible= true;
            }
        }

        private void lbl_Type_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.Design;
using System.Windows.Forms;

namespace QMS
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-3IN531N\SQLEXPRESS;Initial Catalog=QMS_DB;Integrated Security=True;Pooling=False");
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
         
                if (txt_select_user.SelectedIndex == 0)
                {
                    Teacher_panel.Visible = true;
                    studnet_panel.Visible = false;
                    pnl_greeting.Visible = false;

            }
                else if (txt_select_user.SelectedIndex != 0)
                {
                    studnet_panel.Visible = true;   
                    Teacher_panel.Visible = false;
                     pnl_greeting.Visible = false;

            }

            
            
            
        }
        public static string CandName = "";
        private void btn_studentLogin_Click(object sender, EventArgs e)
        {
            
            if (txt_StudentNo.Text == "" && txt_Stpwd.Text == "")
            {
                MessageBox.Show("Enter Candidate Name and Password");
                
                    
               
               
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count (*) from StudentTable where CPass='"+ txt_Stpwd.Text +"' and CName='"+ txt_StudentNo.Text+"'",Con);
               DataTable dt= new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() =="1")
                {
                    CandName = txt_StudentNo.Text;
                    Exam studentQuiz = new Exam();
                    studentQuiz.Show();
                    this.Hide();
                    Con.Close();
                 
                }
                else
                {
                    MessageBox.Show("Wrong Name and Password");
                }
                Con.Close();

                
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

          
                admin_dashboard admin = new admin_dashboard();
                admin.Show();
                this.Hide();
            }
            else
            {
                
            }
        }

        private void lbl_Type_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_Stpwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_StudentNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_wrong_cred_st_Click(object sender, EventArgs e)
        {

        }

        private void Uname_txt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void studnet_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

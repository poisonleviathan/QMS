using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QMS
{
    public partial class frm_Dashboard : Form
    {
        
        public frm_Dashboard()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_dashboard_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_quiz_Click(object sender, EventArgs e)
        {

            panel_quiz.Visible = true;
            btn_quizActive.Visible = true;

        }

        private void btn_adminPanel_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login_form login = new Login_form();
            login.ShowDialog();
            Close();
        }

        private void frm_Dashboard_Load(object sender, EventArgs e)
        {
           panel_quiz.Visible= false;
           btn_quizActive.Visible= false;
            
        }

        private void btn_studentLogin_Click(object sender, EventArgs e)
        {

        }

        private void roundedbtn2_Click(object sender, EventArgs e)
        {

        }
    }
}

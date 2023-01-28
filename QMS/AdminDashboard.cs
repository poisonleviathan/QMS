using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace QMS
{
    public partial class admin_dashboard : Form
    {
        
        public admin_dashboard()
        {
            InitializeComponent();
            GetSubjects();  
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-3IN531N\SQLEXPRESS;Initial Catalog=QMS_DB;Integrated Security=True;Pooling=False");
       

        private void GetSubjects()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select SName from SubjectTable ",Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt =new DataTable();
            dt.Columns.Add("Sname",typeof (string));
            dt.Load(rdr);
            SubjectCb.ValueMember = "SName";
            SubjectCb.DataSource = dt;
            Con.Close();
        }
        private void DisplayQuestions()
        {
            Con.Open();
            string Query = "select * from QuestionTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            QuestionDGV.DataSource = ds.Tables[0];

            Con.Close();
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
           
            
        }

        private void btn_studentLogin_Click(object sender, EventArgs e)
        {

        }

        private void roundedbtn2_Click(object sender, EventArgs e)
        {

        }

        private void btn_quizActive_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Qustion2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void btn_quizActive_Click_1(object sender, EventArgs e)
        {
            Subjects Obj = new Subjects();
            Obj.Show();
            this.Hide();
        }

        private void roundedbtn1_Click(object sender, EventArgs e)
        {
            StudentReg Obj = new StudentReg();
            Obj.Show();
            this.Hide();
        }

        private void roundedbtn6_Click(object sender, EventArgs e)
        {
            Quiz Obj = new Quiz();
            Obj.Show();
            this.Hide();
        }

        private void btn_logout_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Reset()
        {
            txt_Qustion1.Text = "";
            txt_Option1.Text = "";
            txt_Option2.Text = ""; 
            txt_Option3.Text = ""; 
            txt_Option4.Text = "";
            txt_Option5.Text = "";
        }
        private void btn_save_Click(object sender, EventArgs e)
        {

            if (txt_Qustion1.Text == "" || txt_Option1.Text == "" || txt_Option2.Text == "" || txt_Option3.Text == "" || txt_Option4.Text == "" || txt_Option5.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into QuestionTable  (QDesc,Q01,Q02,Q03,Q04,QA,QS) values (@Qd,@01,@02,@03,@04,@Qan,@Qsu)", Con);
                    cmd.Parameters.AddWithValue("@Qd", txt_Qustion1.Text);
                    cmd.Parameters.AddWithValue("@01", txt_Option1.Text);
                    cmd.Parameters.AddWithValue("@02", txt_Option2.Text);
                    cmd.Parameters.AddWithValue("@03", txt_Option3.Text);
                    cmd.Parameters.AddWithValue("@04", txt_Option4.Text);
                    cmd.Parameters.AddWithValue("@Qan", txt_Option5.Text);
                    cmd.Parameters.AddWithValue("@Qsu", SubjectCb.SelectedValue.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Question Added");
                    Con.Close();
                    Reset();
                    DisplayQuestions();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void txt_Qustion1_Enter(object sender, EventArgs e)
        {
            if (txt_Qustion1.Text == "Question ")
            {
                txt_Qustion1.Text = "";
                txt_Qustion1.ForeColor = Color.FromArgb(71, 2, 108);
            }
        }

        private void txt_Qustion1_Leave(object sender, EventArgs e)
        {
            if (txt_Qustion1.Text == "")
            {
                txt_Qustion1.Text = "Question ";
                txt_Qustion1.ForeColor = Color.FromArgb(71, 2, 108);
            }
        }

        private void txt_Option1_Enter(object sender, EventArgs e)
        {
            if (txt_Option1.Text == "Option 1")
            {
                txt_Option1.Text = "";
                txt_Option1.ForeColor = Color.FromArgb(71, 2, 108);
            }
        }

        private void txt_Option1_Leave(object sender, EventArgs e)
        {
            if (txt_Option1.Text == "")
            {
                txt_Option1.Text = "Option 1";
                txt_Option1.ForeColor = Color.FromArgb(71, 2, 108);
            }
        }

    

        private void txt_Option2_Enter(object sender, EventArgs e)
        {
            if (txt_Option2.Text == " Option 2")
            {
                txt_Option2.Text = "";
                txt_Option2.ForeColor = Color.FromArgb(71, 2, 108);
            }
        }

        private void txt_Option2_Leave(object sender, EventArgs e)
        {
            if (txt_Option2.Text == "")
            {
                txt_Option2.Text = " Option 2";
                txt_Option2.ForeColor = Color.FromArgb(71, 2, 108);
            }
        }

        private void txt_Option3_Enter(object sender, EventArgs e)
        {
            if (txt_Option3.Text == "Option 3")
            {
                txt_Option3.Text = "";
                txt_Option3.ForeColor = Color.FromArgb(71, 2, 108);
            }

        }

        private void txt_Option3_Leave(object sender, EventArgs e)
        {
            if (txt_Option3.Text == "")
            {
                txt_Option3.Text = "Option 3";
                txt_Option3.ForeColor = Color.FromArgb(71, 2, 108);
            }
        }

        private void txt_Option4_Enter(object sender, EventArgs e)
        {
            if (txt_Option4.Text == "Option 4")
            {
                txt_Option4.Text = "";
                txt_Option4.ForeColor = Color.FromArgb(71, 2, 108);
            }
        }

        private void txt_Option4_Leave(object sender, EventArgs e)
        {
            if (txt_Option4.Text == "")
            {
                txt_Option4.Text = "Option 4";
                txt_Option4.ForeColor = Color.FromArgb(71, 2, 108);
            }
        }

        private void txt_Option5_Enter(object sender, EventArgs e)
        {
            if (txt_Option5.Text == "Answer")
            {
                txt_Option5.Text = "";
                txt_Option5.ForeColor = Color.FromArgb(71, 2, 108);
            }
        }

        private void txt_Option5_Leave(object sender, EventArgs e)
        {
            if (txt_Option5.Text == "")
            {
                txt_Option5.Text = "Answer";
                txt_Option5.ForeColor = Color.FromArgb(71, 2, 108);
            }
        }
    }
}

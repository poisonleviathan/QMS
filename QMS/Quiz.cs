using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QMS
{
    public partial class Quiz : Form
    {
        public Quiz()
        {
            InitializeComponent();
            FetchQuestions();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-3IN531N\SQLEXPRESS;Initial Catalog=QMS_DB;Integrated Security=True;Pooling=False");
        private void btn_dashboard_Click(object sender, EventArgs e)
        {

        }
        string A1, A2, A3, A4, A5, A6, A7, A8, A9, A10;
        private int RandomQuestionGen() 
        { 
        Random rd =new Random();
            int x = rd.Next(1, 17);
            return x;
        }
        private void FetchQuestions()
        {
            try
            {
                int Qnum =RandomQuestionGen();
                Con.Open();
                string Query = "select * from QuestionTable where QId "+Qnum+"";
                SqlCommand cmd =new SqlCommand(Query,Con);
                DataTable dt =new DataTable();
                SqlDataAdapter sda =new SqlDataAdapter(cmd);
                sda.Fill(dt);
               
                foreach(DataRow dr in dt.Rows)
                {
                    Q1.Text = dr["QDesc"].ToString();
                    Q101.Text = dr["Q01"].ToString();
                    Q102.Text = dr["Q02"].ToString();
                    Q103.Text = dr["Q03"].ToString();
                    Q104.Text = dr["Q04"].ToString();
                    A1 = dr["QA"].ToString();

                }
                Con.Close();
            }
            catch (Exception Ex) 
            {
                    
            }
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            
            this.subjectTableTableAdapter.Fill(this.qMS_DBDataSet.SubjectTable);

        }

        private void btn_dashboard_Click_1(object sender, EventArgs e)
        {
            admin_dashboard Obj = new admin_dashboard();

            Obj.Show();
            this.Hide();
        }

        private void btn_quizActive_Click(object sender, EventArgs e)
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

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Q701_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

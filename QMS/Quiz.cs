﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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

        private int GenerateRand()
        {
            Random rd = new Random();
            int x = rd.Next(10, 17);
          
            return x;
        }

        int Chrono = 300;
        int Count = 0 ;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                Chrono -= 1;
                Count += 1;
                TimingBar.Value = Count;
                lbl_time.Text = "" + Chrono;

                if (Chrono == 0)
                {

                    timer1.Stop();
                    MessageBox.Show("Time Is Over");
                    this.Hide();
                    CompleteScreen Obj = new CompleteScreen();
                    Obj.Show();



                }
            }
            catch
            {

            }
        }

        private void TimingBar_Click(object sender, EventArgs e)
        {

        }
        int score;
        string[] Ua = new string[10];

        int Score = 0;

        private void checkQ1()
        {
            if (Q101.Checked)
            {
                Ua[0] = "";
                Ua[0] = Q101.Text;
            }
            else if (Q102.Checked)
            {
                Ua[0] = "";
                Ua[0] = Q102.Text;
            }
            else if (Q103.Checked)
            {
                Ua[0] = "";
                Ua[0] = Q103.Text;
            }
            else if (Q104.Checked)
            {
                Ua[0] = "";
                Ua[0] = Q104.Text;
            }
            if (Ua[0] == A1)
            {
                Score = Score + 1;
            }
            else
            {
                Score = Score;
            }
        }

        private void checkQ2()
        {
            if (Q201.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q201.Text;
            }
            else if (Q202.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q202.Text;
            }
            else if (Q203.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q203.Text;
            }
            else if (Q204.Checked)
            {
                Ua[1] = "";
                Ua[1] = Q204.Text;
            }
            if (Ua[1] == A2)
            {
                Score = Score + 1;
            }
            else
            {
                Score = Score;
            }
        }

        private void checkQ3()
        {
            if (Q301.Checked)
            {
                Ua[2] = "";
                Ua[2] = Q301.Text;
            }
            else if (Q302.Checked)
            {
                Ua[2] = "";
                Ua[2] = Q302.Text;
            }
            else if (Q303.Checked)
            {
                Ua[2] = "";
                Ua[2] = Q303.Text;
            }
            else if (Q304.Checked)
            {
                Ua[2] = "";
                Ua[2] = Q304.Text;
            }
            if (Ua[2] == A3)
            {
                Score = Score + 1;
            }
            else
            {
                Score = Score;
            }
        }

        private void checkQ4()
        {
            if (Q401.Checked)
            {
                Ua[3] = "";
                Ua[3] = Q401.Text;
            }
            else if (Q402.Checked)
            {
                Ua[3] = "";
                Ua[3] = Q402.Text;
            }
            else if (Q403.Checked)
            {
                Ua[3] = "";
                Ua[3] = Q403.Text;
            }
            else if (Q404.Checked)
            {
                Ua[3] = "";
                Ua[3] = Q404.Text;
            }

            if (Ua[3] == A4)
            {
                Score = Score + 1;
            }
            else
            {
                Score = Score;
            }
        }

        private void checkQ5()
        {
            if (Q501.Checked)
            {
                Ua[4] = "";
                Ua[4] = Q501.Text;
            }
            else if (Q502.Checked)
            {
                Ua[4] = "";
                Ua[4] = Q502.Text;
            }
            else if (Q503.Checked)
            {
                Ua[4] = "";
                Ua[4] = Q503.Text;
            }
            else if (Q504.Checked)
            {
                Ua[4] = "";
                Ua[4] = Q504.Text;
            }

            if (Ua[4] == A5)
            {
                Score = Score + 1;
            }
            else
            {
                Score = Score;
            }
        }

        private void checkQ6()
        {
            if (Q601.Checked)
            {
                Ua[5] = "";
                Ua[5] = Q601.Text;
            }
            else if (Q602.Checked)
            {
                Ua[5] = "";
                Ua[5] = Q602.Text;
            }
            else if (Q603.Checked)
            {
                Ua[5] = "";
                Ua[5] = Q603.Text;
            }
            else if (Q604.Checked)
            {
                Ua[5] = "";
                Ua[5] = Q604.Text;
            }

            if (Ua[5] == A6)
            {
                Score = Score + 1;
            }
            else
            {
                Score = Score;
            }
        }

        private void checkQ7()
        {
            if (Q701.Checked)
            {
                Ua[6] = "";
                Ua[6] = Q701.Text;
            }
            else if (Q702.Checked)
            {
                Ua[6] = "";
                Ua[6] = Q702.Text;
            }
            else if (Q703.Checked)
            {
                Ua[6] = "";
                Ua[6] = Q703.Text;
            }
            else if (Q704.Checked)
            {
                Ua[6] = "";
                Ua[6] = Q404.Text;
            }

            if (Ua[6] == A7)
            {
                Score = Score + 1;
            }
            else
            {
                Score = Score;
            }
        }

        private void checkQ8()
        {
            if (Q801.Checked)
            {
                Ua[7] = "";
                Ua[7] = Q801.Text;
            }
            else if (Q802.Checked)
            {
                Ua[7] = "";
                Ua[7] = Q802.Text;
            }
            else if (Q803.Checked)
            {
                Ua[7] = "";
                Ua[7] = Q803.Text;
            }
            else if (Q804.Checked)
            {
                Ua[7] = "";
                Ua[7] = Q804.Text;
            }

            if (Ua[7] ==A8)
            {
                Score = Score + 1;
            }
            else
            {
                Score = Score;
            }
        }

        private void checkQ9()
        {
            if (Q901.Checked)
            {
                Ua[8] = "";
                Ua[8] = Q901.Text;
            }
            else if (Q902.Checked)
            {
                Ua[8] = "";
                Ua[8] = Q902.Text;
            }
            else if (Q903.Checked)
            {
                Ua[8] = "";
                Ua[8] = Q903.Text;
            }
            else if (Q904.Checked)
            {
                Ua[8] = "";
                Ua[8] = Q904.Text;
            }

            if (Ua[8] == A9)
            {
                Score = Score + 1;
            }
            else
            {
                Score = Score;
            }
        }

        private void checkQ10()
        {
            if (Q1001.Checked)
            {
                Ua[9] = "";
                Ua[9] = Q1001.Text;
            }
            else if (Q1002.Checked)
            {
                Ua[9] = "";
                Ua[9] = Q1002.Text;
            }
            else if (Q1003.Checked)
            {
                Ua[9] = "";
                Ua[9] = Q1003.Text;
            }
            else if (Q1004.Checked)
            {
                Ua[9] = "";
                Ua[9] = Q1004.Text;
            }

            if (Ua[9] == A10)
            {
                Score = Score + 1;
            }
            else
            {
                Score = Score;
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            Score = 0;
            checkQ1();
            checkQ2();
            checkQ3();
            checkQ4();
            checkQ5();
            checkQ6();
            checkQ7();
            checkQ8();
            checkQ9();
            checkQ10();

            MessageBox.Show("" + Score);
           
        }

        private void lbl_time_Click(object sender, EventArgs e)
        {

        }

        private void lbl_DashHeader_Click(object sender, EventArgs e)
        {

        }

        private void Q2_Enter(object sender, EventArgs e)
        {

        }

        private void Q3_Enter(object sender, EventArgs e)
        {

        }

        private void Q4_Enter(object sender, EventArgs e)
        {

        }

        private void Q5_Enter(object sender, EventArgs e)
        {

        }

        private void Q6_Enter(object sender, EventArgs e)
        {

        }

        private void Q7_Enter(object sender, EventArgs e)
        {

        }

        private void Q8_Enter(object sender, EventArgs e)
        {

        }

        private void Q9_Enter(object sender, EventArgs e)
        {

        }

        private void Q10_Enter(object sender, EventArgs e)
        {

        }

        private void FetchQuestions()
        {
            try
            {
                int Qnum = GenerateRand();
                //multirandom();
                Con.Open();
                string Query = "select * from QuestionTable where QId=10" ;
                SqlCommand cmd = new SqlCommand(Query, Con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Q1.Text = dr["QDesc"].ToString();
                    Q101.Text = dr["Q01"].ToString();
                    Q102.Text = dr["Q02"].ToString();
                    Q103.Text = dr["Q03"].ToString();
                    Q104.Text = dr["Q04"].ToString();
                    A1 = dr["QA"].ToString();

                }

                string Query1 = "select * from QuestionTable where QId=11";
                 cmd = new SqlCommand(Query1, Con);
                 dt = new DataTable();
                 sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Q2.Text = dr["QDesc"].ToString();
                    Q201.Text = dr["Q01"].ToString();
                    Q202.Text = dr["Q02"].ToString();
                    Q203.Text = dr["Q03"].ToString();
                    Q204.Text = dr["Q04"].ToString();
                    A2 = dr["QA"].ToString();

                }

                string Query2 = "select * from QuestionTable where QId=12";
                cmd = new SqlCommand(Query2, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Q3.Text = dr["QDesc"].ToString();
                    Q301.Text = dr["Q01"].ToString();
                    Q302.Text = dr["Q02"].ToString();
                    Q303.Text = dr["Q03"].ToString();
                    Q304.Text = dr["Q04"].ToString();
                    A3 = dr["QA"].ToString();

                }

                string Query3 = "select * from QuestionTable where QId=13";
                cmd = new SqlCommand(Query3, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Q4.Text = dr["QDesc"].ToString();
                    Q401.Text = dr["Q01"].ToString();
                    Q402.Text = dr["Q02"].ToString();
                    Q403.Text = dr["Q03"].ToString();
                    Q404.Text = dr["Q04"].ToString();
                    A4 = dr["QA"].ToString();

                }

                string Query4 = "select * from QuestionTable where QId=14";
                cmd = new SqlCommand(Query4, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Q5.Text = dr["QDesc"].ToString();
                    Q501.Text = dr["Q01"].ToString();
                    Q502.Text = dr["Q02"].ToString();
                    Q503.Text = dr["Q03"].ToString();
                    Q504.Text = dr["Q04"].ToString();
                    A5 = dr["QA"].ToString();

                }
                string Query5= "select * from QuestionTable where QId=15";
                cmd = new SqlCommand(Query5, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Q6.Text = dr["QDesc"].ToString();
                    Q601.Text = dr["Q01"].ToString();
                    Q602.Text = dr["Q02"].ToString();
                    Q603.Text = dr["Q03"].ToString();
                    Q604.Text = dr["Q04"].ToString();
                    A6 = dr["QA"].ToString();

                }
                string Query6 = "select * from QuestionTable where QId=16";
                cmd = new SqlCommand(Query6, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Q7.Text = dr["QDesc"].ToString();
                    Q701.Text = dr["Q01"].ToString();
                    Q702.Text = dr["Q02"].ToString();
                    Q703.Text = dr["Q03"].ToString();
                    Q704.Text = dr["Q04"].ToString();
                    A7 = dr["QA"].ToString();

                }

                string Query7 = "select * from QuestionTable where QId=17";
                cmd = new SqlCommand(Query7, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Q8.Text = dr["QDesc"].ToString();
                    Q801.Text = dr["Q01"].ToString();
                    Q802.Text = dr["Q02"].ToString();
                    Q803.Text = dr["Q03"].ToString();
                    Q804.Text = dr["Q04"].ToString();
                    A8 = dr["QA"].ToString();

                }
                string Query8 = "select * from QuestionTable where QId=18";
                cmd = new SqlCommand(Query8, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Q9.Text = dr["QDesc"].ToString();
                    Q901.Text = dr["Q01"].ToString();
                    Q902.Text = dr["Q02"].ToString();
                    Q903.Text = dr["Q03"].ToString();
                    Q904.Text = dr["Q04"].ToString();
                    A9 = dr["QA"].ToString();

                }
                string Query9 = "select * from QuestionTable where QId=19";
                cmd = new SqlCommand(Query9, Con);
                dt = new DataTable();
                sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Q10.Text = dr["QDesc"].ToString();
                    Q1001.Text = dr["Q01"].ToString();
                    Q1002.Text = dr["Q02"].ToString();
                    Q1003.Text = dr["Q03"].ToString();
                    Q1004.Text = dr["Q04"].ToString();
                    A10 = dr["QA"].ToString();

                }
               

                Con.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void Q1_Enter(object sender, EventArgs e)
        {

        }

       



        private void Quiz_Load(object sender, EventArgs e)
        {
            timer1.Start();
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

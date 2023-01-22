using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QMS
{
    public partial class StudentReg : Form
    {
        public StudentReg()
        {
            InitializeComponent();
           
            DisplayStudents();
        }
        private void Reset()
        {
            CNameTb.Text = "";
            CAgeTb.Text = "";
            PhoneTb.Text = "";
            addressTb.Text = "";
            PasswordTb.Text="";
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-3IN531N\SQLEXPRESS;Initial Catalog=QMS_DB;Integrated Security=True;Pooling=False");
      

      
        private void ScreenPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void lbl_StudentList_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }
        int Key = 0;
        private void DisplayStudents()
        {
            Con.Open();
            string Query = "select * from StudentTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StudentsDGV.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if(CNameTb.Text == "" || CAgeTb.Text==""|| PasswordTb.Text =="" || addressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    int score = 0;
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into StudentTable  (CName,CAge,CPass,CScore,CAdd,CPhone) values (@CN,@CA,@CP,@CS,@CAd,@Cph)", Con);
                    cmd.Parameters.AddWithValue("@CN", CNameTb.Text);
                    cmd.Parameters.AddWithValue("@CA", CAgeTb.Text);
                    cmd.Parameters.AddWithValue("@CP", PasswordTb.Text);
                    cmd.Parameters.AddWithValue("@CS", score);
                    cmd.Parameters.AddWithValue("@CAd", addressTb.Text);
                    cmd.Parameters.AddWithValue("@Cph", PhoneTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Saved");
                    Con.Close();
                    Reset();
                    DisplayStudents();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
               
            }
        }

        private void lbl_DashHeader_Click(object sender, EventArgs e)
        {

        }

        private void txt_StAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_StPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_StAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_StPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_StName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedbtn1_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedbtn2_Click(object sender, EventArgs e)
        {

        }

        private void roundedbtn4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_quizActive_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedbtn3_Click(object sender, EventArgs e)
        {

        }

        private void btn_quiz_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_logo_img_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundedbtn5_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {

        }

        private void StudentReg_Load(object sender, EventArgs e)
        {

        }

        private void StudentsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentsDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            CNameTb.Text = StudentsDGV.SelectedRows[0].Cells[1].Value.ToString();
            CAgeTb.Text = StudentsDGV.SelectedRows[0].Cells[2].Value.ToString();
            PhoneTb.Text = StudentsDGV.SelectedRows[0].Cells[3].Value.ToString();
            addressTb.Text = StudentsDGV.SelectedRows[0].Cells[5].Value.ToString();
            PasswordTb.Text = StudentsDGV.SelectedRows[0].Cells[6].Value.ToString();
         
            if (CNameTb.Text == "")
            {
                Key = 0;
            }else
            {
                Key = Convert.ToInt32(StudentsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}

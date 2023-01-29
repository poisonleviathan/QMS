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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace QMS
{
    public partial class Subjects : Form
    {
        public Subjects()
        {
            InitializeComponent();
            DisplaySubjects();
        }
        int Key = 0;
        private void Reset()
        {
            SNameTb.Text = "";
            Key = 0;

        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-3IN531N\SQLEXPRESS;Initial Catalog=QMS_DB;Integrated Security=True;Pooling=False");
        private void DisplaySubjects()
        {
            Con.Open();
            string Query = "select * from SubjectTable";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SubjectsDGV.DataSource = ds.Tables[0];

            Con.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (SNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update SubjectTable  set SName=@SN where SId=@SKey", Con);
                    cmd.Parameters.AddWithValue("@Sn", SNameTb.Text);
                    cmd.Parameters.AddWithValue("@SKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject Updated");
                    Con.Close();
                    Reset();
                    DisplaySubjects();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (SNameTb.Text=="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into SubjectTable  (SName) values (@Sn)", Con);
                    cmd.Parameters.AddWithValue("@Sn", SNameTb.Text);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject Saved");
                    Con.Close();
                    Reset();
                    DisplaySubjects();
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

        private void SNameTb_TextChanged(object sender, EventArgs e)
        {

        }
        private void SubjectsDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            SNameTb.Text = SubjectsDGV.SelectedRows[0].Cells[1].Value.ToString();
            if (SNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Key = Convert.ToInt32(SubjectsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void SNameTb_Enter(object sender, EventArgs e)
        {
            if (SNameTb.Text == "Subject Name")
            {
                SNameTb.Text = "";
                SNameTb.ForeColor = Color.FromArgb(71, 2, 108);
            }
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            admin_dashboard Obj =new admin_dashboard();
           
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

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login_form Obj = new Login_form();
            Obj.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {

        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qMS_DBDataSet.SubjectTable' table. You can move, or remove it, as needed.
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
    }
}

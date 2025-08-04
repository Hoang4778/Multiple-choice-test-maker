using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCuoiKy.Controller;
using DoAnCuoiKy.Model;

namespace DoAnCuoiKy.View
{
    public partial class StudentWindow : Form
    {
        private int _userId;
        private bool isLoggedOutConfirmed = false;

        private void centerLabel(Label lbl)
        {
            lbl.Left = (lbl.Parent.ClientSize.Width - lbl.Width) / 2;
        }

        public void loadEnrolledClasses()
        {
            gridViewStudentClasses.Rows.Clear();
            ClassController classController = new ClassController();

            List<EnrolledClass> enrolledClasses = classController.getEnrolledClasses(_userId);

            if (enrolledClasses.Count > 0)
            {
                foreach (var _class in enrolledClasses)
                {
                    int newRowIdx = gridViewStudentClasses.Rows.Add();
                    DataGridViewRow newRow = gridViewStudentClasses.Rows[newRowIdx];

                    newRow.Cells["id"].Value = _class.classId;
                    newRow.Cells["name"].Value = _class.name;
                    newRow.Cells["description"].Value = _class.description;
                    newRow.Cells["startDate"].Value = _class.startDate.ToString("MMMM dd, yyyy");
                    newRow.Cells["endDate"].Value = _class.endDate.ToString("MMMM dd, yyyy");
                    newRow.Cells["finalGrade"].Value = _class.finalGrade == -1m ? "Not graded" : _class.finalGrade.ToString();
                }
                gridViewStudentClasses.ClearSelection();
            }
        }

        public StudentWindow(int userId, string userName)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            _userId = userId;
            lblDashboardTitle.Text = $"Hello, {userName}!";
            centerLabel(lblDashboardTitle);
        }

        private void StudentWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !isLoggedOutConfirmed)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to close?", "Logout confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.OpenForms["LoginForm"]?.Show();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                isLoggedOutConfirmed = true;
                Application.OpenForms["LoginForm"]?.Show();
                this.Close();
            }
        }

        private void StudentWindow_Load(object sender, EventArgs e)
        {
            loadEnrolledClasses();
        }

        private void btnEnrollClass_Click(object sender, EventArgs e)
        {
            ClassEnrollForm classEnrollForm = new ClassEnrollForm(_userId, this);
            classEnrollForm.Show();
            this.Hide();
        }

        private void btnCheckExams_Click(object sender, EventArgs e)
        {
            if (gridViewStudentClasses.SelectedRows.Count > 0)
            {
                int classId = (int)gridViewStudentClasses.SelectedRows[0].Cells["id"].Value;
                string className = gridViewStudentClasses.SelectedRows[0].Cells["name"].Value.ToString();
                string classDesc = gridViewStudentClasses.SelectedRows[0].Cells["description"].Value.ToString();
                ContestantWindow contestantWindow = new ContestantWindow(classId, className, classDesc, _userId);
                contestantWindow.Show();
                this.Hide();
            }
            else
            {
                DialogResult result = MessageBox.Show("Please choose one class to check the exams", "Class not chosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

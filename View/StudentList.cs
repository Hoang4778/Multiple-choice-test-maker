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
    public partial class StudentList : Form
    {
        private int _classId;
        private string _className;
        private bool isCloseConfirmed;
        public AdminWindow2 _classWindow;

        private void centerLabel(Label lbl)
        {
            lbl.Left = (lbl.Parent.ClientSize.Width - lbl.Width) / 2;
        }

        private void loadStudentList()
        {
            gridViewStudents.Rows.Clear();

            ClassController classController = new ClassController();
            List<Student> students = classController.getStudentsByClass(_classId);

            if (students.Count > 0)
            {
                foreach (var student in students)
                {
                    int newRowIdx = gridViewStudents.Rows.Add();
                    DataGridViewRow newRow = gridViewStudents.Rows[newRowIdx];

                    newRow.Cells["id"].Value = student.id;
                    newRow.Cells["firstName"].Value = student.firstName;
                    newRow.Cells["lastName"].Value = student.lastName;
                    newRow.Cells["dateOfBirth"].Value = student.dateOfBirth.ToString("MMMM dd, yyyy");
                    newRow.Cells["gender"].Value = student.gender;
                    newRow.Cells["phoneNumber"].Value = student.phoneNumber;
                    newRow.Cells["email"].Value = student.email;
                    newRow.Cells["averageGrade"].Value = student.averageGrade == -1m ? "Not graded" : student.averageGrade.ToString();
                }
                gridViewStudents.ClearSelection();
            }
        }

        public StudentList(int classId, string className, AdminWindow2 classWindow)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            
            _classId = classId;
            _className = className;
            _classWindow = classWindow;

            this.Text = $"Class {_className}";
            lblClassName.Text = $"Class {_className}";
            centerLabel(lblClassName);
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            loadStudentList();
        }

        private void StudentList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !isCloseConfirmed)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to close?", "Close confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _classWindow.Show();
                    this.Hide();
                }
                else
                {
                    e.Cancel = true;
                }
            }

        }

        private void btnViewGraph_Click(object sender, EventArgs e)
        {
            ReportStudentGradeByClass reportStudentGradeByClass = new ReportStudentGradeByClass(_classId, _className, this);
            
            reportStudentGradeByClass.Show();
            this.Hide();
        }
    }
}

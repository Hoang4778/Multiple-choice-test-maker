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
    public partial class AdminWindow : Form
    {
        private int _classId;
        private bool isAdminLoggedOutConfirmed = false;

        private void centerLabel(Label lbl)
        {
            lbl.Left = (lbl.Parent.ClientSize.Width - lbl.Width) / 2;
        }
        
        public AdminWindow(int classId, string className)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            _classId = classId;
            this.Text = className;
            lblAdminDashboardTitle.Text = $"Exams for {className}";
            centerLabel(lblAdminDashboardTitle);
        }

        public void loadExamsByClass()
        {
            gridViewAllTests.Rows.Clear();
            ExamController examController = new ExamController();

            List<Exam> newExams = examController.getExamsByClass(_classId);
            if (newExams.Count > 0)
            {
                foreach (var newExam in newExams)
                {
                    int newRowIdx = gridViewAllTests.Rows.Add();
                    DataGridViewRow newRow = gridViewAllTests.Rows[newRowIdx];

                    newRow.Cells["id"].Value = newExam.id;
                    newRow.Cells["title"].Value = newExam.title;
                    newRow.Cells["description"].Value = newExam.description;
                    newRow.Cells["examDate"].Value = newExam.examDate.ToString("MMMM dd, yyyy");
                    newRow.Cells["startTime"].Value = newExam.startTime.ToString(@"hh\:mm");
                    newRow.Cells["duration"].Value = newExam.duration;
                    newRow.Cells["questionAmount"].Value = newExam.questionAmount;
                    newRow.Cells["maxScore"].Value = newExam.maxScore;
                }
            }
        }

        private void AdminWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !isAdminLoggedOutConfirmed)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to close?", "Logout confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.OpenForms["AdminWindow2"]?.Show();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void AdminWindow_Load(object sender, EventArgs e)
        {
            loadExamsByClass();
            gridViewAllTests.ClearSelection();
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            Exam newExam = new Exam();
            AddEditTestForm addEditTestForm = new AddEditTestForm(newExam, "add", this, _classId);
            addEditTestForm.Show();
        }

        private void btnEditTest_Click(object sender, EventArgs e)
        {
            Exam examToEdit = new Exam();
            DataGridViewRow selectedRow = gridViewAllTests.SelectedRows[0];

            examToEdit.id = (int)selectedRow.Cells["id"].Value;
            examToEdit.title = selectedRow.Cells["title"].Value.ToString();
            examToEdit.description = selectedRow.Cells["description"].Value.ToString();
            examToEdit.examDate = Convert.ToDateTime(selectedRow.Cells["examDate"].Value);
            examToEdit.startTime = TimeSpan.Parse(selectedRow.Cells["startTime"].Value.ToString());
            examToEdit.duration = (decimal)selectedRow.Cells["duration"].Value;
            examToEdit.questionAmount = (int)selectedRow.Cells["questionAmount"].Value;
            examToEdit.maxScore = (int)selectedRow.Cells["maxScore"].Value;

            AddEditTestForm addEditTestForm = new AddEditTestForm(examToEdit, "edit", this, _classId);
            addEditTestForm.Show();
        }

        private void btnCheckQuestions_Click(object sender, EventArgs e)
        {
            if (gridViewAllTests.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRows = gridViewAllTests.SelectedRows[0];
                var examId = selectedRows.Cells["id"].Value.ToString();
                string examTitle = selectedRows.Cells["title"].Value.ToString();
                string examDesc = selectedRows.Cells["description"].Value.ToString();
                QuestionsByTest questionsByTest = new QuestionsByTest(int.Parse(examId), examTitle, examDesc, this);
                questionsByTest.Show();
                this.Hide();
            } else
            {
                DialogResult result = MessageBox.Show("Please choose one exam to see its questions", "Exam not chosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

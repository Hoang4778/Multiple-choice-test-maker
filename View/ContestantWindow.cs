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
using DoAnCuoiKy.View;

namespace DoAnCuoiKy
{
    public partial class ContestantWindow : Form
    {
        private int _classId;
        private string _className;
        private string _classDesc;
        private int _userId;
        private bool isCloseConfirmed = false;
        private ExamController _examController = new ExamController();

        private void centerLabel(Label lbl)
        {
            lbl.Left = (lbl.Parent.ClientSize.Width - lbl.Width) / 2;
        }

        public ContestantWindow(int classId, string className, string classDesc, int userId)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            _classId = classId;
            _className = className;
            _classDesc = classDesc;
            _userId = userId;

            lblDashboardTitle.Text = className;
            lblDashboardDesc.Text = _classDesc;
            centerLabel(lblDashboardTitle);
            centerLabel(lblDashboardDesc);

            this.Text = className;
        }

        private void ContestantWindow_Load(object sender, EventArgs e)
        {
            List<Exam> allExams = _examController.getStudentExamsByClass(_classId);
            if (allExams.Count > 0)
            {
                foreach (var exam in allExams)
                {
                    int newRowIdx = gridViewExamsByClass.Rows.Add();
                    DataGridViewRow newRow = gridViewExamsByClass.Rows[newRowIdx];

                    newRow.Cells["id"].Value = exam.id;
                    newRow.Cells["title"].Value = exam.title;
                    newRow.Cells["examDate"].Value = exam.examDate.ToString("MMMM dd, yyyy");
                    newRow.Cells["startTime"].Value = exam.startTime.ToString(@"hh\:mm");
                    newRow.Cells["duration"].Value = exam.duration;
                    newRow.Cells["questionAmount"].Value = exam.questionAmount;
                    newRow.Cells["maxScore"].Value = exam.maxScore;
                }
                gridViewExamsByClass.ClearSelection();
            }
        }

        private void ContestantWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !isCloseConfirmed)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to close?", "Close confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.OpenForms["StudentWindow"]?.Show();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            if (gridViewExamsByClass.SelectedRows.Count > 0)
            {
                if (DateTime.TryParseExact(gridViewExamsByClass.SelectedRows[0].Cells["examDate"].Value.ToString(), "MMMM dd, yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime convertedExamDate))
                {
                    if (convertedExamDate.Date > DateTime.Now)
                    {
                        DialogResult result = MessageBox.Show("The exam is not opened yet. Please start on the right date", "Starting exam early", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (convertedExamDate.Date == DateTime.Now)
                    {
                        if (TimeSpan.TryParseExact(gridViewExamsByClass.SelectedRows[0].Cells["startTime"].Value.ToString(), @"hh\:mm", null, out TimeSpan convertedStartTime))
                        {
                            if (convertedStartTime > DateTime.Now.TimeOfDay)
                            {
                                DialogResult result = MessageBox.Show("The exam is not open yet. Please start at the right time.", "Starting exam early", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    else
                    {
                        if (TimeSpan.TryParseExact(gridViewExamsByClass.SelectedRows[0].Cells["startTime"].Value.ToString(), @"hh\:mm", null, out TimeSpan convertedStartTime))
                        {
                            if (convertedStartTime.Hours + 24 < DateTime.Now.TimeOfDay.Hours)
                            {
                                DialogResult result2 = MessageBox.Show("The exam was closed after 24 hours. Better start it on time next time", "Exam already closed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    //else if (convertedExamDate.Date.AddHours(24) < DateTime.Now)
                    //{
                    //    DialogResult result2 = MessageBox.Show("The exam was closed after 24 hours. Better start it on time next time", "Exam already closed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return;
                    //}
                }

                int testId = (int)gridViewExamsByClass.SelectedRows[0].Cells["id"].Value;
                string testTitle = gridViewExamsByClass.SelectedRows[0].Cells["title"].Value.ToString();
                decimal duration = (decimal)gridViewExamsByClass.SelectedRows[0].Cells["duration"].Value;
                int maxScore = (int)gridViewExamsByClass.SelectedRows[0].Cells["maxScore"].Value;

                ExamGrade examGrade = _examController.getGradeByExam(testId, _userId);

                if (examGrade.grade == null)
                {
                    QuestionController questionController = new QuestionController();
                    List<Question> questions = questionController.getQuestionsByTest(testId);

                    if (questions.Count > 0)
                    {
                        DialogResult result = MessageBox.Show("Are you ready to take the test?", "Confirm before begin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            ExamWindow examWindow = new ExamWindow(this, questions, testTitle, testId, _userId, duration, maxScore, _classId);
                            examWindow.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("There is no questions in this exam yet, please try again later.", "No questions for the exam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (examGrade.grade == -2m)
                {
                    DialogResult result = MessageBox.Show("Something went wrong, please try again later.", "Error starting the exam", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult result = MessageBox.Show("You already took this exam. Please click the 'Check grade' button to check the grade.", "Exam already taken", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Please choose one exam to start.", "No exam chosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheckGrade_Click(object sender, EventArgs e)
        {
            if (gridViewExamsByClass.SelectedRows.Count > 0)
            {
                int testId = (int)gridViewExamsByClass.SelectedRows[0].Cells["id"].Value;
                string testTitle = gridViewExamsByClass.SelectedRows[0].Cells["title"].Value.ToString();
                int maxScore = (int)gridViewExamsByClass.SelectedRows[0].Cells["maxScore"].Value;

                ExamGrade examGrade = _examController.getGradeByExam(testId, _userId);
                if (examGrade.grade == null)
                {
                    DialogResult result = MessageBox.Show("You need to take the exam to see your grade.", "Exam not taken", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (examGrade.grade == -2m)
                {
                    DialogResult result = MessageBox.Show("Something went wrong, please try again later.", "Error opening the exam result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ExamResult examResult = new ExamResult(testId, testTitle, maxScore, examGrade.grade, this, examGrade.correctAnswerCount, _userId);
                    examResult.Show();
                    this.Hide();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Please choose one exam to check your grade.", "No exam chosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

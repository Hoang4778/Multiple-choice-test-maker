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
    public partial class AddEditTestForm : Form
    {
        public Exam _currentExam;
        private string _action;
        private bool isCanceledConfirmed = false;
        private AdminWindow _adminWindow;
        private int _classId;

        public AddEditTestForm(Exam currentExam, string action, AdminWindow adminWindow, int classId)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _currentExam = currentExam;
            _action = action;
            _adminWindow = adminWindow;
            _classId = classId;
        }

        private void AddEditTestForm_Load(object sender, EventArgs e)
        {
            if (_action == "edit")
            {
                tbxTestTitle.Text = _currentExam.title;
                richTbxTestDesc.Text = _currentExam.description;
                dpkTestDate.Text = _currentExam.examDate.ToString();
                tpkTestStartTime.Text = _currentExam.startTime.ToString();
                mskdTestDuration.Text = _currentExam.duration >= 100 ? _currentExam.duration.ToString() : $"0{_currentExam.duration.ToString()}";
                mskdTestQuestionAmount.Text = _currentExam.questionAmount >= 100 ? _currentExam.questionAmount.ToString() : $"0{_currentExam.questionAmount.ToString()}";
                mskedTestMaxScore.Text = _currentExam.maxScore >= 100 ? _currentExam.maxScore.ToString() : $"0{_currentExam.maxScore.ToString()}";
            }
        }

        private void btnTestCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel now?", "Cancel editing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                isCanceledConfirmed = true;
                _adminWindow.loadExamsByClass();
                this.Close();
            }
        }

        private void AddEditTestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !isCanceledConfirmed)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to cancel now?", "Cancel editing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    _adminWindow.loadExamsByClass();
                }
            }
        }

        private void btnTestSave_Click(object sender, EventArgs e)
        {
            btnTestSave.Enabled = false;
            tbxTestTitle.Enabled = false;
            richTbxTestDesc.Enabled = false;
            dpkTestDate.Enabled = false;
            tpkTestStartTime.Enabled = false;
            mskdTestDuration.Enabled = false;
            mskdTestQuestionAmount.Enabled = false;
            mskedTestMaxScore.Enabled = false;

            _currentExam.classId = _classId;
            _currentExam.title = String.IsNullOrEmpty(tbxTestTitle.Text.Trim()) ? "Exam title 1" : tbxTestTitle.Text.Trim();
            _currentExam.description = String.IsNullOrEmpty(richTbxTestDesc.Text.Trim()) ? "Exam description 1" : richTbxTestDesc.Text.Trim();
            _currentExam.examDate = dpkTestDate.Value.Date;
            _currentExam.startTime = tpkTestStartTime.Value.TimeOfDay;
            _currentExam.duration = String.IsNullOrEmpty(mskdTestDuration.Text.Trim()) ? 10 : Convert.ToDecimal(mskdTestDuration.Text.Trim());
            _currentExam.questionAmount = String.IsNullOrEmpty(mskdTestQuestionAmount.Text.Trim()) ? 5 : Convert.ToInt32(mskdTestQuestionAmount.Text.Trim());
            _currentExam.maxScore = String.IsNullOrEmpty(mskedTestMaxScore.Text.Trim()) ? 100 : Convert.ToInt32(mskedTestMaxScore.Text.Trim());

            ExamController examController = new ExamController();
            if (_action == "add")
            {
                bool isAddedOkay = examController.addTest(_currentExam);

                if (isAddedOkay)
                {
                    MessageBox.Show("New exam has been added successfully.", "Adding exam successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tbxTestTitle.Clear();
                    richTbxTestDesc.Clear();
                    dpkTestDate.Value = DateTime.Now;
                    tpkTestStartTime.Value = DateTime.Now;
                    mskdTestDuration.Clear();
                    mskdTestQuestionAmount.Clear();
                    mskedTestMaxScore.Clear();
                }
                else
                {
                    MessageBox.Show("Something went wrong, please try again later.", "Failed to add exam", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (_action == "edit")
            {
                bool isEditedOkay = examController.updateTest(_currentExam);

                if (isEditedOkay)
                {
                    MessageBox.Show("The current exam has been edited successfully.", "Editing exam successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Something went wrong, please try again later.", "Failed to edit exam", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            btnTestSave.Enabled = true;
            tbxTestTitle.Enabled = true;
            richTbxTestDesc.Enabled = true;
            dpkTestDate.Enabled = true;
            tpkTestStartTime.Enabled = true;
            mskdTestDuration.Enabled = true;
            mskdTestQuestionAmount.Enabled = true;
            mskedTestMaxScore.Enabled = true;
        }
    }
}

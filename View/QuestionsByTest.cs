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
    public partial class QuestionsByTest : Form
    {
        private int _examId;
        private string _examTitle;
        private string _examDescription;
        private AdminWindow _adminWindow;
        private QuestionController _questionController = new QuestionController();
        private List<Answer> fetchedAnswers = new List<Answer>();

        public QuestionsByTest(int examId, string examTitle, string examDesc, AdminWindow adminWindow)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _examId = examId;
            _examTitle = examTitle;
            _examDescription = examDesc;
            _adminWindow = adminWindow;
        }

        public void fetchQuestionsByTest()
        {
            List<Question> questions = _questionController.getQuestionsByTest(_examId);

            gridViewQuestions.Rows.Clear();
            foreach (Question question in questions)
            {
                int newRowIdx = gridViewQuestions.Rows.Add();
                DataGridViewRow newRow = gridViewQuestions.Rows[newRowIdx];

                newRow.Cells["id"].Value = question.id;
                newRow.Cells["questionContent"].Value = question.content;
            }
            gridViewQuestions.Enabled = true;
            gridViewQuestions.ClearSelection();
        }

        private void resumeToNormal()
        {
            tbxQuestionContent.Enabled = true;
            tbxAnswer1.Enabled = true;
            tbxAnswer2.Enabled = true;
            tbxAnswer3.Enabled = true;
            tbxAnswer4.Enabled = true;
            cbxCorrectAnswer.Enabled = true;
            btnCreateQuestion.Enabled = false;
            btnCancelEditQuestion.Enabled = true;
            btnSaveQuestion.Enabled = true;

            fetchQuestionsByTest();

            if (gridViewQuestions.SelectedRows.Count > 0)
            {
                btnDeleteQuestion.Enabled = true;
            }
            else
            {
                btnDeleteQuestion.Enabled = false;
            }
        }

        private void resumeFromCancel()
        {
            tbxQuestionContent.Clear();
            tbxAnswer1.Clear();
            tbxAnswer2.Clear();
            tbxAnswer3.Clear();
            tbxAnswer4.Clear();
            cbxCorrectAnswer.SelectedItem = null;

            tbxQuestionContent.Enabled = false;
            tbxAnswer1.Enabled = false;
            tbxAnswer2.Enabled = false;
            tbxAnswer3.Enabled = false;
            tbxAnswer4.Enabled = false;
            cbxCorrectAnswer.Enabled = false;
            btnCreateQuestion.Enabled = true;
            btnCancelEditQuestion.Enabled = false;
            btnSaveQuestion.Enabled = false;
            btnDeleteQuestion.Enabled = false;
            fetchQuestionsByTest();
        }

        private void QuestionsByTest_Load(object sender, EventArgs e)
        {
            lblTestTitle.Text = _examTitle;
            lblTestTitle.Left = (this.ClientSize.Width - lblTestTitle.Width) / 2;
            lblTestDesc.Text = _examDescription;
            lblTestDesc.Left = (this.ClientSize.Width - lblTestDesc.Width) / 2;
            fetchQuestionsByTest();
        }

        private void QuestionsByTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to close now?", "Cancel editing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                } else
                {
                    _adminWindow.loadExamsByClass();
                    _adminWindow.Show();
                }
            }
        }

        private void gridViewQuestions_SelectionChanged(object sender, EventArgs e)
        {
            if (gridViewQuestions.SelectedRows.Count > 0)
            {
                if (gridViewQuestions.SelectedRows[0].Cells["questionContent"].Value != null)
                {
                    tbxQuestionContent.Text = gridViewQuestions.SelectedRows[0].Cells["questionContent"].Value.ToString();
                }

                if (gridViewQuestions.SelectedRows[0].Cells["id"].Value != null)
                {
                    int questionId = (int)gridViewQuestions.SelectedRows[0].Cells["id"].Value;
                    fetchedAnswers = _questionController.getAnswersByQuestion(questionId);

                    for (int i = 0; i < fetchedAnswers.Count; i++)
                    {
                        if (i == 0)
                        {
                            tbxAnswer1.Text = fetchedAnswers[i].content.ToString();
                            tbxAnswer1.Tag = fetchedAnswers[i].id;
                        }
                        else if (i == 1)
                        {
                            tbxAnswer2.Text = fetchedAnswers[i].content.ToString();
                            tbxAnswer2.Tag = fetchedAnswers[i].id;
                        }
                        else if (i == 2)
                        {
                            tbxAnswer3.Text = fetchedAnswers[i].content.ToString();
                            tbxAnswer3.Tag = fetchedAnswers[i].id;
                        }
                        else if (i == 3)
                        {
                            tbxAnswer4.Text = fetchedAnswers[i].content.ToString();
                            tbxAnswer4.Tag = fetchedAnswers[i].id;
                        }
                        if (fetchedAnswers[i].isCorrect)
                        {
                            cbxCorrectAnswer.SelectedItem = $"Answer {i + 1}";
                        }
                    }

                    tbxQuestionContent.Enabled = true;
                    tbxAnswer1.Enabled = true;
                    tbxAnswer2.Enabled = true;
                    tbxAnswer3.Enabled = true;
                    tbxAnswer4.Enabled = true;
                    cbxCorrectAnswer.Enabled = true;
                    btnCreateQuestion.Enabled = false;
                    btnCancelEditQuestion.Enabled = true;
                    btnSaveQuestion.Enabled = true;
                    btnDeleteQuestion.Enabled = true;
                    gridViewQuestions.Enabled = false;
                }
            }
        }

        private void btnCancelEditQuestion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel editing this question now?", "Cancel editing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                resumeFromCancel();
            }
        }

        private void btnCreateQuestion_Click(object sender, EventArgs e)
        {
            tbxQuestionContent.Enabled = true;
            tbxAnswer1.Enabled = true;
            tbxAnswer2.Enabled = true;
            tbxAnswer3.Enabled = true;
            tbxAnswer4.Enabled = true;
            cbxCorrectAnswer.Enabled = true;
            btnCreateQuestion.Enabled = false;
            btnCancelEditQuestion.Enabled = true;
            btnSaveQuestion.Enabled = true;
            gridViewQuestions.Enabled = false;
        }

        private void btnSaveQuestion_Click(object sender, EventArgs e)
        {
            tbxQuestionContent.Enabled = false;
            tbxAnswer1.Enabled = false;
            tbxAnswer2.Enabled = false;
            tbxAnswer3.Enabled = false;
            tbxAnswer4.Enabled = false;
            cbxCorrectAnswer.Enabled = false;
            btnCreateQuestion.Enabled = false;
            btnCancelEditQuestion.Enabled = false;
            btnSaveQuestion.Enabled = false;
            btnDeleteQuestion.Enabled = false;
            gridViewQuestions.Enabled = false;

            string questionContent = tbxQuestionContent.Text.Trim();
            string answer1 = tbxAnswer1.Text.Trim();
            string answer2 = tbxAnswer2.Text.Trim();
            string answer3 = tbxAnswer3.Text.Trim();
            string answer4 = tbxAnswer4.Text.Trim();
            var correctAnswer = cbxCorrectAnswer.SelectedItem;

            if (questionContent.Length == 0)
            {
                DialogResult result = MessageBox.Show("The question content cannot be empty, please fill in the question", "Empty question content", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    resumeToNormal();
                    return;
                }
            }

            if (answer1.Length == 0)
            {
                DialogResult result = MessageBox.Show("The answer 1 content cannot be empty, please fill in the answer", "Empty answer content", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    resumeToNormal();
                    return;
                }
            }

            if (answer2.Length == 0)
            {
                DialogResult result = MessageBox.Show("The answer 2 content cannot be empty, please fill in the answer", "Empty answer content", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    resumeToNormal();
                    return;
                }
            }

            if (answer3.Length == 0)
            {
                DialogResult result = MessageBox.Show("The answer 3 content cannot be empty, please fill in the answer", "Empty answer content", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    resumeToNormal();
                    return;
                }
            }

            if (answer4.Length == 0)
            {
                DialogResult result = MessageBox.Show("The answer 4 content cannot be empty, please fill in the answer", "Empty answer content", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    resumeToNormal();
                    return;
                }
            }

            if (correctAnswer == null)
            {
                DialogResult result = MessageBox.Show("The correct answer was not chosen, please choose the correct answer", "Correct answer not chosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    resumeToNormal();
                    return;
                }
            }

            if (gridViewQuestions.SelectedRows.Count > 0)
            {
                int questionId = (int)gridViewQuestions.SelectedRows[0].Cells["id"].Value;
                bool isQuestionupdated = _questionController.updateQuestion(questionId, questionContent);

                if (isQuestionupdated)
                {
                    bool isAnswer1Updated = _questionController.updateAnswer((int)tbxAnswer1.Tag, answer1, correctAnswer.ToString() == "Answer 1");

                    if (isAnswer1Updated)
                    {
                        bool isAnswer2Updated = _questionController.updateAnswer((int)tbxAnswer2.Tag, answer2, correctAnswer.ToString() == "Answer 2");

                        if (isAnswer2Updated)
                        {
                            bool isAnswer3Updated = _questionController.updateAnswer((int)tbxAnswer3.Tag, answer3, correctAnswer.ToString() == "Answer 3");

                            if (isAnswer3Updated)
                            {
                                bool isAnswer4Updated = _questionController.updateAnswer((int)tbxAnswer4.Tag, answer4, correctAnswer.ToString() == "Answer 4");

                                if (!isAnswer4Updated)
                                {
                                    DialogResult result = MessageBox.Show("Something went wrong while updating answer 4, please try again later.", "Updating answer 4 failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    resumeToNormal();
                                    return;
                                }
                            }
                            else
                            {
                                DialogResult result = MessageBox.Show("Something went wrong while updating answer 3, please try again later.", "Updating answer 3 failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                resumeToNormal();
                                return;
                            }
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Something went wrong while updating answer 2, please try again later.", "Updating answer 2 failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            resumeToNormal();
                            return;
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Something went wrong while updating answer 1, please try again later.", "Updating answer 1 failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        resumeToNormal();
                        return;
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Something went wrong while updating the question, please try again later.", "Updating question failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resumeToNormal();
                    return;
                }
            }
            else
            {
                int newQuestionId = _questionController.createQuestion(questionContent, _examId);

                if (newQuestionId > 0)
                {
                    bool isAnswer1Created = _questionController.createAnswer(answer1, newQuestionId, correctAnswer.ToString() == "Answer 1");

                    if (isAnswer1Created)
                    {
                        bool isAnswer2Created = _questionController.createAnswer(answer2, newQuestionId, correctAnswer.ToString() == "Answer 2");

                        if (isAnswer2Created)
                        {
                            bool isAnswer3Created = _questionController.createAnswer(answer3, newQuestionId, correctAnswer.ToString() == "Answer 3");

                            if (isAnswer3Created)
                            {
                                bool isAnswer4Created = _questionController.createAnswer(answer4, newQuestionId, correctAnswer.ToString() == "Answer 4");

                                if (!isAnswer4Created)
                                {
                                    DialogResult result = MessageBox.Show("Something went wrong while creating answer 4, please try again later.", "Creating answer 4 failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    resumeToNormal();
                                    return;
                                }
                            }
                            else
                            {
                                DialogResult result = MessageBox.Show("Something went wrong while creating answer 3, please try again later.", "Creating answer 3 failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                resumeToNormal();
                                return;
                            }
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("Something went wrong while creating answer 2, please try again later.", "Creating answer 2 failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            resumeToNormal();
                            return;
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Something went wrong while creating answer 1, please try again later.", "Creating answer 1 failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        resumeToNormal();
                        return;
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Something went wrong while creating the question, please try again later.", "Creating question failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resumeToNormal();
                    return;
                }
            }

            tbxQuestionContent.Clear();
            tbxAnswer1.Clear();
            tbxAnswer2.Clear();
            tbxAnswer3.Clear();
            tbxAnswer4.Clear();
            cbxCorrectAnswer.SelectedItem = null;

            resumeToNormal();
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            bool isAnswer1Deleted = _questionController.deleteAnswer((int)tbxAnswer1.Tag);

            if (isAnswer1Deleted)
            {
                bool isAnswer2Deleted = _questionController.deleteAnswer((int)tbxAnswer2.Tag);

                if (isAnswer2Deleted)
                {
                    bool isAnswer3Deleted = _questionController.deleteAnswer((int)tbxAnswer3.Tag);

                    if (isAnswer3Deleted)
                    {
                        bool isAnswer4Deleted = _questionController.deleteAnswer((int)tbxAnswer4.Tag);

                        if (!isAnswer4Deleted)
                        {
                            DialogResult result = MessageBox.Show("Something went wrong while deleting answer 4, please try again later.", "Deleting answer 4 failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            resumeToNormal();
                            return;
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Something went wrong while deleting answer 3, please try again later.", "Deleting answer 3 failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        resumeToNormal();
                        return;
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Something went wrong while deleting answer 2, please try again later.", "Deleting answer 2 failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resumeToNormal();
                    return;
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Something went wrong while deleting answer 1, please try again later.", "Deleting answer 1 failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resumeToNormal();
                return;
            }

            int questionId = (int)gridViewQuestions.SelectedRows[0].Cells["id"].Value;
            bool isQuestionDeleted = _questionController.deleteQuestion(questionId);

            if (isQuestionDeleted)
            {
                DialogResult result = MessageBox.Show("Question is deleted successfully.", "Question deleted successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resumeFromCancel();
            } else
            {
                DialogResult result = MessageBox.Show("Something went wrong while deleting the question, please try again later.", "Question deleted failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resumeToNormal();
            }
        }
    }
}

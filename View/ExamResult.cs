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
    public partial class ExamResult : Form
    {
        private int _examId;
        private string _examTitle;
        private int _maxScore;
        private int _correctAnswerCount;
        private int _userId;
        private bool isCloseConfirmed;
        private ContestantWindow _contestantWindow;
        private ExamController _examController = new ExamController();

        private void centerLabel(Label lbl)
        {
            lbl.Left = (lbl.Parent.ClientSize.Width - lbl.Width) / 2;
        }

        private void loadExamResult()
        {
            treeViewExamResult.Nodes.Clear();
            List<Question> questions = _examController.getQuestionsByExam(_examId);
            List<CompletedAnswer> completedAnswers = _examController.getCompletedAnswers(_userId, _examId);

            foreach (Question question in questions)
            {
                CompletedAnswer completedAnswer = new CompletedAnswer();

                for (int i = 0; i < completedAnswers.Count; i++)
                {
                    if (completedAnswers[i].questionId == question.id)
                    {
                        completedAnswer = completedAnswers[i];
                    }
                }

                TreeNode questionNode = new TreeNode(question.content);
                List<Answer> answers = _examController.getAnswersByQuestion(question.id);

                foreach (Answer answer in answers)
                {
                    string answerText = answer.content;

                    if (completedAnswer != null)
                    {
                        if (answer.isCorrect && answer.id == completedAnswer.answerId)
                        {
                            answerText += " 👈 ✅";
                        }
                        else if (answer.isCorrect)
                        {
                            answerText += " ✅";
                        }
                        else if (answer.id == completedAnswer.answerId)
                        {
                            answerText += " 👈";
                        }
                    }
                    else
                    {
                        if (answer.isCorrect)
                        {
                            answerText += " ✅";
                        }
                    }

                    TreeNode answerNode = new TreeNode(answerText);
                    questionNode.Nodes.Add(answerNode);
                }

                treeViewExamResult.Nodes.Add(questionNode);
            }
            treeViewExamResult.ExpandAll();
        }

        public ExamResult(int examId, string examTitle, int maxScore, decimal? finalGrade, ContestantWindow contestantWindow, int correctAnswerCount, int contestantId)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            _examId = examId;
            _examTitle = examTitle;
            _maxScore = maxScore;
            _contestantWindow = contestantWindow;
            _correctAnswerCount = correctAnswerCount;
            _userId = contestantId;

            this.Text = examTitle;
            lblExamTitle.Text = examTitle;
            centerLabel(lblExamTitle);
            lblMaxScore.Text = $"Max score: {_maxScore}";
            lblFinalGrade.Text = $"Final grade: {finalGrade}";
            lblCorrectAnswerAmount.Text = $"No. correct answers: {_correctAnswerCount}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (!isCloseConfirmed)
            {
                isCloseConfirmed = true;
                _contestantWindow.Show();
                this.Close();
            }
        }

        private void ExamResult_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !isCloseConfirmed)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to close?", "Close confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    isCloseConfirmed = true;
                    _contestantWindow.Show();
                    this.Close();
                }
                else
                {
                    e.Cancel = true;
                }
            }

        }

        private void ExamResult_Load(object sender, EventArgs e)
        {
            loadExamResult();
        }
    }
}

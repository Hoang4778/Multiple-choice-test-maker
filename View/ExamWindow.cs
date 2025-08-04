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
    public partial class ExamWindow : Form
    {
        public ContestantWindow _contestantWindow;
        private QuestionController _questionController = new QuestionController();
        private ExamController _examController = new ExamController();
        private ClassController _classController = new ClassController();
        private string _testTitle;
        private int _testId;
        private int _userId;
        private int _testDuration;
        private int _maxScore;
        private int _classId;
        public List<QuestionAnswer> _questionAnswers = new List<QuestionAnswer>();
        private int _currentQuestionIdx = 0;
        private bool _isCloseConfirmed = false;
        private List<CompletedAnswer> _completedAnswers = new List<CompletedAnswer>();

        private string formatTime(int totalSeconds)
        {
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;
            return $"{minutes:D2}:{seconds:D2}";
        }

        private void shuffleAnswers<T>(List<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        private void showQuestion(int currentQuestionIdx)
        {
            lblQuestion.Text = $"{currentQuestionIdx + 1}. {_questionAnswers[currentQuestionIdx].content}";
            int questionId = _questionAnswers[currentQuestionIdx].id;
            lblQuestion.Tag = questionId;

            List<Answer> answers = _questionAnswers[currentQuestionIdx].answers;
            if (answers.Count == 0)
            {
                List<Answer> fetchedAnswers = _questionController.getAnswersByQuestion(questionId);
                shuffleAnswers(fetchedAnswers);
                _questionAnswers[currentQuestionIdx].answers = fetchedAnswers;
                answers = fetchedAnswers;
            }

            int idx = 0;
            foreach (RadioButton radBtn in grpBxAnswers.Controls.OfType<RadioButton>())
            {
                radBtn.Text = answers[idx].content;
                radBtn.Tag = answers[idx].id;
                radBtn.Checked = false;

                if (_completedAnswers.Count - 1 < currentQuestionIdx)
                {
                    radBtn.Checked = false;
                }
                else
                {
                    if (_completedAnswers[currentQuestionIdx].answerId == answers[idx].id)
                    {
                        radBtn.Checked = true;
                    }
                    else
                    {
                        radBtn.Checked = false;
                    }
                }

                idx += 1;
            }
        }

        //private void print()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    foreach (var item in _completedAnswers)
        //    {
        //        sb.AppendLine($"questionId: {item.questionId}, answerId: {item.answerId}");
        //    }
        //    lblConsole.Text = sb.ToString();
        //}

        private void tempSaveAnswer()
        {
            RadioButton selectedOption = grpBxAnswers.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (_completedAnswers.Count - 1 < _currentQuestionIdx)
            {
                CompletedAnswer newAnswer = new CompletedAnswer();

                if (selectedOption != null)
                {
                    newAnswer.answerId = (int)selectedOption.Tag;
                }
                else
                {
                    newAnswer.answerId = null;
                }

                newAnswer.questionId = (int)lblQuestion.Tag;
                newAnswer.contestantId = _userId;
                newAnswer.examId = _testId;
                _completedAnswers.Add(newAnswer);
            }
            else
            {
                if (selectedOption != null)
                {
                    _completedAnswers[_currentQuestionIdx].answerId = (int)selectedOption.Tag;
                }
                else
                {
                    _completedAnswers[_currentQuestionIdx].answerId = null;
                }
            }
        }

        private void clearChosenOption(GroupBox grbx)
        {
            foreach (RadioButton radBtn in grbx.Controls.OfType<RadioButton>())
            {
                radBtn.Checked = false;
            }
        }

        private void saveExam()
        {
            double finalGrade = 0;
            double gradePerAnswer = Math.Round(((double)_maxScore / _questionAnswers.Count) * 100) / 100;
            int correctAnswerCount = 0;

            foreach (CompletedAnswer completedAnswer in _completedAnswers)
            {
                var question = _questionAnswers.First(q => q.id == completedAnswer.questionId);
                if (question != null)
                {
                    var chosenAnswer = question.answers.First(answer => answer.id == completedAnswer.answerId);
                    if (chosenAnswer != null && chosenAnswer.isCorrect)
                    {
                        correctAnswerCount += 1;
                    }
                }
            }

            finalGrade = gradePerAnswer * correctAnswerCount;

            bool isGradeSaved = _examController.postExamGrade(_userId, _testId, finalGrade, correctAnswerCount);
            if (isGradeSaved)
            {
                bool isCompletedAnswersSaved = _examController.postCompletedAnswer(_completedAnswers);

                if (isCompletedAnswersSaved)
                {
                    List<ExamGrade> examGrades = _examController.getStudentExamGradeByClass(_classId, _userId);

                    decimal gradeSum = 0;
                    if (examGrades.Count > 0)
                    {
                        foreach (ExamGrade examGrade in examGrades)
                        {
                            if (examGrade.grade != null)
                            {
                                gradeSum += (decimal)examGrade.grade;
                            }
                        }

                        decimal averageGrade = Math.Round(((gradeSum / examGrades.Count) * 100)) / 100;
                        bool isAvgGradePosted = _classController.postClassAvgGrade(_classId, _userId, averageGrade);

                        if (isAvgGradePosted)
                        {
                            DialogResult result4 = MessageBox.Show("Average grade is calculated successfully", "Average grade calculated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            DialogResult result5 = MessageBox.Show("Average grade failed to calculate", "Average grade calculation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    DialogResult result3 = MessageBox.Show("The exam is concluded, you can check your grade shortly after this.", "Exam finished", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (result3 == DialogResult.OK)
                    {
                        _contestantWindow.Show();
                        _isCloseConfirmed = true;
                        this.Close();
                    }
                }
                else
                {
                    DialogResult result1 = MessageBox.Show("There is something wrong while saving the chosen answers. Please try again later.", "Exam failed to finish", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DialogResult result2 = MessageBox.Show("There is something wrong while calculating the grade. Please try again later.", "Exam failed to finish", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ExamWindow(ContestantWindow contestantWindow, List<Question> questions, string testTitle, int testId, int userId, decimal testDuration, int maxScore, int classId)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            _contestantWindow = contestantWindow;
            _testTitle = testTitle;
            _testId = testId;
            _userId = userId;
            _classId = classId;
            _maxScore = maxScore;
            _testDuration = (int)Math.Round(testDuration * 60);
            this.Text = _testTitle;

            for (int i = 0; i < questions.Count; i++)
            {
                QuestionAnswer newQuestionAnswer = new QuestionAnswer();
                newQuestionAnswer.id = questions[i].id;
                newQuestionAnswer.content = questions[i].content;
                newQuestionAnswer.answers = new List<Answer>();
                _questionAnswers.Add(newQuestionAnswer);
            }
        }

        private void ExamWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !_isCloseConfirmed)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to close?", "Finish the exam", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    saveExam();
                    _contestantWindow.Show();
                    _isCloseConfirmed = true;
                    this.Close();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void ExamWindow_Load(object sender, EventArgs e)
        {
            showQuestion(_currentQuestionIdx);

            lblTestDuration.Text = formatTime(_testDuration);
            testTimer.Start();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tempSaveAnswer();

            if (_currentQuestionIdx == _questionAnswers.Count - 2)
            {
                _currentQuestionIdx = _questionAnswers.Count - 1;
                btnFinish.Enabled = true;
                btnNext.Enabled = false;
            }
            else
            {
                btnFinish.Enabled = false;
                _currentQuestionIdx += 1;
            }

            showQuestion(_currentQuestionIdx);
            btnBack.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tempSaveAnswer();

            if (_currentQuestionIdx == 1)
            {
                _currentQuestionIdx = 0;
                btnBack.Enabled = false;
            }
            else
            {
                _currentQuestionIdx -= 1;
            }

            btnFinish.Enabled = false;
            showQuestion(_currentQuestionIdx);
            btnNext.Enabled = true;
        }

        private void btnClearChoice_Click(object sender, EventArgs e)
        {
            clearChosenOption(grpBxAnswers);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to finish the test here?", "Confirm to finish the exam", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _isCloseConfirmed = true;
                tempSaveAnswer();
                saveExam();
            }
        }

        private void testTimer_Tick(object sender, EventArgs e)
        {
            if (_testDuration > 0)
            {
                _testDuration -= 1;
                lblTestDuration.Text = formatTime(_testDuration);
            }
            else
            {
                testTimer.Stop();
                lblTestDuration.Text = "00:00";
                DialogResult result = MessageBox.Show("Time's up! The exam is finished now.", "Exam end", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    saveExam();
                }
            }
        }
    }
}

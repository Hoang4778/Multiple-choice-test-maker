using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnCuoiKy.Model;

namespace DoAnCuoiKy.Controller
{
    internal class ExamController
    {
        DatabaseAccessController DBAccess = null;
        SqlCommand testCommand = null;

        public ExamController()
        {
            DBAccess = new DatabaseAccessController();
            testCommand = new SqlCommand();
            testCommand.Connection = DBAccess.initiateConnection();
            testCommand.CommandType = CommandType.Text;
        }

        public ExamGrade getGradeByExam(int examId, int studentId)
        {
            try
            {
                ExamGrade examGrade = new ExamGrade();
                testCommand.CommandText = $"select grade, correctAnswerCount from ExamGrade where examId = {examId} and contestantId = {studentId}";
                testCommand.Connection.Open();
                var result = testCommand.ExecuteReader();

                while (result.Read())
                {
                    examGrade.grade = (decimal)result["grade"];
                    examGrade.correctAnswerCount = (int)result["correctAnswerCount"];
                }

                testCommand.Connection.Close();

                return examGrade;
            }
            catch (Exception ex)
            {
                return new ExamGrade { grade = -2m, correctAnswerCount = -2 };
            }
        }

        public List<ExamGrade> getStudentExamGradeByClass(int classId, int studentId)
        {
            List<ExamGrade> examGrades = new List<ExamGrade>();
            testCommand.CommandText = $"select grade, correctAnswerCount from ExamGrade join Exam on ExamGrade.examId = Exam.id where contestantId = {studentId} and Exam.classId = {classId}";
            testCommand.Connection.Open();

            try
            {
                var result = testCommand.ExecuteReader();
                while (result.Read())
                {
                    ExamGrade examGrade = new ExamGrade();
                    examGrade.grade = (decimal)result["grade"];
                    examGrade.correctAnswerCount = (int)result["correctAnswerCount"];
                    examGrades.Add(examGrade);
                }

                testCommand.Connection.Close();
                return examGrades;
            }
            catch (Exception ex)
            {
                testCommand.Connection.Close();
                return examGrades;
            }
        }

        public List<Exam> getExamsByClass(int classId)
        {
            List<Exam> allExams = new List<Exam>();
            testCommand.CommandText = $"select id, title, description, examDate, startTime, duration, questionAmount, maxScore from Exam where classId = {classId}";
            testCommand.Connection.Open();

            var result = testCommand.ExecuteReader();
            while (result.Read())
            {
                Exam newExam = new Exam();

                newExam.id = (int)result["id"];
                newExam.title = result["title"].ToString();
                newExam.description = result["description"].ToString();
                newExam.examDate = (DateTime)result["examDate"];
                newExam.startTime = (TimeSpan)result["startTime"];
                newExam.duration = (decimal)result["duration"];
                newExam.questionAmount = (int)result["questionAmount"];
                newExam.maxScore = (int)result["maxScore"];

                allExams.Add(newExam);
            }

            testCommand.Connection.Close();
            return allExams;
        }

        public List<Exam> getStudentExamsByClass(int classId)
        {
            List<Exam> allExams = new List<Exam>();
            testCommand.CommandText = $"select id, title, examDate, startTime, duration, questionAmount, maxScore from Exam where classId = {classId} order by examDate asc";
            testCommand.Connection.Open();

            var result = testCommand.ExecuteReader();
            while (result.Read())
            {
                Exam newExam = new Exam();

                newExam.id = (int)result["id"];
                newExam.title = result["title"].ToString();
                newExam.examDate = (DateTime)result["examDate"];
                newExam.startTime = (TimeSpan)result["startTime"];
                newExam.duration = (decimal)result["duration"];
                newExam.questionAmount = (int)result["questionAmount"];
                newExam.maxScore = (int)result["maxScore"];

                allExams.Add(newExam);
            }

            testCommand.Connection.Close();
            return allExams;
        }

        public bool addTest(Exam newTest)
        {
            try
            {
                testCommand.CommandText = $"insert into Exam (title, description, examDate, startTime, duration, questionAmount, maxScore, classId) " +
                    $"values (@newTestTitle, @newTestDescription, '{newTest.examDate.ToString(@"yyyy/MM/dd")}', '{newTest.startTime.ToString(@"hh\:mm\:ss")}', {newTest.duration}, {newTest.questionAmount}, {newTest.maxScore}, {newTest.classId})";
                testCommand.Parameters.AddWithValue("@newTestTitle", newTest.title);
                testCommand.Parameters.AddWithValue("@newTestDescription", newTest.description);
                testCommand.Connection.Open();

                int rowCount = testCommand.ExecuteNonQuery();
                testCommand.Connection.Close();
                testCommand.Parameters.Clear();

                if (rowCount > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                testCommand.Connection.Close();
                testCommand.Parameters.Clear();
                return false;
            }
        }

        public bool updateTest(Exam existingTest)
        {
            try
            {
                testCommand.CommandText = $"update Exam " +
                    $"set " +
                    $"title = @existingTestTitle, " +
                    $"description = @existingTestDescription, " +
                    $"examDate = '{existingTest.examDate.ToString(@"yyyy/MM/dd")}', " +
                    $"startTime = '{existingTest.startTime.ToString(@"hh\:mm\:ss")}', " +
                    $"duration = {existingTest.duration}, " +
                    $"questionAmount = {existingTest.questionAmount}, " +
                    $"maxScore = {existingTest.maxScore} " +
                    $"where id = {existingTest.id}";
                testCommand.Parameters.AddWithValue("@existingTestTitle", existingTest.title);
                testCommand.Parameters.AddWithValue("@existingTestDescription", existingTest.description);
                testCommand.Connection.Open();

                int rowCount = testCommand.ExecuteNonQuery();
                testCommand.Connection.Close();

                if (rowCount > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool postExamGrade(int contestantId, int examId, double grade, int correctAnswerCount)
        {
            testCommand.CommandText = $"insert into ExamGrade (contestantId, examId, grade, correctAnswerCount) " +
                $"values ({contestantId}, {examId}, {grade}, {correctAnswerCount})";

            testCommand.Connection.Open();

            try
            {
                int rowCount = testCommand.ExecuteNonQuery();
                testCommand.Connection.Close();

                if (rowCount > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                testCommand.Connection.Close();
                return false;
            }
        }

        public bool postCompletedAnswer(List<CompletedAnswer> completedAnswerList)
        {
            string queryPt1 = "insert into CompletedAnswer (contestantId, examId, questionId, answerId) ";
            string queryPt2 = "values ";

            for (int i = 0; i < completedAnswerList.Count; i++)
            {
                if (i != completedAnswerList.Count - 1)
                {
                    queryPt2 += $"({completedAnswerList[i].contestantId}, {completedAnswerList[i].examId}, {completedAnswerList[i].questionId}, {completedAnswerList[i].answerId}), ";
                }
                else
                {
                    queryPt2 += $"({completedAnswerList[i].contestantId}, {completedAnswerList[i].examId}, {completedAnswerList[i].questionId}, {completedAnswerList[i].answerId})";
                }
            }

            testCommand.CommandText = queryPt1 + queryPt2;
            testCommand.Connection.Open();

            try
            {
                int rowCount = testCommand.ExecuteNonQuery();
                testCommand.Connection.Close();

                if (rowCount > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                testCommand.Connection.Close(); return false;
            }
        }

        public List<Question> getQuestionsByExam(int examId)
        {
            List<Question> questionList = new List<Question>();

            testCommand.CommandText = $"select * from Question where examId = {examId}";
            testCommand.Connection.Open();

            try
            {
                var result = testCommand.ExecuteReader();

                while (result.Read())
                {
                    Question question = new Question();
                    question.id = (int)result["id"];
                    question.content = (string)result["content"];
                    question.examId = (int)result["examId"];
                    questionList.Add(question);
                }

                testCommand.Connection.Close();
                return questionList;
            }
            catch (Exception ex)
            {
                testCommand.Connection.Close();
                return questionList;
            }
        }

        public List<Answer> getAnswersByQuestion(int questionId)
        {
            List<Answer> answerList = new List<Answer>();

            testCommand.CommandText = $"select * from Answer where questionId = {questionId}";
            testCommand.Connection.Open();

            try
            {
                var result = testCommand.ExecuteReader();

                while (result.Read())
                {
                    Answer answer = new Answer();
                    answer.id = (int)result["id"];
                    answer.content = (string)result["content"];
                    answer.questionId = (int)result["questionId"];
                    answer.isCorrect = (bool)result["isCorrect"];
                    answerList.Add(answer);
                }

                testCommand.Connection.Close();
                return answerList;
            }
            catch (Exception ex)
            {
                testCommand.Connection.Close();
                return answerList;
            }
        }

        public List<CompletedAnswer> getCompletedAnswers(int contestantId, int examId)
        {
            List<CompletedAnswer> completedAnswers = new List<CompletedAnswer>();
            testCommand.CommandText = $"select * from CompletedAnswer where contestantId = {contestantId} and examId = {examId}";
            testCommand.Connection.Open();

            try
            {
                var result = testCommand.ExecuteReader();

                while (result.Read())
                {
                    CompletedAnswer answer = new CompletedAnswer();
                    answer.id = (int)result["id"];
                    answer.contestantId = (int)result["contestantId"];
                    answer.examId = (int)result["examId"];
                    answer.questionId = (int)result["questionId"];
                    answer.answerId = (int)result["answerId"];
                    completedAnswers.Add(answer);
                }

                testCommand.Connection.Close();
                return completedAnswers;
            }
            catch (Exception ex)
            {
                testCommand.Connection.Close();
                return completedAnswers;
            }
        }
    }
}

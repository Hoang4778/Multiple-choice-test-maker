using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnCuoiKy.Model;

namespace DoAnCuoiKy.Controller
{
    internal class QuestionController
    {
        DatabaseAccessController DBAccess = null;
        SqlCommand questionCommand = null;

        public QuestionController()
        {
            DBAccess = new DatabaseAccessController();
            questionCommand = new SqlCommand();
            questionCommand.Connection = DBAccess.initiateConnection();
            questionCommand.CommandType = CommandType.Text;
        }

        public List<Question> getQuestionsByTest(int examId)
        {
            List<Question> questionList = new List<Question>();
            questionCommand.CommandText = $"select * from Question where examId = {examId}";
            questionCommand.Connection.Open();

            var result = questionCommand.ExecuteReader();

            while (result.Read())
            {
                Question newQuestion = new Question();

                newQuestion.id = (int)result["id"];
                newQuestion.content = result["content"].ToString();
                newQuestion.examId = (int)result["examId"];

                questionList.Add(newQuestion);
            }

            questionCommand.Connection.Close();
            return questionList;
        }

        public List<Answer> getAnswersByQuestion(int questionId)
        {
            List<Answer> answers = new List<Answer>();
            questionCommand.CommandText = $"select * from Answer where questionId = {questionId}";
            questionCommand.Connection.Open();
            var result = questionCommand.ExecuteReader();

            while (result.Read())
            {
                Answer answer = new Answer();

                answer.id = (int)result["id"];
                answer.content = result["content"].ToString();
                answer.questionId = (int)result["questionId"];
                answer.isCorrect = (bool)result["isCorrect"];

                answers.Add(answer);
            }

            questionCommand.Connection.Close();
            return answers;
        }

        public bool updateQuestion(int questionId, string questionContent)
        {
            questionCommand.CommandText = $"update Question set content = @questionContent where id = {questionId}";
            questionCommand.Parameters.AddWithValue("@questionContent", questionContent);
            questionCommand.Connection.Open();

            try
            {
                int rowCount = questionCommand.ExecuteNonQuery();

                if (rowCount <= 0)
                {
                    questionCommand.Connection.Close();
                    questionCommand.Parameters.Clear();
                    return false;
                }
            }
            catch (Exception e)
            {
                questionCommand.Connection.Close();
                questionCommand.Parameters.Clear();
                return false;
            }

            questionCommand.Connection.Close();
            questionCommand.Parameters.Clear();
            return true;
        }

        public int createQuestion(string questionContent, int examId)
        {
            questionCommand.CommandText = $"insert into Question (content, examId) output inserted.id values (@content, {examId})";
            questionCommand.Parameters.AddWithValue("@content", questionContent);
            questionCommand.Connection.Open();

            try
            {
                int newQuestionId = (int)questionCommand.ExecuteScalar();

                if (newQuestionId <= 0)
                {
                    questionCommand.Connection.Close();
                    questionCommand.Parameters.Clear();
                    return -1;
                }
                else
                {
                    questionCommand.Connection.Close();
                    questionCommand.Parameters.Clear();
                    return newQuestionId;
                }
            }
            catch (Exception e)
            {
                questionCommand.Connection.Close();
                questionCommand.Parameters.Clear();
                return -1;
            }
        }

        public bool deleteQuestion(int questionId)
        {
            questionCommand.CommandText = $"delete from Question where id = {questionId}";
            questionCommand.Connection.Open();

            try
            {
                int rowCount = questionCommand.ExecuteNonQuery();

                if (rowCount <= 0)
                {
                    questionCommand.Connection.Close();
                    return false;
                }
            }
            catch (Exception e)
            {
                questionCommand.Connection.Close();
                return false;
            }

            questionCommand.Connection.Close();
            return true;
        }

        public bool createAnswer(string answerContent, int questionId, bool isCorrect)
        {
            questionCommand.CommandText = $"insert into Answer (content, questionId, isCorrect)" +
                $"values (@answerContent, {questionId}, {(isCorrect ? 1 : 0)})";
            questionCommand.Parameters.AddWithValue("@answerContent", answerContent);
            questionCommand.Connection.Open();

            try
            {
                int rowCount = questionCommand.ExecuteNonQuery();

                if (rowCount <= 0)
                {
                    questionCommand.Connection.Close();
                    questionCommand.Parameters.Clear();
                    return false;
                }
            }
            catch (Exception e)
            {
                questionCommand.Connection.Close();
                questionCommand.Parameters.Clear();
                return false;
            }

            questionCommand.Connection.Close();
            questionCommand.Parameters.Clear();
            return true;
        }

        public bool updateAnswer(int answerId, string answerContent, bool isCorrect)
        {
            questionCommand.CommandText = $"update Answer set content = @answerContent, isCorrect = {(isCorrect ? 1 : 0)} where id = {answerId}";
            questionCommand.Parameters.AddWithValue("@answerContent", answerContent);
            questionCommand.Connection.Open();

            try
            {
                int rowCount = questionCommand.ExecuteNonQuery();

                if (rowCount <= 0)
                {
                    questionCommand.Connection.Close();
                    questionCommand.Parameters.Clear();
                    return false;
                }
            }
            catch (Exception e)
            {
                questionCommand.Connection.Close();
                questionCommand.Parameters.Clear();
                return false;
            }

            questionCommand.Connection.Close();
            questionCommand.Parameters.Clear();
            return true;
        }

        public bool deleteAnswer(int answerId)
        {
            questionCommand.CommandText = $"delete from Answer where id = {answerId}";
            questionCommand.Connection.Open();

            try
            {
                int rowCount = questionCommand.ExecuteNonQuery();

                if (rowCount <= 0)
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }

            questionCommand.Connection.Close();
            return true;
        }
    }
}

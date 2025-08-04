using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DoAnCuoiKy.Model;

namespace DoAnCuoiKy.Controller
{
    internal class ClassController
    {
        DatabaseAccessController DBAccess = null;
        SqlCommand classCommand = null;

        public ClassController()
        {
            DBAccess = new DatabaseAccessController();
            classCommand = new SqlCommand();
            classCommand.Connection = DBAccess.initiateConnection();
            classCommand.CommandType = CommandType.Text;
        }

        public List<Class> getAllClasses()
        {
            List<Class> allClasses = new List<Class>();
            classCommand.CommandText = "select id, name, description, startDate, endDate from Class";
            classCommand.Connection.Open();

            var result = classCommand.ExecuteReader();
            while (result.Read())
            {
                Class newClass = new Class();

                newClass.id = (int)result["id"];
                newClass.name = result["name"].ToString();
                newClass.description = result["description"].ToString();
                newClass.startDate = (DateTime)result["startDate"];
                newClass.endDate = (DateTime)result["endDate"];

                allClasses.Add(newClass);
            }

            classCommand.Connection.Close();
            return allClasses;
        }

        public List<EnrolledClass> getEnrolledClasses(int studentId)
        {
            List<EnrolledClass> classes = new List<EnrolledClass>();

            classCommand.CommandText = $"select EnrolledClass.id, name, description, startDate, endDate, grade, EnrolledClass.classId from EnrolledClass join Class on EnrolledClass.classId = Class.id where contestantId = {studentId}";
            classCommand.Connection.Open();

            var result = classCommand.ExecuteReader();
            while (result.Read())
            {
                EnrolledClass newEnrolledClass = new EnrolledClass();
                newEnrolledClass.id = (int)result["id"];
                newEnrolledClass.name = result["name"].ToString();
                newEnrolledClass.description = result["description"].ToString();
                newEnrolledClass.startDate = (DateTime)result["startDate"];
                newEnrolledClass.endDate = (DateTime)result["endDate"];
                newEnrolledClass.finalGrade = result["grade"] != DBNull.Value ? (decimal)result["grade"] : -1m;
                newEnrolledClass.classId = (int)result["classId"];
                classes.Add(newEnrolledClass);
            }

            classCommand.Connection.Close();

            return classes;
        }

        public List<Class> getAvailableClasses(int studentId)
        {
            List<Class> classes = new List<Class>();

            classCommand.CommandText = $"select * from Class where startDate > CAST(GETDATE() AS DATE) and Class.id not in (select classId from EnrolledClass where contestantId = {studentId});";
            classCommand.Connection.Open();

            var result = classCommand.ExecuteReader();
            while (result.Read())
            {
                Class newAvailableClass = new Class();
                newAvailableClass.id = (int)result["id"];
                newAvailableClass.name = result["name"].ToString();
                newAvailableClass.description = result["description"].ToString();
                newAvailableClass.startDate = (DateTime)result["startDate"];
                newAvailableClass.endDate = (DateTime)result["endDate"];
                classes.Add(newAvailableClass);
            }

            classCommand.Connection.Close();

            return classes;
        }

        public bool addEnrolledClasses(List<Class> chosenClasses, int contestantId)
        {
            try
            {
                string sqlPt1 = $"insert into EnrolledClass (classId, contestantId) ";
                string sqlPt2 = "values ";

                for (int i = 0; i < chosenClasses.Count; i++)
                {
                    if (chosenClasses.Count - 1 != i)
                    {
                        sqlPt2 += $"({chosenClasses[i].id}, {contestantId}), ";
                    }
                    else
                    {
                        sqlPt2 += $"({chosenClasses[i].id}, {contestantId})";
                    }
                }

                classCommand.CommandText = sqlPt1 + sqlPt2;
                classCommand.Connection.Open();

                int rowCount = classCommand.ExecuteNonQuery();

                classCommand.Connection.Close();
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
                classCommand.Connection.Close();
                return false;
            }
        }

        public bool addClass(Class newClass)
        {
            try
            {
                classCommand.CommandText = $"insert into Class (name, description, startDate, endDate)" +
                    $"values (@newClassName, @newClassDesc, '{newClass.startDate.ToString(@"yyyy/MM/dd")}', '{newClass.endDate.ToString(@"yyyy/MM/dd")}')";
                classCommand.Parameters.AddWithValue("@newClassName", newClass.name);
                classCommand.Parameters.AddWithValue("@newClassDesc", newClass.description);
                classCommand.Connection.Open();

                int rowCount = classCommand.ExecuteNonQuery();
                classCommand.Connection.Close();
                classCommand.Parameters.Clear();

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
                classCommand.Connection.Close();
                classCommand.Parameters.Clear();
                return false;
            }
        }

        public bool updateClass(Class existingClass)
        {
            try
            {
                classCommand.CommandText = $"update Class " +
                    $"set " +
                    $"name = @existingClassName, " +
                    $"description = @existingClassDesc, " +
                    $"startDate = '{existingClass.startDate.ToString(@"yyyy/MM/dd")}', " +
                    $"endDate = '{existingClass.endDate.ToString(@"yyyy/MM/dd")}' " +
                    $"where id = {existingClass.id}";
                classCommand.Parameters.AddWithValue("@existingClassName", existingClass.name);
                classCommand.Parameters.AddWithValue("@existingClassDesc", existingClass.description);
                classCommand.Connection.Open();

                int rowCount = classCommand.ExecuteNonQuery();
                classCommand.Connection.Close();
                classCommand.Parameters.Clear();

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

        public List<Student> getStudentsByClass(int classId)
        {
            List<Student> students = new List<Student>();

            classCommand.CommandText = $"select Contestant.id, firstName, lastName, dateOfBirth, gender, phoneNumber, email, grade from EnrolledClass join Contestant on EnrolledClass.contestantId = Contestant.id where classId = {classId}";
            classCommand.Connection.Open();

            try
            {
                var result = classCommand.ExecuteReader();

                while (result.Read())
                {
                    Student student = new Student();
                    student.id = (int)result["id"];
                    student.firstName = result["firstName"].ToString();
                    student.lastName = result["lastName"].ToString();
                    student.dateOfBirth = (DateTime)result["dateOfBirth"];
                    student.gender = result["gender"].ToString();
                    student.phoneNumber = result["phoneNumber"].ToString();
                    student.email = result["email"].ToString();
                    student.averageGrade = result["grade"] != DBNull.Value ? (decimal)result["grade"] : -1m;
                    students.Add(student);
                }

                classCommand.Connection.Close();
                return students;
            }
            catch (Exception ex)
            {
                classCommand.Connection.Close();
                return students;
            }
        }

        public bool postClassAvgGrade(int classId, int studentId, decimal averageGrade)
        {
            classCommand.CommandText = $"update EnrolledClass " +
                $"set grade = {averageGrade} where classId = {classId} and contestantId = {studentId}";
            classCommand.Connection.Open();

            try
            {
                var rowCount = classCommand.ExecuteNonQuery();

                if (rowCount > 0)
                {
                    classCommand.Connection.Close();
                    return true;
                }
                else
                {
                    classCommand.Connection.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                classCommand.Connection.Close();
                return false;
            }
        }

        public DataTable reportGetStudentGradeByClass(int classId)
        {
            string connectionStr = "Data Source=localhost;Initial Catalog=TestMaker;Integrated Security=False;Trusted_Connection=True";
            string query = $"select Contestant.id, firstName, lastName, dateOfBirth, gender, phoneNumber, email, grade from EnrolledClass join Contestant on EnrolledClass.contestantId = Contestant.id where classId = {classId}";

            using (SqlConnection connection = new SqlConnection(connectionStr))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }
}

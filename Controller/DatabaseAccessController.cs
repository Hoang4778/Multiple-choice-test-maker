using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCuoiKy.Model;
using DoAnCuoiKy.View;

namespace DoAnCuoiKy.Controller
{
    internal class DatabaseAccessController
    {
        public SqlConnection initiateConnection()
        {
            string connectionStr = "Data Source=localhost;Initial Catalog=TestMaker;Integrated Security=False;Trusted_Connection=True";
            SqlConnection connectionToSQL = new SqlConnection(connectionStr);

            return connectionToSQL;
        }

        public bool login(string email, string password)
        {
            SqlCommand loginCommand = new SqlCommand();
            loginCommand.Connection = initiateConnection();
            loginCommand.CommandType = CommandType.Text;
            loginCommand.CommandText = "select top 1 * from AdminAccount where email = @email";
            loginCommand.Parameters.AddWithValue("@email", email);
            loginCommand.Connection.Open();

            var adminResult = loginCommand.ExecuteReader();
            if (adminResult.Read())
            {
                if (password != adminResult["password"].ToString())
                {
                    MessageBox.Show("Password is not correct, please try again!", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loginCommand.Connection.Close();
                    loginCommand.Parameters.Clear();
                    return false;
                }
                else
                {
                    AdminWindow2 adminProgram2 = new AdminWindow2(adminResult["accountName"].ToString());
                    adminProgram2.Show();

                    loginCommand.Connection.Close();
                    loginCommand.Parameters.Clear();
                    return true;
                }
            }
            else
            {
                loginCommand.Connection.Close();
                loginCommand.Parameters.Clear();
                loginCommand.CommandText = "select top 1 * from Contestant where email = @email";
                loginCommand.Parameters.AddWithValue("@email", email);
                loginCommand.Connection.Open();
                var contestantResult = loginCommand.ExecuteReader();

                if (contestantResult.Read())
                {
                    if (password != contestantResult["password"].ToString())
                    {
                        MessageBox.Show("Password is not correct, please try again!", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        loginCommand.Connection.Close();
                        loginCommand.Parameters.Clear();
                        return false;
                    }
                    else
                    {
                        StudentWindow studentWindow = new StudentWindow((int)contestantResult["id"], contestantResult["firstName"].ToString());
                        studentWindow.Show();

                        loginCommand.Connection.Close();
                        loginCommand.Parameters.Clear();
                        return true;
                    }
                }
                else
                {
                    MessageBox.Show("Account does not exist, please try again!", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loginCommand.Connection.Close();
                    return false;
                }
            }
        }
    }
}

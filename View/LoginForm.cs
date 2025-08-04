using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCuoiKy.Controller;
using DoAnCuoiKy.View;

namespace DoAnCuoiKy
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void tbxEmail_Validating(object sender, CancelEventArgs e)
        {
            string regexEmailPattern = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";
            Regex regexEmail = new Regex(regexEmailPattern);

            if (!regexEmail.IsMatch(tbxEmail.Text))
            {
                errorEmail.SetError(tbxEmail, "Email address type is invalid. Please try again.");
            }
            else
            {
                errorEmail.Clear();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sanitizedEmail = tbxEmail.Text.Trim();
            string sanitizedPassword = tbxPassword.Text.Trim();

            if (sanitizedEmail.Length == 0)
            {
                errorEmail.SetError(tbxEmail, "Email address cannot be empty, please fill it in");
                return;
            }

            if (sanitizedPassword.Length == 0)
            {
                errorPassword.SetError(tbxPassword, "Password cannot be empty, please fill it in");
                return;
            }

            DatabaseAccessController databaseAccessController = new DatabaseAccessController();
            bool isLoggedIn = databaseAccessController.login(sanitizedEmail, sanitizedPassword);

            if (isLoggedIn)
            {
                tbxEmail.Text = "";
                tbxPassword.Text = "";
                errorEmail.Clear();
                errorPassword.Clear();
                this.Hide();
            }
        }
    }
}

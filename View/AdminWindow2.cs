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
    public partial class AdminWindow2 : Form
    {
        private string _adminName;
        private bool isAdminLoggedOutConfirmed = false;

        private void centerLabel(Label lbl)
        {
            lbl.Left = (lbl.Parent.ClientSize.Width - lbl.Width) / 2;
        }

        public void loadAllClasses()
        {
            gridViewClasses.Rows.Clear();
            ClassController classController = new ClassController();

            List<Class> allClasses = classController.getAllClasses();
            if (allClasses.Count > 0)
            {
                foreach (var _class in allClasses)
                {
                    int newRowIdx = gridViewClasses.Rows.Add();
                    DataGridViewRow newRow = gridViewClasses.Rows[newRowIdx];

                    newRow.Cells["id"].Value = _class.id;
                    newRow.Cells["name"].Value = _class.name;
                    newRow.Cells["description"].Value = _class.description;
                    newRow.Cells["startDate"].Value = _class.startDate.ToString(@"MMMM dd, yyyy");
                    newRow.Cells["endDate"].Value = _class.endDate.ToString(@"MMMM dd, yyyy");
                }
            }
        }

        public AdminWindow2(string userName)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            _adminName = userName;
            lblAdmin2DashboardTitle.Text = $"Hello, {_adminName}!";
            centerLabel(lblAdmin2DashboardTitle);
        }

        private void AdminWindow2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !isAdminLoggedOutConfirmed)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to close?", "Logout confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.OpenForms["LoginForm"]?.Show();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnAdmin2Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                isAdminLoggedOutConfirmed = true;
                Application.OpenForms["LoginForm"]?.Show();
                this.Close();
            }
        }

        private void btnCheckExams_Click(object sender, EventArgs e)
        {
            if (gridViewClasses.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridViewClasses.SelectedRows[0];
                int classId = (int)selectedRow.Cells["id"].Value;
                string className = selectedRow.Cells["name"].Value.ToString();

                AdminWindow examsByClass = new AdminWindow(classId, className);
                this.Hide();
                examsByClass.Show();
            }
            else
            {
                DialogResult result = MessageBox.Show("Please choose one class to see its exams", "Class not chosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminWindow2_Load(object sender, EventArgs e)
        {
            loadAllClasses();
            gridViewClasses.ClearSelection();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            Class newClass = new Class();
            AddEditClassForm addEditClassForm = new AddEditClassForm(newClass, "add", this);
            addEditClassForm.Show();
        }

        private void btnEditClass_Click(object sender, EventArgs e)
        {
            Class classToEdit = new Class();
            DataGridViewRow selectedRow = gridViewClasses.SelectedRows[0];

            classToEdit.id = (int)selectedRow.Cells["id"].Value;
            classToEdit.name = selectedRow.Cells["name"].Value.ToString();
            classToEdit.description = selectedRow.Cells["description"].Value.ToString();
            classToEdit.startDate = Convert.ToDateTime(selectedRow.Cells["startDate"].Value);
            classToEdit.endDate = Convert.ToDateTime(selectedRow.Cells["endDate"].Value);

            AddEditClassForm addEditClassForm = new AddEditClassForm(classToEdit, "edit", this);
            addEditClassForm.Show();
        }

        private void btnStudentList_Click(object sender, EventArgs e)
        {
            if (gridViewClasses.SelectedRows.Count > 0)
            {
                int classId = (int)gridViewClasses.SelectedRows[0].Cells["id"].Value;
                string className = gridViewClasses.SelectedRows[0].Cells["name"].Value.ToString();
                StudentList studentListWindow = new StudentList(classId, className, this);
                studentListWindow.Show();
                this.Hide();
            } else
            {
                DialogResult result = MessageBox.Show("Please choose one class to see its students", "Class not chosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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
    public partial class ClassEnrollForm : Form
    {
        private int _contestantId;
        private ClassController _classController = new ClassController();
        private bool isLoggedOutConfirmed;
        private StudentWindow _studentWindow;

        public void loadAvailableClasses(int contestantId)
        {
            gridViewUnenrolledClasses.Rows.Clear();

            List<Class> availableClasses = _classController.getAvailableClasses(contestantId);

            if (availableClasses.Count > 0)
            {
                foreach (var _class in availableClasses)
                {
                    int newRowIdx = gridViewUnenrolledClasses.Rows.Add();
                    DataGridViewRow newRow = gridViewUnenrolledClasses.Rows[newRowIdx];

                    newRow.Cells["id"].Value = _class.id;
                    newRow.Cells["name"].Value = _class.name;
                    newRow.Cells["description"].Value = _class.description;
                    newRow.Cells["startDate"].Value = _class.startDate.ToString("MMMM dd, yyyy");
                    newRow.Cells["endDate"].Value = _class.endDate.ToString("MMMM dd, yyyy");
                }
                gridViewUnenrolledClasses.ClearSelection();
            }
        }

        public ClassEnrollForm(int contestantId, StudentWindow studentWindow)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _contestantId = contestantId;
            _studentWindow = studentWindow;
        }

        private void ClassEnrollForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !isLoggedOutConfirmed)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to close?", "Exit from enrollment form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _studentWindow.loadEnrolledClasses();
                    _studentWindow.Show();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void ClassEnrollForm_Load(object sender, EventArgs e)
        {
            loadAvailableClasses(_contestantId);
            gridViewUnenrolledClasses.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (gridViewUnenrolledClasses.SelectedRows.Count > 0)
            {
                List<DataGridViewRow> rowsToRemove = new List<DataGridViewRow>();

                foreach (DataGridViewRow row in gridViewUnenrolledClasses.SelectedRows)
                {
                    int index = gridViewChosenClasses.Rows.Add();
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        gridViewChosenClasses.Rows[index].Cells[i].Value = row.Cells[i].Value;
                    }

                    rowsToRemove.Add(row);
                }

                foreach (DataGridViewRow row in rowsToRemove)
                {
                    gridViewUnenrolledClasses.Rows.Remove(row);
                }

                gridViewUnenrolledClasses.ClearSelection();
                gridViewChosenClasses.ClearSelection();
            }
            else
            {
                DialogResult result = MessageBox.Show("Please choose at least one class to enroll", "Classes not chosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (gridViewChosenClasses.SelectedRows.Count > 0)
            {
                List<DataGridViewRow> rowsToRemove = new List<DataGridViewRow>();

                foreach (DataGridViewRow row in gridViewChosenClasses.SelectedRows)
                {
                    int index = gridViewUnenrolledClasses.Rows.Add();
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        gridViewUnenrolledClasses.Rows[index].Cells[i].Value = row.Cells[i].Value;
                    }

                    rowsToRemove.Add(row);
                }

                foreach (DataGridViewRow row in rowsToRemove)
                {
                    gridViewChosenClasses.Rows.Remove(row);
                }

                gridViewChosenClasses.ClearSelection();
                gridViewUnenrolledClasses.ClearSelection();
            }
            else
            {
                DialogResult result = MessageBox.Show("Please choose at least one class to unlist", "Classes not chosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (gridViewChosenClasses.Rows.Count > 0)
            {
                List<Class> chosenClasses = new List<Class>();
                foreach (DataGridViewRow row in gridViewChosenClasses.Rows)
                {
                    Class newChosenClass = new Class();
                    newChosenClass.id = (int)row.Cells["chosenId"].Value;
                    newChosenClass.name = row.Cells["chosenName"].Value.ToString();
                    newChosenClass.description = row.Cells["chosenDescription"].Value.ToString();
                    newChosenClass.startDate = DateTime.Parse(row.Cells["chosenStartDate"].Value.ToString());
                    newChosenClass.endDate = DateTime.Parse(row.Cells["chosenEndDate"].Value.ToString());
                    chosenClasses.Add(newChosenClass);
                }

                bool isAddedOkay = _classController.addEnrolledClasses(chosenClasses, _contestantId);
                if (isAddedOkay)
                {
                    DialogResult result = MessageBox.Show("Classes added successfully!", "Classes added okay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridViewChosenClasses.Rows.Clear();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Something went wrong, please try again later", "Classes added failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Please choose at least one class to enroll.", "Classes not chosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

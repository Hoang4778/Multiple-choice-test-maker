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
    public partial class AddEditClassForm : Form
    {
        public Class _currentClass;
        private string _action;
        private bool isCanceledConfirmed = false;
        private AdminWindow2 _adminWindow2;

        public AddEditClassForm(Class currentClass, string action, AdminWindow2 adminWindow2)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _currentClass = currentClass;
            _action = action;
            _adminWindow2 = adminWindow2;
        }

        private void AddEditClassForm_Load(object sender, EventArgs e)
        {
            if (_action == "edit")
            {
                tbxClassName.Text = _currentClass.name;
                richTbxClassDesc.Text = _currentClass.description;
                dpkStartDate.Text = _currentClass.startDate.ToString();
                dtpkEndDate.Text = _currentClass.endDate.ToString();
            }
        }

        private void AddEditClassForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !isCanceledConfirmed)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to cancel now?", "Cancel editing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    _adminWindow2.loadAllClasses();
                }
            }
        }

        private void btnTestSave_Click(object sender, EventArgs e)
        {
            btnClassSave.Enabled = false;
            tbxClassName.Enabled = false;
            richTbxClassDesc.Enabled = false;
            dpkStartDate.Enabled = false;
            dtpkEndDate.Enabled = false;

            _currentClass.name = String.IsNullOrEmpty(tbxClassName.Text.Trim()) ? "Class name 1" : tbxClassName.Text.Trim();
            _currentClass.description = String.IsNullOrEmpty(richTbxClassDesc.Text.Trim()) ? "Class description 1" : richTbxClassDesc.Text.Trim();
            _currentClass.startDate = dpkStartDate.Value.Date;
            _currentClass.endDate = dtpkEndDate.Value.Date;

            ClassController classController = new ClassController();
            if (_action == "add")
            {
                bool isAddedOkay = classController.addClass(_currentClass);

                if (isAddedOkay)
                {
                    MessageBox.Show("New class has been added successfully.", "Adding class successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tbxClassName.Clear();
                    richTbxClassDesc.Clear();
                    dpkStartDate.Value = DateTime.Now;
                    dtpkEndDate.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Something went wrong, please try again later.", "Failed to add class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (_action == "edit")
            {
                bool isEditedOkay = classController.updateClass(_currentClass);

                if (isEditedOkay)
                {
                    MessageBox.Show("The current class has been edited successfully.", "Editing class successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Something went wrong, please try again later.", "Failed to edit class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            btnClassSave.Enabled = true;
            tbxClassName.Enabled = true;
            richTbxClassDesc.Enabled = true;
            dpkStartDate.Enabled = true;
            dtpkEndDate.Enabled = true;
        }

        private void btnClassCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel now?", "Cancel editing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                isCanceledConfirmed = true;
                _adminWindow2.loadAllClasses();
                this.Close();
            }
        }
    }
}

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
    public partial class ReportStudentGradeByClass : Form
    {
        private int _classId;
        private string _className;
        private StudentList _studentListWindow;
        private ClassController _classController = new ClassController();
        private bool _isCloseConfirmed = false;

        private void centerLabel(Label lbl)
        {
            lbl.Left = (lbl.Parent.ClientSize.Width - lbl.Width) / 2;
        }

        public ReportStudentGradeByClass(int classId, string className, StudentList studentListWindow)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            _classId = classId;
            _className = className;
            _studentListWindow = studentListWindow;

            this.Text = $"Student grade for class {_className}";
            lblReportTitle.Text = $"Student grade for class {_className}";
            centerLabel(lblReportTitle);
        }

        private void ReportStudentGradeByClass_Load(object sender, EventArgs e)
        {
            var dt = _classController.reportGetStudentGradeByClass(_classId);

            rptStudentGradeByClass.LocalReport.ReportEmbeddedResource = "DoAnCuoiKy.Report.StudentGradeByClass.rdlc";
            rptStudentGradeByClass.LocalReport.DataSources.Clear();
            rptStudentGradeByClass.LocalReport.DataSources.Add(
                new Microsoft.Reporting.WinForms.ReportDataSource("DS_StudentGradeByClass", dt));

            this.rptStudentGradeByClass.RefreshReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _isCloseConfirmed = true;
            _studentListWindow.Show();
            this.Close();
        }

        private void ReportStudentGradeByClass_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !_isCloseConfirmed)
            {
                _isCloseConfirmed = true;
                _studentListWindow.Show();
            }
        }
    }
}

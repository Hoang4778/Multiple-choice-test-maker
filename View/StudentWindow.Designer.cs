namespace DoAnCuoiKy.View
{
    partial class StudentWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDashboardDesc = new System.Windows.Forms.Label();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.gridViewStudentClasses = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblClasses = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnCheckExams = new System.Windows.Forms.Button();
            this.btnEnrollClass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStudentClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDashboardDesc
            // 
            this.lblDashboardDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDashboardDesc.AutoSize = true;
            this.lblDashboardDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardDesc.Location = new System.Drawing.Point(361, 59);
            this.lblDashboardDesc.Name = "lblDashboardDesc";
            this.lblDashboardDesc.Size = new System.Drawing.Size(455, 25);
            this.lblDashboardDesc.TabIndex = 7;
            this.lblDashboardDesc.Text = "Hope you have a great day and let\'s do some tests!";
            this.lblDashboardDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDashboardTitle.AutoSize = true;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardTitle.Location = new System.Drawing.Point(506, 23);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(165, 36);
            this.lblDashboardTitle.TabIndex = 6;
            this.lblDashboardTitle.Text = "Hello, user!";
            this.lblDashboardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridViewStudentClasses
            // 
            this.gridViewStudentClasses.AllowUserToAddRows = false;
            this.gridViewStudentClasses.AllowUserToDeleteRows = false;
            this.gridViewStudentClasses.AllowUserToOrderColumns = true;
            this.gridViewStudentClasses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewStudentClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewStudentClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewStudentClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.description,
            this.startDate,
            this.endDate,
            this.finalGrade});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewStudentClasses.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridViewStudentClasses.Location = new System.Drawing.Point(12, 143);
            this.gridViewStudentClasses.Name = "gridViewStudentClasses";
            this.gridViewStudentClasses.ReadOnly = true;
            this.gridViewStudentClasses.RowHeadersWidth = 51;
            this.gridViewStudentClasses.RowTemplate.Height = 24;
            this.gridViewStudentClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewStudentClasses.Size = new System.Drawing.Size(1153, 389);
            this.gridViewStudentClasses.TabIndex = 8;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 300;
            // 
            // startDate
            // 
            this.startDate.HeaderText = "Start date";
            this.startDate.MinimumWidth = 6;
            this.startDate.Name = "startDate";
            this.startDate.ReadOnly = true;
            this.startDate.Width = 200;
            // 
            // endDate
            // 
            this.endDate.HeaderText = "End date";
            this.endDate.MinimumWidth = 6;
            this.endDate.Name = "endDate";
            this.endDate.ReadOnly = true;
            this.endDate.Width = 200;
            // 
            // finalGrade
            // 
            this.finalGrade.HeaderText = "Final grade";
            this.finalGrade.MinimumWidth = 6;
            this.finalGrade.Name = "finalGrade";
            this.finalGrade.ReadOnly = true;
            this.finalGrade.Width = 150;
            // 
            // lblClasses
            // 
            this.lblClasses.AutoSize = true;
            this.lblClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasses.Location = new System.Drawing.Point(7, 115);
            this.lblClasses.Name = "lblClasses";
            this.lblClasses.Size = new System.Drawing.Size(154, 25);
            this.lblClasses.TabIndex = 9;
            this.lblClasses.Text = "Enrolled classes";
            this.lblClasses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(12, 549);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(112, 42);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnCheckExams
            // 
            this.btnCheckExams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckExams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckExams.Location = new System.Drawing.Point(1007, 549);
            this.btnCheckExams.Name = "btnCheckExams";
            this.btnCheckExams.Size = new System.Drawing.Size(158, 42);
            this.btnCheckExams.TabIndex = 11;
            this.btnCheckExams.Text = "Check exams";
            this.btnCheckExams.UseVisualStyleBackColor = true;
            this.btnCheckExams.Click += new System.EventHandler(this.btnCheckExams_Click);
            // 
            // btnEnrollClass
            // 
            this.btnEnrollClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnrollClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnrollClass.Location = new System.Drawing.Point(830, 549);
            this.btnEnrollClass.Name = "btnEnrollClass";
            this.btnEnrollClass.Size = new System.Drawing.Size(158, 42);
            this.btnEnrollClass.TabIndex = 12;
            this.btnEnrollClass.Text = "Enroll class";
            this.btnEnrollClass.UseVisualStyleBackColor = true;
            this.btnEnrollClass.Click += new System.EventHandler(this.btnEnrollClass_Click);
            // 
            // StudentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 603);
            this.Controls.Add(this.btnEnrollClass);
            this.Controls.Add(this.btnCheckExams);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblClasses);
            this.Controls.Add(this.gridViewStudentClasses);
            this.Controls.Add(this.lblDashboardDesc);
            this.Controls.Add(this.lblDashboardTitle);
            this.Name = "StudentWindow";
            this.Text = "Student Program";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentWindow_FormClosing);
            this.Load += new System.EventHandler(this.StudentWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStudentClasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDashboardDesc;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.DataGridView gridViewStudentClasses;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalGrade;
        private System.Windows.Forms.Label lblClasses;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnCheckExams;
        private System.Windows.Forms.Button btnEnrollClass;
    }
}
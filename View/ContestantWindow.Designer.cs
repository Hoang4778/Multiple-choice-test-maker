namespace DoAnCuoiKy
{
    partial class ContestantWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.lblDashboardDesc = new System.Windows.Forms.Label();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.gridViewExamsByClass = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCheckGrade = new System.Windows.Forms.Button();
            this.lblExams = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewExamsByClass)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDashboardTitle.AutoSize = true;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardTitle.Location = new System.Drawing.Point(431, 22);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(143, 36);
            this.lblDashboardTitle.TabIndex = 4;
            this.lblDashboardTitle.Text = "Class title";
            this.lblDashboardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDashboardDesc
            // 
            this.lblDashboardDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDashboardDesc.AutoEllipsis = true;
            this.lblDashboardDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardDesc.Location = new System.Drawing.Point(143, 58);
            this.lblDashboardDesc.MaximumSize = new System.Drawing.Size(1200, 500);
            this.lblDashboardDesc.MinimumSize = new System.Drawing.Size(100, 50);
            this.lblDashboardDesc.Name = "lblDashboardDesc";
            this.lblDashboardDesc.Size = new System.Drawing.Size(718, 100);
            this.lblDashboardDesc.TabIndex = 5;
            this.lblDashboardDesc.Text = "Class description";
            this.lblDashboardDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartTest
            // 
            this.btnStartTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTest.Location = new System.Drawing.Point(850, 519);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(142, 51);
            this.btnStartTest.TabIndex = 6;
            this.btnStartTest.Text = "Start exam";
            this.btnStartTest.UseVisualStyleBackColor = true;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // gridViewExamsByClass
            // 
            this.gridViewExamsByClass.AllowUserToAddRows = false;
            this.gridViewExamsByClass.AllowUserToDeleteRows = false;
            this.gridViewExamsByClass.AllowUserToOrderColumns = true;
            this.gridViewExamsByClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewExamsByClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewExamsByClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewExamsByClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewExamsByClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.title,
            this.examDate,
            this.startTime,
            this.duration,
            this.questionAmount,
            this.maxScore});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewExamsByClass.DefaultCellStyle = dataGridViewCellStyle7;
            this.gridViewExamsByClass.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridViewExamsByClass.Location = new System.Drawing.Point(13, 172);
            this.gridViewExamsByClass.MultiSelect = false;
            this.gridViewExamsByClass.Name = "gridViewExamsByClass";
            this.gridViewExamsByClass.ReadOnly = true;
            this.gridViewExamsByClass.RowHeadersWidth = 51;
            this.gridViewExamsByClass.RowTemplate.Height = 24;
            this.gridViewExamsByClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewExamsByClass.Size = new System.Drawing.Size(979, 321);
            this.gridViewExamsByClass.TabIndex = 12;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 60;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.title.HeaderText = "Title";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 78;
            // 
            // examDate
            // 
            this.examDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.examDate.HeaderText = "Exam date";
            this.examDate.MinimumWidth = 200;
            this.examDate.Name = "examDate";
            this.examDate.ReadOnly = true;
            this.examDate.Width = 200;
            // 
            // startTime
            // 
            this.startTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTime.DefaultCellStyle = dataGridViewCellStyle3;
            this.startTime.HeaderText = "Start time";
            this.startTime.MinimumWidth = 130;
            this.startTime.Name = "startTime";
            this.startTime.ReadOnly = true;
            this.startTime.Width = 130;
            // 
            // duration
            // 
            this.duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duration.DefaultCellStyle = dataGridViewCellStyle4;
            this.duration.HeaderText = "Duration (min)";
            this.duration.MinimumWidth = 120;
            this.duration.Name = "duration";
            this.duration.ReadOnly = true;
            this.duration.Width = 164;
            // 
            // questionAmount
            // 
            this.questionAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionAmount.DefaultCellStyle = dataGridViewCellStyle5;
            this.questionAmount.HeaderText = "No. questions";
            this.questionAmount.MinimumWidth = 120;
            this.questionAmount.Name = "questionAmount";
            this.questionAmount.ReadOnly = true;
            this.questionAmount.Width = 160;
            // 
            // maxScore
            // 
            this.maxScore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxScore.DefaultCellStyle = dataGridViewCellStyle6;
            this.maxScore.HeaderText = "Max score";
            this.maxScore.MinimumWidth = 120;
            this.maxScore.Name = "maxScore";
            this.maxScore.ReadOnly = true;
            this.maxScore.Width = 132;
            // 
            // btnCheckGrade
            // 
            this.btnCheckGrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckGrade.Location = new System.Drawing.Point(662, 519);
            this.btnCheckGrade.Name = "btnCheckGrade";
            this.btnCheckGrade.Size = new System.Drawing.Size(169, 51);
            this.btnCheckGrade.TabIndex = 13;
            this.btnCheckGrade.Text = "Check grade";
            this.btnCheckGrade.UseVisualStyleBackColor = true;
            this.btnCheckGrade.Click += new System.EventHandler(this.btnCheckGrade_Click);
            // 
            // lblExams
            // 
            this.lblExams.AutoSize = true;
            this.lblExams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExams.Location = new System.Drawing.Point(8, 144);
            this.lblExams.Name = "lblExams";
            this.lblExams.Size = new System.Drawing.Size(72, 25);
            this.lblExams.TabIndex = 14;
            this.lblExams.Text = "Exams";
            // 
            // lblNote
            // 
            this.lblNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(12, 519);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(624, 62);
            this.lblNote.TabIndex = 15;
            this.lblNote.Text = "** Exams are only opened for 24 hours from the start time, so please start the ex" +
    "am within the time range.**";
            // 
            // ContestantWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 582);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblExams);
            this.Controls.Add(this.btnCheckGrade);
            this.Controls.Add(this.gridViewExamsByClass);
            this.Controls.Add(this.btnStartTest);
            this.Controls.Add(this.lblDashboardDesc);
            this.Controls.Add(this.lblDashboardTitle);
            this.Name = "ContestantWindow";
            this.Text = "Exam dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContestantWindow_FormClosing);
            this.Load += new System.EventHandler(this.ContestantWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewExamsByClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.Label lblDashboardDesc;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.DataGridView gridViewExamsByClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn examDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxScore;
        private System.Windows.Forms.Button btnCheckGrade;
        private System.Windows.Forms.Label lblExams;
        private System.Windows.Forms.Label lblNote;
    }
}
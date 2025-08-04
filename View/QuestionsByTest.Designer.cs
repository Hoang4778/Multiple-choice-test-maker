namespace DoAnCuoiKy.View
{
    partial class QuestionsByTest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTestTitle = new System.Windows.Forms.Label();
            this.lblTestDesc = new System.Windows.Forms.Label();
            this.gridViewQuestions = new System.Windows.Forms.DataGridView();
            this.tbxQuestionContent = new System.Windows.Forms.TextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.lblAnswer3 = new System.Windows.Forms.Label();
            this.lblAnswer4 = new System.Windows.Forms.Label();
            this.tbxAnswer1 = new System.Windows.Forms.TextBox();
            this.tbxAnswer2 = new System.Windows.Forms.TextBox();
            this.tbxAnswer3 = new System.Windows.Forms.TextBox();
            this.tbxAnswer4 = new System.Windows.Forms.TextBox();
            this.cbxCorrectAnswer = new System.Windows.Forms.ComboBox();
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            this.btnSaveQuestion = new System.Windows.Forms.Button();
            this.btnCreateQuestion = new System.Windows.Forms.Button();
            this.btnCancelEditQuestion = new System.Windows.Forms.Button();
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTestTitle
            // 
            this.lblTestTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTestTitle.AutoSize = true;
            this.lblTestTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestTitle.Location = new System.Drawing.Point(369, 26);
            this.lblTestTitle.Name = "lblTestTitle";
            this.lblTestTitle.Size = new System.Drawing.Size(132, 31);
            this.lblTestTitle.TabIndex = 0;
            this.lblTestTitle.Text = "Exam title";
            // 
            // lblTestDesc
            // 
            this.lblTestDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTestDesc.AutoSize = true;
            this.lblTestDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestDesc.Location = new System.Drawing.Point(355, 78);
            this.lblTestDesc.Name = "lblTestDesc";
            this.lblTestDesc.Size = new System.Drawing.Size(161, 25);
            this.lblTestDesc.TabIndex = 1;
            this.lblTestDesc.Text = "Exam description";
            // 
            // gridViewQuestions
            // 
            this.gridViewQuestions.AllowUserToAddRows = false;
            this.gridViewQuestions.AllowUserToDeleteRows = false;
            this.gridViewQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewQuestions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.questionContent});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewQuestions.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridViewQuestions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridViewQuestions.Location = new System.Drawing.Point(12, 149);
            this.gridViewQuestions.MultiSelect = false;
            this.gridViewQuestions.Name = "gridViewQuestions";
            this.gridViewQuestions.ReadOnly = true;
            this.gridViewQuestions.RowHeadersWidth = 51;
            this.gridViewQuestions.RowTemplate.Height = 24;
            this.gridViewQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewQuestions.Size = new System.Drawing.Size(847, 225);
            this.gridViewQuestions.TabIndex = 2;
            this.gridViewQuestions.SelectionChanged += new System.EventHandler(this.gridViewQuestions_SelectionChanged);
            // 
            // tbxQuestionContent
            // 
            this.tbxQuestionContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxQuestionContent.Enabled = false;
            this.tbxQuestionContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxQuestionContent.Location = new System.Drawing.Point(115, 395);
            this.tbxQuestionContent.Multiline = true;
            this.tbxQuestionContent.Name = "tbxQuestionContent";
            this.tbxQuestionContent.Size = new System.Drawing.Size(412, 109);
            this.tbxQuestionContent.TabIndex = 3;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(12, 395);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(97, 25);
            this.lblQuestion.TabIndex = 4;
            this.lblQuestion.Text = "Question:";
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswer1.AutoSize = true;
            this.lblAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer1.Location = new System.Drawing.Point(12, 531);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(100, 25);
            this.lblAnswer1.TabIndex = 5;
            this.lblAnswer1.Text = "Answer 1:";
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer2.Location = new System.Drawing.Point(12, 576);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(100, 25);
            this.lblAnswer2.TabIndex = 6;
            this.lblAnswer2.Text = "Answer 2:";
            // 
            // lblAnswer3
            // 
            this.lblAnswer3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswer3.AutoSize = true;
            this.lblAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer3.Location = new System.Drawing.Point(12, 622);
            this.lblAnswer3.Name = "lblAnswer3";
            this.lblAnswer3.Size = new System.Drawing.Size(100, 25);
            this.lblAnswer3.TabIndex = 7;
            this.lblAnswer3.Text = "Answer 3:";
            // 
            // lblAnswer4
            // 
            this.lblAnswer4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswer4.AutoSize = true;
            this.lblAnswer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer4.Location = new System.Drawing.Point(12, 663);
            this.lblAnswer4.Name = "lblAnswer4";
            this.lblAnswer4.Size = new System.Drawing.Size(100, 25);
            this.lblAnswer4.TabIndex = 8;
            this.lblAnswer4.Text = "Answer 4:";
            // 
            // tbxAnswer1
            // 
            this.tbxAnswer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAnswer1.Enabled = false;
            this.tbxAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAnswer1.Location = new System.Drawing.Point(115, 528);
            this.tbxAnswer1.Name = "tbxAnswer1";
            this.tbxAnswer1.Size = new System.Drawing.Size(412, 30);
            this.tbxAnswer1.TabIndex = 9;
            // 
            // tbxAnswer2
            // 
            this.tbxAnswer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAnswer2.Enabled = false;
            this.tbxAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAnswer2.Location = new System.Drawing.Point(115, 573);
            this.tbxAnswer2.Name = "tbxAnswer2";
            this.tbxAnswer2.Size = new System.Drawing.Size(412, 30);
            this.tbxAnswer2.TabIndex = 10;
            // 
            // tbxAnswer3
            // 
            this.tbxAnswer3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAnswer3.Enabled = false;
            this.tbxAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAnswer3.Location = new System.Drawing.Point(115, 617);
            this.tbxAnswer3.Name = "tbxAnswer3";
            this.tbxAnswer3.Size = new System.Drawing.Size(412, 30);
            this.tbxAnswer3.TabIndex = 11;
            // 
            // tbxAnswer4
            // 
            this.tbxAnswer4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAnswer4.Enabled = false;
            this.tbxAnswer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAnswer4.Location = new System.Drawing.Point(115, 660);
            this.tbxAnswer4.Name = "tbxAnswer4";
            this.tbxAnswer4.Size = new System.Drawing.Size(412, 30);
            this.tbxAnswer4.TabIndex = 12;
            // 
            // cbxCorrectAnswer
            // 
            this.cbxCorrectAnswer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCorrectAnswer.Enabled = false;
            this.cbxCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCorrectAnswer.FormattingEnabled = true;
            this.cbxCorrectAnswer.Items.AddRange(new object[] {
            "Answer 1",
            "Answer 2",
            "Answer 3",
            "Answer 4"});
            this.cbxCorrectAnswer.Location = new System.Drawing.Point(722, 395);
            this.cbxCorrectAnswer.Name = "cbxCorrectAnswer";
            this.cbxCorrectAnswer.Size = new System.Drawing.Size(137, 33);
            this.cbxCorrectAnswer.TabIndex = 13;
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorrectAnswer.AutoSize = true;
            this.lblCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAnswer.Location = new System.Drawing.Point(558, 398);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(150, 25);
            this.lblCorrectAnswer.TabIndex = 14;
            this.lblCorrectAnswer.Text = "Correct answer:";
            // 
            // btnSaveQuestion
            // 
            this.btnSaveQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveQuestion.Enabled = false;
            this.btnSaveQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveQuestion.Location = new System.Drawing.Point(722, 576);
            this.btnSaveQuestion.Name = "btnSaveQuestion";
            this.btnSaveQuestion.Size = new System.Drawing.Size(137, 47);
            this.btnSaveQuestion.TabIndex = 15;
            this.btnSaveQuestion.Text = "Save";
            this.btnSaveQuestion.UseVisualStyleBackColor = true;
            this.btnSaveQuestion.Click += new System.EventHandler(this.btnSaveQuestion_Click);
            // 
            // btnCreateQuestion
            // 
            this.btnCreateQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateQuestion.Location = new System.Drawing.Point(722, 643);
            this.btnCreateQuestion.Name = "btnCreateQuestion";
            this.btnCreateQuestion.Size = new System.Drawing.Size(137, 47);
            this.btnCreateQuestion.TabIndex = 16;
            this.btnCreateQuestion.Text = "Create";
            this.btnCreateQuestion.UseVisualStyleBackColor = true;
            this.btnCreateQuestion.Click += new System.EventHandler(this.btnCreateQuestion_Click);
            // 
            // btnCancelEditQuestion
            // 
            this.btnCancelEditQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelEditQuestion.Enabled = false;
            this.btnCancelEditQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEditQuestion.Location = new System.Drawing.Point(571, 576);
            this.btnCancelEditQuestion.Name = "btnCancelEditQuestion";
            this.btnCancelEditQuestion.Size = new System.Drawing.Size(137, 47);
            this.btnCancelEditQuestion.TabIndex = 17;
            this.btnCancelEditQuestion.Text = "Cancel";
            this.btnCancelEditQuestion.UseVisualStyleBackColor = true;
            this.btnCancelEditQuestion.Click += new System.EventHandler(this.btnCancelEditQuestion_Click);
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteQuestion.Enabled = false;
            this.btnDeleteQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteQuestion.Location = new System.Drawing.Point(571, 643);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(137, 47);
            this.btnDeleteQuestion.TabIndex = 18;
            this.btnDeleteQuestion.Text = "Delete";
            this.btnDeleteQuestion.UseVisualStyleBackColor = true;
            this.btnDeleteQuestion.Click += new System.EventHandler(this.btnDeleteQuestion_Click);
            // 
            // id
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.DefaultCellStyle = dataGridViewCellStyle2;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 60;
            // 
            // questionContent
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionContent.DefaultCellStyle = dataGridViewCellStyle3;
            this.questionContent.HeaderText = "Question";
            this.questionContent.MinimumWidth = 6;
            this.questionContent.Name = "questionContent";
            this.questionContent.ReadOnly = true;
            this.questionContent.Width = 120;
            // 
            // QuestionsByTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 702);
            this.Controls.Add(this.btnDeleteQuestion);
            this.Controls.Add(this.btnCancelEditQuestion);
            this.Controls.Add(this.btnCreateQuestion);
            this.Controls.Add(this.btnSaveQuestion);
            this.Controls.Add(this.lblCorrectAnswer);
            this.Controls.Add(this.cbxCorrectAnswer);
            this.Controls.Add(this.tbxAnswer4);
            this.Controls.Add(this.tbxAnswer3);
            this.Controls.Add(this.tbxAnswer2);
            this.Controls.Add(this.tbxAnswer1);
            this.Controls.Add(this.lblAnswer4);
            this.Controls.Add(this.lblAnswer3);
            this.Controls.Add(this.lblAnswer2);
            this.Controls.Add(this.lblAnswer1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.tbxQuestionContent);
            this.Controls.Add(this.gridViewQuestions);
            this.Controls.Add(this.lblTestDesc);
            this.Controls.Add(this.lblTestTitle);
            this.Name = "QuestionsByTest";
            this.Text = "Questions By Exam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuestionsByTest_FormClosing);
            this.Load += new System.EventHandler(this.QuestionsByTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTestTitle;
        private System.Windows.Forms.Label lblTestDesc;
        private System.Windows.Forms.DataGridView gridViewQuestions;
        private System.Windows.Forms.TextBox tbxQuestionContent;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.Label lblAnswer3;
        private System.Windows.Forms.Label lblAnswer4;
        private System.Windows.Forms.TextBox tbxAnswer1;
        private System.Windows.Forms.TextBox tbxAnswer2;
        private System.Windows.Forms.TextBox tbxAnswer3;
        private System.Windows.Forms.TextBox tbxAnswer4;
        private System.Windows.Forms.ComboBox cbxCorrectAnswer;
        private System.Windows.Forms.Label lblCorrectAnswer;
        private System.Windows.Forms.Button btnSaveQuestion;
        private System.Windows.Forms.Button btnCreateQuestion;
        private System.Windows.Forms.Button btnCancelEditQuestion;
        private System.Windows.Forms.Button btnDeleteQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionContent;
    }
}
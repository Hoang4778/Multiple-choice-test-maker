namespace DoAnCuoiKy.View
{
    partial class ExamWindow
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
            this.components = new System.ComponentModel.Container();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.grpBxAnswers = new System.Windows.Forms.GroupBox();
            this.radBtnAnswer4 = new System.Windows.Forms.RadioButton();
            this.radBtnAnswer3 = new System.Windows.Forms.RadioButton();
            this.radBtnAnswer2 = new System.Windows.Forms.RadioButton();
            this.radBtnAnswer1 = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClearChoice = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.testTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTestDuration = new System.Windows.Forms.Label();
            this.grpBxAnswers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(12, 87);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(194, 29);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question content";
            // 
            // grpBxAnswers
            // 
            this.grpBxAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxAnswers.Controls.Add(this.radBtnAnswer4);
            this.grpBxAnswers.Controls.Add(this.radBtnAnswer3);
            this.grpBxAnswers.Controls.Add(this.radBtnAnswer2);
            this.grpBxAnswers.Controls.Add(this.radBtnAnswer1);
            this.grpBxAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxAnswers.Location = new System.Drawing.Point(12, 212);
            this.grpBxAnswers.Name = "grpBxAnswers";
            this.grpBxAnswers.Size = new System.Drawing.Size(856, 226);
            this.grpBxAnswers.TabIndex = 1;
            this.grpBxAnswers.TabStop = false;
            this.grpBxAnswers.Text = "Answers";
            // 
            // radBtnAnswer4
            // 
            this.radBtnAnswer4.AutoSize = true;
            this.radBtnAnswer4.Location = new System.Drawing.Point(29, 174);
            this.radBtnAnswer4.Name = "radBtnAnswer4";
            this.radBtnAnswer4.Size = new System.Drawing.Size(115, 29);
            this.radBtnAnswer4.TabIndex = 3;
            this.radBtnAnswer4.TabStop = true;
            this.radBtnAnswer4.Text = "Anwser 4";
            this.radBtnAnswer4.UseVisualStyleBackColor = true;
            // 
            // radBtnAnswer3
            // 
            this.radBtnAnswer3.AutoSize = true;
            this.radBtnAnswer3.Location = new System.Drawing.Point(29, 130);
            this.radBtnAnswer3.Name = "radBtnAnswer3";
            this.radBtnAnswer3.Size = new System.Drawing.Size(115, 29);
            this.radBtnAnswer3.TabIndex = 2;
            this.radBtnAnswer3.TabStop = true;
            this.radBtnAnswer3.Text = "Answer 3";
            this.radBtnAnswer3.UseVisualStyleBackColor = true;
            // 
            // radBtnAnswer2
            // 
            this.radBtnAnswer2.AutoSize = true;
            this.radBtnAnswer2.Location = new System.Drawing.Point(29, 85);
            this.radBtnAnswer2.Name = "radBtnAnswer2";
            this.radBtnAnswer2.Size = new System.Drawing.Size(115, 29);
            this.radBtnAnswer2.TabIndex = 1;
            this.radBtnAnswer2.TabStop = true;
            this.radBtnAnswer2.Text = "Answer 2";
            this.radBtnAnswer2.UseVisualStyleBackColor = true;
            // 
            // radBtnAnswer1
            // 
            this.radBtnAnswer1.AutoSize = true;
            this.radBtnAnswer1.CausesValidation = false;
            this.radBtnAnswer1.Location = new System.Drawing.Point(29, 40);
            this.radBtnAnswer1.Name = "radBtnAnswer1";
            this.radBtnAnswer1.Size = new System.Drawing.Size(115, 29);
            this.radBtnAnswer1.TabIndex = 0;
            this.radBtnAnswer1.TabStop = true;
            this.radBtnAnswer1.Text = "Answer 1";
            this.radBtnAnswer1.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(735, 494);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(133, 42);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Enabled = false;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(585, 494);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 42);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Previous";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClearChoice
            // 
            this.btnClearChoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearChoice.Location = new System.Drawing.Point(418, 494);
            this.btnClearChoice.Name = "btnClearChoice";
            this.btnClearChoice.Size = new System.Drawing.Size(150, 42);
            this.btnClearChoice.TabIndex = 4;
            this.btnClearChoice.Text = "Clear choice";
            this.btnClearChoice.UseVisualStyleBackColor = true;
            this.btnClearChoice.Click += new System.EventHandler(this.btnClearChoice_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinish.Enabled = false;
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(12, 494);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(133, 42);
            this.btnFinish.TabIndex = 5;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // testTimer
            // 
            this.testTimer.Interval = 1000;
            this.testTimer.Tick += new System.EventHandler(this.testTimer_Tick);
            // 
            // lblTestDuration
            // 
            this.lblTestDuration.AutoSize = true;
            this.lblTestDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestDuration.Location = new System.Drawing.Point(405, 25);
            this.lblTestDuration.Name = "lblTestDuration";
            this.lblTestDuration.Size = new System.Drawing.Size(71, 29);
            this.lblTestDuration.TabIndex = 7;
            this.lblTestDuration.Text = "00:00";
            // 
            // ExamWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 564);
            this.Controls.Add(this.lblTestDuration);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnClearChoice);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.grpBxAnswers);
            this.Controls.Add(this.lblQuestion);
            this.Name = "ExamWindow";
            this.Text = "Exam window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExamWindow_FormClosing);
            this.Load += new System.EventHandler(this.ExamWindow_Load);
            this.grpBxAnswers.ResumeLayout(false);
            this.grpBxAnswers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.GroupBox grpBxAnswers;
        private System.Windows.Forms.RadioButton radBtnAnswer4;
        private System.Windows.Forms.RadioButton radBtnAnswer3;
        private System.Windows.Forms.RadioButton radBtnAnswer2;
        private System.Windows.Forms.RadioButton radBtnAnswer1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClearChoice;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Timer testTimer;
        private System.Windows.Forms.Label lblTestDuration;
    }
}
namespace DoAnCuoiKy.View
{
    partial class ExamResult
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblExamTitle = new System.Windows.Forms.Label();
            this.lblMaxScore = new System.Windows.Forms.Label();
            this.lblCorrectAnswerAmount = new System.Windows.Forms.Label();
            this.lblFinalGrade = new System.Windows.Forms.Label();
            this.treeViewExamResult = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(665, 676);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 37);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblExamTitle
            // 
            this.lblExamTitle.AutoSize = true;
            this.lblExamTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamTitle.Location = new System.Drawing.Point(343, 40);
            this.lblExamTitle.Name = "lblExamTitle";
            this.lblExamTitle.Size = new System.Drawing.Size(132, 31);
            this.lblExamTitle.TabIndex = 2;
            this.lblExamTitle.Text = "Exam title";
            // 
            // lblMaxScore
            // 
            this.lblMaxScore.AutoSize = true;
            this.lblMaxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxScore.Location = new System.Drawing.Point(16, 109);
            this.lblMaxScore.Name = "lblMaxScore";
            this.lblMaxScore.Size = new System.Drawing.Size(114, 25);
            this.lblMaxScore.TabIndex = 3;
            this.lblMaxScore.Text = "Max score: ";
            // 
            // lblCorrectAnswerAmount
            // 
            this.lblCorrectAnswerAmount.AutoSize = true;
            this.lblCorrectAnswerAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAnswerAmount.Location = new System.Drawing.Point(183, 109);
            this.lblCorrectAnswerAmount.Name = "lblCorrectAnswerAmount";
            this.lblCorrectAnswerAmount.Size = new System.Drawing.Size(195, 25);
            this.lblCorrectAnswerAmount.TabIndex = 4;
            this.lblCorrectAnswerAmount.Text = "No. correct answers: ";
            // 
            // lblFinalGrade
            // 
            this.lblFinalGrade.AutoSize = true;
            this.lblFinalGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalGrade.Location = new System.Drawing.Point(438, 109);
            this.lblFinalGrade.Name = "lblFinalGrade";
            this.lblFinalGrade.Size = new System.Drawing.Size(120, 25);
            this.lblFinalGrade.TabIndex = 5;
            this.lblFinalGrade.Text = "Final grade: ";
            // 
            // treeViewExamResult
            // 
            this.treeViewExamResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewExamResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewExamResult.Location = new System.Drawing.Point(12, 152);
            this.treeViewExamResult.Name = "treeViewExamResult";
            this.treeViewExamResult.Size = new System.Drawing.Size(795, 500);
            this.treeViewExamResult.TabIndex = 6;
            // 
            // ExamResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 725);
            this.Controls.Add(this.treeViewExamResult);
            this.Controls.Add(this.lblFinalGrade);
            this.Controls.Add(this.lblCorrectAnswerAmount);
            this.Controls.Add(this.lblMaxScore);
            this.Controls.Add(this.lblExamTitle);
            this.Controls.Add(this.btnClose);
            this.Name = "ExamResult";
            this.Text = "Exam result";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExamResult_FormClosing);
            this.Load += new System.EventHandler(this.ExamResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblExamTitle;
        private System.Windows.Forms.Label lblMaxScore;
        private System.Windows.Forms.Label lblCorrectAnswerAmount;
        private System.Windows.Forms.Label lblFinalGrade;
        private System.Windows.Forms.TreeView treeViewExamResult;
    }
}
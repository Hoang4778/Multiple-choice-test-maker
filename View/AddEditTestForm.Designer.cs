namespace DoAnCuoiKy.View
{
    partial class AddEditTestForm
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
            this.lblAddEditFormTitle = new System.Windows.Forms.Label();
            this.lblTestTitle = new System.Windows.Forms.Label();
            this.tbxTestTitle = new System.Windows.Forms.TextBox();
            this.lblTestDesc = new System.Windows.Forms.Label();
            this.richTbxTestDesc = new System.Windows.Forms.RichTextBox();
            this.lblTestDate = new System.Windows.Forms.Label();
            this.dpkTestDate = new System.Windows.Forms.DateTimePicker();
            this.lblTestDuration = new System.Windows.Forms.Label();
            this.mskdTestDuration = new System.Windows.Forms.MaskedTextBox();
            this.mskdTestQuestionAmount = new System.Windows.Forms.MaskedTextBox();
            this.lblTestQuestinAmount = new System.Windows.Forms.Label();
            this.mskedTestMaxScore = new System.Windows.Forms.MaskedTextBox();
            this.lblTestMaxScore = new System.Windows.Forms.Label();
            this.lblTestStartTime = new System.Windows.Forms.Label();
            this.tpkTestStartTime = new System.Windows.Forms.DateTimePicker();
            this.btnTestSave = new System.Windows.Forms.Button();
            this.btnTestCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddEditFormTitle
            // 
            this.lblAddEditFormTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddEditFormTitle.AutoSize = true;
            this.lblAddEditFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEditFormTitle.Location = new System.Drawing.Point(183, 9);
            this.lblAddEditFormTitle.Name = "lblAddEditFormTitle";
            this.lblAddEditFormTitle.Size = new System.Drawing.Size(204, 36);
            this.lblAddEditFormTitle.TabIndex = 15;
            this.lblAddEditFormTitle.Text = "Add/edit exam";
            this.lblAddEditFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTestTitle
            // 
            this.lblTestTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTestTitle.AutoSize = true;
            this.lblTestTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestTitle.Location = new System.Drawing.Point(104, 51);
            this.lblTestTitle.Name = "lblTestTitle";
            this.lblTestTitle.Size = new System.Drawing.Size(49, 25);
            this.lblTestTitle.TabIndex = 16;
            this.lblTestTitle.Text = "Title";
            // 
            // tbxTestTitle
            // 
            this.tbxTestTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTestTitle.Location = new System.Drawing.Point(109, 79);
            this.tbxTestTitle.Name = "tbxTestTitle";
            this.tbxTestTitle.Size = new System.Drawing.Size(366, 30);
            this.tbxTestTitle.TabIndex = 17;
            // 
            // lblTestDesc
            // 
            this.lblTestDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTestDesc.AutoSize = true;
            this.lblTestDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestDesc.Location = new System.Drawing.Point(104, 121);
            this.lblTestDesc.Name = "lblTestDesc";
            this.lblTestDesc.Size = new System.Drawing.Size(109, 25);
            this.lblTestDesc.TabIndex = 18;
            this.lblTestDesc.Text = "Description";
            // 
            // richTbxTestDesc
            // 
            this.richTbxTestDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTbxTestDesc.Location = new System.Drawing.Point(109, 149);
            this.richTbxTestDesc.Name = "richTbxTestDesc";
            this.richTbxTestDesc.Size = new System.Drawing.Size(366, 132);
            this.richTbxTestDesc.TabIndex = 20;
            this.richTbxTestDesc.Text = "";
            // 
            // lblTestDate
            // 
            this.lblTestDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTestDate.AutoSize = true;
            this.lblTestDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestDate.Location = new System.Drawing.Point(104, 297);
            this.lblTestDate.Name = "lblTestDate";
            this.lblTestDate.Size = new System.Drawing.Size(105, 25);
            this.lblTestDate.TabIndex = 21;
            this.lblTestDate.Text = "Exam date";
            // 
            // dpkTestDate
            // 
            this.dpkTestDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dpkTestDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkTestDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkTestDate.Location = new System.Drawing.Point(109, 325);
            this.dpkTestDate.MinDate = new System.DateTime(2025, 3, 24, 0, 0, 0, 0);
            this.dpkTestDate.Name = "dpkTestDate";
            this.dpkTestDate.Size = new System.Drawing.Size(366, 30);
            this.dpkTestDate.TabIndex = 22;
            this.dpkTestDate.Value = new System.DateTime(2025, 3, 24, 1, 9, 20, 0);
            // 
            // lblTestDuration
            // 
            this.lblTestDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTestDuration.AutoSize = true;
            this.lblTestDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestDuration.Location = new System.Drawing.Point(104, 456);
            this.lblTestDuration.Name = "lblTestDuration";
            this.lblTestDuration.Size = new System.Drawing.Size(135, 25);
            this.lblTestDuration.TabIndex = 23;
            this.lblTestDuration.Text = "Duration (min)";
            // 
            // mskdTestDuration
            // 
            this.mskdTestDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskdTestDuration.Location = new System.Drawing.Point(109, 484);
            this.mskdTestDuration.Mask = "000";
            this.mskdTestDuration.Name = "mskdTestDuration";
            this.mskdTestDuration.Size = new System.Drawing.Size(366, 30);
            this.mskdTestDuration.TabIndex = 24;
            // 
            // mskdTestQuestionAmount
            // 
            this.mskdTestQuestionAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskdTestQuestionAmount.Location = new System.Drawing.Point(109, 561);
            this.mskdTestQuestionAmount.Mask = "000";
            this.mskdTestQuestionAmount.Name = "mskdTestQuestionAmount";
            this.mskdTestQuestionAmount.Size = new System.Drawing.Size(366, 30);
            this.mskdTestQuestionAmount.TabIndex = 26;
            // 
            // lblTestQuestinAmount
            // 
            this.lblTestQuestinAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTestQuestinAmount.AutoSize = true;
            this.lblTestQuestinAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestQuestinAmount.Location = new System.Drawing.Point(104, 533);
            this.lblTestQuestinAmount.Name = "lblTestQuestinAmount";
            this.lblTestQuestinAmount.Size = new System.Drawing.Size(161, 25);
            this.lblTestQuestinAmount.TabIndex = 25;
            this.lblTestQuestinAmount.Text = "Question amount";
            // 
            // mskedTestMaxScore
            // 
            this.mskedTestMaxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskedTestMaxScore.Location = new System.Drawing.Point(109, 642);
            this.mskedTestMaxScore.Mask = "000";
            this.mskedTestMaxScore.Name = "mskedTestMaxScore";
            this.mskedTestMaxScore.Size = new System.Drawing.Size(366, 30);
            this.mskedTestMaxScore.TabIndex = 28;
            // 
            // lblTestMaxScore
            // 
            this.lblTestMaxScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTestMaxScore.AutoSize = true;
            this.lblTestMaxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestMaxScore.Location = new System.Drawing.Point(104, 614);
            this.lblTestMaxScore.Name = "lblTestMaxScore";
            this.lblTestMaxScore.Size = new System.Drawing.Size(103, 25);
            this.lblTestMaxScore.TabIndex = 27;
            this.lblTestMaxScore.Text = "Max score";
            // 
            // lblTestStartTime
            // 
            this.lblTestStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTestStartTime.AutoSize = true;
            this.lblTestStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestStartTime.Location = new System.Drawing.Point(104, 376);
            this.lblTestStartTime.Name = "lblTestStartTime";
            this.lblTestStartTime.Size = new System.Drawing.Size(94, 25);
            this.lblTestStartTime.TabIndex = 29;
            this.lblTestStartTime.Text = "Start time";
            // 
            // tpkTestStartTime
            // 
            this.tpkTestStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tpkTestStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpkTestStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.tpkTestStartTime.Location = new System.Drawing.Point(109, 404);
            this.tpkTestStartTime.Name = "tpkTestStartTime";
            this.tpkTestStartTime.Size = new System.Drawing.Size(366, 30);
            this.tpkTestStartTime.TabIndex = 30;
            // 
            // btnTestSave
            // 
            this.btnTestSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestSave.Location = new System.Drawing.Point(358, 691);
            this.btnTestSave.Name = "btnTestSave";
            this.btnTestSave.Size = new System.Drawing.Size(117, 35);
            this.btnTestSave.TabIndex = 31;
            this.btnTestSave.Text = "Save";
            this.btnTestSave.UseVisualStyleBackColor = true;
            this.btnTestSave.Click += new System.EventHandler(this.btnTestSave_Click);
            // 
            // btnTestCancel
            // 
            this.btnTestCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestCancel.Location = new System.Drawing.Point(109, 691);
            this.btnTestCancel.Name = "btnTestCancel";
            this.btnTestCancel.Size = new System.Drawing.Size(117, 35);
            this.btnTestCancel.TabIndex = 32;
            this.btnTestCancel.Text = "Cancel";
            this.btnTestCancel.UseVisualStyleBackColor = true;
            this.btnTestCancel.Click += new System.EventHandler(this.btnTestCancel_Click);
            // 
            // AddEditTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 739);
            this.Controls.Add(this.btnTestCancel);
            this.Controls.Add(this.btnTestSave);
            this.Controls.Add(this.tpkTestStartTime);
            this.Controls.Add(this.lblTestStartTime);
            this.Controls.Add(this.mskedTestMaxScore);
            this.Controls.Add(this.lblTestMaxScore);
            this.Controls.Add(this.mskdTestQuestionAmount);
            this.Controls.Add(this.lblTestQuestinAmount);
            this.Controls.Add(this.mskdTestDuration);
            this.Controls.Add(this.lblTestDuration);
            this.Controls.Add(this.dpkTestDate);
            this.Controls.Add(this.lblTestDate);
            this.Controls.Add(this.richTbxTestDesc);
            this.Controls.Add(this.lblTestDesc);
            this.Controls.Add(this.tbxTestTitle);
            this.Controls.Add(this.lblTestTitle);
            this.Controls.Add(this.lblAddEditFormTitle);
            this.Name = "AddEditTestForm";
            this.Text = "Add/Edit exam form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditTestForm_FormClosing);
            this.Load += new System.EventHandler(this.AddEditTestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddEditFormTitle;
        private System.Windows.Forms.Label lblTestTitle;
        private System.Windows.Forms.TextBox tbxTestTitle;
        private System.Windows.Forms.Label lblTestDesc;
        private System.Windows.Forms.RichTextBox richTbxTestDesc;
        private System.Windows.Forms.Label lblTestDate;
        private System.Windows.Forms.DateTimePicker dpkTestDate;
        private System.Windows.Forms.Label lblTestDuration;
        private System.Windows.Forms.MaskedTextBox mskdTestDuration;
        private System.Windows.Forms.MaskedTextBox mskdTestQuestionAmount;
        private System.Windows.Forms.Label lblTestQuestinAmount;
        private System.Windows.Forms.MaskedTextBox mskedTestMaxScore;
        private System.Windows.Forms.Label lblTestMaxScore;
        private System.Windows.Forms.Label lblTestStartTime;
        private System.Windows.Forms.DateTimePicker tpkTestStartTime;
        private System.Windows.Forms.Button btnTestSave;
        private System.Windows.Forms.Button btnTestCancel;
    }
}
namespace DoAnCuoiKy.View
{
    partial class AddEditClassForm
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
            this.btnClassCancel = new System.Windows.Forms.Button();
            this.btnClassSave = new System.Windows.Forms.Button();
            this.lblClassEndDate = new System.Windows.Forms.Label();
            this.dpkStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.richTbxClassDesc = new System.Windows.Forms.RichTextBox();
            this.lblClassDesc = new System.Windows.Forms.Label();
            this.tbxClassName = new System.Windows.Forms.TextBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblAddEditFormTitle = new System.Windows.Forms.Label();
            this.dtpkEndDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnClassCancel
            // 
            this.btnClassCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassCancel.Location = new System.Drawing.Point(123, 485);
            this.btnClassCancel.Name = "btnClassCancel";
            this.btnClassCancel.Size = new System.Drawing.Size(117, 35);
            this.btnClassCancel.TabIndex = 49;
            this.btnClassCancel.Text = "Cancel";
            this.btnClassCancel.UseVisualStyleBackColor = true;
            this.btnClassCancel.Click += new System.EventHandler(this.btnClassCancel_Click);
            // 
            // btnClassSave
            // 
            this.btnClassSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassSave.Location = new System.Drawing.Point(372, 485);
            this.btnClassSave.Name = "btnClassSave";
            this.btnClassSave.Size = new System.Drawing.Size(117, 35);
            this.btnClassSave.TabIndex = 48;
            this.btnClassSave.Text = "Save";
            this.btnClassSave.UseVisualStyleBackColor = true;
            this.btnClassSave.Click += new System.EventHandler(this.btnTestSave_Click);
            // 
            // lblClassEndDate
            // 
            this.lblClassEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblClassEndDate.AutoSize = true;
            this.lblClassEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassEndDate.Location = new System.Drawing.Point(118, 394);
            this.lblClassEndDate.Name = "lblClassEndDate";
            this.lblClassEndDate.Size = new System.Drawing.Size(90, 25);
            this.lblClassEndDate.TabIndex = 46;
            this.lblClassEndDate.Text = "End date";
            // 
            // dpkStartDate
            // 
            this.dpkStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dpkStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpkStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkStartDate.Location = new System.Drawing.Point(123, 343);
            this.dpkStartDate.MinDate = new System.DateTime(2025, 3, 24, 0, 0, 0, 0);
            this.dpkStartDate.Name = "dpkStartDate";
            this.dpkStartDate.Size = new System.Drawing.Size(366, 30);
            this.dpkStartDate.TabIndex = 39;
            this.dpkStartDate.Value = new System.DateTime(2025, 3, 24, 1, 9, 20, 0);
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(118, 315);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(96, 25);
            this.lblStartDate.TabIndex = 38;
            this.lblStartDate.Text = "Start date";
            // 
            // richTbxClassDesc
            // 
            this.richTbxClassDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTbxClassDesc.Location = new System.Drawing.Point(123, 167);
            this.richTbxClassDesc.Name = "richTbxClassDesc";
            this.richTbxClassDesc.Size = new System.Drawing.Size(366, 132);
            this.richTbxClassDesc.TabIndex = 37;
            this.richTbxClassDesc.Text = "";
            // 
            // lblClassDesc
            // 
            this.lblClassDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblClassDesc.AutoSize = true;
            this.lblClassDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassDesc.Location = new System.Drawing.Point(118, 139);
            this.lblClassDesc.Name = "lblClassDesc";
            this.lblClassDesc.Size = new System.Drawing.Size(109, 25);
            this.lblClassDesc.TabIndex = 36;
            this.lblClassDesc.Text = "Description";
            // 
            // tbxClassName
            // 
            this.tbxClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxClassName.Location = new System.Drawing.Point(123, 97);
            this.tbxClassName.Name = "tbxClassName";
            this.tbxClassName.Size = new System.Drawing.Size(366, 30);
            this.tbxClassName.TabIndex = 35;
            // 
            // lblClassName
            // 
            this.lblClassName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.Location = new System.Drawing.Point(118, 69);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(64, 25);
            this.lblClassName.TabIndex = 34;
            this.lblClassName.Text = "Name";
            // 
            // lblAddEditFormTitle
            // 
            this.lblAddEditFormTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddEditFormTitle.AutoSize = true;
            this.lblAddEditFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEditFormTitle.Location = new System.Drawing.Point(199, 19);
            this.lblAddEditFormTitle.Name = "lblAddEditFormTitle";
            this.lblAddEditFormTitle.Size = new System.Drawing.Size(202, 36);
            this.lblAddEditFormTitle.TabIndex = 33;
            this.lblAddEditFormTitle.Text = "Add/edit class";
            this.lblAddEditFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpkEndDate
            // 
            this.dtpkEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpkEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkEndDate.Location = new System.Drawing.Point(123, 422);
            this.dtpkEndDate.MinDate = new System.DateTime(2025, 3, 24, 0, 0, 0, 0);
            this.dtpkEndDate.Name = "dtpkEndDate";
            this.dtpkEndDate.Size = new System.Drawing.Size(366, 30);
            this.dtpkEndDate.TabIndex = 50;
            this.dtpkEndDate.Value = new System.DateTime(2025, 3, 24, 1, 9, 20, 0);
            // 
            // AddEditClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 546);
            this.Controls.Add(this.dtpkEndDate);
            this.Controls.Add(this.btnClassCancel);
            this.Controls.Add(this.btnClassSave);
            this.Controls.Add(this.lblClassEndDate);
            this.Controls.Add(this.dpkStartDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.richTbxClassDesc);
            this.Controls.Add(this.lblClassDesc);
            this.Controls.Add(this.tbxClassName);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.lblAddEditFormTitle);
            this.Name = "AddEditClassForm";
            this.Text = "Add/Edit class form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditClassForm_FormClosing);
            this.Load += new System.EventHandler(this.AddEditClassForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClassCancel;
        private System.Windows.Forms.Button btnClassSave;
        private System.Windows.Forms.Label lblClassEndDate;
        private System.Windows.Forms.DateTimePicker dpkStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.RichTextBox richTbxClassDesc;
        private System.Windows.Forms.Label lblClassDesc;
        private System.Windows.Forms.TextBox tbxClassName;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblAddEditFormTitle;
        private System.Windows.Forms.DateTimePicker dtpkEndDate;
    }
}
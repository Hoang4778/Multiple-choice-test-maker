namespace DoAnCuoiKy.View
{
    partial class ClassEnrollForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.gridViewUnenrolledClasses = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblUnenrolledClasses = new System.Windows.Forms.Label();
            this.gridViewChosenClasses = new System.Windows.Forms.DataGridView();
            this.chosenId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chosenName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chosenDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chosenStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chosenEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblChosenClasses = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUnenrolledClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChosenClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDashboardTitle.AutoSize = true;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardTitle.Location = new System.Drawing.Point(376, 26);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(244, 36);
            this.lblDashboardTitle.TabIndex = 7;
            this.lblDashboardTitle.Text = "Available classes";
            this.lblDashboardTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridViewUnenrolledClasses
            // 
            this.gridViewUnenrolledClasses.AllowUserToAddRows = false;
            this.gridViewUnenrolledClasses.AllowUserToDeleteRows = false;
            this.gridViewUnenrolledClasses.AllowUserToOrderColumns = true;
            this.gridViewUnenrolledClasses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewUnenrolledClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.gridViewUnenrolledClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewUnenrolledClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.description,
            this.startDate,
            this.endDate});
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewUnenrolledClasses.DefaultCellStyle = dataGridViewCellStyle25;
            this.gridViewUnenrolledClasses.Location = new System.Drawing.Point(12, 112);
            this.gridViewUnenrolledClasses.Name = "gridViewUnenrolledClasses";
            this.gridViewUnenrolledClasses.ReadOnly = true;
            this.gridViewUnenrolledClasses.RowHeadersWidth = 51;
            this.gridViewUnenrolledClasses.RowTemplate.Height = 24;
            this.gridViewUnenrolledClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewUnenrolledClasses.Size = new System.Drawing.Size(973, 227);
            this.gridViewUnenrolledClasses.TabIndex = 17;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.DefaultCellStyle = dataGridViewCellStyle22;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 60;
            // 
            // name
            // 
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.DefaultCellStyle = dataGridViewCellStyle23;
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // description
            // 
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.DefaultCellStyle = dataGridViewCellStyle24;
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
            this.startDate.Width = 180;
            // 
            // endDate
            // 
            this.endDate.HeaderText = "End date";
            this.endDate.MinimumWidth = 6;
            this.endDate.Name = "endDate";
            this.endDate.ReadOnly = true;
            this.endDate.Width = 180;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(827, 355);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(158, 42);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblUnenrolledClasses
            // 
            this.lblUnenrolledClasses.AutoSize = true;
            this.lblUnenrolledClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnenrolledClasses.Location = new System.Drawing.Point(7, 84);
            this.lblUnenrolledClasses.Name = "lblUnenrolledClasses";
            this.lblUnenrolledClasses.Size = new System.Drawing.Size(177, 25);
            this.lblUnenrolledClasses.TabIndex = 19;
            this.lblUnenrolledClasses.Text = "Unenrolled classes";
            this.lblUnenrolledClasses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridViewChosenClasses
            // 
            this.gridViewChosenClasses.AllowUserToAddRows = false;
            this.gridViewChosenClasses.AllowUserToDeleteRows = false;
            this.gridViewChosenClasses.AllowUserToOrderColumns = true;
            this.gridViewChosenClasses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewChosenClasses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.gridViewChosenClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewChosenClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chosenId,
            this.chosenName,
            this.chosenDescription,
            this.chosenStartDate,
            this.chosenEndDate});
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewChosenClasses.DefaultCellStyle = dataGridViewCellStyle30;
            this.gridViewChosenClasses.Location = new System.Drawing.Point(12, 460);
            this.gridViewChosenClasses.Name = "gridViewChosenClasses";
            this.gridViewChosenClasses.ReadOnly = true;
            this.gridViewChosenClasses.RowHeadersWidth = 51;
            this.gridViewChosenClasses.RowTemplate.Height = 24;
            this.gridViewChosenClasses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewChosenClasses.Size = new System.Drawing.Size(973, 233);
            this.gridViewChosenClasses.TabIndex = 20;
            // 
            // chosenId
            // 
            this.chosenId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenId.DefaultCellStyle = dataGridViewCellStyle27;
            this.chosenId.HeaderText = "ID";
            this.chosenId.MinimumWidth = 6;
            this.chosenId.Name = "chosenId";
            this.chosenId.ReadOnly = true;
            this.chosenId.Width = 60;
            // 
            // chosenName
            // 
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenName.DefaultCellStyle = dataGridViewCellStyle28;
            this.chosenName.HeaderText = "Name";
            this.chosenName.MinimumWidth = 6;
            this.chosenName.Name = "chosenName";
            this.chosenName.ReadOnly = true;
            this.chosenName.Width = 200;
            // 
            // chosenDescription
            // 
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenDescription.DefaultCellStyle = dataGridViewCellStyle29;
            this.chosenDescription.HeaderText = "Description";
            this.chosenDescription.MinimumWidth = 6;
            this.chosenDescription.Name = "chosenDescription";
            this.chosenDescription.ReadOnly = true;
            this.chosenDescription.Width = 300;
            // 
            // chosenStartDate
            // 
            this.chosenStartDate.HeaderText = "Start date";
            this.chosenStartDate.MinimumWidth = 6;
            this.chosenStartDate.Name = "chosenStartDate";
            this.chosenStartDate.ReadOnly = true;
            this.chosenStartDate.Width = 180;
            // 
            // chosenEndDate
            // 
            this.chosenEndDate.HeaderText = "End date";
            this.chosenEndDate.MinimumWidth = 6;
            this.chosenEndDate.Name = "chosenEndDate";
            this.chosenEndDate.ReadOnly = true;
            this.chosenEndDate.Width = 180;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(827, 712);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(158, 42);
            this.btnRemove.TabIndex = 21;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblChosenClasses
            // 
            this.lblChosenClasses.AutoSize = true;
            this.lblChosenClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChosenClasses.Location = new System.Drawing.Point(7, 432);
            this.lblChosenClasses.Name = "lblChosenClasses";
            this.lblChosenClasses.Size = new System.Drawing.Size(152, 25);
            this.lblChosenClasses.TabIndex = 22;
            this.lblChosenClasses.Text = "Chosen classes";
            this.lblChosenClasses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(646, 712);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(158, 42);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ClassEnrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 766);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblChosenClasses);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gridViewChosenClasses);
            this.Controls.Add(this.lblUnenrolledClasses);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridViewUnenrolledClasses);
            this.Controls.Add(this.lblDashboardTitle);
            this.Name = "ClassEnrollForm";
            this.Text = "Classes to enroll";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClassEnrollForm_FormClosing);
            this.Load += new System.EventHandler(this.ClassEnrollForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUnenrolledClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChosenClasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.DataGridView gridViewUnenrolledClasses;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblUnenrolledClasses;
        private System.Windows.Forms.DataGridView gridViewChosenClasses;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblChosenClasses;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn chosenId;
        private System.Windows.Forms.DataGridViewTextBoxColumn chosenName;
        private System.Windows.Forms.DataGridViewTextBoxColumn chosenDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn chosenStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn chosenEndDate;
    }
}
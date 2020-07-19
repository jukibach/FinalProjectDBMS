namespace WindowsForm_FinalProject.Views
{
    partial class AddStudentsToProjectForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbCourse = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.idStudent = new System.Windows.Forms.Label();
            this.dataStudent = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGender = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPicture = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnFindP = new System.Windows.Forms.Button();
            this.btnAddP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataStudent);
            this.splitContainer1.Size = new System.Drawing.Size(1287, 552);
            this.splitContainer1.SplitterDistance = 590;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(108, 40);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(305, 53);
            this.panel4.TabIndex = 80;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(51, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(210, 29);
            this.label12.TabIndex = 72;
            this.label12.Text = "Students\' Project";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnFindP);
            this.panel1.Controls.Add(this.cbbCourse);
            this.panel1.Controls.Add(this.btnAddP);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.idStudent);
            this.panel1.Location = new System.Drawing.Point(25, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 404);
            this.panel1.TabIndex = 26;
            // 
            // cbbCourse
            // 
            this.cbbCourse.FormattingEnabled = true;
            this.cbbCourse.Location = new System.Drawing.Point(163, 64);
            this.cbbCourse.Name = "cbbCourse";
            this.cbbCourse.Size = new System.Drawing.Size(189, 24);
            this.cbbCourse.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 24);
            this.label11.TabIndex = 20;
            this.label11.Text = "Project Name";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(163, 181);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(189, 22);
            this.txtID.TabIndex = 24;
            // 
            // idStudent
            // 
            this.idStudent.AutoSize = true;
            this.idStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.idStudent.Location = new System.Drawing.Point(16, 181);
            this.idStudent.Name = "idStudent";
            this.idStudent.Size = new System.Drawing.Size(121, 25);
            this.idStudent.TabIndex = 23;
            this.idStudent.Text = "ID students";
            // 
            // dataStudent
            // 
            this.dataStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataStudent.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cFullname,
            this.cBirthday,
            this.cGender,
            this.cClass,
            this.cEmail,
            this.cPhone,
            this.cPicture});
            this.dataStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataStudent.Location = new System.Drawing.Point(0, 0);
            this.dataStudent.Name = "dataStudent";
            this.dataStudent.ReadOnly = true;
            this.dataStudent.RowHeadersWidth = 51;
            this.dataStudent.RowTemplate.Height = 24;
            this.dataStudent.Size = new System.Drawing.Size(693, 552);
            this.dataStudent.TabIndex = 0;
            // 
            // cID
            // 
            this.cID.HeaderText = "ID";
            this.cID.MinimumWidth = 6;
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            // 
            // cFullname
            // 
            this.cFullname.HeaderText = "Full name";
            this.cFullname.MinimumWidth = 6;
            this.cFullname.Name = "cFullname";
            this.cFullname.ReadOnly = true;
            // 
            // cBirthday
            // 
            this.cBirthday.HeaderText = "Birthday";
            this.cBirthday.MinimumWidth = 6;
            this.cBirthday.Name = "cBirthday";
            this.cBirthday.ReadOnly = true;
            // 
            // cGender
            // 
            this.cGender.DisplayStyleForCurrentCellOnly = true;
            this.cGender.HeaderText = "Gender";
            this.cGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cGender.MinimumWidth = 6;
            this.cGender.Name = "cGender";
            this.cGender.ReadOnly = true;
            // 
            // cClass
            // 
            this.cClass.HeaderText = "Class";
            this.cClass.MinimumWidth = 6;
            this.cClass.Name = "cClass";
            this.cClass.ReadOnly = true;
            this.cClass.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cClass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cEmail
            // 
            this.cEmail.HeaderText = "Email";
            this.cEmail.MinimumWidth = 6;
            this.cEmail.Name = "cEmail";
            this.cEmail.ReadOnly = true;
            this.cEmail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cPhone
            // 
            this.cPhone.HeaderText = "Phone";
            this.cPhone.MinimumWidth = 6;
            this.cPhone.Name = "cPhone";
            this.cPhone.ReadOnly = true;
            this.cPhone.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cPicture
            // 
            this.cPicture.HeaderText = "Picture";
            this.cPicture.MinimumWidth = 6;
            this.cPicture.Name = "cPicture";
            this.cPicture.ReadOnly = true;
            // 
            // btnFindP
            // 
            this.btnFindP.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFindP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindP.Image = global::WindowsForm_FinalProject.Properties.Resources.search;
            this.btnFindP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindP.Location = new System.Drawing.Point(227, 312);
            this.btnFindP.Name = "btnFindP";
            this.btnFindP.Size = new System.Drawing.Size(180, 69);
            this.btnFindP.TabIndex = 26;
            this.btnFindP.Text = "Find Project";
            this.btnFindP.UseVisualStyleBackColor = false;
            this.btnFindP.Click += new System.EventHandler(this.btnFindC_Click);
            // 
            // btnAddP
            // 
            this.btnAddP.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddP.Image = global::WindowsForm_FinalProject.Properties.Resources.plus1;
            this.btnAddP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddP.Location = new System.Drawing.Point(21, 312);
            this.btnAddP.Name = "btnAddP";
            this.btnAddP.Size = new System.Drawing.Size(155, 69);
            this.btnAddP.TabIndex = 25;
            this.btnAddP.Text = "Add";
            this.btnAddP.UseVisualStyleBackColor = false;
            this.btnAddP.Click += new System.EventHandler(this.btnAddP_Click);
            // 
            // AddStudentsToProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 552);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AddStudentsToProjectForm";
            this.Text = "Add Student to Project";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbbCourse;
        private System.Windows.Forms.DataGridView dataStudent;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label idStudent;
        private System.Windows.Forms.Button btnAddP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFindP;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBirthday;
        private System.Windows.Forms.DataGridViewComboBoxColumn cGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn cClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhone;
        private System.Windows.Forms.DataGridViewImageColumn cPicture;
    }
}
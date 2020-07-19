namespace WindowsForm_FinalProject.Views
{
    partial class ProjectManagementForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataProject = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cPBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.form = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ccbType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateBegin = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteP = new System.Windows.Forms.Button();
            this.btnAddP = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProject)).BeginInit();
            this.form.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.26568F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.73432F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.form, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1427, 511);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataProject);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(620, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 505);
            this.panel1.TabIndex = 0;
            // 
            // dataProject
            // 
            this.dataProject.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cPName,
            this.cPContent,
            this.cPType,
            this.cPBegin,
            this.cPEnd});
            this.dataProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataProject.Location = new System.Drawing.Point(0, 0);
            this.dataProject.Name = "dataProject";
            this.dataProject.RowHeadersWidth = 51;
            this.dataProject.RowTemplate.Height = 24;
            this.dataProject.Size = new System.Drawing.Size(804, 505);
            this.dataProject.TabIndex = 0;
            this.dataProject.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProject_CellEndEdit);
            // 
            // cID
            // 
            this.cID.HeaderText = "ID";
            this.cID.MinimumWidth = 6;
            this.cID.Name = "cID";
            this.cID.Width = 125;
            // 
            // cPName
            // 
            this.cPName.HeaderText = "Project Name";
            this.cPName.MinimumWidth = 6;
            this.cPName.Name = "cPName";
            this.cPName.Width = 125;
            // 
            // cPContent
            // 
            this.cPContent.HeaderText = "Content";
            this.cPContent.MinimumWidth = 6;
            this.cPContent.Name = "cPContent";
            this.cPContent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cPContent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cPContent.Width = 125;
            // 
            // cPType
            // 
            this.cPType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cPType.HeaderText = "Type";
            this.cPType.Items.AddRange(new object[] {
            "Course",
            "Graduation"});
            this.cPType.MinimumWidth = 6;
            this.cPType.Name = "cPType";
            this.cPType.Width = 125;
            // 
            // cPBegin
            // 
            this.cPBegin.HeaderText = "Begin";
            this.cPBegin.MinimumWidth = 6;
            this.cPBegin.Name = "cPBegin";
            this.cPBegin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cPBegin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cPBegin.Width = 125;
            // 
            // cPEnd
            // 
            this.cPEnd.HeaderText = "End";
            this.cPEnd.MinimumWidth = 6;
            this.cPEnd.Name = "cPEnd";
            this.cPEnd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cPEnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cPEnd.Width = 125;
            // 
            // form
            // 
            this.form.BackColor = System.Drawing.Color.BlueViolet;
            this.form.Controls.Add(this.panel3);
            this.form.Controls.Add(this.panel2);
            this.form.Controls.Add(this.btnUpdate);
            this.form.Controls.Add(this.btnDeleteP);
            this.form.Controls.Add(this.btnAddP);
            this.form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form.Location = new System.Drawing.Point(3, 3);
            this.form.Name = "form";
            this.form.Size = new System.Drawing.Size(611, 505);
            this.form.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(27, 25);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(496, 61);
            this.panel3.TabIndex = 106;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(156, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 31);
            this.label7.TabIndex = 72;
            this.label7.Text = "Project info";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ccbType);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dateBegin);
            this.panel2.Controls.Add(this.dateEnd);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtContent);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtPName);
            this.panel2.Location = new System.Drawing.Point(11, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 232);
            this.panel2.TabIndex = 20;
            // 
            // ccbType
            // 
            this.ccbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccbType.FormattingEnabled = true;
            this.ccbType.Items.AddRange(new object[] {
            "Course",
            "Graduation"});
            this.ccbType.Location = new System.Drawing.Point(147, 163);
            this.ccbType.Name = "ccbType";
            this.ccbType.Size = new System.Drawing.Size(129, 28);
            this.ccbType.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(32, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Project ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(77, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(147, 13);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(129, 26);
            this.txtID.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(296, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Begin";
            // 
            // dateBegin
            // 
            this.dateBegin.CustomFormat = "dd/MM/yyyy";
            this.dateBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBegin.Location = new System.Drawing.Point(371, 60);
            this.dateBegin.Name = "dateBegin";
            this.dateBegin.Size = new System.Drawing.Size(121, 26);
            this.dateBegin.TabIndex = 7;
            this.dateBegin.Value = new System.DateTime(2020, 6, 12, 0, 0, 0, 0);
            // 
            // dateEnd
            // 
            this.dateEnd.CustomFormat = "dd/MM/yyyy";
            this.dateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEnd.Location = new System.Drawing.Point(371, 115);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(121, 26);
            this.dateEnd.TabIndex = 8;
            this.dateEnd.Value = new System.DateTime(2020, 6, 12, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(52, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Content";
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(147, 112);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(129, 26);
            this.txtContent.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(312, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "End";
            // 
            // txtPName
            // 
            this.txtPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPName.Location = new System.Drawing.Point(147, 60);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(129, 26);
            this.txtPName.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Red;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = global::WindowsForm_FinalProject.Properties.Resources.buttonUpdate;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(170, 357);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(146, 69);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteP
            // 
            this.btnDeleteP.BackColor = System.Drawing.Color.Lime;
            this.btnDeleteP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteP.Image = global::WindowsForm_FinalProject.Properties.Resources.buttonClean;
            this.btnDeleteP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteP.Location = new System.Drawing.Point(371, 357);
            this.btnDeleteP.Name = "btnDeleteP";
            this.btnDeleteP.Size = new System.Drawing.Size(152, 69);
            this.btnDeleteP.TabIndex = 11;
            this.btnDeleteP.Text = "Delete";
            this.btnDeleteP.UseVisualStyleBackColor = false;
            this.btnDeleteP.Click += new System.EventHandler(this.btnDeleteP_Click);
            // 
            // btnAddP
            // 
            this.btnAddP.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddP.Image = global::WindowsForm_FinalProject.Properties.Resources.plus1;
            this.btnAddP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddP.Location = new System.Drawing.Point(11, 357);
            this.btnAddP.Name = "btnAddP";
            this.btnAddP.Size = new System.Drawing.Size(131, 69);
            this.btnAddP.TabIndex = 10;
            this.btnAddP.Text = "Add";
            this.btnAddP.UseVisualStyleBackColor = false;
            this.btnAddP.Click += new System.EventHandler(this.btnAddP_Click);
            // 
            // ProjectManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProjectManagementForm";
            this.Text = "Project";
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataProject)).EndInit();
            this.form.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel form;
        private System.Windows.Forms.ComboBox ccbType;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateBegin;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteP;
        private System.Windows.Forms.Button btnAddP;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dataProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPContent;
        private System.Windows.Forms.DataGridViewComboBoxColumn cPType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPEnd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
    }
}
namespace ClassWork
{
    partial class UpdateStudentForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdateStdnt = new System.Windows.Forms.Button();
            this.gridItemMarks = new System.Windows.Forms.DataGridView();
            this.clmAssignmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaxMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAsgnmtId = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtAssgnmtId = new System.Windows.Forms.TextBox();
            this.lblMarks = new System.Windows.Forms.Label();
            this.txtMarks = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.txtMaxMarks = new System.Windows.Forms.NumericUpDown();
            this.lblMaxMarks = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.lblLname = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.lblFname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridItemMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(532, 559);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 40);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(656, 559);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 40);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnUpdateStdnt
            // 
            this.btnUpdateStdnt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateStdnt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateStdnt.Location = new System.Drawing.Point(774, 559);
            this.btnUpdateStdnt.Name = "btnUpdateStdnt";
            this.btnUpdateStdnt.Size = new System.Drawing.Size(140, 40);
            this.btnUpdateStdnt.TabIndex = 8;
            this.btnUpdateStdnt.Text = "Update &Student";
            this.btnUpdateStdnt.UseVisualStyleBackColor = false;
            this.btnUpdateStdnt.Click += new System.EventHandler(this.BtnUpdateStdnt_Click);
            // 
            // gridItemMarks
            // 
            this.gridItemMarks.AllowUserToAddRows = false;
            this.gridItemMarks.AllowUserToDeleteRows = false;
            this.gridItemMarks.AllowUserToResizeRows = false;
            this.gridItemMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItemMarks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAssignmentId,
            this.clmMarks,
            this.clmMaxMarks});
            this.gridItemMarks.Location = new System.Drawing.Point(417, 207);
            this.gridItemMarks.MultiSelect = false;
            this.gridItemMarks.Name = "gridItemMarks";
            this.gridItemMarks.ReadOnly = true;
            this.gridItemMarks.RowHeadersWidth = 51;
            this.gridItemMarks.RowTemplate.Height = 24;
            this.gridItemMarks.RowTemplate.ReadOnly = true;
            this.gridItemMarks.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridItemMarks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridItemMarks.ShowEditingIcon = false;
            this.gridItemMarks.Size = new System.Drawing.Size(496, 317);
            this.gridItemMarks.TabIndex = 5;
            this.gridItemMarks.SelectionChanged += new System.EventHandler(this.GridItemMarks_SelectionChanged);
            // 
            // clmAssignmentId
            // 
            this.clmAssignmentId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmAssignmentId.HeaderText = "Assignment ID";
            this.clmAssignmentId.MinimumWidth = 6;
            this.clmAssignmentId.Name = "clmAssignmentId";
            this.clmAssignmentId.ReadOnly = true;
            // 
            // clmMarks
            // 
            this.clmMarks.HeaderText = "Marks";
            this.clmMarks.MinimumWidth = 6;
            this.clmMarks.Name = "clmMarks";
            this.clmMarks.ReadOnly = true;
            this.clmMarks.Width = 80;
            // 
            // clmMaxMarks
            // 
            this.clmMaxMarks.HeaderText = "Max Marks";
            this.clmMaxMarks.MinimumWidth = 6;
            this.clmMaxMarks.Name = "clmMaxMarks";
            this.clmMaxMarks.ReadOnly = true;
            this.clmMaxMarks.Width = 80;
            // 
            // lblAsgnmtId
            // 
            this.lblAsgnmtId.AutoSize = true;
            this.lblAsgnmtId.Location = new System.Drawing.Point(41, 238);
            this.lblAsgnmtId.Name = "lblAsgnmtId";
            this.lblAsgnmtId.Size = new System.Drawing.Size(124, 20);
            this.lblAsgnmtId.TabIndex = 6;
            this.lblAsgnmtId.Text = "Assignment ID:";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(61, 445);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(130, 40);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add/&Update";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(225, 445);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(130, 40);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "&Remove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // txtAssgnmtId
            // 
            this.txtAssgnmtId.Location = new System.Drawing.Point(186, 235);
            this.txtAssgnmtId.Name = "txtAssgnmtId";
            this.txtAssgnmtId.Size = new System.Drawing.Size(188, 26);
            this.txtAssgnmtId.TabIndex = 1;
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Location = new System.Drawing.Point(41, 297);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(60, 20);
            this.lblMarks.TabIndex = 10;
            this.lblMarks.Text = "Marks:";
            // 
            // txtMarks
            // 
            this.txtMarks.DecimalPlaces = 2;
            this.txtMarks.Location = new System.Drawing.Point(186, 294);
            this.txtMarks.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(188, 26);
            this.txtMarks.TabIndex = 2;
            this.txtMarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // errProvider
            // 
            this.errProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProvider.ContainerControl = this;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(201, 32);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(315, 26);
            this.txtStudentID.TabIndex = 12;
            this.txtStudentID.TabStop = false;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(41, 35);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(93, 20);
            this.lblStudentId.TabIndex = 11;
            this.lblStudentId.Text = "Student ID:";
            // 
            // txtMaxMarks
            // 
            this.txtMaxMarks.DecimalPlaces = 2;
            this.txtMaxMarks.Location = new System.Drawing.Point(186, 353);
            this.txtMaxMarks.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtMaxMarks.Name = "txtMaxMarks";
            this.txtMaxMarks.Size = new System.Drawing.Size(188, 26);
            this.txtMaxMarks.TabIndex = 3;
            this.txtMaxMarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMaxMarks
            // 
            this.lblMaxMarks.AutoSize = true;
            this.lblMaxMarks.Location = new System.Drawing.Point(41, 356);
            this.lblMaxMarks.Name = "lblMaxMarks";
            this.lblMaxMarks.Size = new System.Drawing.Size(96, 20);
            this.lblMaxMarks.TabIndex = 14;
            this.lblMaxMarks.Text = "Max Marks:";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(672, 142);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(188, 26);
            this.txtClassName.TabIndex = 118;
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(562, 145);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(106, 20);
            this.lblClassName.TabIndex = 119;
            this.lblClassName.Text = "Class Name:";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(672, 88);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(188, 26);
            this.txtGender.TabIndex = 116;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(562, 91);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(69, 20);
            this.lblGender.TabIndex = 117;
            this.lblGender.Text = "Gender:";
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(672, 33);
            this.numAge.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(188, 26);
            this.numAge.TabIndex = 114;
            this.numAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(562, 38);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(43, 20);
            this.lblAge.TabIndex = 115;
            this.lblAge.Text = "Age:";
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(201, 139);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(315, 26);
            this.txtLname.TabIndex = 113;
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(41, 142);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(158, 20);
            this.lblLname.TabIndex = 112;
            this.lblLname.Text = "Student Last Name:";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(201, 88);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(315, 26);
            this.txtFname.TabIndex = 111;
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(41, 91);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(159, 20);
            this.lblFname.TabIndex = 110;
            this.lblFname.Text = "Student First Name:";
            // 
            // UpdateStudentForm
            // 
            this.AcceptButton = this.btnUpdateStdnt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(942, 615);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.txtMaxMarks);
            this.Controls.Add(this.lblMaxMarks);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.txtMarks);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.txtAssgnmtId);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblAsgnmtId);
            this.Controls.Add(this.gridItemMarks);
            this.Controls.Add(this.btnUpdateStdnt);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UpdateStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddStudentForm";
            this.Load += new System.EventHandler(this.UpdateStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridItemMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdateStdnt;
        private System.Windows.Forms.DataGridView gridItemMarks;
        private System.Windows.Forms.Label lblAsgnmtId;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtAssgnmtId;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.NumericUpDown txtMarks;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.NumericUpDown txtMaxMarks;
        private System.Windows.Forms.Label lblMaxMarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAssignmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaxMarks;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label lblFname;
    }
}
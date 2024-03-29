namespace ClassWork
{
    partial class Form1
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
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.grpOperation = new System.Windows.Forms.GroupBox();
            this.btnPerform = new System.Windows.Forms.Button();
            this.rdbExit = new System.Windows.Forms.RadioButton();
            this.rdbDelete = new System.Windows.Forms.RadioButton();
            this.rdbUpdate = new System.Windows.Forms.RadioButton();
            this.rdbAddNew = new System.Windows.Forms.RadioButton();
            this.txtScoreTotal = new System.Windows.Forms.TextBox();
            this.txtMaxTotal = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.lblStudents = new System.Windows.Forms.Label();
            this.lblScoreTotal = new System.Windows.Forms.Label();
            this.lblScoreCount = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridItemMarks = new System.Windows.Forms.DataGridView();
            this.clmAssignmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaxMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblStudentAssignment = new System.Windows.Forms.Label();
            this.grpOperation.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItemMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lstStudents
            // 
            this.lstStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.ItemHeight = 20;
            this.lstStudents.Location = new System.Drawing.Point(39, 71);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(557, 184);
            this.lstStudents.TabIndex = 5;
            this.lstStudents.SelectedIndexChanged += new System.EventHandler(this.LstStudents_SelectedIndexChanged);
            // 
            // grpOperation
            // 
            this.grpOperation.Controls.Add(this.btnPerform);
            this.grpOperation.Controls.Add(this.rdbExit);
            this.grpOperation.Controls.Add(this.rdbDelete);
            this.grpOperation.Controls.Add(this.rdbUpdate);
            this.grpOperation.Controls.Add(this.rdbAddNew);
            this.grpOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOperation.Location = new System.Drawing.Point(672, 272);
            this.grpOperation.Name = "grpOperation";
            this.grpOperation.Size = new System.Drawing.Size(200, 233);
            this.grpOperation.TabIndex = 1;
            this.grpOperation.TabStop = false;
            this.grpOperation.Text = "Operation";
            // 
            // btnPerform
            // 
            this.btnPerform.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerform.Location = new System.Drawing.Point(43, 172);
            this.btnPerform.Name = "btnPerform";
            this.btnPerform.Size = new System.Drawing.Size(102, 37);
            this.btnPerform.TabIndex = 4;
            this.btnPerform.Text = "&Perform";
            this.btnPerform.UseVisualStyleBackColor = true;
            this.btnPerform.Click += new System.EventHandler(this.BtnPerform_Click);
            // 
            // rdbExit
            // 
            this.rdbExit.AutoSize = true;
            this.rdbExit.Checked = true;
            this.rdbExit.Location = new System.Drawing.Point(43, 125);
            this.rdbExit.Name = "rdbExit";
            this.rdbExit.Size = new System.Drawing.Size(58, 24);
            this.rdbExit.TabIndex = 3;
            this.rdbExit.TabStop = true;
            this.rdbExit.Text = "E&xit";
            this.rdbExit.UseVisualStyleBackColor = true;
            // 
            // rdbDelete
            // 
            this.rdbDelete.AutoSize = true;
            this.rdbDelete.Location = new System.Drawing.Point(43, 95);
            this.rdbDelete.Name = "rdbDelete";
            this.rdbDelete.Size = new System.Drawing.Size(79, 24);
            this.rdbDelete.TabIndex = 2;
            this.rdbDelete.TabStop = true;
            this.rdbDelete.Text = "&Delete";
            this.rdbDelete.UseVisualStyleBackColor = true;
            // 
            // rdbUpdate
            // 
            this.rdbUpdate.AutoSize = true;
            this.rdbUpdate.Location = new System.Drawing.Point(43, 65);
            this.rdbUpdate.Name = "rdbUpdate";
            this.rdbUpdate.Size = new System.Drawing.Size(83, 24);
            this.rdbUpdate.TabIndex = 1;
            this.rdbUpdate.TabStop = true;
            this.rdbUpdate.Text = "&Update";
            this.rdbUpdate.UseVisualStyleBackColor = true;
            // 
            // rdbAddNew
            // 
            this.rdbAddNew.AutoSize = true;
            this.rdbAddNew.Location = new System.Drawing.Point(43, 35);
            this.rdbAddNew.Name = "rdbAddNew";
            this.rdbAddNew.Size = new System.Drawing.Size(97, 24);
            this.rdbAddNew.TabIndex = 0;
            this.rdbAddNew.TabStop = true;
            this.rdbAddNew.Text = "&Add New";
            this.rdbAddNew.UseVisualStyleBackColor = true;
            // 
            // txtScoreTotal
            // 
            this.txtScoreTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScoreTotal.Location = new System.Drawing.Point(772, 90);
            this.txtScoreTotal.Name = "txtScoreTotal";
            this.txtScoreTotal.ReadOnly = true;
            this.txtScoreTotal.Size = new System.Drawing.Size(100, 26);
            this.txtScoreTotal.TabIndex = 2;
            this.txtScoreTotal.TabStop = false;
            // 
            // txtMaxTotal
            // 
            this.txtMaxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxTotal.Location = new System.Drawing.Point(772, 148);
            this.txtMaxTotal.Name = "txtMaxTotal";
            this.txtMaxTotal.ReadOnly = true;
            this.txtMaxTotal.Size = new System.Drawing.Size(100, 26);
            this.txtMaxTotal.TabIndex = 3;
            this.txtMaxTotal.TabStop = false;
            // 
            // txtAverage
            // 
            this.txtAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAverage.Location = new System.Drawing.Point(772, 207);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(100, 26);
            this.txtAverage.TabIndex = 4;
            this.txtAverage.TabStop = false;
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudents.Location = new System.Drawing.Point(34, 44);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(75, 20);
            this.lblStudents.TabIndex = 5;
            this.lblStudents.Text = "Students";
            // 
            // lblScoreTotal
            // 
            this.lblScoreTotal.AutoSize = true;
            this.lblScoreTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTotal.Location = new System.Drawing.Point(660, 93);
            this.lblScoreTotal.Name = "lblScoreTotal";
            this.lblScoreTotal.Size = new System.Drawing.Size(97, 20);
            this.lblScoreTotal.TabIndex = 6;
            this.lblScoreTotal.Text = "Marks Total";
            // 
            // lblScoreCount
            // 
            this.lblScoreCount.AutoSize = true;
            this.lblScoreCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreCount.Location = new System.Drawing.Point(660, 151);
            this.lblScoreCount.Name = "lblScoreCount";
            this.lblScoreCount.Size = new System.Drawing.Size(91, 20);
            this.lblScoreCount.TabIndex = 7;
            this.lblScoreCount.Text = "Max Marks";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(660, 210);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(67, 20);
            this.lblAverage.TabIndex = 8;
            this.lblAverage.Text = "Percent";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.operationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 30);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.updateStudentToolStripMenuItem,
            this.deleteStudentToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(96, 26);
            this.operationsToolStripMenuItem.Text = "&Operations";
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.addNewStudentToolStripMenuItem.Text = "&Add New Student";
            this.addNewStudentToolStripMenuItem.Click += new System.EventHandler(this.AddNewStudentToolStripMenuItem_Click);
            // 
            // updateStudentToolStripMenuItem
            // 
            this.updateStudentToolStripMenuItem.Name = "updateStudentToolStripMenuItem";
            this.updateStudentToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.updateStudentToolStripMenuItem.Text = "&Update Student";
            this.updateStudentToolStripMenuItem.Click += new System.EventHandler(this.UpdateStudentToolStripMenuItem_Click);
            // 
            // deleteStudentToolStripMenuItem
            // 
            this.deleteStudentToolStripMenuItem.Name = "deleteStudentToolStripMenuItem";
            this.deleteStudentToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.deleteStudentToolStripMenuItem.Text = "&Delete Student";
            this.deleteStudentToolStripMenuItem.Click += new System.EventHandler(this.DeleteStudentToolStripMenuItem_Click);
            // 
            // gridItemMarks
            // 
            this.gridItemMarks.AllowUserToAddRows = false;
            this.gridItemMarks.AllowUserToDeleteRows = false;
            this.gridItemMarks.AllowUserToResizeRows = false;
            this.gridItemMarks.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridItemMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItemMarks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAssignmentId,
            this.clmMarks,
            this.clmMaxMarks});
            this.gridItemMarks.Location = new System.Drawing.Point(38, 296);
            this.gridItemMarks.MultiSelect = false;
            this.gridItemMarks.Name = "gridItemMarks";
            this.gridItemMarks.ReadOnly = true;
            this.gridItemMarks.RowHeadersWidth = 51;
            this.gridItemMarks.RowTemplate.Height = 24;
            this.gridItemMarks.RowTemplate.ReadOnly = true;
            this.gridItemMarks.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridItemMarks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridItemMarks.ShowCellToolTips = false;
            this.gridItemMarks.ShowEditingIcon = false;
            this.gridItemMarks.Size = new System.Drawing.Size(558, 209);
            this.gridItemMarks.TabIndex = 100;
            this.gridItemMarks.TabStop = false;
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
            // assignmentBindingSource
            // 
            this.assignmentBindingSource.DataSource = typeof(ClassWork.Assignment);
            // 
            // lblStudentAssignment
            // 
            this.lblStudentAssignment.AutoSize = true;
            this.lblStudentAssignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStudentAssignment.Location = new System.Drawing.Point(39, 272);
            this.lblStudentAssignment.Name = "lblStudentAssignment";
            this.lblStudentAssignment.Size = new System.Drawing.Size(312, 20);
            this.lblStudentAssignment.TabIndex = 101;
            this.lblStudentAssignment.Text = "Display Selected Student\'s Assignments";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPerform;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 537);
            this.Controls.Add(this.lblStudentAssignment);
            this.Controls.Add(this.gridItemMarks);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblScoreCount);
            this.Controls.Add(this.lblScoreTotal);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtMaxTotal);
            this.Controls.Add(this.txtScoreTotal);
            this.Controls.Add(this.grpOperation);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students Score App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpOperation.ResumeLayout(false);
            this.grpOperation.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItemMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.GroupBox grpOperation;
        private System.Windows.Forms.TextBox txtScoreTotal;
        private System.Windows.Forms.TextBox txtMaxTotal;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.RadioButton rdbExit;
        private System.Windows.Forms.RadioButton rdbDelete;
        private System.Windows.Forms.RadioButton rdbUpdate;
        private System.Windows.Forms.RadioButton rdbAddNew;
        private System.Windows.Forms.Label lblScoreTotal;
        private System.Windows.Forms.Label lblScoreCount;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Button btnPerform;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentToolStripMenuItem;
        private System.Windows.Forms.DataGridView gridItemMarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAssignmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaxMarks;
        private System.Windows.Forms.BindingSource assignmentBindingSource;
        private System.Windows.Forms.Label lblStudentAssignment;
    }
}


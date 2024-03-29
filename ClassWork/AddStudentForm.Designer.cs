namespace ClassWork
{
    partial class AddStudentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddStdnt = new System.Windows.Forms.Button();
            this.gridItemMarks = new System.Windows.Forms.DataGridView();
            this.clmAssignmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaxMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtMaxMarks = new System.Windows.Forms.NumericUpDown();
            this.lblMaxMarks = new System.Windows.Forms.Label();
            this.txtMarks = new System.Windows.Forms.NumericUpDown();
            this.lblMarks = new System.Windows.Forms.Label();
            this.txtAssgnmtId = new System.Windows.Forms.TextBox();
            this.lblAsgnmtId = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridItemMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(65, 83);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(120, 20);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student Name:";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(225, 80);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(315, 26);
            this.txtStudentName.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(532, 559);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 40);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(656, 559);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 40);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnAddStdnt
            // 
            this.btnAddStdnt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddStdnt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddStdnt.Location = new System.Drawing.Point(774, 559);
            this.btnAddStdnt.Name = "btnAddStdnt";
            this.btnAddStdnt.Size = new System.Drawing.Size(140, 40);
            this.btnAddStdnt.TabIndex = 10;
            this.btnAddStdnt.Text = "Add &Student";
            this.btnAddStdnt.UseVisualStyleBackColor = false;
            this.btnAddStdnt.Click += new System.EventHandler(this.BtnAddStdnt_Click);
            // 
            // gridItemMarks
            // 
            this.gridItemMarks.AllowUserToAddRows = false;
            this.gridItemMarks.AllowUserToDeleteRows = false;
            this.gridItemMarks.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridItemMarks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridItemMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItemMarks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAssignmentId,
            this.clmMarks,
            this.clmMaxMarks});
            this.gridItemMarks.Location = new System.Drawing.Point(417, 133);
            this.gridItemMarks.MultiSelect = false;
            this.gridItemMarks.Name = "gridItemMarks";
            this.gridItemMarks.ReadOnly = true;
            this.gridItemMarks.RowHeadersWidth = 51;
            this.gridItemMarks.RowTemplate.Height = 24;
            this.gridItemMarks.RowTemplate.ReadOnly = true;
            this.gridItemMarks.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridItemMarks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridItemMarks.ShowEditingIcon = false;
            this.gridItemMarks.Size = new System.Drawing.Size(496, 391);
            this.gridItemMarks.TabIndex = 99;
            this.gridItemMarks.TabStop = false;
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
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(61, 427);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(130, 40);
            this.btnAddItem.TabIndex = 6;
            this.btnAddItem.Text = "Add/&Update";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(225, 427);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(130, 40);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "&Remove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // errProvider
            // 
            this.errProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProvider.ContainerControl = this;
            // 
            // txtMaxMarks
            // 
            this.txtMaxMarks.DecimalPlaces = 2;
            this.txtMaxMarks.Location = new System.Drawing.Point(202, 330);
            this.txtMaxMarks.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtMaxMarks.Name = "txtMaxMarks";
            this.txtMaxMarks.Size = new System.Drawing.Size(188, 26);
            this.txtMaxMarks.TabIndex = 5;
            this.txtMaxMarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMaxMarks
            // 
            this.lblMaxMarks.AutoSize = true;
            this.lblMaxMarks.Location = new System.Drawing.Point(57, 333);
            this.lblMaxMarks.Name = "lblMaxMarks";
            this.lblMaxMarks.Size = new System.Drawing.Size(96, 20);
            this.lblMaxMarks.TabIndex = 20;
            this.lblMaxMarks.Text = "Max Marks:";
            // 
            // txtMarks
            // 
            this.txtMarks.DecimalPlaces = 2;
            this.txtMarks.Location = new System.Drawing.Point(202, 271);
            this.txtMarks.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtMarks.Name = "txtMarks";
            this.txtMarks.Size = new System.Drawing.Size(188, 26);
            this.txtMarks.TabIndex = 4;
            this.txtMarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Location = new System.Drawing.Point(57, 274);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(60, 20);
            this.lblMarks.TabIndex = 18;
            this.lblMarks.Text = "Marks:";
            // 
            // txtAssgnmtId
            // 
            this.txtAssgnmtId.Location = new System.Drawing.Point(202, 212);
            this.txtAssgnmtId.Name = "txtAssgnmtId";
            this.txtAssgnmtId.Size = new System.Drawing.Size(188, 26);
            this.txtAssgnmtId.TabIndex = 3;
            // 
            // lblAsgnmtId
            // 
            this.lblAsgnmtId.AutoSize = true;
            this.lblAsgnmtId.Location = new System.Drawing.Point(57, 215);
            this.lblAsgnmtId.Name = "lblAsgnmtId";
            this.lblAsgnmtId.Size = new System.Drawing.Size(124, 20);
            this.lblAsgnmtId.TabIndex = 17;
            this.lblAsgnmtId.Text = "Assignment ID:";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(225, 35);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(315, 26);
            this.txtStudentId.TabIndex = 1;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(65, 38);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(93, 20);
            this.lblStudentId.TabIndex = 21;
            this.lblStudentId.Text = "Student ID:";
            // 
            // AddStudentForm
            // 
            this.AcceptButton = this.btnAddStdnt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(942, 615);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.txtMaxMarks);
            this.Controls.Add(this.lblMaxMarks);
            this.Controls.Add(this.txtMarks);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.txtAssgnmtId);
            this.Controls.Add(this.lblAsgnmtId);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.gridItemMarks);
            this.Controls.Add(this.btnAddStdnt);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblStudentName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddStudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridItemMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddStdnt;
        private System.Windows.Forms.DataGridView gridItemMarks;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.NumericUpDown txtMaxMarks;
        private System.Windows.Forms.Label lblMaxMarks;
        private System.Windows.Forms.NumericUpDown txtMarks;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.TextBox txtAssgnmtId;
        private System.Windows.Forms.Label lblAsgnmtId;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAssignmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaxMarks;
    }
}
namespace ClassWork
{
    partial class StudentSelectionForm
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
            this.lstStudentSelection = new System.Windows.Forms.ListBox();
            this.lblStudentSelection = new System.Windows.Forms.Label();
            this.btnSelectStudent = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstStudentSelection
            // 
            this.lstStudentSelection.FormattingEnabled = true;
            this.lstStudentSelection.ItemHeight = 20;
            this.lstStudentSelection.Location = new System.Drawing.Point(14, 44);
            this.lstStudentSelection.Margin = new System.Windows.Forms.Padding(4);
            this.lstStudentSelection.Name = "lstStudentSelection";
            this.lstStudentSelection.Size = new System.Drawing.Size(653, 344);
            this.lstStudentSelection.TabIndex = 0;
            this.lstStudentSelection.DoubleClick += new System.EventHandler(this.LstStudentSelection_DoubleClick);
            // 
            // lblStudentSelection
            // 
            this.lblStudentSelection.AutoSize = true;
            this.lblStudentSelection.Location = new System.Drawing.Point(15, 11);
            this.lblStudentSelection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentSelection.Name = "lblStudentSelection";
            this.lblStudentSelection.Size = new System.Drawing.Size(293, 20);
            this.lblStudentSelection.TabIndex = 1;
            this.lblStudentSelection.Text = "Select the student you want to modify:";
            // 
            // btnSelectStudent
            // 
            this.btnSelectStudent.Location = new System.Drawing.Point(527, 407);
            this.btnSelectStudent.Name = "btnSelectStudent";
            this.btnSelectStudent.Size = new System.Drawing.Size(140, 40);
            this.btnSelectStudent.TabIndex = 2;
            this.btnSelectStudent.Text = "&Select Student";
            this.btnSelectStudent.UseVisualStyleBackColor = true;
            this.btnSelectStudent.Click += new System.EventHandler(this.BtnSelectStudent_Click);
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(398, 407);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 40);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // StudentSelectionForm
            // 
            this.AcceptButton = this.btnSelectStudent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(682, 472);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSelectStudent);
            this.Controls.Add(this.lblStudentSelection);
            this.Controls.Add(this.lstStudentSelection);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentSelectionForm";
            this.Text = "Student Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStudentSelection;
        private System.Windows.Forms.Button btnSelectStudent;
        private System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.ListBox lstStudentSelection;
    }
}
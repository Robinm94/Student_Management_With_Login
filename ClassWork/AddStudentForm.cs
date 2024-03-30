using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ClassWork
{
    public partial class AddStudentForm : Form
    {
        public Student NewStudent { get; set; }
        public bool AddStudentFlag { get; set; } = false;
        public AddStudentForm()
        {
            InitializeComponent();
            NewStudent = new Student("","","",0,"","");
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            if (txtAssgnmtId.Text == null || txtAssgnmtId.Text.Equals(String.Empty))
            {
                errProvider.SetError(txtAssgnmtId, "Please enter Item name");
                return;
            }
            else
            {
                errProvider.SetError(txtAssgnmtId, String.Empty);
            }
            if(txtMarks.Value > txtMaxMarks.Value)
            {
                errProvider.SetError(txtMarks, "Marks can not be higher than Max Marks");
                return;
            }
            else
            {
                errProvider.SetError(txtMarks, String.Empty);
            }
            Assignment item = NewStudent.FindAssignment(txtAssgnmtId.Text);
            if (item != null)
            {
                item.Score = Convert.ToDouble(txtMarks.Value);
                item.MaxScore = Convert.ToDouble(txtMaxMarks.Value);
            }
            else
            {
                if (!NewStudent.AddAssignment(new Assignment(txtAssgnmtId.Text, Convert.ToDouble(txtMarks.Value), Convert.ToDouble(txtMaxMarks.Value))))
                {
                    MessageBox.Show("Can only add 5 assignments, please remove other assignments before adding new");
                }
            }
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            gridItemMarks.Rows.Clear();
            foreach (Assignment assignment in NewStudent.Assignments)
            {
                if(assignment !=null)
                {
                    gridItemMarks.Rows.Add(assignment.AssignmentId, assignment.Score, assignment.MaxScore);
                }
            }
            gridItemMarks.ClearSelection();
            ClearValues();
        }

        private void ClearValues()
        {
            txtAssgnmtId.Text = String.Empty;
            txtMarks.Value = 0;
            txtMaxMarks.Value = 0;
        }

        private void GridItemMarks_SelectionChanged(object sender, EventArgs e)
        {
            int selectedRowCount = gridItemMarks.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                txtAssgnmtId.Text = (string)gridItemMarks.SelectedRows[0].Cells[0].Value;
                txtMarks.Value = Convert.ToDecimal(gridItemMarks.SelectedRows[0].Cells[1].Value);
                txtMaxMarks.Value = Convert.ToDecimal(gridItemMarks.SelectedRows[0].Cells[2].Value);
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            Assignment item = NewStudent.FindAssignment(txtAssgnmtId.Text);
            if (item != null)
            {
                NewStudent.RemoveAssignment(item.AssignmentId);
            }
            RefreshDataGridView();
        }

        private void BtnAddStdnt_Click(object sender, EventArgs e)
        {
            if (txtStudentId.Text.Equals(String.Empty))
            {
                errProvider.SetError(txtStudentId, "Please Enter Student ID");
                return;
            }
            else
            {
                errProvider.SetError(txtStudentId, String.Empty);
            }
            if(txtFname.Text.Equals(String.Empty))
            {
                errProvider.SetError(txtFname, "Please Enter First Name");
                return;
            }
            else
            {
                errProvider.SetError(txtFname, String.Empty);
            }
            if (txtLname.Text.Equals(String.Empty))
            {
                errProvider.SetError(txtLname, "Please Enter Last Name");
                return;
            }
            else
            {
                errProvider.SetError(txtLname, String.Empty);
            }
            if (txtClassName.Text.Equals(String.Empty))
            {
                errProvider.SetError(txtClassName, "Please Enter Class Name");
                return;
            }
            else
            {
                errProvider.SetError(txtClassName, String.Empty);
            }
            if (txtGender.Text.Equals(String.Empty))
            {
                errProvider.SetError(txtGender, "Please Enter Gender");
                return;
            }
            else
            {
                errProvider.SetError(txtGender, String.Empty);
            }
            if (gridItemMarks.RowCount == 0)
            {
                DialogResult result = MessageBox.Show("Do you want to create student without items?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    AddStudentFlag = true;
                    NewStudent.StudentId = txtStudentId.Text;
                    NewStudent.FirstName = txtFname.Text;
                    NewStudent.LastName = txtLname.Text;
                    NewStudent.Age = Convert.ToInt32(numAge.Value);
                    NewStudent.Gender = txtGender.Text;
                    NewStudent.ClassName = txtClassName.Text;
                    this.Close();
                }
            }
            else
            {
                AddStudentFlag = true;
                NewStudent.StudentId = txtStudentId.Text;
                NewStudent.FirstName = txtFname.Text;
                NewStudent.LastName = txtLname.Text;
                NewStudent.Age = Convert.ToInt32(numAge.Value);
                NewStudent.Gender = txtGender.Text;
                NewStudent.ClassName = txtClassName.Text;
                this.Close();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Array.Clear(NewStudent.Assignments, 0, NewStudent.Assignments.Length);
            RefreshDataGridView();
        }
    }
}

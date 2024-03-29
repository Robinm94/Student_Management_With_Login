using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassWork
{
    public partial class UpdateStudentForm : Form
    {
        public Student NewUpdatedStudent { get; set; }
        public Student UpdateStudent { get; set; }
        public bool UpdateFlag { get; set; } = false;

        public UpdateStudentForm(Student studentToUpdate)
        {
            InitializeComponent();
            UpdateStudent = studentToUpdate;
            if (studentToUpdate != null)
            {
                NewUpdatedStudent = new Student(studentToUpdate.StudentId, studentToUpdate.Name);
                txtStudentID.Text = studentToUpdate.StudentId;
                txtStudentName.Text = studentToUpdate.Name;
                CloneAssignments();
            }
        }

        private void CloneAssignments()
        {
            for (int i = 0; i < UpdateStudent.Assignments.Length; i++)
            {
                if (UpdateStudent.Assignments[i] != null)
                {
                    NewUpdatedStudent.AddAssignment(new Assignment(UpdateStudent.Assignments[i].AssignmentId, UpdateStudent.Assignments[i].Score, UpdateStudent.Assignments[i].MaxScore));
                }
            }
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
            if (txtMarks.Value > txtMaxMarks.Value)
            {
                errProvider.SetError(txtMarks, "Marks can not be higher than Max Marks");
                return;
            }
            else
            {
                errProvider.SetError(txtMarks, String.Empty);
            }
            Assignment item = NewUpdatedStudent.FindAssignment(txtAssgnmtId.Text);
            if (item != null)
            {
                item.Score = Convert.ToDouble(txtMarks.Value);
                item.MaxScore = Convert.ToDouble(txtMaxMarks.Value);
            }
            else
            {
                if(!NewUpdatedStudent.AddAssignment(new Assignment(txtAssgnmtId.Text, Convert.ToDouble(txtMarks.Value), Convert.ToDouble(txtMaxMarks.Value))))
                {
                    MessageBox.Show("Can only add 5 assignments, please remove other assignments before adding new");
                }
            }
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            gridItemMarks.Rows.Clear();
            foreach (Assignment assignment in NewUpdatedStudent.Assignments)
            {
                if (assignment != null)
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
            Assignment item = NewUpdatedStudent.FindAssignment(txtAssgnmtId.Text); 
            if (item != null)
            {
                NewUpdatedStudent.RemoveAssignment(item.AssignmentId);
            }
            RefreshDataGridView();
        }

        private void BtnUpdateStdnt_Click(object sender, EventArgs e)
        {
            UpdateFlag = true;
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            NewUpdatedStudent = null;
            this.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Array.Clear(NewUpdatedStudent.Assignments, 0, NewUpdatedStudent.Assignments.Length);
            CloneAssignments();
            RefreshDataGridView();
        }

        private void UpdateStudentForm_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
    }
}

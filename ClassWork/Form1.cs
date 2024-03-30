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
    public partial class Form1 : Form
    {
        private StudentDB students = new StudentDB();
        private int selectedIndex = 0;
        private string default_display_text = "Display Selected Student's Assignments";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudentGridView();
        }

        private void LoadStudentGridView()
        {
            gridViewStudents.DataSource = null;
            studentBindingSource.DataSource = students.GetAllStudents();
            gridViewStudents.DataSource = studentBindingSource;

            if (gridViewStudents.Rows.Count > selectedIndex)
            {
                gridViewStudents.Rows[selectedIndex].Selected = true;
            }
            else
            {
                ClearData();
                lblStudentAssignment.Text = default_display_text;
                gridItemMarks.ClearSelection();
                gridItemMarks.Rows.Clear();
            }
        }

        private void ClearData()
        {
            txtScoreTotal.Text = string.Empty;
            txtMaxTotal.Text = string.Empty;
            txtAverage.Text = string.Empty;
        }

        private void GridViewStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (gridViewStudents.SelectedRows.Count > 0)
            {
                selectedIndex = gridViewStudents.SelectedRows[0].Index;
                DataGridViewRow row = gridViewStudents.Rows[selectedIndex];
                Student selectedStudent = students.FindStudent(new Student(row.Cells[0].Value.ToString()));
                if (selectedStudent == null)
                {
                    MessageBox.Show("Unable to find student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtScoreTotal.Text = selectedStudent.TotalScore.ToString();
                txtMaxTotal.Text = selectedStudent.TotalMaxScore.ToString();
                double avg = selectedStudent.TotalMaxScore == 0 ? 0 : selectedStudent.TotalScore / selectedStudent.TotalMaxScore;
                txtAverage.Text = (avg).ToString("p2");
                gridItemMarks.Rows.Clear();
                foreach (Assignment assignment in selectedStudent.Assignments)
                {
                    if (assignment != null)
                    {
                        gridItemMarks.Rows.Add(assignment.AssignmentId, assignment.Score, assignment.MaxScore);
                    }
                }
                lblStudentAssignment.Text = $"Assignment Details for {selectedStudent.StudentId} - {selectedStudent.FirstName} {selectedStudent.LastName}:";
                gridItemMarks.ClearSelection();
            }
            else
            {
                lblStudentAssignment.Text = default_display_text;
                gridItemMarks.ClearSelection();
                gridItemMarks.Rows.Clear();
                ClearData();
            }
        }

        private void BtnPerform_Click(object sender, EventArgs e)
        {
            if (rdbAddNew.Checked)
            {
                AddStudentForm addStudentForm = new AddStudentForm();
                addStudentForm.ShowDialog();
                Student newStudent = addStudentForm.NewStudent;
                if (newStudent != null && addStudentForm.AddStudentFlag)
                {
                    if (students.GetAllStudents().Contains(newStudent))
                    {
                        MessageBox.Show("This student already exists in the list, please update instead", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    students.AddStudent(newStudent);
                }
                LoadStudentGridView();
            }
            else if (rdbUpdate.Checked)
            {
                if (gridViewStudents.SelectedRows.Count > 0)
                {
                    string studentId = gridViewStudents.Rows[selectedIndex].Cells[0].Value.ToString();
                    Student studentToUpdate = students.FindStudent(new Student(studentId));
                    if (studentToUpdate == null)
                    {
                        MessageBox.Show("Unable to find student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    UpdateStudentForm updateStudentForm = new UpdateStudentForm(studentToUpdate);
                    updateStudentForm.ShowDialog();
                    if (updateStudentForm.NewUpdatedStudent != null && updateStudentForm.UpdateFlag)
                    {
                        bool updateStatus = students.UpdateStudent(updateStudentForm.NewUpdatedStudent);
                        if (!updateStatus)
                        {
                            MessageBox.Show("Unable to update student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    LoadStudentGridView();
                }
                else
                {
                    MessageBox.Show("Please select a student from the table first.\nIf there are no students, add students first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rdbDelete.Checked)
            {
                if (gridViewStudents.SelectedRows.Count > 0)
                {
                    string studentId = gridViewStudents.Rows[selectedIndex].Cells[0].Value.ToString();
                    if (!students.RemoveStudent(new Student(studentId)))
                    {
                        MessageBox.Show("Unable to Remove student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    selectedIndex = 0;
                    LoadStudentGridView();
                }
                else
                {
                    MessageBox.Show("Please select a student from the table first.\nIf there are no students, add students first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.Close();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.rdbExit.Checked = true;
            BtnPerform_Click(this, e);
        }

        private void AddNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.rdbAddNew.Checked = true;
            BtnPerform_Click(this, e);
        }

        private void UpdateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridViewStudents.Rows.Count == 0)
            {
                MessageBox.Show("Please add a student before updating", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StudentSelectionForm studentSelectionForm = new StudentSelectionForm();
            foreach (DataGridViewRow row in gridViewStudents.Rows)
            {
                studentSelectionForm.lstStudentSelection.Items.Add(row.Cells[0].Value.ToString() + " - " + row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString());
            }
            studentSelectionForm.ShowDialog();
            int selectionIndex = studentSelectionForm.selectedStudentIndex;
            if (selectionIndex < 0)
            {
                return;
            }
            selectedIndex = selectionIndex;
            gridViewStudents.Rows[selectedIndex].Selected = true;
            this.rdbUpdate.Checked = true;
            BtnPerform_Click(this, e);
        }

        private void DeleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridViewStudents.Rows.Count == 0)
            {
                MessageBox.Show("Please add a student before removing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StudentSelectionForm studentSelectionForm = new StudentSelectionForm();
            foreach (DataGridViewRow row in gridViewStudents.Rows)
            {
                studentSelectionForm.lstStudentSelection.Items.Add(row.Cells[0].Value.ToString() + " - " + row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString());
            }
            studentSelectionForm.ShowDialog();
            int selectionIndex = studentSelectionForm.selectedStudentIndex;
            if (selectionIndex < 0)
            {
                return;
            }
            gridViewStudents.Rows[selectionIndex].Selected = true;
            this.rdbDelete.Checked = true;
            BtnPerform_Click(this, e);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            if (string.IsNullOrEmpty(searchText))
            {
                LoadStudentGridView();
                return;
            }
            gridViewStudents.ClearSelection();

            var matchingRows = gridViewStudents.Rows.Cast<DataGridViewRow>()
                .Where(row => row.Cells[0].Value.ToString().ToLower().Contains(searchText.ToLower()) ||
                              row.Cells[1].Value.ToString().ToLower().Contains(searchText.ToLower()) ||
                              row.Cells[2].Value.ToString().ToLower().Contains(searchText.ToLower()));

            // Select (highlight) the matching rows
            foreach (var row in matchingRows)
            {
                row.Selected = true;
            }

        }
    }
}

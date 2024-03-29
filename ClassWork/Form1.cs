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
        private string[] separators = { " - ", "|" };
        private string default_display_text = "Display Selected Student's Assignments";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudentListBox();
        }

        private void LoadStudentListBox()
        {
            lstStudents.Items.Clear();

            foreach (Student student in students.GetAllStudents())
            {
                lstStudents.Items.Add(student.ToString());
            }

            if (lstStudents.Items.Count > 0)
            {
                lstStudents.SelectedIndex = selectedIndex;
            }
            else
            {
                ClearData();
            }
            lstStudents.Focus();
        }

        private void ClearData()
        {
            txtScoreTotal.Text = string.Empty;
            txtMaxTotal.Text = string.Empty;
            txtAverage.Text = string.Empty;
        }

        private void LstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex != -1)
            {
                selectedIndex = lstStudents.SelectedIndex;
                string student = lstStudents.SelectedItem.ToString();
                String[] studentInfo = student.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                Student selectedStudent = students.FindStudent(new Student(studentInfo[0], studentInfo[1]));

                txtScoreTotal.Text = selectedStudent.TotalScore.ToString();
                txtMaxTotal.Text = selectedStudent.TotalMaxScore.ToString();
                double avg = studentInfo.Length == 2 ? 0 : selectedStudent.TotalScore / selectedStudent.TotalMaxScore;
                txtAverage.Text = (avg).ToString("p2");
                gridItemMarks.Rows.Clear();
                foreach (Assignment assignment in selectedStudent.Assignments)
                {
                    if (assignment != null)
                    {
                        gridItemMarks.Rows.Add(assignment.AssignmentId, assignment.Score, assignment.MaxScore);
                    }
                }
                lblStudentAssignment.Text = $"Assignment Details for {selectedStudent.StudentId} - {selectedStudent.Name}:";
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
                LoadStudentListBox();
            }
            else if (rdbUpdate.Checked)
            {
                if (lstStudents.SelectedIndex != -1)
                {
                    string student = lstStudents.SelectedItem.ToString();
                    String[] studentInfo = student.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    Student studentToUpdate = students.FindStudent(new Student(studentInfo[0], studentInfo[1]));
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
                    LoadStudentListBox();
                }
                else
                {
                    MessageBox.Show("Please select a student from the table first.\nIf there are no students, add students first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rdbDelete.Checked)
            {
                if (lstStudents.SelectedIndex != -1)
                {
                    selectedIndex = lstStudents.SelectedIndex;
                    string student = lstStudents.SelectedItem.ToString();
                    String[] studentInfo = student.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    if (!students.RemoveStudent(new Student(studentInfo[0], studentInfo[1])))
                    {
                        MessageBox.Show("Unable to Remove student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    selectedIndex = 0;
                    LoadStudentListBox();
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
            if (lstStudents.Items.Count == 0)
            {
                MessageBox.Show("Please add a student before updating", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StudentSelectionForm studentSelectionForm = new StudentSelectionForm();
            studentSelectionForm.lstStudentSelection.Items.AddRange(lstStudents.Items);
            studentSelectionForm.ShowDialog();
            int selectionIndex = studentSelectionForm.selectedStudentIndex;
            if (selectionIndex < 0)
            {
                return;
            }
            lstStudents.SelectedIndex = selectionIndex;
            this.rdbUpdate.Checked = true;
            BtnPerform_Click(this, e);
        }

        private void DeleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstStudents.Items.Count == 0)
            {
                MessageBox.Show("Please add a student before removing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StudentSelectionForm studentSelectionForm = new StudentSelectionForm();
            studentSelectionForm.lstStudentSelection.Items.AddRange(lstStudents.Items);
            studentSelectionForm.ShowDialog();
            int selectionIndex = studentSelectionForm.selectedStudentIndex;
            if (selectionIndex < 0)
            {
                return;
            }
            this.rdbDelete.Checked = true;
            BtnPerform_Click(this, e);
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public class StudentDB
    {
        private readonly List<Student> students = new List<Student>();
        private const string Path = @"../../students.txt";
        private static readonly string[] Delimiter = { " - "};
        private static readonly char AssignmentDelimiter = '|';

        public void AddStudent(Student student)
        {
            students.Add(student);
            SaveStudents();
        }

        public bool RemoveStudent(Student student)
        {

            bool successFlag = students.Remove(student);
            SaveStudents();
            return successFlag;

        }
        public Student FindStudent(Student student)
        {
            return students.Find(x => x.Equals(student));
        }

        public bool UpdateStudent(Student student)
        {
            Student studentToUpdate = students.Find(x => x.Equals(student));
            //todo update other properties
            if (studentToUpdate == null)
            {
                return false;
            }
            studentToUpdate.FirstName = student.FirstName;
            studentToUpdate.LastName = student.LastName;
            studentToUpdate.Age = student.Age;
            studentToUpdate.ClassName = student.ClassName;
            studentToUpdate.Gender = student.Gender;
            studentToUpdate.Assignments = student.Assignments;
            studentToUpdate.TotalMaxScore = student.TotalMaxScore;
            studentToUpdate.TotalScore = student.TotalScore;
            SaveStudents();
            return true;
        }

        public List<Student> GetAllStudents()
        {
            students.Clear();
            using (StreamReader textIn =
                new StreamReader(
                new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read)))
            {
                while (textIn.Peek() != -1)
                {
                    string line = textIn.ReadLine() ?? "";
                    string[] parts = line.Split(AssignmentDelimiter);
                    string[] studentInfo = parts[0].Split(Delimiter, StringSplitOptions.RemoveEmptyEntries);
                    Student student = new Student( studentInfo[0],studentInfo[1], studentInfo[2], int.Parse(studentInfo[3]), studentInfo[4], studentInfo[5]);
                    for (int i = 1; i < parts.Length; i++)
                    {
                        string[] assignmentInfo = parts[i].Split(Delimiter, StringSplitOptions.RemoveEmptyEntries);
                        student.AddAssignment(new Assignment(assignmentInfo[0], double.Parse(assignmentInfo[1]), double.Parse(assignmentInfo[2])));
                    }
                    students.Add(student);
                }
            }
            return students;
        }

        public void SaveStudents()
        {
            using (StreamWriter textOut = new StreamWriter(new FileStream(Path, FileMode.Create, FileAccess.Write)))
            {
                foreach (Student student in students)
                {
                    textOut.Write(student.StudentId + Delimiter[0] + student.FirstName + Delimiter[0] + student.LastName + Delimiter[0] + student.Age.ToString() + Delimiter[0] + student.ClassName + Delimiter[0] + student.Gender);
                    for (int i = 0; i < student.Assignments.Length; i++)
                    {
                        if (student.Assignments[i] != null)
                        {
                            textOut.Write(AssignmentDelimiter + student.Assignments[i].AssignmentId + Delimiter[0] + student.Assignments[i].Score + Delimiter[0] + student.Assignments[i].MaxScore);
                        }
                    }
                    textOut.WriteLine();
                }
            }
        }


    }
}

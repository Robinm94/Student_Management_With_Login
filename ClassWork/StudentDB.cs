using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public class StudentDB
    {
        private readonly List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public bool RemoveStudent(Student student)
        {
            return students.Remove(student);
        }
        public Student FindStudent(Student student)
        {
            return students.Find(x => x.Equals(student));
        }

        public bool UpdateStudent(Student student)
        {
            Student studentToUpdate = students.Find(x => x.Equals(student));
            if (studentToUpdate == null)
            {
                return false;
            }
            studentToUpdate.Assignments = student.Assignments;
            studentToUpdate.TotalMaxScore = student.TotalMaxScore;
            studentToUpdate.TotalScore = student.TotalScore;
            return true;
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

    }
}

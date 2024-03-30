using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassWork
{
    public class Student
    {
        public Student(string studentId)
        {
            StudentId = studentId;
        }

        public Student(string studentId, string firstName, string lastName, int age, string className,string gender)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            ClassName = className;
            Gender = gender;
        }

        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string ClassName { get; set; }
        public string Grade { 
            get 
            {
                if (TotalMaxScore == 0)
                {
                    return "N/A";
                }
                double percentage = TotalScore / TotalMaxScore * 100;
                if (percentage >= 90)
                {
                    return "A";
                }
                else if (percentage >= 80)
                {
                    return "B";
                }
                else if (percentage >= 70)
                {
                    return "C";
                }
                else if (percentage >= 60)
                {
                    return "D";
                }
                else
                {
                    return "F";
                }
            }
        }
        public double TotalScore { get; set; }
        public double TotalMaxScore { get; set; }
        public Assignment[] Assignments { get; set; } = new Assignment[5];

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   String.Equals(StudentId, student.StudentId,StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            String objectString = StudentId + " - " + FirstName + " - " + LastName + " - " + Age + " - " + ClassName + " - " + Gender + " - " + Grade + " - ";
            foreach (Assignment assignment in Assignments)
            {
                if (assignment != null)
                {
                    objectString += ("|" + assignment.Score);
                }
            }
            return objectString;
        }

        public bool AddAssignment(Assignment assignment)
        {
            for (int i = 0; i < Assignments.Length; i++)
            {
                if (Assignments[i] == null)
                {
                    Assignments[i] = assignment;
                    TotalScore += assignment.Score;
                    TotalMaxScore += assignment.MaxScore;
                    return true;
                }
            }
            return false;
        }

        public Assignment FindAssignment(string assignmentId)
        {
            for (int i = 0; i < Assignments.Length; i++)
            {
                if (Assignments[i] != null && Assignments[i].AssignmentId.Equals(assignmentId))
                {
                    return Assignments[i];
                }
            }
            return null;
        }

        public bool RemoveAssignment(string assignmentId)
        {
            for (int i = 0; i < Assignments.Length; i++)
            {
                if (Assignments[i] != null && Assignments[i].AssignmentId.Equals(assignmentId))
                {
                    TotalScore -= Assignments[i].Score;
                    TotalMaxScore -= Assignments[i].MaxScore;
                    Assignments[i] = null;
                    return true;
                }
            }
            return false;
        }

        public bool UpdateAssignment(Assignment assignment)
        {
            for (int i = 0; i < Assignments.Length; i++)
            {
                if (Assignments[i] != null && Assignments[i].Equals(assignment))
                {
                    TotalScore += assignment.Score - Assignments[i].Score;
                    TotalMaxScore += assignment.MaxScore - Assignments[i].MaxScore;
                    Assignments[i].Score = assignment.Score;
                    Assignments[i].MaxScore = assignment.MaxScore;
                    return true;
                }
            }
            return false;
        }
    }
}

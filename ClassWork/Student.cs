using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public class Student
    {
        public Student(string studentId, string name)
        {
            StudentId = studentId;
            Name = name;
        }

        public string StudentId { get; set; }
        public string Name { get; set; }
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
            String objectString = StudentId + " - " + Name + " ";
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

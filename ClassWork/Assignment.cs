using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    public class Assignment
    {
        public Assignment(string assignmentId, double score, double maxScore)
        {
            AssignmentId = assignmentId;
            Score = score;
            MaxScore = maxScore;
        }

        public string AssignmentId {  get; set; }
        public double Score { get; set; }
        public double MaxScore { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Assignment item &&
                   String.Equals(AssignmentId,item.AssignmentId,StringComparison.OrdinalIgnoreCase);
        }
    }
}

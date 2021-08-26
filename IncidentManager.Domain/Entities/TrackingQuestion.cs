using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentManager.Domain.Entities
{
    public class TrackingQuestion
    {
        [Key]
        public int Id { get; set; }

        public int QuestionOrder { get; set; }

        [StringLength(200)]
        public string FollowupQuestion { get; set; }
        public int FollowupInterval { get; set; }

        public override bool Equals(object obj)
        {
            return obj is TrackingQuestion question &&
                   FollowupQuestion == question.FollowupQuestion &&
                   FollowupInterval == question.FollowupInterval;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FollowupQuestion, FollowupInterval);
        }
    }
}

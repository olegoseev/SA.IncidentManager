using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentManager.Domain.Entities
{
    public class IncidentSeverity
    {
        [Key]
        public int Id {  get; set; }
        [StringLength(45)]
        public string Severity {  get; set; }
        public int NotificationInterval {  get; set; }
        public int FollowupInterval {  get; set; }

        public override bool Equals(object obj)
        {
            return obj is IncidentSeverity severity &&
                   Severity == severity.Severity &&
                   NotificationInterval == severity.NotificationInterval &&
                   FollowupInterval == severity.FollowupInterval;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Severity, NotificationInterval, FollowupInterval);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentManager.Domain.Entities
{
    public class IncidentTracking
    {
        [Key]
        public int Id { get; set; }

        public Incident Incident { get;set ; }

        public int IncidentId {  get; set; }

        public TrackingQuestion Name {  get; set; }

        public int TrackingQuestionId {  get; set; }

        public int RemainingTime {  get; set; }

        public override bool Equals(object obj)
        {
            return obj is IncidentTracking tracking &&
                   EqualityComparer<Incident>.Default.Equals(Incident, tracking.Incident) &&
                   IncidentId == tracking.IncidentId &&
                   EqualityComparer<TrackingQuestion>.Default.Equals(Name, tracking.Name) &&
                   TrackingQuestionId == tracking.TrackingQuestionId &&
                   RemainingTime == tracking.RemainingTime;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Incident, IncidentId, Name, TrackingQuestionId, RemainingTime);
        }
    }
}

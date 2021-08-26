using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentManager.Domain.Entities
{
    public class Incident
    {
        [Key]
        public int Id {  get; set; }

        [StringLength(45)]
        public string IncidentCase { get; set;  }
        public DateTime StartTime {  get; set; }
        public DateTime? EndTime {  get; set; }
        public DateTime? NotifiedTime {  get; set; }
        public IncidentStatus Status {  get; set; }
        public IncidentSeverity Severity { get; set; }
        public TSBridge Bridge { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentManager.Domain.DTO
{
    public class IncidentDto
    {
        public int Id { get; set; }
        public string IncidentCase { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? NotifiedTime { get; set; }
        public string Status { get; set; }
        public string Severity { get; set; }
        public string Bridge { get; set; }
    }
}

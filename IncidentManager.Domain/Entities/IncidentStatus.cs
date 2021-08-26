using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentManager.Domain.Entities
{
    public class IncidentStatus
    {
        [Key]
        public int Id { get; set; }
        [StringLength(45)]
        public string Status {  get; set; }

        public override bool Equals(object obj)
        {
            return obj is IncidentStatus status &&
                   Status == status.Status;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Status);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentManager.Domain.Entities
{
    public class TSBridge
    {
        [Key]
        public int Id { get; set; }
        [StringLength(45)]
        public string BridgeType {  get; set; }

        public override bool Equals(object obj)
        {
            return obj is TSBridge bridge &&
                   BridgeType == bridge.BridgeType;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(BridgeType);
        }
    }
}

using IncidentManager.Domain;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncidentManager.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Incident> Incidents { get; set; }
        public DbSet<IncidentSeverity> IncidentSeverities { get; set; }
        public DbSet<IncidentStatus> IncidentStatuses { get; set; }
        public DbSet<IncidentTracking> IncidentTrackings { get; set; }
        public DbSet<TSBridge> TSBridges { get; set; }

    }
}

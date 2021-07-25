using Futronic.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futronic.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("Server=(localdb)\\mssqllocaldb;Database=FutronicFingerprint;Trusted_Connection=True;MultipleActiveResultSets=true")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<FingerPrint> FingerPrints { get; set; }
        public DbSet<AttendanceLog> AttendanceLogs { get; set; }

    }
}

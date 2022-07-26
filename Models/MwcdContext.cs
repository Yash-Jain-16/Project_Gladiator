using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Women_Empowerment.Models
{
    public class MwcdContext:DbContext
    {
        public MwcdContext(DbContextOptions <MwcdContext> options):base(options)
        {

        }

        public DbSet<User> USERS { get; set; }
        public DbSet<User> STEP_REGISTRATIONS { get; set; }
        public DbSet<User> NGO_REGISTRATIONS { get; set; }
        public DbSet<User> TRAINING_COURSES { get; set; }
        public DbSet<User> Takes { get; set; }
        public DbSet<User> Provides { get; set; }

    }
}

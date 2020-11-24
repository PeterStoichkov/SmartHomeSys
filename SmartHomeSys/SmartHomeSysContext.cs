using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using SmartHomeSys.Models;

namespace SmartHomeSys
{
    class SmartHomeSysContext : DbContext
    {
        public DbSet<Cluster> Clusters { get; set; }
        public DbSet<Lamp> Lamps { get; set; }
        public DbSet<Lock> Locks { get; set; }
        public DbSet<Television> Televisions { get; set; }
        public DbSet<User> Users { get; set; }

    }
}

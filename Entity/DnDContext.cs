using System;
using System.Data.Entity;

namespace Entity
{
    public class DnDContext : DbContext
    {
        public DnDContext() : base()
        {
            
        }

        public DbSet<Action> Actions { get; set; }
    }
}
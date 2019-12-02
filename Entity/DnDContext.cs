using System;
using System.Data.Entity;
using Common;

namespace Entity
{
    public class DnDContext : DbContext
    {
        public DnDContext() : base()
        {
            
        }
        
        public DbSet<Character> Characters { get; set; }
    }
}
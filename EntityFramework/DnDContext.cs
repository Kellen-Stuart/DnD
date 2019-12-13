using Common;
using Microsoft.EntityFrameworkCore;

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
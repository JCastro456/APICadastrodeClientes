using Microsoft.EntityFrameworkCore;

namespace womanAPI.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {             
        }
        
    }
}
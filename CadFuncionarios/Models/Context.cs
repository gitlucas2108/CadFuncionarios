using Microsoft.EntityFrameworkCore;

namespace CadFuncionarios.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) 
        { 
        
        }
        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
    }
}

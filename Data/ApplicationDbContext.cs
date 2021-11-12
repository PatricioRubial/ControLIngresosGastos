using ControLIngresosGasto.Models;
using Microsoft.EntityFrameworkCore;

namespace ControLIngresosGasto.Data
{
    public class ApplicationDbContext : DbContext
    {



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<IngresoGasto> IngresoGasto { get; set; }
    }
}

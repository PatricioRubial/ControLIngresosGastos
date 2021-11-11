using ControLIngresosGastos.Models;
using Microsoft.EntityFrameworkCore;

namespace ControLIngresosGastos.Data
{
    public class ApplicationDbContext :DbContext
    {



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }

    }
}

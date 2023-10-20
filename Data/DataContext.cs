using Contacto.Model;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Contacto.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base (options) 
        {

        }

        public DbSet<ContactoModelo > contacto { get; set; }
        public DbSet<UsuarioModelo> usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

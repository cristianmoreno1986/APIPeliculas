using ApiPeliculas.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiPeliculas.Data {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {

        }

        //Agregar los modelos aquí
        public DbSet<Categoria> Categoria { get; set; }
    }
}

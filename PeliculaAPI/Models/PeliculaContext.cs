using Microsoft.EntityFrameworkCore;

namespace PeliculaAPI.Models
{
    public class PeliculaContext : DbContext
    {
        public PeliculaContext(DbContextOptions<PeliculaContext> options) : base(options)
        {
        }
        
        public DbSet<Pelicula> Libros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Siembra de datos para la tabla Products

            modelBuilder.Entity<Pelicula>().HasData(
                new Pelicula
                {
                    Id = 1,
                    Titulo = "El padrino",
                    Director = "Francis Ford Coppola",
                    AnioLanzamiento = 1972
                },
                new Pelicula
                {
                    Id = 2,
                    Titulo = "La La Land: ciudad de sueños",
                    Director = "Damien Chazelle",
                    AnioLanzamiento = 2016
                },
                new Pelicula
                {
                    Id = 3,
                    Titulo = "El paciente inglés",
                    Director = "Anthony Minghella",
                    AnioLanzamiento = 1999
                }
            );
        }
    }
}

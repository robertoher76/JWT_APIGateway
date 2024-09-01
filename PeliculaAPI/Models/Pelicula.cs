using System.ComponentModel.DataAnnotations;

namespace PeliculaAPI.Models
{
    public class Pelicula
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Director { get; set; } = string.Empty;
        public int AnioLanzamiento { get; set; }
    }
}

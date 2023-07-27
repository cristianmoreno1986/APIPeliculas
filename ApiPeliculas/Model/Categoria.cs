using System.ComponentModel.DataAnnotations;

namespace ApiPeliculas.Model {
    public class Categoria {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tarea_en_clase.Models
{
    public class Equipo

    {
        [Key]
        public int IdEquipo { get; set; }
        public string Name { get; set; }
        public string Ciudad { get; set; }
        public string Titulos { get; set; }
        public bool AceptaExtra { get; set; }
        [ForeignKey("Estadio")]
        public string IdEstadio { get; set; }

    }
}

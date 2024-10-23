using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tarea_en_clase.Models
{
    public class Jugadores
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Posicion { get; set; }
        public int Edad {  get; set; }
        public string NombreDeEquipo { get; set; }


    }
}

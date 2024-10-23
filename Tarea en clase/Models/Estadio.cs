using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Tarea_en_clase.Models
{
    public class Estadio
    {
        [Key]
        public int IdEstadio { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }

        public int Capacidad { get; set; }
    }
}

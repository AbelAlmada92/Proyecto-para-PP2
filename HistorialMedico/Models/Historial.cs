using System.ComponentModel.DataAnnotations;

namespace HistorialMedico.Models
{
    public class Historial
    {
        public int Id { get; set; }
        [Required]
        public int PacienteId { get; set; }
        [Range(0, 120)]
        public string Diagnostico { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        public string Notas { get; set; }
    }
}

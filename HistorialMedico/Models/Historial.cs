using System.ComponentModel.DataAnnotations;

namespace HistorialMedico.Models
{
    public class Historial
    {
        public int Id { get; set; }
        [Required]
        public int PacienteId { get; set; }
        [Required]
        public string Diagnostico { get; set; } = null!;
        [Required]
        public DateTime Fecha { get; set; }
        public string Notas { get; set; } = null!;
        //public Paciente Paciente { get; set; };
    }
}

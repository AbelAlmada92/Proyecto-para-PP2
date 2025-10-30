using System.ComponentModel.DataAnnotations;

namespace HistorialMedico.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; } = null!;
        [Required]
        public string Apellido { get; set; }= null!;
        public int Edad { get; set; }
        public string? TipoSangre { get; set; }

        // Datos de apoyo (según el resumen del proyecto)
        //public string ContactoEmergencia { get; set; }
        //public string TelefonoContacto { get; set; }
        public string? CondicionActual { get; set; }

        /* 
        MEJORA CLAVE: Propiedad de navegación a su historial.
        Esto crea la relación Uno a Muchos: Un paciente tiene muchos registros
        */
        public ICollection<Historial> Registros { get; set; } = new List<Historial>();

    }
}

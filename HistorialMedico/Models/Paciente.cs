namespace HistorialMedico.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Enfermedad { get; set; }

        //public string Email { get; set; }
        //public string Direccion { get; set; }
        public string TipoSangre { get; set; }
    }
}

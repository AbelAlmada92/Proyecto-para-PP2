using HistorialMedico.Models;
using Microsoft.AspNetCore.Mvc;

namespace HistorialMedico.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HistorialControllers : ControllerBase
    {
        private static List<Historial> historial = new List<Historial>
       {
           new Historial { Id = 1, PacienteId = 1, Diagnostico = "Hipertensión por exceso de código", Fecha = DateTime.Now.AddDays(-10),
               Notas = "Paciente presenta presión alta después de 3 días seguidos programando" },
           new Historial { Id = 2, PacienteId = 2, Diagnostico = "Diabetes de café", Fecha = DateTime.Now.AddDays(-5),
               Notas = "Niveles de cafeína en sangre extremadamente altos" },
           new Historial { Id = 3, PacienteId = 3, Diagnostico = "Alergia a los bugs", Fecha = DateTime.Now.AddDays(-3),
               Notas = "Paciente estornuda cada vez que ve un NullReferenceException" },
           new Historial { Id = 4, PacienteId = 4, Diagnostico = "Síndrome del deploy nocturno", Fecha = DateTime.Now.AddDays(-1),
               Notas = "Insomnio severo por deployments a las 3 AM" } };

        // Get /api/historial/{pacienteId}
        [HttpGet("{pacienteId}")]
        public IActionResult GetHistorial(int pacienteId)
        {
            var lista = historial.FindAll(h => h.PacienteId == pacienteId);
            return Ok(lista);
        }
        
    }
}

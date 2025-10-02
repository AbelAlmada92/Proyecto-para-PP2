using HistorialMedico.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace HistorialMedico.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacientesController : ControllerBase
    {
        private static List<Paciente> pacientes = new List<Paciente>
        {
            new Paciente {Id = 1,Nombre = "Claudio", Edad = 28, Enfermedad= "Hipertensión por el código",TipoSangre = "A+"},
            new Paciente {Id = 2,Nombre = "gaston", Edad = 32, Enfermedad= "Diabetes de café",TipoSangre = "B+"},
            new Paciente {Id = 3,Nombre = "Abel", Edad = 29, Enfermedad = "Síndrome del deploy nocturno",TipoSangre = "AB+"},
            new Paciente {Id = 4,Nombre = "Gabriel Lopez", Edad = 30, Enfermedad = "Alergia a los bugs",TipoSangre = "B+"}

        };

        // Get /api/TodosLosPacientes
        [HttpGet]
        public IActionResult GetPacientes()
        {
            return Ok(pacientes);
        }

        // Get /api/pacientes/{id}
        [HttpGet("{id}")]
        public IActionResult GetPaciente(int id)
        {
            var paciente = pacientes.Find(p => p.Id == id);
            if (paciente == null) return NotFound();
            return Ok(paciente);
        }

        // Post /api/pacientes
        [HttpPost]
        public IActionResult CrearPaciente([FromBody] Paciente nuevoPaciente)
        {
            nuevoPaciente.Id = pacientes.Count + 1;
            pacientes.Add(nuevoPaciente);
            return CreatedAtAction(nameof(GetPaciente), new { id = nuevoPaciente.Id }, nuevoPaciente);
        }


    }
}

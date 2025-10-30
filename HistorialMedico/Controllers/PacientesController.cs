using HistorialMedico.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks; //  para el  async/await!
using System.Linq; //  para el Find, Max.!

namespace HistorialMedico.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacientesController : ControllerBase
    {
        private static List<Paciente> pacientes = new List<Paciente>
        {
            new Paciente {Id = 1,Nombre = "Claudio", Edad = 28, CondicionActual= "Hipertensión por el código",TipoSangre = "A+"},
            new Paciente {Id = 2,Nombre = "gaston", Edad = 32, CondicionActual= "Diabetes de café",TipoSangre = "B+"},
            new Paciente {Id = 3,Nombre = "Abel", Edad = 29, CondicionActual = "Síndrome del deploy nocturno",TipoSangre = "AB+"},
            new Paciente {Id = 4,Nombre = "Gabriel Lopez", Edad = 30, CondicionActual = "Alergia a los bugs",TipoSangre = "B+"}

        };

        // Get /api/TodosLosPacientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Paciente>>> GetPacientes()
        {
            await Task.Run(() => Task.Delay(1)); // Simula una operación asincrónica
            return Ok(pacientes);
        }

        // Get /api/pacientes/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Paciente>> GetPaciente(int id)
        {
            await Task.Run(() => Task.Delay(1)); // Simula una operación asincrónica
            var paciente = pacientes.Find(p => p.Id == id);

            if (paciente == null) return NotFound("Paciente no encontrado");
            // Retorna el paciente con código 200 OK
            return Ok(paciente);
        }

        // Post /api/pacientes
        [HttpPost]
        public async Task<IActionResult> CrearPaciente([FromBody] Paciente nuevoPaciente)
        {
            await Task.Run(() => Task.Delay(1)); // Simula una operación asincrónica
            nuevoPaciente.Id = pacientes.Count > 0 ? pacientes.Max(p => p.Id) + 1 : 1;
            pacientes.Add(nuevoPaciente);
            return CreatedAtAction(nameof(GetPaciente), new { id = nuevoPaciente.Id }, nuevoPaciente);
        }
        // Put /api/pacientes/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarPaciente(int id, [FromBody] Paciente pacienteActualizado)
        {
            await Task.Run(() => Task.Delay(1));

            if (id != pacienteActualizado.Id)
            {
                return BadRequest("El id de la ruta no coincide con el id del paciente");
            }

            var pacienteExistente = pacientes.Find(p => p.Id == id);
            if (pacienteExistente == null)
            {
                return NotFound("Paciente no encontrado para actualizar.");
            }
            // actualizamos al querido paciente
            pacienteExistente.Nombre = pacienteActualizado.Nombre;
            pacienteExistente.Edad = pacienteActualizado.Edad;
            pacienteExistente.CondicionActual = pacienteActualizado.CondicionActual;
            pacienteExistente.TipoSangre = pacienteActualizado.TipoSangre;

            // Retorna 204 no content
            return NoContent();
        }
        // Delete /api/pacientes/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarPaciente(int id)
        {
            await Task.Run(() => Task.Delay(1));

            var pacienteAEliminar = pacientes.Find(p => p.Id == id);

            if (pacienteAEliminar == null)
            {
                return NotFound("Paciente no encontrado para eliminar.");
            }
            //eliminar 
            pacientes.Remove(pacienteAEliminar);

            // Retorna 204 No Content
            return NoContent();
        }

    }
}

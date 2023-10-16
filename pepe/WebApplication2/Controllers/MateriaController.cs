using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Modelssss;

namespace WebApplication2.Controllerssss
{
    [ApiController]
    [Route("[controller]")]
    public class MateriaController : ControllerBase
    {
        private readonly ILogger<MateriaController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public MateriaController(
            ILogger<MateriaController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear docentes
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Materia materia)
        {
            _aplicacionContexto.materia.Add(materia);
            _aplicacionContexto.SaveChanges();
            return Ok(materia);
        }
        //READ: Obtener lista de estudiantes
        [Route("")]
        [HttpGet]
        public IEnumerable<Materia> Get()
        {
            return _aplicacionContexto.materia.ToList();
        }
        //Update: Modificar estudiantes
        [Route("ma/id")]
        [HttpPut]
        public IActionResult Put([FromBody] Materia materia)
        {
            _aplicacionContexto.materia.Update(materia);
            _aplicacionContexto.SaveChanges();
            return Ok(materia);
        }
        //Delete: Eliminar estudiantes
        [Route("ma/id")]
        [HttpDelete]
        public IActionResult Delete(int materiaID)
        {
            _aplicacionContexto.materia.Remove(
                _aplicacionContexto.materia.ToList()
                .Where(x => x.id_materia == materiaID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(materiaID);
        }
    }
}


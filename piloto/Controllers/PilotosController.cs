using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using piloto.Data;
using piloto.Models;

namespace piloto.Controllers
{
    [Route("api/piloto")]
    [ApiController]
    public class PilotosController : ControllerBase
    {
        private readonly IPilotoRepository _repository;

        public PilotosController(IPilotoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Piloto>> GetAllPilotos()
        {
            var pilotos = _repository.getAllPilotos();

            return Ok(pilotos);
        }

        [HttpGet("{id}")]
        public ActionResult<Piloto> GetPiloto(int id)
        {
            var piloto = _repository.getPilotoById(id);

            return Ok(piloto);
        }
    }
}
using alurachallengebackend7.Data;
using alurachallengebackend7.Models;
using alurachallengebackend7.Models.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace alurachallengebackend7.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DestinoController : ControllerBase
    {
        private ChallengeContext _context;
        private IMapper _mapper;

        public DestinoController(IMapper mapper, ChallengeContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult AdcionaDestino([FromBody] DestinoDto destinoDto)
        {
            Destino Destino = _mapper.Map<Destino>(destinoDto);
            _context.Destinos.Add(Destino);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperarDestinoPorId), new { id = Destino.Id }, Destino);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarDestinoPorId(int id)
        {
            var destino = _context.Destinos.FirstOrDefault(de => de.Id == id);
            if (destino == null) return NotFound();
            var DestinoDto = _mapper.Map<DestinoDto>(destino);
            return Ok(DestinoDto);
        }

        [HttpGet]
        public IActionResult RecuperarDestinoPorNome([FromQuery] string nome)
        {
            var destino = _context.Destinos.FirstOrDefault(de => de.Nome.ToLower() == nome.ToLower());
            if (destino == null) return NotFound();
            var DestinoDto = _mapper.Map<DestinoDto>(destino);
            return Ok(DestinoDto);
        }

        [HttpPut("{id}")]
        public IActionResult AtulizarDestino(int id, [FromBody] DestinoDto destinoDto)
        {
            var destino = _context.Destinos.FirstOrDefault(Destino => Destino.Id == id);
            if (destino == null) return NotFound();
            _mapper.Map(destinoDto, destino);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarDestino(int id)
        {
            var destino = _context.Destinos.FirstOrDefault(Destino => Destino.Id == id);
            if (destino == null) return NotFound();

            _context.Remove(destino);
            _context.SaveChanges();
            return NoContent();

        }
    }
}
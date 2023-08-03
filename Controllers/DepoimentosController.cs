using alurachallengebackend7.Data;
using alurachallengebackend7.Models;
using alurachallengebackend7.Models.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace alurachallengebackend7.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepoimentosController : ControllerBase
    {

        private ChallengeContext _context;
        private IMapper _mapper;

        public DepoimentosController(IMapper mapper, ChallengeContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult AdcionaDepoimento([FromBody] DepoimentoDto depoimentoDto)
        {
            Depoimento depoimento = _mapper.Map<Depoimento>(depoimentoDto);
            _context.Depoimentos.Add(depoimento);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperarDepoimentoPorId), new { id = depoimento.Id }, depoimento);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarDepoimentoPorId(int id)
        {
            var depoimento = _context.Depoimentos.FirstOrDefault(de => de.Id == id);
            if (depoimento == null) return NotFound();
            var depoimentoDto = _mapper.Map<DepoimentoDto>(depoimento);
            return Ok(depoimentoDto);
        }

        [HttpPut("{id}")]
        public IActionResult AtulizarDepoimento(int id, [FromBody] DepoimentoDto depoimentoDto)
        {
            var depoimento = _context.Depoimentos.FirstOrDefault(depoimento => depoimento.Id == id);
            if (depoimento == null) return NotFound();
            _mapper.Map(depoimentoDto, depoimento);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarDepoimento(int id)
        {
            var depoimento = _context.Depoimentos.FirstOrDefault(depoimento => depoimento.Id == id);
            if (depoimento == null) return NotFound();

            _context.Remove(depoimento);
            _context.SaveChanges();
            return NoContent();

        }
    }
}
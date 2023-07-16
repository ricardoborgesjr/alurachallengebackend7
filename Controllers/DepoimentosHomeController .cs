using alurachallengebackend7.Data;
using alurachallengebackend7.Models;
using alurachallengebackend7.Models.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace alurachallengebackend7.Controllers
{
    [ApiController]
    [Route("/depoimentos-home")]
    public class DepoimentosHomeController : ControllerBase
    {

        private DepoimentoContext _context;
        private IMapper _mapper;

        public DepoimentosHomeController(IMapper mapper, DepoimentoContext context)
        {
            _mapper = mapper;
            _context = context;
        }


        [HttpGet]
        public IEnumerable<DepoimentoDto> RecuperarDepoimentos()
        {
            var depoimentos = new List<Depoimento>();

            var tamanho = _context.Depoimentos.Count();
            if (tamanho < 4)
            {
                return _mapper.Map<List<DepoimentoDto>>(_context.Depoimentos);
            }

            var rnd = new Random();
            List<int> ids = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                int id = 0;
                var repetido = false;
                while (!repetido)
                {
                    id = rnd.Next(1, tamanho + 1);
                    repetido = !ids.Contains(id);
                    ids.Add(id);
                }
                var depoimento = _context.Depoimentos.FirstOrDefault(d => d.Id == id);

                depoimentos.Add(depoimento);
            }

            return _mapper.Map<List<DepoimentoDto>>(depoimentos);
        }
    }
}
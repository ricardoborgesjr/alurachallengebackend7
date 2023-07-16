using alurachallengebackend7.Models;
using alurachallengebackend7.Models.Dtos;
using AutoMapper;

namespace alurachallengebackend7.Profiles
{
    public class DepoimentoProfile : Profile
    {
        public DepoimentoProfile ()
        {
            CreateMap<DepoimentoDto, Depoimento>();
            CreateMap<Depoimento, DepoimentoDto>();
        }
    }
}
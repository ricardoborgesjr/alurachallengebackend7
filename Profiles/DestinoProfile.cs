
using alurachallengebackend7.Models;
using alurachallengebackend7.Models.Dtos;
using AutoMapper;

namespace alurachallengebackend7.Profiles
{
    public class DestinoProfile : Profile
    {
        public DestinoProfile()
        {
            CreateMap<DestinoDto, Destino>();
            CreateMap<Destino, DestinoDto>();
        }
    }
}
using AutoMapper;

using Domain.Dtos.Response;
using Domain.Entities;

namespace Application.Mappers
{
    public class PersonaMapper : Profile
    {
        public PersonaMapper()
        {
            CreateMap<Persona, PersonaDto>();
        }
    }
}

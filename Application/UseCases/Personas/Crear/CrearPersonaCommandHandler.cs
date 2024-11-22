using Application.Interfaces;

using AutoMapper;

using Domain.Dtos.Response;
using Domain.Entities;
using Domain.ValueObject;

using MediatR;

namespace Application.UseCases.Personas.Crear
{
    public class CrearPersonaCommandHandler(IPersonaRepository personaRepository, IMapper mapper) : IRequestHandler<CrearPersonaCommand, PersonaDto>
    {
        public async Task<PersonaDto> Handle(CrearPersonaCommand request, CancellationToken cancellationToken)
        {
            var nombreCompleto = NombreCompleto.Crear(request.PrimerNombre, request.PrimerApellido, request.SegundoNombre, request.SegundoApellido);
            var personaNueva = Persona.Crear(nombreCompleto, request.FechaNacimiento);

            await personaRepository.AgregarAsync(personaNueva);

            return mapper.Map<PersonaDto>(personaNueva);
        }
    }
}

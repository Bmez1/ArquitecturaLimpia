using Domain.Dtos.Response;

using MediatR;

namespace Application.UseCases.Personas.Crear
{
    public class CrearPersonaCommand : IRequest<PersonaDto>
    {
        public required string PrimerNombre { get; init; }
        public string? SegundoNombre { get; init; }
        public required string PrimerApellido { get; init; }
        public string? SegundoApellido { get; init; }
        public required DateTime FechaNacimiento { get; init; }
    }
}

using Application.Interfaces;

using AutoMapper;

using Domain.Dtos.Response;

using MediatR;

namespace Application.UseCases.Personas.ConsultarTodo
{
    public class ConsultarTodoQueryHandler(IPersonaRepository personaRepository, IMapper mapper) : IRequestHandler<ConsultarTodoQuery, IEnumerable<PersonaDto>>
    {
        public async Task<IEnumerable<PersonaDto>> Handle(ConsultarTodoQuery request, CancellationToken cancellationToken)
        {
            var registros = await personaRepository.ObtenerTodosAsync();
            var personas = mapper.Map<IEnumerable<PersonaDto>>(registros);
            return personas;
        }
    }
}

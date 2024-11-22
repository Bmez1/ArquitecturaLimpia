using Domain.Dtos.Response;

using MediatR;

namespace Application.UseCases.Personas.ConsultarTodo
{
    public record ConsultarTodoQuery : IRequest<IEnumerable<PersonaDto>>;
}

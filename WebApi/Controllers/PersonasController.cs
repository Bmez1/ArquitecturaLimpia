using Application.UseCases.Personas.ConsultarTodo;
using Application.UseCases.Personas.Crear;

using Domain.Dtos.Response;

using MediatR;

using Microsoft.AspNetCore.Mvc;

using WebApi.Dtos;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> ObtenerPersonas()
        {
            var response = await mediator.Send(new ConsultarTodoQuery());
            return Ok(ApiResponse<IEnumerable<PersonaDto>>.RespuestaExitosa(response));
        }

        [HttpPost]
        public async Task<IActionResult> CrearPersona([FromBody] CrearPersonaCommand peticion)
        {
            var response = await mediator.Send(peticion);
            return Ok(ApiResponse<PersonaDto>.RespuestaExitosa(response));
        }
    }
}

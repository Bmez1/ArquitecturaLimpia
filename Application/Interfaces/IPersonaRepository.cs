using Domain.Entities;

namespace Application.Interfaces
{
    public interface IPersonaRepository
    {
        Task<Persona?> ObtenerPorIdAsync(Guid id);
        Task<IEnumerable<Persona>> ObtenerTodosAsync();
        Task AgregarAsync(Persona persona);
        Task ActualizarAsync(Persona persona);
        Task EliminarAsync(Persona persona);
        Task<IEnumerable<Persona>> ObtenerPorEdadMayorAAsync(int edad);
    }
}

using Application.Interfaces;

using Domain.Entities;

using Infraestructure.DataBase;

using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repositories
{
    public class PersonaRepository(DataBaseContext context) : IPersonaRepository
    {
        public async Task ActualizarAsync(Persona persona)
        {
            context.Personas.Update(persona);
            await context.SaveChangesAsync();
        }

        public async Task AgregarAsync(Persona persona)
        {
            await context.Personas.AddAsync(persona);
            await context.SaveChangesAsync();
        }

        public async Task EliminarAsync(Persona persona)
        {
            context.Personas.Remove(persona);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Persona>> ObtenerPorEdadMayorAAsync(int edad)
        {
            return await context.Personas
                .AsNoTracking()
                .Where(p => p.Edad > edad)
                .ToListAsync();
        }

        public async Task<Persona?> ObtenerPorIdAsync(Guid id)
        {
            return await context.Personas
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Persona>> ObtenerTodosAsync()
        {
            return await context.Personas
                .AsNoTracking()
                .ToListAsync();
        }
    }
}

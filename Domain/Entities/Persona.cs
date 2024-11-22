using Domain.Constantes;
using Domain.ValueObject;

namespace Domain.Entities
{
    public class Persona
    {
        public Guid Id { get; private set; }
        public NombreCompleto NombreCompleto { get; private set; } = null!;
        public DateTime FechaNacimiento { get; private set; }
        public int Edad { get => CalcularEdad(); }
        public bool PuedeVotar => Edad >= Constante.EdadMinimaParaVotar;

        private Persona()
        {
        }

        private Persona(Guid id, NombreCompleto nombreCompleto, DateTime fechaNacimiento)
        {
            Id = id;
            NombreCompleto = nombreCompleto;
            FechaNacimiento = fechaNacimiento.Date;
        }

        public static Persona Crear(NombreCompleto nombreCompleto, DateTime fechaNacimiento)
        {
            return new Persona(Guid.NewGuid(), nombreCompleto, fechaNacimiento);
        }

        private int CalcularEdad()
        {
            var hoy = DateTime.Today;
            var edad = hoy.Year - FechaNacimiento.Year;

            if (FechaNacimiento > hoy.AddYears(-edad))
            {
                edad--;
            }
            return edad;
        }
    }
}

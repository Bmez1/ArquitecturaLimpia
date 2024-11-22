namespace Domain.ValueObject
{
    public class NombreCompleto
    {
        public string PrimerNombre { get; }
        public string? SegundoNombre { get; }
        public string PrimerApellido { get; }
        public string? SegundoApellido { get; }

        private NombreCompleto(string primerNombre, string primerApellido, string? segundoNombre = null, string? segundoApellido = null)
        {
            if (string.IsNullOrWhiteSpace(primerNombre))
                throw new ArgumentException("El primer nombre no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(primerApellido))
                throw new ArgumentException("El apellido no puede estar vacío.");

            PrimerNombre = primerNombre;
            PrimerApellido = primerApellido;
            SegundoNombre = segundoNombre;
            SegundoApellido = segundoApellido;
        }

        public override string ToString()
        {
            return $"{PrimerNombre} {SegundoNombre} {PrimerApellido} {SegundoApellido}";
        }

        public static NombreCompleto Crear(string primerNombre, string primerApellido, string? segundoNombre = null, string? segundoApellido = null)
        {
            return new NombreCompleto(primerNombre, primerApellido, segundoNombre, segundoApellido);
        }
    }
}

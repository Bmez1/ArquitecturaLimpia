namespace Domain.Dtos.Response
{
    public class PersonaDto
    {
        public Guid Id { get; set; }
        public string NombreCompleto { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public bool PuedeVotar { get; set; }
    }
}

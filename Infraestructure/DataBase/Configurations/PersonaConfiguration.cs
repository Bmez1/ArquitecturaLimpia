using Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.DataBase.Configurations
{
    internal sealed class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("Personas");

            builder.OwnsOne(p => p.NombreCompleto, nombreCompleto =>
            {
                nombreCompleto.Property(n => n.PrimerNombre)
                    .HasColumnName("PrimerNombre")
                    .IsRequired()
                    .HasMaxLength(50);

                nombreCompleto.Property(n => n.SegundoNombre)
                    .HasColumnName("SegundoNombre")
                    .HasMaxLength(50);
                nombreCompleto.Property(n => n.PrimerApellido)
                    .HasColumnName("PrimerApellido")
                    .IsRequired()
                    .HasMaxLength(50);
                nombreCompleto.Property(n => n.SegundoApellido)
                    .HasColumnName("SegundoApellido")
                    .HasMaxLength(50);
            });

            builder.Ignore(x => x.PuedeVotar);
            builder.Ignore(x => x.Edad);
        }
    }
}

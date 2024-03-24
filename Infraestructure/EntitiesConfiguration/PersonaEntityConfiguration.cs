using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.EntitiesConfiguration
{
    public class PersonaEntityConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.Property(p => p.Nombre).HasMaxLength(50);
            builder.Property(p => p.Apellido).HasMaxLength(50);
            builder.Property(p => p.Telefono).HasMaxLength(13);
            builder.Property(p => p.Email).HasMaxLength(50);
        }
    }
}

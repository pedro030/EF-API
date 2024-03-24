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
    internal class DomicilioEntityConfiguration : IEntityTypeConfiguration<Domicilio>
    {
        public void Configure(EntityTypeBuilder<Domicilio> builder)
        {
            builder.Property(d => d.Calle).HasMaxLength(50);
            builder.Property(d => d.Localidad).HasMaxLength(50);
        }
    }
}

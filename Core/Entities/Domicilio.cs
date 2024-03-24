using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Domicilio: BaseEntity
    {
        public string Calle {  get; set; } = string.Empty;
        public int Altura { get; set; }
        public string Localidad { get; set; } = string.Empty;
        public long PersonaId { get; set; }
        public Persona Persona { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class PersonaDomicilioDto
    {
        [StringLength(maximumLength: 50)]
        public string Nombre { get; set; } = string.Empty;
        [StringLength(maximumLength: 50)]
        public string Apellido { get; set; } = string.Empty;
        [StringLength(maximumLength: 13)]
        public string Telefono { get; set; } = string.Empty;
        [StringLength(maximumLength: 50), EmailAddress]
        public string Email { get; set; } = string.Empty;
        public DomicilioCreateDto Domicilio { get; set; } = null!;
    }
}

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADSProject.Models
{
    [PrimaryKey(nameof(IdCarrera))]
    public class Carrera
    {
        public string Codigo { get; set; }
        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 3, ErrorMessage = "La longitud del campo no puede ser mayor a 50 caracteres.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Este es un campo requerido")]
        [MaxLength(length: 40, ErrorMessage = "La longitud del campo no puede ser mayor a 50 caracteres.")]

        public int IdCarrera { get; set; }
    }
}

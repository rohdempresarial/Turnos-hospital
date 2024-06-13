using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class Paciente
    {
        [Key]
        public int IdPaciente { get; set; }

        [Required]
        [Display (Name = "Nombre", Prompt ="Ingrese un nombre")]
        public string? Nombre { get; set; }

        [Required]
        [Display (Name = "Apellido", Prompt ="Ingrese un apellido")]
        public string? Apellido { get; set; }

        [Required]
        [Display (Name = "Dirección", Prompt ="Ingrese una dirección")]
        public string? Direccion { get; set; }

        [Required]
        [Display (Name = "Teléfono", Prompt ="Ingrese un teléfono")]
        public string? Telefono { get; set; }

        [Required]
        [Display (Name = "Email", Prompt ="Ingrese un email")]
        [EmailAddress (ErrorMessage ="No es una dirección de email válida")]
        public string? Email { get; set; }
    }
}
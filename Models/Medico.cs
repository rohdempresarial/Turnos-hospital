using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class Medico
    {
        [Key]
        public int IdMedico { get; set; }
        [Required (ErrorMessage = "Debe ingresar un nombre")]
        public string? Nombre { get; set; }

        [Required (ErrorMessage = "Debe ingresar un apellido")]
        public string? Apellido { get; set; }

        [Required (ErrorMessage = "Debe ingresar una dirección")]
        [Display (Name ="Dirección")]
        public string? Direccion { get; set; }

        [Required (ErrorMessage = "Debe ingresar un teléfono")]
        [Display (Name ="Teléfono")]
        public string? Telefono { get; set; }

        [Required (ErrorMessage = "Debe ingresar un email")]
        [EmailAddress (ErrorMessage ="No es una dirección de email válida")]
        public string? Email { get; set; }

        [Display (Name ="Horario desde")]
        [DataType (DataType.Time)]
        public DateTime HorarioAtencionDesde { get; set; }

        [Display (Name ="Horario hasta")]
        [DataType (DataType.Time)]
        public DateTime HorarioAtencionHasta { get; set; }
        
        public List<MedicoEspecialidad>? MedicoEspecialidad {get;set;}
    }
}
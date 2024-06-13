using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Models
{
    public class Especialidad
    {
        [Key]
        public int IdEspecialidad { get; set; }
        [Required (ErrorMessage ="Debe ingresar una descripción")]
        [Display (Name="Descripción", Prompt ="Ingrese una descripción")]
        public string? Descripcion { get; set; }
        public List<MedicoEspecialidad>? MedicoEspecialidad{get;set;}
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMaste.Shared.Entities
{
    public class Taska
    {
        public int Id { get; set; }



        [Display(Name = "Usuario")]

        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]

        public string Description { get; set; } = null!;

        public string DtaCreation { get; set; } = null!;

        public string DtaVencimiento { get; set; } = null!;

        public string Prioridad { get; set; } = null!;

        public string Estado { get; set; } = null!;
    }
}
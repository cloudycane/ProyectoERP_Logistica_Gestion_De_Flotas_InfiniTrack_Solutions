using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Core.DTOs
{
    public class CategoriaActivosDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [StringLength(25, ErrorMessage = "Este campo requiere un mínimo de entre 1 y {0} carácteres.")]
        [Display(Name = "Nombre de la Categoría")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [StringLength(250, ErrorMessage = "Este campo requiere un mínimo de entre 1 y {0} carácteres.")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
    }
}

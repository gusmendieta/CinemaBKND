using BackEndProyecto.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProyecto.Entidades
{
    public class Genero
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="The Field {0} is required")]
        [StringLength(maximumLength:50)]
        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }

    }
}

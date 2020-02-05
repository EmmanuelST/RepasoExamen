using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RepasoExamen1.Entidades
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }
        [Required(ErrorMessage ="Es necesario introducir una fecha")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage ="Es necesario introducir un monto")]
        [Range(100,100000000,ErrorMessage ="EL monto no esta dentro del rango")]
        public decimal Monto { get; set; }
        [Required(ErrorMessage ="Es necesario introducir la cantidad de semanas")]
        [Range(1,100,ErrorMessage ="El rango de semanas es muy corto o muy largo")]
        public int Semanas { get; set; }
        [Required(ErrorMessage ="Es necesario introducir un concepto")]
        [StringLength(98,ErrorMessage ="El concepto es muy largo")]
        public string Concepto { get; set; }

        public Prestamos()
        {
            PrestamoId = 0;
            Fecha = DateTime.Now;
            Monto = 0;
            Semanas = 0;
            Concepto = string.Empty;
        }

    }
}

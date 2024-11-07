using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaAPI.Dtos
{
    public class CreateOrderDetailDto
    {
        [Required(ErrorMessage ="El producto es requerido.")]
        public required int ProductId { get; set; }

        [Required(ErrorMessage ="La cantidad es requerida.")]
        [Range(1, 100, ErrorMessage ="La cantidad debe ser mayor a 0")]
        public required int Quantity { get; set; }

    }
}
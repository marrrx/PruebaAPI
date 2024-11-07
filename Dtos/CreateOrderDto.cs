using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Bogus.DataSets;

namespace PruebaAPI.Dtos
{
    public class CreateOrderDto
    {
        [Required(ErrorMessage = "El total es requerido.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El total debe de ser mayor a cero.")]
        public required double Total { get; set; }
        public required int UserId { get; set; }
        public required List<CreateOrderDetailDto> OrderDetails { get; set; }

    }
}
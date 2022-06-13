using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [Range(0.01, 1000)]
        public decimal Price { get; set; }
        [Required]
        [Range(0,1000)]
        public int Stock { get; set; }
    }
}

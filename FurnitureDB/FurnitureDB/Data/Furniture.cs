using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mebeli.Data
{
    public class Furniture
    {
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string CatalogNum { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(5)]
        public string TypeFurniture { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string Color { get; set; }
        [Required]
        [Range(1,100)]
        public int Stock { get; set; }

        [Required]
        [Range(typeof(decimal),"0.01","10000")]
        public decimal Price { get; set; }
        
    }
}

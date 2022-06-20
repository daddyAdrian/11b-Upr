using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string RegistrationNumber { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]

        public string Model { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string Country { get; set; }

        [Required]
        [Range(1980, 2022)]
        public int Year { get; set; }

        [Required]
        [Range(3000, 100000)]
        public decimal Price { get; set; }
    }
}

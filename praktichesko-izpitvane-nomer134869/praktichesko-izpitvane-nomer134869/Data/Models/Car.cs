using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktichesko_izpitvane_nomer134869.Data.Models
{
    public class Car
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MinLength(6)]
        [MaxLength(10)]
        public int RegNum { get; set; }
        [Required]
        [MinLength(20)]
        [MaxLength(20)]
        public string Model { get; set; }
        [Required]
        [MinLength(20)]
        [MaxLength(20)]
        public string Country { get; set; }
        [Required]
        [Range(1980, 2022)]
        public int YearMade { get; set; }
        [Required]
        [Range(0.00, 1000.00)]
        public decimal PriceForADay{get;set;}
    }
}

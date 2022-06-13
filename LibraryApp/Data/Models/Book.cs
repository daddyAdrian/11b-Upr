using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        [Range(1800, 2022)]
        public int YearPublished { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Genre { get; set; }

    }
}

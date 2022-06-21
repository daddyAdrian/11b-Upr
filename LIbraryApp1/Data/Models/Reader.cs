using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Reader
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(10)]
        public string EGN { get; set; }
        [Required]
        public string Job { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(10)]
        public string Number { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}

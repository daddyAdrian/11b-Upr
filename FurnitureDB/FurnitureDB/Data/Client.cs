using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mebeli.Data
{
    public class Client
    {
        [Required]
        [MinLength(10)]
        [MaxLength(10)]
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string LastName { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(10)]
        public int EGN { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        [MaxLength(30)]
        [EmailAddress]
        public string Email { get; set; }
    }
}

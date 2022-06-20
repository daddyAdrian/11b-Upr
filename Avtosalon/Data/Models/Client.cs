using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [MinLength(3)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(10)]
        [MinLength(10)]
        public string EGN { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(10)]
        public string Phone { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(30)]
        public string Adress { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }


    }
}

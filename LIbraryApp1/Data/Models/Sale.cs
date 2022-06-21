using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Sale
    {
        public int Id { get; set; }
        [Required]
        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Book Book { get; set; }
        [Required]
        [ForeignKey("Reader")]
        public int ReaderId { get; set; }
        public Reader Reader { get; set; }
        [Required]
        public DateTime DatePurchased { get; set; }
        public DateTime DateReturned { get; set; }
        public bool IsReturned { get; set; }
    }
}

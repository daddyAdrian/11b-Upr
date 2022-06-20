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
        [ForeignKey("Car")]
        [Required]
        public int CarId { get; set; }
        public Car Car { get; set; }
        [ForeignKey("Client")]
        [Required]
        public int ClientId { get; set; }
        public Client Client { get; set; }
        [Required]
        public DateTime DatePurchase { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktichesko_izpitvane_nomer134869.Data.Models
{
    public class Reservation
    {

        public int Id { get; set; }
        public string Model { get; set; }

        public string ClientId { get; set; }
        public Client Client { get; set; }
        [Required]
        public DateTime DateRented { get; set; }
        [Required]
        [MinLength(1)]
        [MaxLength(20)]
        public int DaysRented { get; set; }
        public Car Car { get; set; }
        public string CarType { get; set; }

        public decimal Price
        {
            get
            {
                return DaysRented * Car.PriceForADay;
            }
        }
    }
}

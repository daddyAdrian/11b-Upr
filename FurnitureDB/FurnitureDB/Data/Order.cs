using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mebeli.Data
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int OrderDate { get; set; }
        public string TypeFurniture { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int FurnitureId { get; set; }
        public Furniture Furniture { get; set; }
        [Required]
        [Range(1,100)]
        public int Amount { get; set; }
        public decimal Price
        {
            get
            {
                return Amount * Furniture.Price;
            }
        }
    }
}

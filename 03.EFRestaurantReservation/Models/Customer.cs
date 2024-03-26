using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EFRestaurantReservation.Models
{
    public class Customer : BaseModel
    {
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Surname { get; set; }
        public string? Email { get; set; }
        public string Phone { get; set; }
        public string? Address { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EFRestaurantReservation.Models
{
    public class Resevation : BaseModel
    {
        public DateTime ReservationDate { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
    }
}

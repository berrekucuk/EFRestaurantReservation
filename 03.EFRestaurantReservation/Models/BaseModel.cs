using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EFRestaurantReservation.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime AddDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
    }
}

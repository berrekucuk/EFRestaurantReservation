using _03.EFRestaurantReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EFRestaurantReservation.Services
{
    public class ReservationService
    {
        public List<Resevation> GetAllReservation()
        {
            RestaurantContext db = new RestaurantContext();
            List<Resevation> reservation = db.Resevations.ToList();

            return reservation;
        }        

        public Resevation AddReservation(Resevation reservation)
        {
            RestaurantContext db = new RestaurantContext();
            db.Resevations.Add(reservation);
            db.SaveChanges();  
            
            return reservation;
        }
    }
}

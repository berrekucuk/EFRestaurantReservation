using _03.EFRestaurantReservation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EFRestaurantReservation.Services
{
    public class CustomerService
    {
        public List<Customer> GetAllCustomer()
        {
            RestaurantContext db = new RestaurantContext();
            List<Customer> customer = db.Customers.Where(x => x.IsDeleted == false).ToList();
            return customer;
        }

        public Customer AddCustomer(Customer customer)
        {
            RestaurantContext db = new RestaurantContext();
            db.Customers.Add(customer);
            db.SaveChanges();
            return customer;
        }

        public void DeleteCustomer(int id) 
        {
            RestaurantContext db = new RestaurantContext();
            Customer customer = db.Customers.FirstOrDefault(x => x.Id == id);
            customer.IsDeleted = true;
            db.SaveChanges();
        }
       
    }

}

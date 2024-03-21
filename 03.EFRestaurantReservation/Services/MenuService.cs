using _03.EFRestaurantReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Menu = _03.EFRestaurantReservation.Models.Menu;


namespace _03.EFRestaurantReservation.Services
{
    public class MenuService
    {
        public List<Menu> GetAllMenu()
        {
            RestaurantContext db = new RestaurantContext();
            List<Menu> menu = db.Menu.Where(x => x.IsDeleted == false).ToList();
            return menu;
        }

        public Menu AddMenu(Menu menu)
        {
            RestaurantContext db = new RestaurantContext();
            db.Menu.Add(menu);
            db.SaveChanges();
            return menu;
        }

        public void DeleteMenu(int id)
        {
            RestaurantContext db = new RestaurantContext();
            Menu menu = db.Menu.FirstOrDefault( x => x.Id == id);
            menu.IsDeleted = true;
            db.SaveChanges();
        }
    }
}

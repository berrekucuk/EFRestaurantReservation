using _03.EFRestaurantReservation.Models;
using _03.EFRestaurantReservation.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03.EFRestaurantReservation.Froms
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            MenuService menuService = new MenuService();
            List<Menu> menu = menuService.GetAllMenu();
            dgvMenuList.DataSource = menu;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Menu menu = new Menu();
                menu.Title = txtAddTitle.Text;
                menu.Description = txtAddDescription.Text;
                menu.Price = Convert.ToInt32(txtAddPrice.Text);

                MenuService menuService = new MenuService();
                menuService.AddMenu(menu);
                MessageBox.Show("Menu added successfully!");
                LoadData();
            }
            catch (Exception)
            {

                MessageBox.Show("There was an error adding!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedMenuId = (int)dgvMenuList.CurrentRow.Cells["id"].Value;
                MenuService menuService = new MenuService();
                menuService.DeleteMenu(selectedMenuId);                

                LoadData();

                MessageBox.Show("Delete process successful!");
            }
            catch (Exception)
            {

                MessageBox.Show("There was an error adding!");
            }
        }

        private void dgvMenuList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedMenuId = (int)dgvMenuList.CurrentRow.Cells["id"].Value;
                RestaurantContext db = new RestaurantContext();
                Menu menu = db.Menu.FirstOrDefault(x => x.Id == selectedMenuId);

                if (menu != null)
                {
                    txtUpdateTitle.Text = menu.Title;
                    txtUpdateDescription.Text = menu.Description;
                    txtUpdatePrice.Text = menu.Price.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("There was an error adding!");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedMenuId = (int)dgvMenuList.CurrentRow.Cells["id"].Value;
                RestaurantContext db = new RestaurantContext();
                Menu menu = db.Menu.FirstOrDefault(x => x.Id == selectedMenuId);
                
                menu.Title = txtUpdateTitle.Text;
                menu.Description = txtUpdateDescription.Text;
                menu.Price = Convert.ToDecimal(txtUpdatePrice.Text);

                db.SaveChanges();                

                LoadData();

                MessageBox.Show("Update process successful!");
            }
            catch (Exception)
            {

                MessageBox.Show("There was an error adding!");
            }
        }
    }
}

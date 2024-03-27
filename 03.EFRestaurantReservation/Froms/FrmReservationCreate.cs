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
    public partial class FrmReservationCreate : Form
    {
        public FrmReservationCreate()
        {
            InitializeComponent();
        }

        private void FrmReservationCreate_Load(object sender, EventArgs e)
        {
            LoadData();

            CustomerService customerService = new CustomerService();
            List<Customer> customer = customerService.GetAllCustomer();
            cmbCustomer.DataSource = customer;            
            cmbCustomer.DisplayMember = "Name";
            cmbCustomer.ValueMember = "Id";
        }

        private void LoadData()
        {
            ReservationService reservationService = new ReservationService();
            List<Resevation> reservation = reservationService.GetAllReservation();
            dgvResevationList.DataSource = reservation;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Resevation resevation = new Resevation();
                resevation.CustomerId = Convert.ToInt32(cmbCustomer.SelectedValue);

                //Customer selectedCustomer = (Customer)cmbCustomer.SelectedItem;
                //resevation.Customer = selectedCustomer;

                resevation.Description = txtDescription.Text;
                resevation.ReservationDate = dtpreservationDate.Value;
                resevation.AddDate = DateTime.Now;
                resevation.IsDeleted = false;

                ReservationService reservationService = new ReservationService();
                reservationService.AddReservation(resevation);

                LoadData();
                MessageBox.Show("Reservation added successfully!");
            }
            catch (Exception)
            {

                MessageBox.Show("There was an error adding!");
            }
        }
    }
}

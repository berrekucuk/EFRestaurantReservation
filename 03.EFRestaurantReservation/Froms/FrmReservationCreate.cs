using _03.EFRestaurantReservation.Models;
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
            RestaurantContext db = new RestaurantContext();
            List<Customer> customer = db.Customers.ToList();

            cmbCustomer.DataSource = customer;
            cmbCustomer.DisplayMember = "Name";
            cmbCustomer.ValueMember = "Id";
            LoadData(db);

        }

        private void LoadData(RestaurantContext db)
        {
            List<Resevation> resevation = db.Resevations.ToList();
            dgvResevationList.DataSource = resevation;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RestaurantContext db = new RestaurantContext();
            Resevation resevation = new Resevation()
            {
                CustomerId = Convert.ToInt32(cmbCustomer.SelectedValue),
                ReservationDate = Convert.ToDateTime(dtpreservationDate.Value),
                Description = txtDescription.Text,
                AddDate = DateTime.Now
            };

            db.Resevations.Add(resevation);
            db.SaveChanges();
            LoadData(db);
            

        }
    }
}

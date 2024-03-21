using _03.EFRestaurantReservation.Models;
using _03.EFRestaurantReservation.Services;

namespace _03.EFRestaurantReservation
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            CustomerService customerService = new CustomerService();
            List<Customer> customer = customerService.GetAllCustomer();
            dgvCustomerList.DataSource = customer;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer();
                customer.Name = txtAddName.Text.Trim();
                customer.Surname = txtAddSurname.Text.Trim();
                customer.Email = txtAddEmail.Text.Trim();
                customer.Phone = txtAddPhone.Text.Trim();
                customer.Address = txtAddAddress.Text.Trim();

                CustomerService customerService = new CustomerService();
                customerService.AddCustomer(customer);
                MessageBox.Show("Customer added successfully!");
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
                int selectedCustomerId = (int)dgvCustomerList.CurrentRow.Cells["id"].Value;

                CustomerService customerService = new CustomerService();
                customerService.DeleteCustomer(selectedCustomerId);

                LoadData();

                MessageBox.Show("Delete process successful!");
            }
            catch (Exception)
            {

                MessageBox.Show("There was an error adding!");
            }
        }

        private void dgvCustomerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedCustomerId = (int)dgvCustomerList.CurrentRow.Cells["id"].Value;
                RestaurantContext db = new RestaurantContext();
                Customer customer = db.Customers.FirstOrDefault(x => x.Id == selectedCustomerId);

                if (customer != null)
                {
                    txtUpdateName.Text = customer.Name;
                    txtUpdateSurname.Text = customer.Surname;
                    txtUpdateEmail.Text = customer.Email;
                    txtUpdatePhone.Text = customer.Phone;
                    txtUpdateAddress.Text = customer.Address;

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
                int selectedCustomerId = (int)dgvCustomerList.CurrentRow.Cells["id"].Value;

                RestaurantContext db = new RestaurantContext();
                Customer customer = db.Customers.FirstOrDefault(x => x.Id == selectedCustomerId);
                customer.Name = txtUpdateName.Text.Trim();
                customer.Surname = txtUpdateSurname.Text.Trim();
                customer.Email = txtUpdateEmail.Text.Trim();
                customer.Phone = txtUpdatePhone.Text.Trim();
                customer.Address = txtUpdateAddress.Text.Trim();

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

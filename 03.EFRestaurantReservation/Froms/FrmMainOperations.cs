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
    public partial class FrmMainOperations : Form
    {
        public FrmMainOperations()
        {
            InitializeComponent();
        }

        private void FrmMainOperations_Load(object sender, EventArgs e)
        {

        }

        private void FormCheck(Form form)
        {
            form.MdiParent = this;

            var FormAcikMi = false;

            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == form.GetType()) //Açık formları kontrol edicek
                {
                    FormAcikMi = true;
                }
            }
            if (FormAcikMi)
            {
                MessageBox.Show("Form Zaten Açık");
            }
            else
            {
                form.Show();
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FrmCustomer frmCustomer = new FrmCustomer();
            FormCheck(frmCustomer);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            FormCheck(frmMenu);
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            FrmReservationCreate frmReservationCreate = new FrmReservationCreate();
            FormCheck(frmReservationCreate);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            FrmCreateOrder frmCreateOrder = new FrmCreateOrder();
            FormCheck(frmCreateOrder);
        }
    }
}

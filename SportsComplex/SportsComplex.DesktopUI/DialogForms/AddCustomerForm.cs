using SportsComplex.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsComplex.DesktopUI
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbLastName.Text) || string.IsNullOrWhiteSpace(tbFirstName.Text) 
                || !mtbPhone.MaskFull)
            {
                MessageBox.Show("First name, last name or phone is invalid", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var customersRepository = new SqlCustomersRepository(ConfigurationManager.ConnectionStrings["SportsComplexConnectionString"].ConnectionString);

                customersRepository.Add(tbLastName.Text, tbFirstName.Text, mtbPhone.Text);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}

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
    public partial class AddRenterForm : Form
    {
        public AddRenterForm()
        {
            InitializeComponent();
        }

        private void btnAddRenter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbLastName.Text) || string.IsNullOrWhiteSpace(tbFirstName.Text) 
                || !mtbPhone.MaskFull)
            {
                MessageBox.Show("First name, last name or phone is invalid", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var rentersRepository = new SqlRentersRepository(ConfigurationManager.ConnectionStrings["SportsComplexConnectionString"].ConnectionString);

                rentersRepository.Add(tbLastName.Text, tbFirstName.Text, mtbPhone.Text);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}

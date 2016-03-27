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
    public partial class RentersForm : Form
    {
        public RentersForm()
        {
            InitializeComponent();

            _rentersRepository = new SqlRentersRepository(connString);
        }

        private void RentersForm_Load(object sender, EventArgs e)
        {
            var renters = _rentersRepository.SelectAll();

            foreach(var r in renters)
            {
                dgvRenters.Rows.Add(r.Id, r.FirstName, r.LastName, r.Phone);
            }
        }

        private SqlRentersRepository _rentersRepository;
        private string connString = ConfigurationManager.ConnectionStrings["SportsComplexConnectionString"].ConnectionString;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRenterForm frmAddRenter = new AddRenterForm();
            if (frmAddRenter.ShowDialog() == DialogResult.OK)
            {
                dgvRenters.Rows.Clear();
                var renters = _rentersRepository.SelectAll();
                // Update renters data grid.
                foreach(var r in renters)
                {
                    dgvRenters.Rows.Add(r.Id, r.FirstName, r.LastName, r.Phone);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvRenters.SelectedCells.Count > 0)
            {
                int row = dgvRenters.SelectedCells[0].RowIndex;
                
                // Remove selected renter. 
                _rentersRepository.Remove((int)dgvRenters[0, row].Value);

                dgvRenters.Rows.RemoveAt(dgvRenters.SelectedCells[0].RowIndex);
            }
        }

        private void dgvRenters_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvRenters[0, e.RowIndex].Value;
            string firstName = (string)dgvRenters[1, e.RowIndex].Value;
            string lastName = (string)dgvRenters[2, e.RowIndex].Value;
            string phone = (string)dgvRenters[3, e.RowIndex].Value;

            try
            {
                _rentersRepository.Edit(id, lastName, firstName, phone);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

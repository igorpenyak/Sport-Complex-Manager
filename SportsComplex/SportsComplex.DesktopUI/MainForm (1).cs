using SportsComplex.Entities;
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
    public partial class MainForm : Form
    {
        private string connString = ConfigurationManager.ConnectionStrings["SportsComplexConnectionString"].ConnectionString;
        // Repositories...
        private SqlRentsRepository _rentsRepository;

        public MainForm(User user)
        {
            InitializeComponent();
            _rentsRepository = new SqlRentsRepository(connString);
            this.Text = String.Format("{0} - [Logged as {1} {2}]", this.Text, user.FirstName, user.LastName);
        }

        private void miShowPriceList_Click(object sender, EventArgs e)
        {
            PriceListForm frmPriceList = new PriceListForm();
            frmPriceList.ShowDialog();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load current rents.
            var rents = _rentsRepository.GetRentsOnDate(DateTime.Now);

            // Update UI.
            UpdateRentsDataGridView(rents);
        }

        public void UpdateRentsDataGridView(IEnumerable<RentItem> rents)
        {
            dgvRents.Rows.Clear();

            foreach (var r in rents)
            {
                dgvRents.Rows.Add(
                    r.Id, 
                    string.Format("{0} {1}.", r.Renter.LastName, r.Renter.FirstName[0]), 
                    r.SportsHall.Type, 
                    r.SportsHall.Area,
                    r.SportsHall.Rate,
                    r.DateStart,
                    r.DateEnd,
                    r.Renter.Phone,
                    r.Cost);
            }
        }

        private void sportsHallsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SportsHallsForm frmSportsHalls = new SportsHallsForm();
            frmSportsHalls.ShowDialog();
        }

        private void btnCancelRent_Click(object sender, EventArgs e)
        {
            if (dgvRents.Rows.Count > 0 && dgvRents.SelectedRows[0].Index >= 0)
            {
                decimal moneyChange = _rentsRepository.Remove(dgvRents.SelectedRows[0].Index);

                if (moneyChange > 0)
                {
                    MessageBox.Show($"Change: moneyChange", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

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
    public partial class SportsHallTypesForm : Form
    {
        public SportsHallTypesForm()
        {
            InitializeComponent();

            _sportsHallTypesRepository = new SqlSportsHallTypesRepository(ConfigurationManager.ConnectionStrings["SportsComplexConnectionString"].ConnectionString);
        }

        private void SportsHallTypesForm_Load(object sender, EventArgs e)
        {
            UpdateSportsHallTypes();
        }

        private void UpdateSportsHallTypes()
        {
            lstSportsHallTypes.Items.Clear();
            var types = _sportsHallTypesRepository.SelectAll();

            foreach (var t in types)
            {
                lstSportsHallTypes.Items.Add(t);
            }

            tbTypeName.Text = string.Empty;
        }
        

        private void btnAddHallType_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbTypeName.Text))
            {
                _sportsHallTypesRepository.Add(tbTypeName.Text);
            }
            else
            {
                MessageBox.Show("Entered type name is invalid", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
      

            // Update UI.
            UpdateSportsHallTypes();
        }

        // IP: це поле мало би бути описано напочатку інтерфейсу класу
        private SqlSportsHallTypesRepository _sportsHallTypesRepository;

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSportsHallTypes.SelectedIndex >= 0)
            {
                _sportsHallTypesRepository.Remove(((SportsHallType)lstSportsHallTypes.SelectedItem).Id);
                UpdateSportsHallTypes();
            }
        }
    }
}

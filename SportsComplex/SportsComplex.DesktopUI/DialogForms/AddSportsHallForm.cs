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
    public partial class AddSportsHallForm : Form
    {
        public AddSportsHallForm()
        {
            InitializeComponent();

            _sportsHallTypesRepository = new SqlSportsHallTypesRepository(ConfigurationManager.ConnectionStrings["SportsComplexConnectionString"].ConnectionString);
            _sportsHallRepository = new SqlSportsHallsRepository(ConfigurationManager.ConnectionStrings["SportsComplexConnectionString"].ConnectionString);
        }

        private void AddSportsHallForm_Load(object sender, EventArgs e)
        {
            cbType.Items.Clear();

            var hallTypes = _sportsHallTypesRepository.SelectAll();
            foreach (var ht in hallTypes)
            {
                cbType.Items.Add(ht);
            }
        }

        private void btnSportsHall_Click(object sender, EventArgs e)
        {
            if (cbType.SelectedIndex >= 0)
            {
                _sportsHallRepository.Add(((SportsHallType)(cbType.SelectedItem)).Id, (int)nudArea.Value, nudRate.Value);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("First, chose a type of sports hall", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private SqlSportsHallTypesRepository _sportsHallTypesRepository;
        private SqlSportsHallsRepository _sportsHallRepository;
    }
}

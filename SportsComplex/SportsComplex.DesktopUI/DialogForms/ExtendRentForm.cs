﻿using SportsComplex.Entities;
using SportsComplex.Repositories;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace SportsComplex.DesktopUI
{
    public partial class ExtendRentForm : Form
    {
        public ExtendRentForm(RentItem rent)
        {
            InitializeComponent();

            _rentsRepository = new SqlRentsRepository(_connString);
            
            // Accept parameter.
            _rent = rent;
        }

        private RentItem _rent;

        private void dtpTimeTo_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan ts = dtpTimeFrom.Value - dtpTimeTo.Value;
            decimal _costTotal = _rent.SportsHall.Rate * (decimal)(ts.TotalMinutes / 60);

            lblOverpay.Text = Math.Abs(Math.Round(_costTotal, 2, MidpointRounding.AwayFromZero)).ToString();
        }

        private void ExtendRentForm_Load(object sender, EventArgs e)
        {
            dtpTimeFrom.Value = _rent.DateEnd.AddMinutes(1);
            dtpTimeTo.MinDate = _rent.DateEnd.AddMinutes(2);
            dtpTimeTo.Value = _rent.DateEnd.AddHours(1);
        }

        private void btnExtendRent_Click(object sender, EventArgs e)
        {
            _rentsRepository.ExtendRent(_rent.Id, dtpTimeTo.Value, Convert.ToDecimal(lblOverpay.Text));
            this.DialogResult = DialogResult.OK;
            return;
        }

        // IP: ці поля мали би бути описані напочатку інтерфейсу класу
        private SqlRentsRepository _rentsRepository;

        private string _connString = ConfigurationManager.ConnectionStrings["SportsComplexConnectionString"].ConnectionString;
    }
}

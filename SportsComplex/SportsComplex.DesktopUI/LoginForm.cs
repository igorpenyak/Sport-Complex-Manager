using SportsComplex.Entities;
using SportsComplex.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsComplex.DesktopUI
{
    public partial class LoginForm : Form
    {
        private string connString = ConfigurationManager.ConnectionStrings["SportsComplexConnectionString"].ConnectionString;
        private SqlUsersRepository _userRepository;

        // Logged user information.
        public User User { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            _userRepository = new SqlUsersRepository(connString);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                int userId = _userRepository.Auth(tbLogin.Text, Encryptor.MD5Hash(tbPassword.Text));

                var query = from user in _userRepository.SelectAll()
                            where user.Id.Equals(userId)
                            select user;

                this.User = query.ToList()[0];

                this.DialogResult = DialogResult.OK;
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, "Authentification error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using ExchangeRate.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangeRate
{
    public partial class LoginForm : Form
    {
        public bool isLoggedIn = false;

        public LoginForm()
        {
            InitializeComponent();
            LoginPanel.BackColor = Color.FromArgb(51, 54, 118);
            MainLabel.ForeColor = Color.FromArgb(212, 166, 106);
            EnterButton.ForeColor = Color.FromArgb(51, 54, 118);
            CancelButton.ForeColor = Color.FromArgb(51, 54, 118);
            EnterButton.BackColor = Color.FromArgb(212, 166, 106);
            CancelButton.BackColor = Color.FromArgb(212, 166, 106);
            EnterButton.Select();
        }

        public Panel GetPanel() => LoginPanel;

        private void EnterButton_Click(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;
            string correctPassword = Properties.Resources.Password;
            string hashedInputValue = GetHashValue();
            if(LoginTB.Text == Properties.Resources.Login && hashedInputValue == correctPassword)
            {
                FavouritesRepository favRep = new FavouritesRepository();
                isLoggedIn = true;
                if(favRep.GetAllFavourites().Count() > 0) (LoginPanel.Parent as MainForm).ShowFav();
                LoginPanel.Dispose();
            }
            else
            {
                LoginTB.Text = String.Empty;
                PasswordTB.Text = String.Empty;
                ErrorLabel.Visible = true;
            }
            
        }

        private string GetHashValue()
        {
            string inputPas = PasswordTB.Text;            
            string salt = Properties.Resources.Salt;

            byte[] saltedPasswordBytes = new byte[inputPas.Length+salt.Length];
            byte[] inputPasBytes = Encoding.ASCII.GetBytes(inputPas);
            byte[] saltBytes = Encoding.ASCII.GetBytes(salt);

            for (int i = 0; i < inputPasBytes.Length; i++)
                saltedPasswordBytes[i] = inputPasBytes[i];

            for (int i = 0; i < saltBytes.Length; i++)
                saltedPasswordBytes[inputPasBytes.Length + i] = saltBytes[i];

            byte[] resHash = new SHA1CryptoServiceProvider().ComputeHash(saltedPasswordBytes);
            string resultPassword = string.Empty;
            for (int i = 0; i < resHash.Length; i++)
            {
                resultPassword += resHash[i].ToString("X2");
            }

            return resultPassword;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            LoginPanel.Dispose();
        }

        private void LoginTB_TextChanged(object sender, EventArgs e)
        {
            EnterButton.Enabled = 
                !(string.IsNullOrWhiteSpace(LoginTB.Text) || string.IsNullOrWhiteSpace(PasswordTB.Text));
        }
    }
}

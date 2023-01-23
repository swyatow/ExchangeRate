using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangeRate
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            AboutPanel.BackColor = Color.FromArgb(51, 54, 118);
            MainLabel.ForeColor = Color.FromArgb(212, 166, 106);
            InfoLabel.ForeColor = Color.FromArgb(212, 166, 106);
            OKButton.ForeColor = Color.FromArgb(51, 54, 118);
            OKButton.BackColor = Color.FromArgb(212, 166, 106);
        }

        private void AboutForm_SizeChanged(object sender, EventArgs e)
        {
            AboutPanel.Left = ActiveForm.Width / 2 - AboutPanel.Width / 2 - 10;
        }

        private void AboutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        public Panel GetPanel() => AboutPanel;

        private void OKButton_Click(object sender, EventArgs e)
        {
            AboutPanel.Dispose();
        }
    }
}

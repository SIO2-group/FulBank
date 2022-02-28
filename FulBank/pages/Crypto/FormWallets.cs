using Fulbank.classes;
using FulBank;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fulbank.pages.Crypto
{
    public partial class FormWallets : Form
    {
        public FormWallets()
        {
            InitializeComponent();
        }

        private void FormWallets_Load(object sender, EventArgs e)
        {
            foreach(Cryptowallet wallet in FormMain.user.GetWallets())
            {
                FormCryptocurrency.cryptos.TryGetValue(wallet.GetSymbol(), out Cryptocurrency crypto);
                dgvWallets.Rows.Add(wallet.GetSymbol(), crypto.name, wallet.GetAmount(), crypto.price_eur, float.Parse(crypto.price_eur) * wallet.GetAmount());
            }
        }

        private void dgvWallets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

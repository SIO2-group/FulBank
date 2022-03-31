using Fulbank.classes;
using FulBank;
using System;
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
            //user's crypto list
            foreach (Cryptowallet wallet in FormMain.user.GetWallets())
            {
                if(FormCryptocurrency.cryptos.TryGetValue(wallet.GetSymbol(), out Cryptocurrency crypto)) {
                    MessageBox.Show(wallet.getId().ToString());
                    dgvWallets.Rows.Add(wallet.GetSymbol(), crypto.name, wallet.GetAmount(), crypto.price_eur, float.Parse(crypto.price_eur) * wallet.GetAmount());
                }
            }
        }

        private void dgvWallets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

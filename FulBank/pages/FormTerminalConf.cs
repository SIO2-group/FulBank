using FulBank.classes;
using System;
using System.Net;
using System.Windows.Forms;

namespace Fulbank.pages
{
    public partial class FormTerminalConf : Form
    {
        public FormTerminalConf()
        {
            InitializeComponent();
        }

        private void textBoxIp_TextChanged(object sender, EventArgs e)
        {

        }

        private void TerminalConf_Load(object sender, EventArgs e)
        {
            this.Text = String.Empty;
            this.ControlBox = false;
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST  
            Console.WriteLine(hostName);
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            textBoxIp.Text = myIP;
        }

        private void buttonSetIni_Click(object sender, EventArgs e)
        {
            IniFile MyIni = new IniFile("Fulbank.ini");
            if (!MyIni.KeyExists("City"))
            {
                MyIni.Write("City", textBoxCity.Text);
            }
            else
            {
                MyIni.DeleteKey("City");
                MyIni.Write("City", textBoxCity.Text);
            }

            if (!MyIni.KeyExists("Building"))
            {
                MyIni.Write("Building", textBoxCity.Text);
            }
            else
            {
                MyIni.DeleteKey("Building");
                MyIni.Write("Building", textBoxBuilding.Text);
            }

            if (!MyIni.KeyExists("Ipv4"))
            {
                MyIni.Write("Ipv4", textBoxIp.Text);
            }
            else
            {
                MyIni.DeleteKey("Ipv4");
                MyIni.Write("Ipv4", textBoxIp.Text);
            }

        }
    }
}

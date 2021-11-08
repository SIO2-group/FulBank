using FulBank;
using FulBank.classes;
using MySql.Data.MySqlClient;
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

            FormMain.dbConnexion.Open();
            
            if(MyIni.KeyExists("City") && MyIni.KeyExists("Building") && MyIni.KeyExists("Ipv4"))
            {
                string commandTextInsertTerminal = "UPDATE terminal SET TL_BUILDING = '" + textBoxBuilding.Text + "', TL_CITY = '" + textBoxCity.Text + "',  TL_IP = '" + textBoxIp.Text + "' WHERE TL_BUILDING = '" + MyIni.Read("Building") + "' AND TL_CITY = '" + MyIni.Read("City") + "' AND  TL_IP = '" + MyIni.Read("Ipv4") + "'";
                MySqlCommand cmdInsertTerminal = new MySqlCommand(commandTextInsertTerminal, FormMain.dbConnexion);
                cmdInsertTerminal.ExecuteNonQuery();
            }
            else
            {
                string commandTextInsertTerminal = "INSERT INTO terminal(TL_BUILDING, TL_CITY, TL_IP) VALUES('" + textBoxBuilding.Text + "','" + textBoxCity.Text + "','" + textBoxIp.Text + "')";
                MySqlCommand cmdInsertTerminal = new MySqlCommand(commandTextInsertTerminal, FormMain.dbConnexion);
                cmdInsertTerminal.ExecuteNonQuery();
            }

            FormMain.dbConnexion.Close();

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
                MyIni.Write("Building", textBoxBuilding.Text);
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

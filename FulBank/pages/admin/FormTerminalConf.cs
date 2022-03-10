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
            string myIP = Dns.GetHostEntry(hostName).AddressList[0].ToString();
            textBoxIp.Text = myIP;
        }

        private void buttonSetIni_Click(object sender, EventArgs e)
        {
            IniFile MyIni = new IniFile("Fulbank.ini");

            FormMain.dbConnexion.Open();
            if(!String.IsNullOrEmpty(textBoxBuilding.Text) && !String.IsNullOrEmpty(textBoxCity.Text) && !String.IsNullOrEmpty(textBoxIp.Text) && !String.IsNullOrEmpty(textPostalCode.Text))
            {
                if(MyIni.KeyExists("Id"))
                {
                    string commandTextInsertTerminal = "UPDATE terminal SET TL_BUILDING = '" + textBoxBuilding.Text + "',TL_POSTALCODE = '" + textPostalCode.Text + "', TL_CITY = '" + textBoxCity.Text + "',  TL_IP = '" + textBoxIp.Text + "' WHERE TL_ID = '" + MyIni.Read("Id") + "'";
                    MySqlCommand cmdInsertTerminal = new MySqlCommand(commandTextInsertTerminal, FormMain.dbConnexion);
                    cmdInsertTerminal.ExecuteNonQuery();
                }
                else
                {
                    string commandTextInsertTerminal = "INSERT INTO terminal(TL_BUILDING, TL_CITY, TL_IP, TL_POSTALCODE) VALUES('" + textBoxBuilding.Text + "','" + textBoxCity.Text + "','" + textBoxIp.Text + "', '" + textPostalCode.Text + "')";
                    MySqlCommand cmdInsertTerminal = new MySqlCommand(commandTextInsertTerminal, FormMain.dbConnexion);
                    cmdInsertTerminal.ExecuteNonQuery();
                    FormMain.dbConnexion.Close();
                    FormMain.dbConnexion.Open();
                    string commandTextGetTerminal = "SELECT TL_ID FROM terminal WHERE TL_BUILDING = '" + textBoxBuilding.Text + "' AND TL_CITY = '" + textBoxCity.Text + "' AND TL_IP ='" + textBoxIp.Text + "' AND TL_POSTALCODE ='" + textPostalCode.Text + "'";
                    MySqlCommand cmdGetTerminal = new MySqlCommand(commandTextGetTerminal, FormMain.dbConnexion);
                    string terminalId = cmdGetTerminal.ExecuteScalar().ToString();
                    MyIni.Write("Id", terminalId);
                    FormMain.dbConnexion.Close();
                }

                if (!MyIni.KeyExists("City"))
                {
                    MyIni.Write("City", textBoxCity.Text);
                }
                else
                {
                    MyIni.DeleteKey("City");
                    MyIni.Write("City", textBoxCity.Text);
                }

                if (!MyIni.KeyExists("CP"))
                {
                    MyIni.Write("CP", textPostalCode.Text);
                }
                else
                {
                    MyIni.DeleteKey("CP");
                    MyIni.Write("CP", textPostalCode.Text);
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
}

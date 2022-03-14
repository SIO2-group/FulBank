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
                    string commandTextInsertTerminal = "UPDATE terminal SET TL_BUILDING = ?building,TL_POSTALCODE = ?cp, TL_CITY = ?city,  TL_IP = ?boxip WHERE TL_ID = ?tl_ip";
                    MySqlCommand cmdInsertTerminal = new MySqlCommand(commandTextInsertTerminal, FormMain.dbConnexion);
                    cmdInsertTerminal.Parameters.AddWithValue("building", textBoxBuilding.Text);
                    cmdInsertTerminal.Parameters.AddWithValue("cp", textPostalCode.Text);
                    cmdInsertTerminal.Parameters.AddWithValue("city", textBoxCity.Text);
                    cmdInsertTerminal.Parameters.AddWithValue("boxip", textBoxIp.Text);
                    cmdInsertTerminal.Parameters.AddWithValue("tl_ip", MyIni.Read("Id"));
                    cmdInsertTerminal.ExecuteNonQuery();
                }
                else
                {
                    string commandTextInsertTerminal = "INSERT INTO terminal(TL_BUILDING, TL_CITY, TL_IP, TL_POSTALCODE) VALUES(?building,?city,?boxip,?cp)";
                    MySqlCommand cmdInsertTerminal = new MySqlCommand(commandTextInsertTerminal, FormMain.dbConnexion);
                    cmdInsertTerminal.Parameters.AddWithValue("building", textBoxBuilding.Text);
                    cmdInsertTerminal.Parameters.AddWithValue("city", textBoxCity.Text);
                    cmdInsertTerminal.Parameters.AddWithValue("boxip", textBoxIp.Text);
                    cmdInsertTerminal.Parameters.AddWithValue("cp", textPostalCode.Text);
                    cmdInsertTerminal.ExecuteNonQuery();
                    FormMain.dbConnexion.Close();
                    FormMain.dbConnexion.Open();
                    string commandTextGetTerminal = "SELECT TL_ID FROM terminal WHERE TL_BUILDING = ?building AND TL_CITY = ?city AND TL_IP =?boxip AND TL_POSTALCODE =?cp";
                    MySqlCommand cmdGetTerminal = new MySqlCommand(commandTextGetTerminal, FormMain.dbConnexion);
                    cmdGetTerminal.Parameters.AddWithValue("building", textBoxBuilding.Text);
                    cmdGetTerminal.Parameters.AddWithValue("city", textBoxCity.Text);
                    cmdGetTerminal.Parameters.AddWithValue("boxip", textBoxIp.Text);
                    cmdGetTerminal.Parameters.AddWithValue("cp", textPostalCode.Text);
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

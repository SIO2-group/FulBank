using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fulbank
{
    public partial class FormAdmin : Form
    {
        private string _userId;

        List<Panel> listPanel = new List<Panel>();
        int Index;

        public FormAdmin(string userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            listPanel.Add(PanelAdminProfile);
            listPanel.Add(PanelAdminCreate);
            listPanel[0].BringToFront();
        }

        private void MenuProfil_Click(object sender, EventArgs e)
        {
            listPanel[0].BringToFront();

        }

        private void MenuCreateAccount_Click(object sender, EventArgs e)
        {
            listPanel[1].BringToFront();

        }

        private void UserCreateNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void UserCreateButton_Click(object sender, EventArgs e)
        {
            InvalidName.Hide();
            InvalidFIrstame.Hide();
            InvalidPhone.Hide();
            NullPhone.Hide();
            InvalidLandline.Hide();
            NullLandline.Hide();
            InvalidMail.Hide();
            NullMail.Hide();
            InvalidAdress.Hide();
            InvalidPassword.Hide();
            InvalidPasswordConfirmation.Hide();
            Regex ruleName = new Regex(@"^[\p{L}]+$");
            Regex ruleMail = new Regex(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9]*[a-z0-9])?)\Z");
            Regex rulePhone = new Regex(@"^(?:[\s.-]*\d{2}){5}$");
            Regex rulePassword = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");

            if (!String.IsNullOrWhiteSpace(UserCreateName.Text) && ruleName.IsMatch(UserCreateName.Text))
            {
                if (!String.IsNullOrWhiteSpace(UserCreateFirstname.Text) && ruleName.IsMatch(UserCreateFirstname.Text))
                {
                    if (rulePhone.IsMatch(UserCreatePhone.Text))
                    {
                        if (rulePhone.IsMatch(UserCreateLandline.Text))
                        {
                            if (ruleMail.IsMatch(UserCreateMail.Text))
                            {
                                if (!String.IsNullOrWhiteSpace(UserCreateAdress.Text))
                                {
                                    if (rulePassword.IsMatch(UserCreatePassword.Text))
                                    {
                                        if (UserCreateConfirmPassword.Text == UserCreatePassword.Text)
                                        {
                                            MessageBox.Show("Utilisateur valide");
                                        }
                                        else
                                        {
                                            InvalidPasswordConfirmation.Show();
                                        }
                                    }
                                    else
                                    {
                                        InvalidPassword.Show();
                                    }
                                }
                                else
                                {
                                    InvalidAdress.Show();
                                }      
                            }
                            else
                            {
                                if (String.IsNullOrWhiteSpace(UserCreateMail.Text))
                                {
                                    NullMail.Show();
                                }
                                else
                                {
                                    InvalidMail.Show();
                                }
                            }
                        }
                        else
                        {
                            if (String.IsNullOrWhiteSpace(UserCreateLandline.Text))
                            {
                                NullLandline.Show();
                            }
                            else
                            {
                                InvalidLandline.Show();
                            }
                        }
                    }
                    else
                    {
                        if (String.IsNullOrWhiteSpace(UserCreatePhone.Text))
                        {
                            NullPhone.Show();
                        }
                        else
                        {
                            InvalidPhone.Show();
                        }
                    }
                }
                else
                {
                    InvalidFIrstame.Show();
                }   
            }
            else
            {
                InvalidName.Show();
            }
            
        }

        private void InvalidMail_Click(object sender, EventArgs e)
        {

        }
    }
}
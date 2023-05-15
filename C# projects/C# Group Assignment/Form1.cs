using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Group_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public int invalidInputMainMenu()
        {
            int invalidInputMenuOpt = Convert.ToInt32(Interaction.InputBox("Invalid Input Please retry\n" +
                "\n" +
                "1. Send Money\n" +
                "2. Make Payment\n" +
                "3. Cash Out\n" +
                "4. Aitime & Bundles\n" +
                "5. Junior Wallet\n" +
                "6. Kashagi & Savings Club\n" +
                "7. Wallet Services\n" +
                "8. Banking Services\n" +
                "9. Ecocash Diaspora"));
            return invalidInputMenuOpt;
        }
        public int ecocashDiasporaMenu()
        {
            int ecoDiasporaMenu = Convert.ToInt32(Interaction.InputBox("Please Select\n" +
                "1. Western Union\n" +
                "2. MoneyGram Receive Money\n" +
                "\n" +
                "Press * for Main Menu and 0 for Previous Menu"));
            return ecoDiasporaMenu;
        }
        public int bankingServicesMenu()
        {
            int bankingServicesOpt = Convert.ToInt32(Interaction.InputBox("Please Select\n" +
                "1. Wallet to Bank Transfer\n" +
                "2. Bank To Wallet Transfer\n" +
                "3. Account Statement\n" +
                "4. Balance Enquiry\n" +
                "\n" +
                "Press * for Main Menu and 0 for Previous Menu"));
            return bankingServicesOpt;
        }
        public int walletServicesMenu()
        {
            int walletServicesMenuOpt = Convert.ToInt32(Interaction.InputBox("1. Ecocash Debit Card\n" +
                "2. Account Enquiry\n" +
                "3. Next of Kin\n" +
                "4. Change Language\n" +
                "5. Pin Reset\n" +
                "6. View Pending Transactions\n" +
                "7. Self Care\n" +
                "\n" +
                "Press * For Main\n" +
                "n Next"));
            return walletServicesMenuOpt;
        }
       public int kashagiSavingsMenu()
        {
            int kashagiSavingsOpt = Convert.ToInt32(Interaction.InputBox("Please Select\n" +
                "1. Ecocash Kashagi\n" +
                "2. Ecocash Savings Club\n" +
                "\n" +
                "Press * for Main Menu and 0 for Previous Menu"));
            return kashagiSavingsOpt;
        }

        public int juniorWalletMenu()
        {
            int juniorWalletOpt = Convert.ToInt32(Interaction.InputBox("1. Child Registration\n" +
                "2. Send Money to child" +
                "3. Widthdraw Money from Child" +
                "4. Balance Enquiry\n" +
                "5. Mini Statement\n" +
                "\n" +
                "Press * for Main Menu and 0 for Previous Menu"));
            return juniorWalletOpt;
        }
        public int airtimeBundlesMenu()
        {
            int airtimeBundlesOpt = Convert.ToInt32(Interaction.InputBox("Please Select\n" +
                "1. Buy Airtime\n" +
                "2. Buy Bundles\n" +
                "\n" +
                "Press * for Main Menu and 0 for Previous Menu"));
            return airtimeBundlesOpt;
        }
        public int cashoutMenu()
        {
            int cashoutMenuopt = Convert.ToInt32(Interaction.InputBox("Please Select\n" +
                "1.From Agent\n" +
                "2.From ATM\n" +
                "3.Check Wallet Balance\n" +
                "\n" +
                "Press * for Main Menu and 0 for Previous Menu"));
            return cashoutMenuopt;
        }
        public int makePaymentMenu()
        {
           int makePaymentOpt = Convert.ToInt32(Interaction.InputBox("1. Pay Bill\n" +
                "2. Pay Merchant\n" +
                "3. Pay School Fees\n" +
                "4. Payment Approval\n" +
                "5. Transfer to Church\n" +
                "6. Ecocash Rewards\n" +
                "7. Regular Payments\n" +
                "8. Add Biller\n" +
                "\n" +
                "Press\n" +
                "n Next"));
            return makePaymentOpt;
        }
        public int mainMenuOpt()
        {
            int optmainMenu1 = Convert.ToInt32(Interaction.InputBox("1. Send Money\n" +
                "2. Make Payment\n" +
                "3. Cash Out\n" +
                "4. Aitime & Bundles\n" +
                "5. Junior Wallet\n" +
                "6. Kashagi & Savings Club\n" +
                "7. Wallet Services\n" +
                "8. Banking Services\n" +
                "9. Ecocash Diaspora"));
            return optmainMenu1;
        }
        public int sendMoneyMenu()
        {
            int opt = 0;
            opt = Convert.ToInt32(Interaction.InputBox("1.Send to registered customer\n" +
                "2. Send to unregistered customer\n" +
                "3. Ecoshopper purchase\n" +
                "4. Check Wallet Balance\n" +
                "5. Send to Account\n" +
                "6. Request Money\n" +
                "\n" +
                "n Next"));
            return opt;
        }
        public int UserValidate(int pin)
        {
            int opt=0;
            if(pin == 2003)
            {
                opt = mainMenuOpt();
            }
            else
            {
                Interaction.MsgBox("MPIN entered is incorrect\nPlease re-enter PIN");
            }
            return opt;
        }
        private void btnInputBox_Click(object sender, EventArgs e)
        {
            if (mainTextBox.Text == "*151#")
            {
                int usRTGSopt = Convert.ToInt32(Interaction.InputBox("Welcome to Ecocash. Please select your currency. \n1 Zimbabwean Dollar (ZWL)\n2 United States Dollar (USD)"));
                if (usRTGSopt == 1)
                {
                    int pin = Convert.ToInt32(Interaction.InputBox("Welcome to Ecocash\nPlease Enter your pin to proceed: "));
                    int opt2mainMenu = UserValidate(pin);
                    switch (opt2mainMenu)
                    {
                        case 1:
                            int mainMenuOpt = sendMoneyMenu();
                            break;
                        case 2:
                            mainMenuOpt = makePaymentMenu();
                            break;
                        case 3:
                            mainMenuOpt = cashoutMenu();
                            break;
                        case 4:
                            mainMenuOpt = airtimeBundlesMenu();
                            break;
                        case 5:
                            mainMenuOpt = juniorWalletMenu();
                            break;
                        case 6:
                            mainMenuOpt = kashagiSavingsMenu();
                            break;
                        case 7:
                            mainMenuOpt = walletServicesMenu();
                            break;
                        case 8:
                            mainMenuOpt = bankingServicesMenu();
                            break;
                        case 9:
                            mainMenuOpt = ecocashDiasporaMenu();
                            break;
                        default:
                            mainMenuOpt = invalidInputMainMenu();
                            break;

                    }
                }
                else if (usRTGSopt == 2)
                {
                    Interaction.MsgBox("The USD option is not yet being supported");

                }
            }
            else
            {
                Interaction.MsgBox("Invalid code entered Please make sure that you have entered *151#");
            }
        }
    }
}

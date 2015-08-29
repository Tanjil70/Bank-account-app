using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Account anAccount;
        private void createButton_Click(object sender, EventArgs e)
        {
            anAccount=new Account(nameTextBox.Text,accNoTextBox.Text);
            anAccount.name = nameTextBox.Text;
            MessageBox.Show("Name: " +anAccount.name + "Account Number: " + anAccount.account);
            nameTextBox.Text = "";
            accNoTextBox.Text = "";
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            anAccount.amount = Convert.ToDouble(amtTextBox.Text);
           MessageBox.Show( anAccount.GetDeposit(anAccount.amount));
            amtTextBox.Text = "";
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            anAccount.amount = Convert.ToDouble(amtTextBox.Text);
           MessageBox.Show( anAccount.GetWithdraw(anAccount.amount));
           amtTextBox.Text = "";

        }

        private void reportButton_Click(object sender, EventArgs e)
        {
           string userMessage =anAccount.name + ", your account number: " + anAccount.account +
                              " and it's balance: " + anAccount.blance;
            MessageBox.Show(userMessage);
        }
    }
}

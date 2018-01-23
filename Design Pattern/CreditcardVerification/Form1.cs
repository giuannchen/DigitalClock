using CreditcardVerification.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditcardVerification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IBankFactory bankFactory = null;
            if (radioCathy.Checked)
            {
                bankFactory = new CathayBankFactory();
            }
            else if (radioCtbc.Checked)
            {
                bankFactory = new CtbcBankFactory();
            }
            else if (radioNccc.Checked)
            {
                bankFactory = new NcccBankFactory();
            }
            IBank bank = bankFactory.VerificationCard();
            listBox1.Items.Add(bank.VerificationNum(inputNum.Text));
        }
    }
}
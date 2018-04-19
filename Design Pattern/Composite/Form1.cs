using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Composite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public ShoppingCartService ShoppingCartService
        {
            get => default(ShoppingCartService);
            set
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShoppingCartService shoppingCartService = new ShoppingCartService();
            shoppingCartService.AddCart(new AppleSwitchCombo());  

            this.listBox1.Items.Add("Apple X Switch = " + shoppingCartService.CalculatePrice());



        }
    }
}

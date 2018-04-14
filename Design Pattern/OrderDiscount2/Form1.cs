using OrderDiscount2;
using System;
using System.Windows.Forms;

namespace OrderDiscount
{
    public partial class Form1 : Form
    {
        // 我的計算機
        private OrderService MyOrderService;

     

        public Form1()
        {
            InitializeComponent();
            this.MyOrderService = new OrderService();
        }

        public OrderService OrderService
        {
            get => default(OrderService);
            set
            {
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {          
            if (this.radioCard1.Checked)
            {
                this.listBox1.Items.Add(this.MyOrderService.GetPrice("A",Convert.ToDouble(this.textBox1.Text)).ToString());              
            }
            else if (this.radioCard2.Checked)
            {
                this.listBox1.Items.Add(this.MyOrderService.GetPrice("B", Convert.ToDouble(this.textBox1.Text)).ToString());

            }
            else if (this.radioCard3.Checked)
            {
                this.listBox1.Items.Add(this.MyOrderService.GetPrice("C", Convert.ToDouble(this.textBox1.Text)).ToString());

            }
        }
    }
}
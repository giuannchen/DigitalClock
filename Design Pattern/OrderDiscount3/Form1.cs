using OrderDiscount3;
using System;
using System.Windows.Forms;

namespace OrderDiscount3
{
    public partial class Form1 : Form
    {
        // 我的計算機        
        private OrderProxy MyOrderProxy;


        public Form1()
        {
            InitializeComponent();            
            this.MyOrderProxy = new OrderProxy();
        }

        public OrderProxy OrderProxy
        {
            get => default(OrderProxy);
            set
            {
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {          
            if (this.radioCard1.Checked)
            {
                this.listBox1.Items.Add(this.MyOrderProxy.GetPrice(this.buyer.Text,"A",Convert.ToDouble(this.amount.Text)).ToString());              
            }           
            else if (this.radioCard2.Checked)
            {
                this.listBox1.Items.Add(this.MyOrderProxy.GetPrice(this.buyer.Text, "B", Convert.ToDouble(this.amount.Text)).ToString());

            }
            else if (this.radioCard3.Checked)
            {
                this.listBox1.Items.Add(this.MyOrderProxy.GetPrice(this.buyer.Text, "C", Convert.ToDouble(this.amount.Text)).ToString());

            }
            
        }
    }
}
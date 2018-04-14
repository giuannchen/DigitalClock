using OrderDiscount.Discount;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderDiscount
{
    public partial class Form1 : Form
    {
        // 我的計算機
        private Calculate MyCalculate;

        //滿額送
        private Full MyFull;

        // 打折
        private Off MyOff;

        public Form1()
        {
            InitializeComponent();
            this.MyCalculate = new Calculate();
        }

        public Interfaces.IIDiscount IIDiscount
        {
            get => default(Interfaces.IIDiscount);
            set
            {
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //折扣後
            double afterCalculate;
            if (this.radioFull.Checked)
            {
                afterCalculate = this.MyCalculate.DoCalculate(new Full(), Convert.ToDouble(this.textBox1.Text));
                this.listBox1.Items.Add("購買金額:" + this.textBox1.Text + " 滿千送百後的價格:" + afterCalculate.ToString());
            }
            else if (this.radioOff.Checked)
            {
                afterCalculate = this.MyCalculate.DoCalculate(new Off(), Convert.ToDouble(this.textBox1.Text));
                this.listBox1.Items.Add("購買金額:" + this.textBox1.Text + " 八折後後的價格:" + afterCalculate.ToString());
            }
        }
    }
}
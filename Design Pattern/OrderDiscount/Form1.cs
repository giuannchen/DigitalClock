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
        private Calculate myCalculate;

        //滿額送
        private Full myFull;

        // 打折
        private Off myOff;

        public Form1()
        {
            InitializeComponent();
            myCalculate = new Calculate();
        }

        public Interfaces.IIDiscount IIDiscount
        {
            get => default(Interfaces.IIDiscount);
            set
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //折扣後
            double afterCalculate;
            if (radioFull.Checked)
            {
                afterCalculate = myCalculate.DoCalculate(new Full(), Convert.ToDouble(textBox1.Text));
                listBox1.Items.Add("購買金額:" + textBox1.Text + " 滿千送百後的價格:" + afterCalculate.ToString());
            }
            else if (radioOff.Checked)
            {
                afterCalculate = myCalculate.DoCalculate(new Off(), Convert.ToDouble(textBox1.Text));
                listBox1.Items.Add("購買金額:" + textBox1.Text + " 八折後後的價格:" + afterCalculate.ToString());
            }
        }
    }
}
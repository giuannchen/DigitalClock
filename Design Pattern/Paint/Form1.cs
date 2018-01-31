using Paint.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        private Rectangle myRectangle;
        private Round myRound;
        private Text myText;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPainter myPainter;
            IPrinter myPrinter = new Print();

            if (radioGDIPlus.Checked)
            {
                myPainter = new PainterV1();
            }
            else
            {
                myPainter = new PainterV2();
            }

            if (radioRound.Checked)
            {
                myRound = new Round(myPainter, myPrinter, 111, 222, 333);
                listBox1.Items.Add(myRound.ShowDisplay());
            }
            else if (radioRectangle.Checked)
            {
                myRectangle = new Rectangle(myPainter, myPrinter, 111, 22, 333, 44);
                listBox1.Items.Add(myRectangle.ShowDisplay());
            }
            else
            {
                myText = new Text(myPainter, myPrinter, textBox1.Text);
                listBox1.Items.Add(myText.ShowDisplay());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IPainter myPainter;
            IPrinter myPrinter = new Print();

            if (radioGDIPlus.Checked)
            {
                myPainter = new PainterV1();
            }
            else
            {
                myPainter = new PainterV2();
            }

            if (radioRound.Checked)
            {
                myRound = new Round(myPainter, myPrinter, 111, 222, 333);
                listBox1.Items.Add(myRound.PrintTo());
            }
            else if (radioRectangle.Checked)
            {
                myRectangle = new Rectangle(myPainter, myPrinter, 111, 22, 333, 44);
                listBox1.Items.Add(myRectangle.PrintTo());
            }
            else
            {
                myText = new Text(myPainter, myPrinter, textBox1.Text);
                listBox1.Items.Add(myText.PrintTo());
            }
        }
    }
}
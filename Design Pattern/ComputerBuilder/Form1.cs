using ComputerBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Director director = new Director();
            IBuilder budilerA = new ConcreteBuilderA();
            IBuilder budilerB = new ConcreteBuilderB();
            director.Construct(budilerA);
            Computer productA = budilerA.GetResult();
            listBox1.Items.Add("商業電腦:");
            listBox1.Items.Add(productA.Show());
            director.Construct(budilerB);
            Computer productB = budilerB.GetResult();
            listBox1.Items.Add("RD電腦:");
            listBox1.Items.Add(productB.Show());
        }

        internal Director Director
        {
            get => default(Director);
            set
            {
            }
        }
    }
}
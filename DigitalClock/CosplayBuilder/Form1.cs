using CosplayBuilder.Aabstract;
using CosplayBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosplayBuilder
{
    public partial class Form1 : Form
    {
        // 製造盔甲的工廠
        private Armor myArmor;

        // 製造武器的工廠
        private Arms myArms;

        //製造靴子的工廠
        private Boots myBoots;

        // 抽像工廠
        private IAbstractFactory myFactory;

        //製造帽子的工廠
        private Hat myHat;

        //製造頭盔的工廠
        private Helmet myHelmet;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioPokemon.Checked)
            {
                myFactory = new PokemonFactory();
            }
            else if (radioWar.Checked)
            {
                myFactory = new WarFactory();
            }
            myArmor = myFactory.CreateArmor();
            myArms = myFactory.CreateArms();
            myBoots = myFactory.CreateBoots();
            myHat = myFactory.CreateHat();
            myHelmet = myFactory.CreateHelmet();

            listBox1.Items.Add(myArmor.MakeArmor());
            listBox1.Items.Add(myArms.MakeArms());
            listBox1.Items.Add(myBoots.MakeBoots());
            listBox1.Items.Add(myHat.MakeHat());
            listBox1.Items.Add(myHelmet.MakeHelmet());
            listBox1.Items.Add("--------------------");
        }
    }
}
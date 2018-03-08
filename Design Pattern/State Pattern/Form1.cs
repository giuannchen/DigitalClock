using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static State_Pattern.LightEnum;

namespace State_Pattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MYMessage = MessageEnum.Green;
            this.MyLightContext.SetState(new GreenLightState());

        }
        private MessageEnum MYMessage;
        private LightContext MyLightContext = new LightContext();

        private void button1_Click(object sender, EventArgs e)
        {
            string LightText = string.Empty;
            if (this.MYMessage.Equals(MessageEnum.Green)) LightText = "綠燈";
            if (this.MYMessage.Equals(MessageEnum.Yellow)) LightText = "黃燈";
            if (this.MYMessage.Equals(MessageEnum.Red)) LightText = "紅燈";
            this.listBox1.Items.Add(LightText);
            this.MYMessage = this.MyLightContext.Request();

            
        }
    }
}

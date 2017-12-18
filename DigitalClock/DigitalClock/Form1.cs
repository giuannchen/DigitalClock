using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form.CheckForIllegalCrossThreadCalls = false;
            Clock MyClock = new Clock();
            DigitalClock MyDigitalClock = new DigitalClock(textBox1);
            //訂閱
            MyClock.RegisterObserver(MyDigitalClock);
            // 每秒
            System.Timers.Timer tmr = new System.Timers.Timer(1000);
            tmr.Elapsed += delegate
            {
                MyClock.onTick();
            };
            tmr.Start();
        }
    }
}
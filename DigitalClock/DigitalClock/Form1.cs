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
            Clock<string> MyClock = new Clock<string>();
            DigitalClock<string> MyDigitalClock = new DigitalClock<string>(MyClock);

            //event method to
            MyDigitalClock.Clock.DatetimePublisher += showtime;

            void showtime(object sender, MessageArgument<string> e)
            {
                textBox1.Text = e.Message;
            }

            // 每秒
            System.Timers.Timer tmr = new System.Timers.Timer(1000);
            tmr.Elapsed += delegate
            {
                DateTime dt = DateTime.Now;
                MyClock.onTick(dt.ToString("HH") + ":" + dt.ToString("mm") + ":" + dt.ToString("ss"));
            };
            tmr.Start();
        }
    }
}
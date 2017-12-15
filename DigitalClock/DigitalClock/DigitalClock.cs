using DigitalClock.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    /// <summary>
    /// 觀察者
    /// </summary>
    internal class DigitalClock : IDigitalClock
    {
        private TextBox clocktime;

        public DigitalClock(TextBox display)
        {
            clocktime = display;
        }

        public void update(string hours, string minutes, string seconds)
        {
            clocktime.Text = hours + ":" + minutes + ":" + seconds;
            // Console.WriteLine(hours + ":" + minutes + ":" + seconds);
        }
    }
}
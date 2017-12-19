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
    internal class DigitalClock<T> : IDigitalClock<T>
    {
        public DigitalClock(IClock<T> clock)
        {
            Clock = clock;
        }

        public IClock<T> Clock { get; private set; }
    }
}
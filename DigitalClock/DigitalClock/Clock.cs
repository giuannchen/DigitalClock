using DigitalClock.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClock
{
    internal class Clock : IClock
    {
        // 使用List來存放觀察者名單
        private readonly List<IDigitalClock> lstObservers = new List<IDigitalClock>();

        public Clock()
        {
            lstObservers = new List<IDigitalClock>();
        }

        public void onTick()
        {
            foreach (IDigitalClock observer in lstObservers)
            {
                DateTime dt = DateTime.Now;
                observer.update(dt.ToString("HH"), dt.ToString("mm"), dt.ToString("ss"));
            }
        }

        // 加入觀察者
        public void RegisterObserver(IDigitalClock pObserver)
        {
            lstObservers.Add(pObserver);
        }
    }
}
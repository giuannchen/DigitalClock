using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClock.Interfaces
{
    /// <summary>
    /// 抽出共同函式
    /// </summary>
    public interface IDigitalClock
    {
        void update(string hours, string minutes, string seconds);
    }
}
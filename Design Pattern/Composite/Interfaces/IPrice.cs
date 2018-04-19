using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Interfaces
{
    /// <summary>
    /// 價格介面
    /// </summary>
    public interface IPrice
    {
        /// <summary>
        /// 回傳價格
        /// </summary>
        /// <returns></returns>
        double GetPrice();
    }
}

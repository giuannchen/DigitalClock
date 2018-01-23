using OrderDiscount.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDiscount.Discount
{
    /// <summary>
    /// 打八折
    /// </summary>
    public class Off : IIDiscount
    {
        /// <summary>
        /// 打折
        /// </summary>
        /// <param name="originalAmt">原來的價格</param>
        /// <returns>打完折後的價格</returns>
        public double DoDiscount(double originalAmt)
        {
            return Math.Round((originalAmt * 0.8), 2);
        }
    }
}
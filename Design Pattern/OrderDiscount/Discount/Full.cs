using OrderDiscount.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDiscount.Discount
{
    /// <summary>
    /// 滿千送百
    /// </summary>
    public class Full : IIDiscount
    {
        /// <summary>
        /// 打折
        /// </summary>
        /// <param name="originalAmt">原來的價格</param>
        /// <returns>打完折後的價格</returns>
        public double DoDiscount(double originalAmt)
        {
            // 贈送價格
            double discount;
            if (originalAmt >= 1000)
                discount = Math.Floor((originalAmt / 1000)) * 100;
            else
                discount = 0;
            return originalAmt - discount;
        }
    }
}
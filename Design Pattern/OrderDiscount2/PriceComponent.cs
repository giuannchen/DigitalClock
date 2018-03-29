using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDiscount2
{
    /// <summary>
    /// 優惠計算
    /// </summary>
    class PriceComponent
    {
        /// <summary>
        /// 八折
        /// </summary>
        /// <param name="price">原價</param>
        /// <returns>折扣後</returns>
        public static double CalculateDiscountPrice(double price)
         { 
             return price * 0.8; 
         }
}
}

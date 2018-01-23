using OrderDiscount.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDiscount
{
    /// <summary>
    /// 計算折扣
    /// </summary>
    public class Calculate
    {
        /// <summary>
        /// 初始
        /// </summary>
        public Calculate()
        {
        }

        /// <summary>
        /// 計算打折後的價格
        /// </summary>
        /// <param name="discountType">折扣方式</param>
        /// <param name="inputAmt">原價</param>
        /// <returns>打折後的價格</returns>
        public double DoCalculate(IIDiscount discountType, double inputAmt)
        {
            return discountType.DoDiscount(inputAmt);
        }
    }
}
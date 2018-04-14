using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDiscount3
{
    /// <summary>
    /// 優惠計算
    /// </summary>
    class PriceDecorator
    {
        internal PriceComponent PriceComponent
        {
            get => default(PriceComponent);
            set
            {
            }
        }

        public OrderService OrderService
        {
            get => default(OrderService);
            set
            {
            }
        }

        /// <summary>
        /// 其他優惠後再滿千送百
        /// </summary>
        /// <param name="fn">其他優惠</param>
        /// <returns>折扣後</returns>
        public static Func<double, double> CalculateRebatePrice(Func<double, double> fn)
         { 
             return price => fn(price) - 100; 
         }

        /// <summary>
        /// 滿千送百
        /// </summary>
        /// <param name="price">原價</param>
        /// <returns>折扣後</returns>
        public static double CalculateRebatePrice(double price)
        {
            return price - 100;
        }

    }
}

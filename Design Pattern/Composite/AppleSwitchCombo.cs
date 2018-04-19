using Composite.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Composite
{
    /// <summary>
    /// AppleSwitchCombo
    /// </summary>
    public class AppleSwitchCombo : IPrice
    {
        /// <summary>
        /// 折扣
        /// </summary>
        private const double Discount = 1000.0;

        /// <summary>
        /// 套餐
        /// </summary>
        private readonly List<IPrice> _products;

        public AppleSwitchCombo()
        {            
            this._products = new List<IPrice>
            {
                new AppleCombo(),
                new SwitchCombo()
            };
        }

        /// <summary>
        /// 回傳價格
        /// </summary>
        /// <returns></returns>
        public double GetPrice()
        {
            return  this._products.Sum(product => product.GetPrice())- Discount;
        }
    }
}
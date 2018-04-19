using Composite.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Composite
{
    /// <summary>
    /// AppleCombo
    /// </summary>
    public class AppleCombo : IPrice
    {
        /// <summary>
        /// 折扣
        /// </summary>
        private const double Discount = 0.9;

        /// <summary>
        /// 套餐
        /// </summary>
        private readonly List<IPrice> _products;

        public AppleCombo()
        {            
            this._products = new List<IPrice>
            {
                new MacBookPro(),
                new IPadAir(),
                new AppleWatch()
            };
        }

        /// <summary>
        /// 回傳價格
        /// </summary>
        /// <returns></returns>
        public double GetPrice()
        {
            return Discount * this._products.Sum(product => product.GetPrice());
        }
    }
}
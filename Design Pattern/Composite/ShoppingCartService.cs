using Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    /// <summary>
    /// 購物車服務
    /// </summary>
    public class ShoppingCartService
    {
        /// <summary>
        /// 購物車
        /// </summary>
        private readonly List<IPrice> _carts = new List<IPrice>();

        public IPrice IPrice
        {
            get => default(IPrice);
            set
            {
            }
        }

        /// <summary>
        /// 加入購物車
        /// </summary>
        /// <param name="product">產品</param>
        public void AddCart(IPrice product)
        {
            this._carts.Add(product);
        }

        /// <summary>
        /// 計算價格
        /// </summary>
        /// <returns>總金額</returns>
        public double CalculatePrice()
        {
            return this._carts.Sum(product => product.GetPrice());
        }
    }
}

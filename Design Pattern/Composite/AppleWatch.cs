using Composite.Interfaces;

namespace Composite
{
    /// <summary>
    /// AppleWatch
    /// </summary>
    public class AppleWatch : IPrice
    {
        /// <summary>
        /// 售價
        /// </summary>
        private const double Price = 10000.0;

        /// <summary>
        /// 回傳價格
        /// </summary>
        /// <returns></returns>
        public double GetPrice()
        {
            return Price;
        }
    }
}
using Composite.Interfaces;

namespace Composite
{
    /// <summary>
    /// Switch
    /// </summary>
    public class Switch : IPrice
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
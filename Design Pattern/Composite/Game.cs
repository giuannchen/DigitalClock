using Composite.Interfaces;

namespace Composite
{
    /// <summary>
    /// 薩爾達傳說
    /// </summary>
    public class Game : IPrice
    {
        /// <summary>
        /// 售價
        /// </summary>
        private const double Price = 2000.0;

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
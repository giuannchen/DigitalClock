using Composite.Interfaces;

namespace Composite
{
    public class MacBookPro : IPrice
    {
        private const double Price = 60000.0;

        public double GetPrice()
        {
            return Price;
        }
    }
}
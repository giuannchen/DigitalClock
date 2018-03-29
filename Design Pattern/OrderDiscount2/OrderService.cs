using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDiscount2
{
    /// <summary>
    /// 訂單服務
    /// </summary>
    public class OrderService
    {
        internal PriceComponent PriceComponent
        {
            get => default(PriceComponent);
            set
            {
            }
        }

        /// <summary>
        /// 計算優惠服務
        /// </summary>
        /// <param name="cardType">卡別</param>
        /// <param name="price">購買金額</param>
        /// <returns>計算結果</returns>
        public string GetPrice(string cardType, double price)
         {
            string message = string.Empty;
            double totalPay = 0;
            if (cardType == "A")
            {
                if (price < 1000)
                {
                    Func<double, double> calculateDiscountPrice = PriceComponent.CalculateDiscountPrice;
                    totalPay = calculateDiscountPrice(price);
                }
                else
                {
                    Func<double, double> calculateDiscountPrice = PriceComponent.CalculateDiscountPrice;
                    Func<double, double> calculateRebatePrice = PriceDecorator.CalculateRebatePrice(calculateDiscountPrice);

                    totalPay = calculateRebatePrice(price);
                }

                message = "中信卡原價:" + price.ToString() + " 實付:" + totalPay.ToString() + " 送100折價券";
            }
            else if (cardType == "B")
            {               
                Func<double, double> calculateDiscountPrice = PriceComponent.CalculateDiscountPrice;
                totalPay = calculateDiscountPrice(price);
                
                message = "台新卡原價:" + price.ToString() + " 實付:" + totalPay.ToString() + " 加一元多一件.送100折價券";
            }
            else if (cardType == "C")
            {
                if (price >= 1000)
                {
                    Func<double, double> calculateRebatePrice = PriceDecorator.CalculateRebatePrice;

                    totalPay = calculateRebatePrice(price);
                }
                else
                {
                    totalPay = price;
                }

                message = "花旗卡原價:" + price.ToString() + " 實付:" + totalPay.ToString() + " 紅利點數增加100點.加一元多一件";
            }

            return message;            
        } 
    }
}
